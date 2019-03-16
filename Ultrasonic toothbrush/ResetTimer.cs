﻿using System;
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
		public static void Start()
		{
			timer.Interval = tick;
			timer.Enabled = true;
			timer.Elapsed += new ElapsedEventHandler(SendReset);
			timer.Start();
		}
		private static void  SendReset(object source,ElapsedEventArgs e)
		{
			 timeInterval = timeInterval + tick;
			if (timeInterval > 2000)//间隔两秒发送重置
			{
				Port.SendCommand(Command.Id.Reset);//间隔时间差大于5秒发送重置
				timeInterval = 0;//重置计时；
			}
		}
		public static void MarkTime()
		{
			timeInterval = 0;//毫秒数
		}
	}
}
