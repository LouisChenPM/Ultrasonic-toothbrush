using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrasonic_toothbrush
{
	class Command
	{
		public static int headerLength = 8;//数据帧头的长度
		public static int lenghtIndex = 6;//指示数据包长度的位
		public static byte[] cmd;//指令缓存
		public static byte[] Scan = { 0x58, 0x53, 0x43, 0x53, 0x00, 0x01, 0x01, 0x01, 0x01 };//扫描命令字节串
		//连接命令字节串，里面的mac地址(从第九位开始往后算两位)、芯片型号(最后两位)
		//public static byte[] Connect = { 0x58, 0x53, 0x43, 0x53, 0x01, 0x02, 0x06, 0x08, 0x20, 0x49, 0x31, 0x50, 0xA0, 0x00, 0x01, 0x31 };
		private static byte[] head = { 0x58, 0x53, 0x43, 0x53};//发送帧头//
		private static byte[] connectCode = { 0x01, 0x02, 0x06, 0x08 };//命令特征码连接码0x1厂家代码，0x02命令类型,0x06数据长度,0x08校验值和
		private static byte[] chipCode = { 0x01, 0x31 };//芯片型号/通道号 ，来自设置
		private static byte[] deviceCodeRear = {  };//device Code，来自设置
		public static byte[] Connect 
		{

			get {
				List<byte> byteSource = new List<byte>();
				byteSource.AddRange(head);
				byteSource.AddRange(connectCode);
				byteSource.AddRange(device.connectMac);
				byteSource.AddRange(chipCode);
				return  byteSource.ToArray();
			}

		}
		//发送数据命令字节串
		public static byte[] UpLoadRealData = { 0x58, 0x53, 0x43, 0x53, 0x01, 0x05, 0x12, 0xA8, 0x9A, 0xC1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC1, 0xAA };
        public static byte[] Factoryreset  = { 0x58, 0x53, 0x43, 0x53, 0x01, 0x05, 0x12, 0xA8, 0x9A, 0xCB, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xCA, 0xAA };
        public static byte[] Disconnect = { 0x58, 0x53, 0x43, 0x53, 0x01, 0x03, 0x00, 0x00 };//收到断开{ 0x78,0x73,0x63,0x73,0x01,0x03,0x00,0x19 };
        private static Device device=null;
		public static Port port;
		public  enum Id//协议中传输命令类型枚举
		{
			Scan = 1,
			Connect = 2,
			Disconnect = 3,
			PackageData = 4,
			UpLoadRealData,
            FactoryReset,
            Stop,
			Reset
			//以下留着备用
			//wait_disconnect = 0xFB,
			//in_reset = 0xFC,
			//out_reset = 0xFD,
			//sel_mac = 0xFE,
		}
	
		public static void  DealCmd()
		{
			switch (cmd[5])
			{
				case(byte) Id.Scan:
					device = new Device();//新建一个扫描到的设备
					device.mac=GetMac();//获取扫描到的mac地址
					device.rssi=GetRssi();//获取信号强度
					device.name=GetDeviceName();//getmac//getrssi//getdevicename//getchiptype//port.connect(if rssi>x)
					if(device.rssi> Setting.Rssi)
					Port.SendCommand(Id.Connect);//在信号范围内尝试连接，不在信号范围内重新扫描
					break;
				case (byte)Id.Connect:
					break;
				case (byte)Id.Disconnect:
					break;
				case (byte)Id.PackageData://PackageData//数据处理
					break;
				case (byte)Id.UpLoadRealData:
					break;
				case (byte)Id.Stop:
					break;
				default:
					break;
			}
		}
		private static int macOffect = 10;
		private static int macLength = 6;
		private static byte[] GetMac()
		{
			byte[] mac = new byte[macLength];//新建一个mac地址缓存
			Array.Copy(cmd, macOffect, mac,0, macLength);//把mac地址copy出来
			Array.Reverse(mac);//mac地址的顺序需要反转一下才正常
			string s = BitConverter.ToString(mac);//方便观察16进制数据格式正式版注释掉这一行
			return mac;
		}
		private static int rssiOffect = 9;
		private static int GetRssi()
		{
			int rssi = -10000;
			rssi =-( 0x7F - cmd[rssiOffect] & 0x7F);//这里信号强度算法不懂，从我哥那里炒来的
			string s = rssi.ToString();
			/*
			this.s_rssi = "" + (-(0x7F - (this.rssi & 0x7F)));
			this.mac[i_mac].rssi = -(0x7F - (this.rssi & 0x7F));
			this.rc_rssi = this.mac[i_mac].rssi;//record current rssi 
			this.isset_rssi = true;
			return 0;
			*/
			return rssi;
		}
		private static string GetDeviceName()
		{
			int i=Array.IndexOf(cmd, (byte)0x9);//查找名称起始字符（\t制表符），这里的查找类型要与cmd元素类型匹配
			int len = cmd[i - 1];//获取名称字符串长度
			return System.Text.Encoding.Default.GetString(cmd, i, len);//将名称拷贝出来里面带有制表符
		}
	}
}
