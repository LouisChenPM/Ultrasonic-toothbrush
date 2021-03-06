﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrasonic_toothbrush
{
    class UI
    {
        public static TextBoxHandler textBoxHandler;//textBox委托对象
        public static LedHandler ledHandler;//led显示更新
        public static PassHandler passHander;//更新测试结果按钮
        public static MainForm mf;//引用主窗口
        public static StatusBarHandler statusBarHander;//更新状态栏按钮
		public static RepeatHandler repeatHandler;
		// public static 
		public static void  TextBox(string s)
        {
            mf.BeginInvoke(textBoxHandler, s);//异步更新
        }

		internal static void Repeat(string s, System.Threading.Thread t)
		{
			 mf.BeginInvoke(repeatHandler, s,t);//同步更新
		}

		//  private static int x=0;
		public static void LED(int i)
        {
            mf.BeginInvoke(ledHandler, i);


        }
        public static void PassShow(bool i)//
        {
            mf.BeginInvoke(passHander, i);
        }
        private static string b = null;
        internal static TimerHandler timeHandler;

        public static void StatusBar(string s,bool clean)//更新状态栏
        {
            b = b + s+" ";
            if (clean)
                b = null;
            mf.BeginInvoke(statusBarHander, b);

        }

        internal static void Time(int pureBrushTime)
        {
            mf.BeginInvoke(timeHandler, pureBrushTime);
        }
    }
}
