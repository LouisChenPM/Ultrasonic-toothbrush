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
		public static int configRssi;
		private static void save()//保存配置文件
		{

		}
	}
}
