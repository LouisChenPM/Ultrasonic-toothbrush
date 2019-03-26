using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultrasonic_toothbrush
{
	public delegate bool UIHandler(string s);//UI更新委托
	
	public partial class MainForm : Form
	{
		//public   UIHandler uiHandler ;
		private Port port;
        private bool isStart=true;
		public MainForm()
		{
			InitializeComponent();
			port = new Port();
			this.buttonPortName.Text = port.NextPort();
			//uiHandler = new UIHandler(UpdateUI);
			Port.uiHandler = new UIHandler(UpdateUI);
			Port.mf = this;
		}


		//更换端口号
		private void buttonPortName_Click(object sender, EventArgs e)
		{
			this.buttonPortName.Text = port.NextPort();
		}

		private void startButton_Click(object sender, EventArgs e)//开始停止
		{
            if (isStart)
            {
                port.Start();//打开串口
                Port.SendCommand(Command.Id.Scan);//发送连接
                ResetTimer.Start();//重置时钟开始计时
                isStart = false;//停止标志
                this.startButton.Text = "停止";
            }
            else
            {
                ResetTimer.Disable();//计时器关闭
                isStart=true;//开始标志
                port.End();//停止串口
                this.startButton.Text = "开始";
            }

		}
		//更新UI
		public  bool UpdateUI(string s)
		{
			s = s + System.Environment.NewLine;//换行
			logBox.AppendText(s);
			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Port.SendCommand(Command.Id.Disconnect);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Port.SendCommand(Command.Id.UpLoadRealData);
		}

		private void button3_Click(object sender, EventArgs e)
		{
            Port.SendCommand(Command.Id.FactoryReset);
			//System.Threading.Thread.Sleep(14);
			Port.SendCommand(Command.Id.Disconnect);
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			label1.Text = trackBar1.Value.ToString();
			Setting.Rssi = trackBar1.Value;
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

		private void button4_Click(object sender, EventArgs e)
		{
		Port.SendCommand(Command.Id.CleanMode);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Port.SendCommand(Command.Id.PowerOn);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Port.SendCommand(Command.Id.PowerOff);
		}

        private void button7_Click(object sender, EventArgs e)
        {
            Port.SendCommand(Command.Id.SetWhiteMode);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Port.SendCommand(Command.Id.SetPolishMode);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Port.SendCommand(Command.Id.SetSensitiveMode);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Port.SendCommand(Command.Id.SetMassageMode);
        }
    }
}
