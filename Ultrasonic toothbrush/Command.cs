﻿using System;
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
		public static byte[] SelRssi = { 0x46, 0x4C, 0x59, 0x43, 0x4F, 0x01, 0x00, 0x01 };
		public static byte[] SelVersion = { 0x58, 0x53, 0x43, 0x53, 0x01, 0x04, 0x08, 0x08, 0x46, 0x4C, 0x59, 0x43, 0x4F, 0x14, 0x00, 0x14 };
//连接命令字节串，里面的mac地址(从第九位开始往后算两位)、芯片型号(最后两位)
//public static byte[] Connect = { 0x58, 0x53, 0x43, 0x53, 0x01, 0x02, 0x06, 0x08, 0x20, 0x49, 0x31, 0x50, 0xA0, 0x00, 0x01, 0x31 };
private static byte[] head = { 0x58, 0x53, 0x43, 0x53};//发送帧头//
		private static byte[] commandCode = { 0x01, 0x02, 0x06, 0x08 };//命令特征码连接码0x1厂家代码，0x02命令类型,0x06数据长度,0x08校验值和
		private static byte[] chipCode = { 0x01, 0x31 };//芯片型号/通道号 ，来自设置
		private static byte[] channelName = {  };//device Code，来自设置
		public static byte[] Connect //拼接连接指令，这里要在最后增加字符串以供通道设置并设置length的长度
		{

			get {
				List<byte> byteSource = new List<byte>();
				byteSource.AddRange(head);//添加头
                commandCode[2] = (byte)(device.mac.Length + channelName.Length + chipCode.Length);//计算数据包的长度
				byteSource.AddRange(commandCode);//添加命令类型
				byteSource.AddRange(device.macConnect);//添加mac地址
				byteSource.AddRange(chipCode);//添加芯片型号
				byteSource.AddRange(channelName);//添加用于指定通道号的字符串
				return  byteSource.ToArray();
			}

		}
        // package = { 0x9A, 0xC1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC1, 0xAA };//x9A帧头0xC1命令类型查询
        public static byte[] UpLoadRealData//上传实时数据命令
        {
            get { return getPackageToBrush(Id.UpLoadRealData); }
        }
        public static byte[] StopRealData//关闭上传实时数据
        {
            get { return getPackageToBrush(Id.StopRealData); }
        }
        public static byte[] Voltage//查询电压命令
        {
            get
            {
                return getPackageToBrush(Id.Voltage);
            }
        }
        public static byte[] SetCleanMode//设置清洁模式
        {
            get { return getPackageToBrush(Id.CleanMode); }
        }
        public static byte[] SetWhiteMode//设置亮白模式
        {
            get { return getPackageToBrush(Id.SetWhiteMode); }
        }
        public static byte[] SetPolishMode//设置抛光模式
        {
            get { return getPackageToBrush(Id.SetPolishMode); }
        }
        public static byte[] SetSensitiveMode//设置敏感模式
        {
            get { return getPackageToBrush(Id.SetSensitiveMode); }
        }
        public static byte[] SetMassageMode//设置按摩模式
        {
            get { return getPackageToBrush(Id.SetMassageMode); }
        }
        public static byte[] SetPowerOn//设置开机
        {
            get { return getPackageToBrush(Id.PowerOn); }
        }

        public static byte[] SetPowerOff//设置关机
        {
            get { return getPackageToBrush(Id.PowerOff); }
        }
        public static byte[] DelData { get {//删除历史数据
                return getPackageToBrush(Id.DelData);
            } }
        public static byte[] SelData
        {
            get
            {
                return getPackageToBrush(Id.SelData);
            }
        }
        /*--将与牙刷通信的指令拆分为head code timestamp brushComdCode Option Rear---
        ----这几部分根据不同的指令对应这些部分不同的内容分别赋值，最后做校验拼接---- */
        private static byte[] code = { 0x01, 0x02, 0x06, 0x08 };
        private static byte[] timestamp { get { return nowtimestamp(); } }
        private static byte[] brushCmdCode = { 0x9A, 0xC1 };
        private static byte[] Option = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC1 };//操作选项
        private static byte[] Rear = { 0xAA };
        private static byte[] getPackageToBrush(Command.Id id)
        {//分别对不同的指令设置的code[1],brushComdCode[1],Option[1],Option[2]进行设置

            for (int i = 0; i < Option.Length; i++)//初始化option
                Option[i] = 0x0;
            switch (id)
            {
                case Id.UpLoadRealData:	    code[1] = 0x05; brushCmdCode[1] = 0xC1; Option[1] = 0x00; Option[2] = 0x00; break;
                case Id.StopRealData:       code[1] = 0x05; brushCmdCode[1] = 0xDD; Option[1] = 0x01;break;//终止发送实时数据
                case Id.Voltage:            code[1] = 0x5;brushCmdCode[1] = 0xD1; break;//查询电池电压电量等
                case Id.DelData: code[1] = 0x5; brushCmdCode[1] = 0xD6;Option[0] = 0xC1; break;//删除历史数据
                case Id.SelData: code[1] = 0x5; brushCmdCode[1] = 0xD6; Option[0] = 0x00; break;//查询历史数据是否被删除
                case Id.CleanMode:		    code[1] = 0x05; brushCmdCode[1] = 0xC8; Option[1] = 0x01; Option[2] = 0x01; break;//C8设置清洁模式
                case Id.SetWhiteMode:	    code[1] = 0x05; brushCmdCode[1] = 0xc8; Option[1] = 0x01; Option[2] = 0x02; break;
                case Id.SetPolishMode:	    code[1] = 0x05; brushCmdCode[1] = 0xc8; Option[1] = 0x01; Option[2] = 0x03; break;
                case Id.SetSensitiveMode:   code[1] = 0x05; brushCmdCode[1] = 0xc8; Option[1] = 0x01; Option[2] = 0x04; break;
                case Id.SetMassageMode:	    code[1] = 0x05; brushCmdCode[1] = 0xc8; Option[1] = 0x01; Option[2] = 0x05; break;
                case Id.PowerOn:			code[1] = 0x05; brushCmdCode[1] = 0xc9; Option[1] = 0x01; Option[2] = 0x01; break;//C9设置开关机
                case Id.PowerOff:			code[1] = 0x05; brushCmdCode[1] = 0xc9; Option[1] = 0x01; Option[2] = 0x00; break;
                case Id.FactoryReset:		code[1] = 0x05; brushCmdCode[1] = 0xcb; Option[1] = 0x01; Option[2] = 0x00; break;//CB设置恢复工厂模式
                
            }
            List<byte> byteSource = new List<byte>();
            byteSource.AddRange(head);//添加帧头
            code[2] = (byte)(brushCmdCode.Length + timestamp.Length + Option.Length + Rear.Length);//计算帧长
            code[3] = 0;//code[3]为暂时未用的校验和位
            byteSource.AddRange(code);//添加code
            byteSource.AddRange(brushCmdCode);//添加牙刷操命令号
            byteSource.AddRange(timestamp);//添加时间戳
            byteSource.AddRange(Option);//添加不同操作指令中的操作选项
            XOR(9, byteSource);//异或校验和
            byteSource.AddRange(Rear);//添加帧尾
            return byteSource.ToArray();//转换为字节串
        }

        public static byte[] Factoryreset
        {
            get { return getPackageToBrush(Id.FactoryReset); }
        }



        //public static byte[] Factoryreset  = { 0x58, 0x53, 0x43, 0x53, 0x01, 0x05, 0x12, 0xA8, 0x9A, 0xCB, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xCA, 0xAA };
        public static byte[] Disconnect = { 0x58, 0x53, 0x43, 0x53, 0x01, 0x03, 0x00, 0x00 };//收到断开{ 0x78,0x73,0x63,0x73,0x01,0x03,0x00,0x19 };
        private static Device device=null;
		public static Port port;
		public enum  Id //协议中传输命令类型枚举
		{
			Scan = 1,
			Connect = 2,
			Disconnect = 3,
			PackageData = 4,
			UpLoadRealData,
            StopRealData,
            FactoryReset,
			CleanMode,
            SetWhiteMode,
            SetPolishMode,
            SetSensitiveMode,
            SetMassageMode,
            PowerOn,
			PowerOff,
			Rssi,
			Version,
            Voltage,
			Stop,
			Reset,
            DelData,
            SelData
            //以下留着备用
            //wait_disconnect = 0xFB,
            //in_reset = 0xFC,
            //out_reset = 0xFD,
            //sel_mac = 0xFE,
        }
		static int systmeTime;
	    public static byte[] nowtimestamp()//时间戳前两位表示高位，后两位表示低位
        {
            long l =(System.DateTime.UtcNow.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
			systmeTime = (int)l;
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
		public static bool XORCheck(byte[] b,int i,int r)//亦或校验
		{
			return true;

		}
		public static void CheckSum(byte source, byte result)//校验和
		{

		}

		static int count = 0;
		public static void  DealCmd()
		{
            //   timestamp();
            if (Status.END) return;
            switch (cmd[5])
			{
				case(byte) Id.Scan://*****测试流程第1步扫描结果决定是否连接
                    device = new Device();//新建一个扫描到的设备
					device.mac=GetMac();//获取扫描到的mac地址
					device.rssi=GetRssi();//获取信号强度
					string settingName = "FLYCO DDYS01      ";//设置中用于比较的名称
					device.name=GetDeviceName();//getmac//getrssi//getdevicename//getchiptype//port.connect(if rssi>x)
                 //   Status.now = Status.AllStatus.Scaning;//全局状态设置为扫描
					if (device.rssi > Setting.Rssi && device.name == settingName)//这里是连接条件（还可以包含设置连接名称）
					{
						if (Status.now == Status.AllStatus.Connecting)
							return;//这里保证在连接时直接忽略其他mac地址
						Port.SendCommand(Id.Connect);//在信号范围内尝试连接，不在信号范围内重新扫描
						Status.now = Status.AllStatus.Connecting;
					}
					break;
				case (byte)Id.Connect://*****测试流程第2步连接后查询版本号
					Status.now = Status.AllStatus.Connected;
                    Port.SendCommand(Id.Version);//查询版本号
                    ResetTimer.DelayRetry(Id.Version);//查询版本号重发机制
                    UI.LED(6);//连接后查询版本号
                    Console.WriteLine("S2");
					break;
				case (byte)Id.Disconnect:UI.LED(-6);//关闭连接led
                    if (Status.now == Status.AllStatus.Testing)
					{
						ResetTimer.StopRetry();//停止断开重发机制。
						Status.now = Status.AllStatus.TestDone;//测试完成标识
					}
					break;
				case (byte)Id.PackageData://*****测试流程第3步获取版本号，设置清洁模式
                    if (cmd[6] == 0x12) RealDataDdOrD9();//PackageData//数据处理
					if (cmd[6] == 0x0A&&cmd[8]==0x66&& cmd[9] == 0x65 && cmd[13]==0x14) {
                        ResetTimer.StopRetry();//停止重发获取版本号
						device.version= GetVersion();//获取版本号
						Port.SendCommand(Id.CleanMode);//设置清洁模式给牙刷发时间
						//ResetTimer.DelayRetry(Id.CleanMode);//设置清洁模式重发机制
						/********************************************这两行注释掉以后从原步骤S4-S10都不在工作*************************************************/
					   //	Port.SendCommand(Id.UpLoadRealData);
                      //  ResetTimer.DelayRetry(Id.UpLoadRealData);//上传实时数据重发机制
                       // UI.LED(6);//*****测试流程第3步上传实时数据打开连接led
                        Console.WriteLine("S3");
					}
					break;
				case (byte)Id.UpLoadRealData:
					break;
				case (byte)Id.Stop:
					break;
				default:
					break;
			}
		}
		private static byte[] ddorD9 = new byte[0x12];//暂存DD或D9指令
        private static bool poweroff = false;
		private static void RealDataDdOrD9()//解析DD或D9指令
		{
			Array.Copy(cmd, 8, ddorD9, 0, 0x12);//从第8位开始将dd或d9指令拷贝出来
                                                //验证一下校验位，不符合的指令忽略
                                                //下面开始对应位数据的解析
                                                //	ddorD9[]

        /*    int pureBrushTime;
            int overPressTime;
            int pauseTime;
			float batteryPercentage;
            int batteryStatus;
			int chargeStatus;
			int cleanMode;
			int runingStatus;
            int pressStatus;
            int brushCount=0;
            int finishStatus;
			*/
            long currentTicks = DateTime.Now.Ticks;
			int brushTime=0;
            switch (ddorD9[1])
            {

                case 0xC8: //*****第4步清洁模式设置成功 ，获取返回时间的数，恢复出厂模式
					ResetTimer.StopRetry();//关闭设置清洁模式重发机制
					brushTime = 0;//清空所有位
					brushTime = brushTime|ddorD9[2];
					brushTime = brushTime << 8;
					brushTime = brushTime | ddorD9[3];
					brushTime = brushTime << 8;
					brushTime = brushTime | ddorD9[4];
					brushTime = brushTime << 8;
					brushTime = brushTime | ddorD9[5];//获取到返回的时间
					int i = brushTime-systmeTime ;//计算时间差

					//提供一种不恢复工厂模式下的测试模式，方便批量化稳定性测试标识位Setting.settingNotResetFactoryMode
					Setting.settingNotResetFactoryMode = true;
					if (Setting.settingNotResetFactoryMode == true)
					{
					Status.now = Status.AllStatus.Testing;//暂时测试使用
					Test.test(device);//暂时测试使用
					Port.SendCommand(Id.Disconnect);//这里如果量产时出现无法断开的情况 则重发
					ResetTimer.DelayRetry(Id.Disconnect);//断开重发机制
						break;
					}
					//恢复工厂模式测试
					Port.SendCommand(Id.FactoryReset);//恢复出厂模式
					ResetTimer.DelayRetry(Id.FactoryReset);//恢复出厂模式重发机制
					Console.WriteLine("S4");
                    break;
                case 0xCb: //case 第5步 断开连接，也是最后一步
                    ResetTimer.StopRetry();//停止恢复工厂模式重发
					device.FactoryReseted = true;//表示已经恢复工厂模式
					Status.now = Status.AllStatus.Testing;//进入测试状态标识
					Test.test(device);//调用设备测试
					Port.SendCommand(Id.Disconnect);//这里如果量产时出现无法断开的情况 则重发
					ResetTimer.DelayRetry(Id.Disconnect);//断开重发机制
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
        //获取固件版本号
        private static string GetVersion()
		{
            int i = 0;
            i = cmd[15];
            i = i <<8;
            i =i| cmd[16];//将[15][16]两位拼接起来
            string spec = (i&1).ToString();//特殊位
            string child=(i >> 1 & 0x1FF).ToString() ;//3位长度子版本号
            string main= (i>> 10 & 0x1F).ToString();//2位长度主版本号
            string fun = (i >> 15 & 1).ToString();//测试环境版本号
            //补足长度
            if (main.Length == 1)
                main = "0" + main;
            if (child.Length == 1)
                child = "00" + child;
            if (child.Length == 2)
                child = "0" + child;
            string s= fun + "." + main + "." + child + "." + spec;//连接
            return s;
		}
        //获取电压
        private static float GetVoltage()//获取电压
        {
            int i = cmd[14];
            float f = i << 8|cmd[15];
            f = f / 10;
            return f;
        }
		private static string GetDeviceName()
		{
			int i=Array.IndexOf(cmd, (byte)0x9);//查找名称起始字符（\t制表符），这里的查找类型要与cmd元素类型匹配
			int len = cmd[i - 1]-1;//获取名称字符串长度
			return System.Text.Encoding.Default.GetString(cmd, i+1, len);//将名称拷贝出来里面带有制表符
		}
	}
}
