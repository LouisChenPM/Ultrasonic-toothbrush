using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrasonic_toothbrush
{
	class Setting
	{
		public static int Rssi {
			get { return configRssi; }
			set { configRssi=value; save(); }
		}
		public static int configRssi;//信号强度
		public static string configVersio;//信号强度
									 //信号强度mac地址范围
		private static void save()//保存配置文件
		{
			//filexml打开关闭文件、保存所有配置确保保存成功
		}

		private static void export()//保存配置文件
		{
			//filexml打开关闭文件、保存所有配置确保保存成功
		}
	}
}
