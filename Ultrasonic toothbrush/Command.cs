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
		private static byte[] commandCode = { 0x01, 0x02, 0x06, 0x08 };//命令特征码连接码0x1厂家代码，0x02命令类型,0x06数据长度,0x08校验值和
		private static byte[] chipCode = { 0x01, 0x31 };//芯片型号/通道号 ，来自设置
		private static byte[] deviceCodeRear = {  };//device Code，来自设置
		public static byte[] Connect //拼接连接指令，这里要在最后增加字符串以供通道设置并设置length的长度
		{

			get {
				List<byte> byteSource = new List<byte>();
				byteSource.AddRange(head);
                commandCode[2] = (byte)(device.connectMac.Length + deviceCodeRear.Length + chipCode.Length);//计算数据包的长度
				byteSource.AddRange(commandCode);
				byteSource.AddRange(device.connectMac);
				byteSource.AddRange(chipCode);
				return  byteSource.ToArray();
			}

		}
        private static byte[] upLoadCode = { 0x01, 0x05, 0x12, 0xA8 };//0x1厂家代码,0x05命令类型,0x12数据长度,0xA8校验值和
        private static byte[] package = { 0x9A, 0xC1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC1, 0xAA };//x9A帧头0xC1命令类型查询
		private static byte[] brushCommandCode= { 0x9A, 0xC1 };
		private static byte[] timestamp { get { return nowtimestamp(); } }
		private static byte[] commandOption = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,0xC1};//操作选项
		private static byte[] commandRear = {  0xAA };
		public static byte[] UpLoadRealData//上传实时数据命令
        {
            get
            {
                List<byte> byteSource = new List<byte>();
               byteSource.AddRange(head);//添加帧头
				upLoadCode[2] = (byte)(brushCommandCode.Length + timestamp.Length + commandOption.Length + commandRear.Length);//计算数据包的长度
				upLoadCode[1] = 0x05;//添加代码编号
				byteSource.AddRange(upLoadCode);//
				byteSource.AddRange(brushCommandCode);//添加牙刷操命令号
				byteSource.AddRange(timestamp);//添加时间戳
				byteSource.AddRange(commandOption);//添加牙刷操作命令号
				XOR(9, byteSource);//异或校验和
				byteSource.AddRange(commandRear);//添加帧尾
				return byteSource.ToArray();

            }
        }
        //发送数据命令字节串
       // public static byte[] UpLoadRealData = { 0x58, 0x53, 0x43, 0x53, 0x01, 0x05, 0x12, 0xA8, 0x9A, 0xC1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC1, 0xAA };
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
	    public static byte[] nowtimestamp()//时间戳前两位表示高位，后两位表示低位
        {
            long l =(System.DateTime.UtcNow.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            byte[] b = new byte[4];
            for (int i=0;i<4;i++ )
            {
                b[i] = (byte)(l& 0x00ff);
                l >>= 8;
            }
			Array.Reverse(b);
			return b;

        }
		public static void XOR(int i, List<byte> byteSource)//亦或校验
		{
			int c = byteSource.Count-1;
			byteSource[c]=0;
			for (int x = i; x< c; x++)
			{
				byteSource[c] ^= byteSource[x];
			}
			
		}
		public static void CheckSum(byte source, byte result)//校验和
		{

		}

		public static void  DealCmd()
		{
         //   timestamp();

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
				case (byte)Id.Connect:Port.SendCommand(Id.UpLoadRealData);
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
