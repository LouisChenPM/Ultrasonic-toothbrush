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
	public delegate bool TextBoxHandler(string s);//UI更新委托
    public delegate bool LedHandler(int i);//LED更新委托
    public delegate bool PassHandler(bool b);//
    public delegate bool StatusBarHandler(string s);//状态栏委托
    public delegate bool TimerHandler(int t);
	public delegate bool RepeatHandler(string s, System.Threading.Thread t);//重复提示显示

	public partial class MainForm : Form
	{
		//public   UIHandler uiHandler ;
		private Port port;
       // private bool isStart=true;
        Color c;
        public MainForm()
		{
			InitializeComponent();
			port = new Port();
			this.buttonPortName.Text = port.NextPort();
            //委托textBoX接口
            UI.textBoxHandler = new TextBoxHandler(UpdateTextBox);
            UI.ledHandler = new LedHandler(UpdateLed);
            UI.passHander = new PassHandler(UpdatePass);
            UI.statusBarHander = new StatusBarHandler(UpdateStatusBar);
            //UI.timeHandler = new TimerHandler(updateTime);
			UI.repeatHandler = new RepeatHandler(ShowRepeatWindow);
            UI.mf = this;
            c = ledBattery.BackColor;
            Status.END = true;
			//dataGridView2.add
        }



        //更换端口号
        private void buttonPortName_Click(object sender, EventArgs e)
		{
			this.buttonPortName.Text = port.NextPort();
		}

		private void startButton_Click(object sender, EventArgs e)//开始停止
		{
            if (Status.END)
            {
                port.Start();//打开串口
                Port.SendCommand(Command.Id.Scan);//发送连接
                ResetTimer.Start();//重置时钟开始计时
                Status.END = false;//停止标志
                this.startButton.Text = "停止";
            }
            else
            {
                ResetTimer.Disable();//计时器关闭
                Status.END =true;//开始标志
                Port.SendCommand(Command.Id.PowerOff);
                System.Threading.Thread.Sleep(100);//延时关闭端口
                Port.SendCommand(Command.Id.Disconnect);
                System.Threading.Thread.Sleep(100);
                port.End();//停止串口
                this.startButton.Text = "开始";
            }

		}
		//更新协议数据窗口
		public  bool UpdateTextBox(string s)
		{
			Console.WriteLine(s);
			s = s + System.Environment.NewLine;//换行
			logBox.AppendText(s);
			return true;
		}

		//显示重复测试提示
		private bool ShowRepeatWindow(string s, System.Threading.Thread t)
		{
			DialogResult dr=MessageBox.Show("  MAC: "+s, "重复MAC地址是否重复测试", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
			if (dr == DialogResult.Yes)
				Test.macRepeatSameProduct = true;
			else
				Test.macRepeatSameProduct = false;
			t.Resume();
			return true;
		}

		//更新LED指示灯
		public bool UpdateLed(int i)
        {
            
            switch (i)
            {
                case 1:radioButton1.Checked = true; ledBattery.BackColor = Color.Green; break;//清洁灯
                case 2:radioButton2.Checked = true; ledBattery.BackColor = Color.Green; break;//
                case 3:radioButton3.Checked = true; ledBattery.BackColor = Color.Green; break;
                case 4:radioButton4.Checked = true; ledBattery.BackColor = Color.Green; break;
                case 5:radioButton5.Checked = true; ledBattery.BackColor = Color.Green; break;
                case 6:radioButton6.Checked = true;  break;
                case -6:radioButton6.Checked = false; break;
                case 0:radioButton1.Checked = false; radioButton2.Checked = false;
                    radioButton3.Checked = false; radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    ledBattery.BackColor =c;
                    break;

            }
            return true;
        }
        //更新测试通过按钮
        int i = 0;
        private bool UpdatePass(bool b)
        {
            i++;
            passBtn.Text = "Pass" + i;
            return true;
        }
        //更新StatusBar
        private bool UpdateStatusBar(string s)
        {
            this.toolStripStatusLabel1.Text = s;
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
		//	asf.InitOldControlRects(this);
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

        private void button11_Click(object sender, EventArgs e)
        {
            Port.SendCommand(Command.Id.StopRealData);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            logBox.Clear();
        }

		private void MainForm_MaximumSizeChanged(object sender, EventArgs e)
		{

		}

		AutoSizeForm asf = new AutoSizeForm();
		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
		//	AutoSizeForm asf = new AutoSizeForm();
			//AutoSizeForm asf = new AutoSizeForm();
			
			asf.AutoSize(this);
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			asf.InitOldControlRects(this);
		}
	}
}
