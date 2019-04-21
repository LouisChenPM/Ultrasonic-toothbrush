using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrasonic_toothbrush
{
	class Test
	{
		static private Device preDevice=null;
		///Setting.FactoryMode;
		///Setting.PCBMode
		public static bool test(Device d)
		{
			//device.mac
			//device.name
			//device.rssi
			//device.version
			//device.factorMode

			if (preDevice != null)
				preDevice = d;
			return true;
		}
	}
}
