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

		public static TestMode Mode { get; internal set ; }
		public static bool settingNotResetFactoryMode { get; internal set; }
		public static string DeviceName { get; internal set; }
		public static string Version { get; internal set; }
		public static bool offLine { get; internal set; }
		public static bool macIngore { get; internal set; }
		public static bool nameIngore { get; internal set; }
		public static bool rssiIngore { get; internal set; }
		public static bool versionIngore { get; internal set; }
		public static bool factResetIngore { get; internal set; }
		public static long MacMax { get; internal set; }
		public static long MacMini { get; internal set; }
		public static int rssiMax { get; internal set; }
		public static int rssiMini { get; internal set; }
		public static string Channel { get; internal set; }
		public static string Server { get; internal set; }
		public static string LineNumber { get; internal set; }
		public static string Chip { get; internal set; }

		public static int configRssi;//信号强度
		public static string configVersio;//信号强度

		public  enum TestMode
		{
			PCB,
			PRODUCT
		}
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
