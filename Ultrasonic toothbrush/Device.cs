using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrasonic_toothbrush
{
	class Device
	{
		public enum Status//标识设备状态
		{
			Scan = 1,
			Connected = 2,
			Disconnected = 3,
			UpLoadingRealData,
			Testing
		}
		public byte[] mac = null;
		public string name = null;
		public int rssi = -10000;
		public byte[] connectMac//用于连接的mac地址与显示的mac地址相反
		{
			get {
				byte[] c = new byte[6];
				Array.Copy(mac, c, 6);
				Array.Reverse(c);
				return c;
			}
		}

		//test bool
	}
}
