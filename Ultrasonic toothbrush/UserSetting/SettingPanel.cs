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

	}
}
