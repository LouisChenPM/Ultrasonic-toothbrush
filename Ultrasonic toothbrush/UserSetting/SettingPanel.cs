using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultrasonic_toothbrush.UserSetting
{
	public partial class SettingPanel : Form
	{
		public SettingPanel()
		{
			InitializeComponent();
			if(SaveXml.Load()==false)
			 MessageBox.Show("  配置文件加载失败 " , "重要信息", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
			//mac地址
			int index =dataGridView.Rows.Add();
			dataGridView.Rows[index].Cells["item"].Value = "MAC";
			dataGridView.Rows[index].Cells["max"].Value = Setting.MacMax.ToString("X2");
			dataGridView.Rows[index].Cells["mini"].Value = Setting.MacMini.ToString("X2");
			//信号强度
			index = dataGridView.Rows.Add();
			dataGridView.Rows[index].Cells["item"].Value = "RSSI";
			dataGridView.Rows[index].Cells["Count"].Value = Setting.Rssi;
			//设备名称
			index = dataGridView.Rows.Add();
			dataGridView.Rows[index].Cells["item"].Value = "设备名称";
			dataGridView.Rows[index].Cells["Count"].Value = Setting.DeviceName;
			//版本号
			index = dataGridView.Rows.Add();
			dataGridView.Rows[index].Cells["item"].Value = "版本号";
			dataGridView.Rows[index].Cells["Count"].Value = Setting.Version;
		}

		private bool offline = false;
		private void button6_Click(object sender, EventArgs e)
		{
			if (offline)
			{ 
				button6.Left = button5.Left;
				button5.BackColor = Color.LightGray;
				offline = false;

			}
			else
			{ 
				button6.Left = button6.Left+button5.Width-button6.Width;
				button5.BackColor = Color.LightGreen;
				offline = true;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (offline)
			{
				button6.Left = button5.Left;
				button5.BackColor = Color.Gray;
				offline = false;

			}
			else
			{
				button6.Left = button6.Left + button5.Width - button6.Width;
				button5.BackColor = Color.LightGreen;
				offline = true;
			}
		}
		private bool notfactoryReset = false;
		private void button4_Click(object sender, EventArgs e)
		{
			if (notfactoryReset)
			{
				button4.Left = button7.Left;
				button7.BackColor = Color.LightGray;
				notfactoryReset = false;

			}
			else
			{
				button4.Left = button4.Left + button7.Width - button4.Width;
				button7.BackColor = Color.LightGreen;
				notfactoryReset = true;
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (notfactoryReset)
			{
				button4.Left = button7.Left;
				button7.BackColor = Color.LightGray;
				notfactoryReset = false;

			}
			else
			{
				button4.Left = button4.Left + button7.Width - button4.Width;
				button7.BackColor = Color.LightGreen;
				notfactoryReset = true;
			}
		}
		private static SaveXml xml = new SaveXml();
		private void button1_Click(object sender, EventArgs e)
		{
			//xml.
			Setting.MacMax= Convert.ToInt64((string) dataGridView.Rows[0].Cells["max"].Value,16);
			Setting.MacMini= Convert.ToInt64((string)dataGridView.Rows[0].Cells["mini"].Value,16);
			Setting.Rssi = Convert.ToInt32(dataGridView.Rows[1].Cells["count"].Value);
			Setting.DeviceName= (string)dataGridView.Rows[2].Cells["count"].Value;
			Setting.Version = (string)dataGridView.Rows[3].Cells["count"].Value;
			//Setting.Version=dataGridView.Rows[]

			Setting.LineNumber = textBox2.Text;

			Setting.DeviceName = textBox1.Text;
			Setting.Server = serverNameComboBox.Text;
			Setting.Chip = bleChipComboBox.Text;
			if(SaveXml.Save()==false)
				MessageBox.Show("  配置文件保存失败 ", "重要信息", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveXml.Load();
		}

		
	}
}
