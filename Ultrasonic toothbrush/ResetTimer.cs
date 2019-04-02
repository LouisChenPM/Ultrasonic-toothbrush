using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace Ultrasonic_toothbrush
{
	class ResetTimer
	{
		public  static System.Timers.Timer timer = new Timer();
		private static long timeInterval;
		private static int tick=100;
        private static bool disConnected = false;
		private static bool eventHandleNotBonded=true;
		private static int SelRssiTime = 5000;
		public static void Start()
		{
			timeInterval = 0;
			timer.Interval = tick;
			timer.Enabled = true;
			if (eventHandleNotBonded) {//只绑定一次计时器相应函数这里后面代码修改
				timer.Elapsed += new ElapsedEventHandler(SendReset);
				eventHandleNotBonded = false;
			}
			
			timer.Start();
		}
        public static void Disable()
        {
            timer.Enabled = false;
        }
        static int delaytime = 0;
        static Command.Id id;
        public static void DelaySend(int t, Command.Id i)//延迟几个tick发送某个命令
		{
            delaytime = t;
            id = i;
		}
        private static void send()
        {
            if (delaytime > 0)
            {
                delaytime = delaytime - tick;
                if (delaytime <= 0)
                Port.SendCommand(id);
            }
        }
        static bool RetryDone= false;//flase为true时启动重发机制
        static int OverTime = 10000;//设置重发超时时间为500毫秒
        static int retryTime = OverTime;
        static Command.Id retryId;
       public static void DelayRetry(Command.Id i)
        {
            RetryDone = true;
            retryId = i;
            if (i == Command.Id.PowerOff)//这里因为PowerOff本身是延时关机所以指令重发的时间要在原来的基础上增加，PowerOff的延时
                retryTime = delaytime + retryTime;
        }
        public static void StopRetry()//停止重发
        {
            RetryDone = false;
            retryTime = OverTime;
        }
        private static void Retry()
        {
            if (retryTime > 0&& RetryDone==true)
            {
                retryTime = retryTime - tick;
                if (retryTime <= 0)
                { 
                    Port.SendCommand(retryId);
                    retryTime = OverTime;
                }

            }
        }
		private static void  SendReset(object source,ElapsedEventArgs e)
		{
			 timeInterval = timeInterval + tick;
            if (timeInterval > 1000)//间隔两秒发送重置
            {
                Status.now = Status.AllStatus.Scaning;
                // Port.SendCommand(Command.Id.Scan);
                if (disConnected == false)
                { 
                Port.SendCommand(Command.Id.Disconnect);//间隔时间差大于5秒发送重置
                disConnected = true;//这里引入全局状态的数据进行判断
                }
                else
                {
                    Port.SendCommand(Command.Id.Scan);//间隔时间差大于5秒发送重置
                    disConnected = false;
                }

                timeInterval = 0;//重置计时；


			}

			//每隔五秒查询信号强度
			//Status判断连接状态是否为连接状态
			
			SelRssiTime = SelRssiTime - tick;
			if (SelRssiTime < 0)
			{
				Port.SendCommand(Command.Id.Rssi);
				SelRssiTime = 5000;
			}
            //延迟发送函数
            send();
            //重发函数
            Retry();

        }
		public static void MarkTime()
		{
			timeInterval = 0;//毫秒数
		}
	}
}
