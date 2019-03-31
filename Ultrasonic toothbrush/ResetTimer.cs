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
		/*	if(delaytime<=0)*/
				//send

		}
        private static void send()
        {
            if (delaytime> 0)
            {
            delaytime = delaytime - tick;
            if(delaytime<=0)
            Port.SendCommand(id);
            }
        }
		private static void  SendReset(object source,ElapsedEventArgs e)
		{
			 timeInterval = timeInterval + tick;
            if (timeInterval > 2000)//间隔两秒发送重置
            {
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


        }
		public static void MarkTime()
		{
			timeInterval = 0;//毫秒数
		}
	}
}
