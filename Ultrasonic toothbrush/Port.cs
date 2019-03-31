using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
namespace Ultrasonic_toothbrush
{
	class Port
	{

		private static SerialPort comm = new SerialPort();
		private StringBuilder builder = new StringBuilder();
		private long receivedCount = 0;//接受计数;
		private long sendCout = 0;//发送计数;
		private bool Listening = false;//是否执行完成invoke操作;
		private bool Closing = false;//是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke  
		private List<byte> buffer = new List<byte>(4096);
        private static bool dataReceivedHandleNotBonded = true;
        /* 串口名称*/
        private string portName;//使用串口
		string[] portNames;//所有串口
		int portNameIndex = -1;//当前串口索引号
	//	public static TextBoxHandler uiHandler ;//ui委托对象
		//public static MainForm mf;//引用主窗口
		public Port()//构造函数
		{
			/*查找本机串口号*/
			portNames = SerialPort.GetPortNames();
			if (portNames == null) return;//本机没有串口返回
			Array.Sort(portNames);
			Array.Reverse(portNames);
			portName = portNames[0];
			Command.port = this;//传递串口引用
		}
		//开始监听
		public bool Start()
		{//初始化串口参数,参数以常数的形式写在这里以后修改
			comm.PortName = portName;
			comm.BaudRate = 115200;
			comm.Parity= System.IO.Ports.Parity.None;
			comm.DataBits = 8;
			comm.StopBits = System.IO.Ports.StopBits.One;
			comm.Handshake= System.IO.Ports.Handshake.None;
			comm.ReadTimeout = 500;
			comm.WriteTimeout = 500;
            if(dataReceivedHandleNotBonded)
            { 
			comm.DataReceived += DataDataReceived;
                dataReceivedHandleNotBonded = false;
                }
			//尝试打开串口
			try { 
			comm.Open();
				return true;
			}
			catch(Exception e)
			{
				e.Data.ToString();
				return false;
			}

		}
		public bool End()
		{
			comm.Close();
			return true;
		}

		static int count1 = 0;
		//发送命令
		public static  void SendCommand(Command.Id commId)
		{
			byte[] buf=null;

			switch (commId)
			{
				case Command.Id.Scan:buf = Command.Scan;
					break;
				case Command.Id.Connect:buf = Command.Connect; 
					break;
				case Command.Id.Stop:
					break;
				case Command.Id.Disconnect:buf = Command.Disconnect;
					break;
				case Command.Id.UpLoadRealData:buf = Command.UpLoadRealData;
					break;
                case Command.Id.StopRealData:buf = Command.StopRealData;
                    break;
                case Command.Id.DelData: buf= Command.DelData;break;
                case Command.Id.Voltage:buf = Command.Voltage;break;
				case Command.Id.Reset: buf=Command.Disconnect; break;//暂时显示reset
                case Command.Id.FactoryReset: buf= Command.Factoryreset;break;
				case Command.Id.CleanMode:buf = Command.SetCleanMode;break;
                case Command.Id.SetWhiteMode:buf = Command.SetWhiteMode;break;
                case Command.Id.SetPolishMode:buf = Command.SetPolishMode;break;
                case Command.Id.SetSensitiveMode: buf = Command.SetSensitiveMode; break;
                case Command.Id.SetMassageMode: buf = Command.SetMassageMode; break;
				case Command.Id.Rssi:buf = Command.SelRssi;break;
				case Command.Id.Version:buf = Command.SelVersion;break;
                case Command.Id.PowerOn:buf = Command.SetPowerOn;break;
				case Command.Id.PowerOff:buf = Command.SetPowerOff;break;

                default:
					break;
			}
			int offset = 0;
			int count = buf.Length;
			string s = BitConverter.ToString(buf).Replace("-", " ");//转换为16进制显示
            string t = DateTime.Now.ToString("HH:mm:ss");
            UI.TextBox( t  + " [W] " + s);//在界面显示/
            comm.Write(buf, offset, count);
		}
		/*修改端口号为下一个*/
		public string NextPort()
		{
			if (portNames == null) return "没找到串口";//本机没有串口返回提示信息
			portNameIndex = (portNameIndex + 1) % portNames.Length;
			portName = portNames[portNameIndex];
			return portName;
		}
		/*接收串口数据*/
		private void DataDataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			ResetTimer.MarkTime();
			if (Closing) return;//尽快完成监听
			Listening = true;//设置标记，说明我已经开始处理数据，一会儿要使用系统UI的。  
			int n = comm.BytesToRead;//获取需要读取字节长度
			byte[] buf = new byte[n];
			receivedCount += n;//增加接收计数 
			comm.Read(buf, 0, n);//读取缓冲数据
			buffer.AddRange(buf);//添加到缓冲区
			while (buffer.Count >= Command.headerLength)
			{
				//2.1 查找数据头  buffer[6] 为数据包的长度
				if (buffer[0] == 0x78&& buffer[1] == 0x73 && buffer[2] == 0x63 && buffer[3] == 0x73)
				{
					int len = buffer[6];
					if (buffer.Count < len + Command.headerLength) break;//保证至少有一个命令长度
					/*在这里做校验*/
					byte[] cmd=new byte[len + Command.headerLength];//新建一个缓存
					buffer.CopyTo(0,cmd, 0, len + Command.headerLength);//拷贝一条命令到缓存
					buffer.RemoveRange(0, len + Command.headerLength);//移除已拷贝数据
					Command.cmd = cmd;//拷贝已缓存命令
					string s =BitConverter.ToString(cmd).Replace("-", " ");//转换为16进制显示
                    string t = DateTime.Now.ToString("HH:mm:ss");
                    UI.TextBox(t+" [R] " + s);//在界面显示/
                    Command.DealCmd();//处理已拷贝的命令
				}
				else
				{
					buffer.RemoveAt(0);//移除无意义的头
				}


}

			
		}
	}
}
