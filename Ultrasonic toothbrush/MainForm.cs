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
		private ResetTimer resetTimer;
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

		private void startButton_Click(object sender, EventArgs e)
		{
			if(port.Start()==true)
				this.startButton.Text="停止";
			Port.SendCommand(Command.Id.Scan);//发送连接
			ResetTimer.Start();//重置时钟开始计时

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
			Port.SendCommand(Command.Id.Connect);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Port.SendCommand(Command.Id.UpLoadRealData);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			port.End();
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			label1.Text = trackBar1.Value.ToString();
			Setting.Rssi = trackBar1.Value;
		}
	}
}
