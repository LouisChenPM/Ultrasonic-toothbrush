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
		private static int tick=20;
        private static bool disConnected = false;
		private static bool eventHandleNotBonded=true;
		private static int SelRssiTime = 5000;
        private static bool exe = false;
		public static void Start()
		{
			timeInterval = 0;
			timer.Interval = tick;
			timer.Enabled = true;
			if (eventHandleNotBonded) {//只绑定一次计时器相应函数这里后面代码修改
				timer.Elapsed += new ElapsedEventHandler(SendReset);
                delayTimer.Elapsed += new ElapsedEventHandler(PowerOffTimerHandle);
                RetryPoweroffTimer.Elapsed += new ElapsedEventHandler(RetryPoweroffTimerHandle);
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
        private static System.Timers.Timer delayTimer = new Timer();
        private static System.Timers.Timer RetryPoweroffTimer = new Timer();
        public static void DelayPowerOff(int t)//延时关机函数
		{
            delayTimer.AutoReset = false;
            delayTimer.Interval = t+500;
            delayTimer.Start();
        }
        private static void PowerOffTimerHandle(object source, ElapsedEventArgs e)//延时关机超时响应函数
        {
           Port.SendCommand(Command.Id.PowerOff);
            delayTimer.Stop();
        }
        public static void RetryPoweroff(int t)//延时关机重发函数
        {
            RetryPoweroffTimer.AutoReset = false;
            PowerOffRetryDone = true;
            RetryPoweroffTimer.Interval = t + 1000;
            RetryPoweroffTimer.Start();
        }
        public static void StopPoweroffRetry()//延时关机停止重发函数
        {
            PowerOffRetryDone = false;
        }
        private static bool PowerOffRetryDone=false;
        private static void RetryPoweroffTimerHandle(object source, ElapsedEventArgs e)//延时关机重发超时响应函数
        {
            if (PowerOffRetryDone == true)
            { 
                Port.SendCommand(Command.Id.PowerOff);
                delayTimer.Interval = 500;//将超时时间修改为500毫秒
                RetryPoweroffTimer.AutoReset = true;
            }
            else
                RetryPoweroffTimer.Stop();
        }

        static bool RetryDone= false;//flase为true时启动重发机制
        const int OverTime = 700;//设置重发超时时间为500毫秒，查询电压需要的时间过长因此将这里的电压查询时间设置为700毫秒
        static int retryTime = OverTime;
        static Command.Id retryId;
       public static void DelayRetry(Command.Id i)
        {
            RetryDone = true;
            retryTime = OverTime;
            retryId = i;
            if (i == Command.Id.PowerOff)//这里因为PowerOff本身是延时关机所以指令重发的时间要在原来的基础上增加，PowerOff的延时
                retryTime = delaytime + retryTime;
        }
        //*这里由于Power与PowerOFF是连续开启并且异步因此PowerOFF会导致
        //* PowerOn的重发机制失效因此对PowerOn重发机制做特殊处理使用
        //* 不同的代码

        static bool PowerOnRetryDone = false;//flase为true时启动重发机制
        static int PowerOnretryTime = OverTime;
        public static void PowerOnDelayRetry()//设置标识位让重发机制生效
        {
            PowerOnRetryDone = true;
            PowerOnretryTime = OverTime;

        }
        public static void StopRetry()//停止重发
        {
            RetryDone = false;
            retryTime = OverTime;

        }
        private static void Retry()//重发函数
        {
            if (retryTime > 0&& RetryDone==true)
            {
                retryTime = retryTime - tick;
                if (retryTime <= 0)
                { 
                    Port.SendCommand(retryId);
                    Console.WriteLine(retryId);
                    retryTime = OverTime;
                }

            }
        }
        public static void StopPowerOnRetry()
        {
            PowerOnRetryDone = false;
            PowerOnretryTime = OverTime;
        }
        private static void PowerOnRetry()//开机重发函数
        {
            if (PowerOnretryTime > 0 && PowerOnRetryDone == true)
            {
                PowerOnretryTime = PowerOnretryTime - tick;
                if (PowerOnretryTime <= 0)
                {
                    Port.SendCommand(Command.Id.PowerOn);
                    PowerOnretryTime = OverTime;
                }

            }
        }
        private static void  SendReset(object source,ElapsedEventArgs e)
		{
            if (exe == true) return;
            exe = true;
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
                    UI.StatusBar(null, true);
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
          //  send();
            //重发函数
            PowerOnRetry();
            Retry();
            exe = false;
        }
		public static void MarkTime()
		{
			timeInterval = 0;//毫秒数
		}
	}
}
