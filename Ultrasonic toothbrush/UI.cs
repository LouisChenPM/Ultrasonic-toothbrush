using System;
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
        public static MainForm mf;//引用主窗口

        public static void  TextBox(string s)
        {
            mf.BeginInvoke(textBoxHandler, s);//异步更新
        }
      //  private static int x=0;
        public static void LED(int i)
        {
            mf.BeginInvoke(ledHandler, i);


        }
    }
}
