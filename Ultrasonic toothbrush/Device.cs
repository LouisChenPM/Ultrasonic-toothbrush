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
        private byte[] macIn = null;
        public byte[] mac {
            set
            {
                macIn = value;
                Array.Copy(macIn, macConnectIn, 6);
				macStr = BitConverter.ToString(macIn).Replace("-", " ");//转换为16进制显示
                UI.StatusBar("MAC: "+ macStr, false);//在UI上显示
            }
            get//实际mac地址与通信时mac地址反向
            {
                return macIn;
            }
        }
        private byte[] macConnectIn = new byte[6];
        public byte[] macConnect//连接时mac与显示时mac相反
        {
            get{
                Array.Reverse(macConnectIn);
                return macConnectIn;
            }
        }
        public string nameIn = null;
        public string name {
            set
            {
                nameIn = value;
                UI.StatusBar("NAME: " + nameIn + "|",false);
            }
            get
            {
                return nameIn;
            }
        }

        public int rssiIn = -10000;

		public int rssi {
            set
            {
                rssiIn = value;
                UI.StatusBar("RSSI: "+rssiIn.ToString(),false);// 在界面状态栏上显示
            }
            get
            {
                return rssiIn;
            }
        }

		public string version { get; internal set; }
		public bool FactoryReseted { get; internal set; }
		public string  macStr { get; internal set; }
		//test bool
	}
}
