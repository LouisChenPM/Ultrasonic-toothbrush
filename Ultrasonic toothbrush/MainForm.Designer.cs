﻿namespace Ultrasonic_toothbrush
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonPortName = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.logBox = new System.Windows.Forms.TextBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ledBattery = new System.Windows.Forms.Label();
			this.passBtn = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.button13 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.MAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonPortName);
			this.groupBox1.Controls.Add(this.startButton);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(986, 88);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "...";
			// 
			// buttonPortName
			// 
			this.buttonPortName.Location = new System.Drawing.Point(144, 22);
			this.buttonPortName.Name = "buttonPortName";
			this.buttonPortName.Size = new System.Drawing.Size(117, 30);
			this.buttonPortName.TabIndex = 3;
			this.buttonPortName.Text = "无串口";
			this.buttonPortName.UseVisualStyleBackColor = true;
			this.buttonPortName.Click += new System.EventHandler(this.buttonPortName_Click);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(295, 16);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(225, 48);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "开始";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(611, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(225, 48);
			this.button1.TabIndex = 4;
			this.button1.Text = "断开";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(419, 18);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(75, 23);
			this.button12.TabIndex = 15;
			this.button12.Text = "清空";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(419, 47);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 23);
			this.button11.TabIndex = 14;
			this.button11.Text = "停止上传";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(247, 48);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 23);
			this.button10.TabIndex = 13;
			this.button10.Text = "按摩";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(247, 19);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 12;
			this.button9.Text = "敏感";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(166, 48);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 11;
			this.button8.Text = "抛光";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(166, 19);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 10;
			this.button7.Text = "亮白";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(328, 48);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 9;
			this.button6.Text = "关机";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(328, 19);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 8;
			this.button5.Text = "开机";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(85, 48);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "清洁";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(85, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "恢复工厂模式";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(4, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "上传数据";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// logBox
			// 
			this.logBox.AllowDrop = true;
			this.logBox.Location = new System.Drawing.Point(281, 463);
			this.logBox.Multiline = true;
			this.logBox.Name = "logBox";
			this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.logBox.Size = new System.Drawing.Size(961, 202);
			this.logBox.TabIndex = 1;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(48, 14);
			this.trackBar1.Maximum = 0;
			this.trackBar1.Minimum = -100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(228, 45);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.FlatAppearance.BorderSize = 10;
			this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.radioButton1.Location = new System.Drawing.Point(21, 22);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(14, 13);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.FlatAppearance.BorderSize = 10;
			this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.radioButton2.Location = new System.Drawing.Point(67, 22);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(14, 13);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.FlatAppearance.BorderSize = 10;
			this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.radioButton3.Location = new System.Drawing.Point(113, 22);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(14, 13);
			this.radioButton3.TabIndex = 8;
			this.radioButton3.TabStop = true;
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.FlatAppearance.BorderSize = 10;
			this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.radioButton4.Location = new System.Drawing.Point(158, 22);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(14, 13);
			this.radioButton4.TabIndex = 9;
			this.radioButton4.TabStop = true;
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(277, 55);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(14, 13);
			this.radioButton6.TabIndex = 11;
			this.radioButton6.TabStop = true;
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton5);
			this.panel1.Controls.Add(this.radioButton4);
			this.panel1.Controls.Add(this.radioButton3);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Location = new System.Drawing.Point(30, 33);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(241, 43);
			this.panel1.TabIndex = 12;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(198, 20);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(14, 13);
			this.radioButton5.TabIndex = 10;
			this.radioButton5.TabStop = true;
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.ledBattery);
			this.panel2.Controls.Add(this.radioButton6);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Location = new System.Drawing.Point(575, 134);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(358, 100);
			this.panel2.TabIndex = 13;
			// 
			// ledBattery
			// 
			this.ledBattery.AutoSize = true;
			this.ledBattery.BackColor = System.Drawing.SystemColors.Control;
			this.ledBattery.Location = new System.Drawing.Point(297, 54);
			this.ledBattery.Name = "ledBattery";
			this.ledBattery.Size = new System.Drawing.Size(41, 12);
			this.ledBattery.TabIndex = 13;
			this.ledBattery.Text = "label2";
			// 
			// passBtn
			// 
			this.passBtn.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.passBtn.Location = new System.Drawing.Point(314, 102);
			this.passBtn.Name = "passBtn";
			this.passBtn.Size = new System.Drawing.Size(225, 48);
			this.passBtn.TabIndex = 14;
			this.passBtn.Text = "PASS";
			this.passBtn.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 693);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1268, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(156, 70);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(117, 30);
			this.button13.TabIndex = 16;
			this.button13.Text = "时间";
			this.button13.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button12);
			this.panel3.Controls.Add(this.button7);
			this.panel3.Controls.Add(this.button11);
			this.panel3.Controls.Add(this.button10);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.button9);
			this.panel3.Controls.Add(this.button3);
			this.panel3.Controls.Add(this.button8);
			this.panel3.Controls.Add(this.button4);
			this.panel3.Controls.Add(this.button5);
			this.panel3.Controls.Add(this.button6);
			this.panel3.Location = new System.Drawing.Point(295, 519);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(497, 85);
			this.panel3.TabIndex = 17;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.trackBar1);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Location = new System.Drawing.Point(575, 264);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(341, 62);
			this.panel4.TabIndex = 22;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.设置ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1268, 25);
			this.menuStrip1.TabIndex = 23;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 打开ToolStripMenuItem
			// 
			this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
			this.打开ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.打开ToolStripMenuItem.Text = "打开";
			// 
			// 设置ToolStripMenuItem
			// 
			this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
			this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.设置ToolStripMenuItem.Text = "设置";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAC,
            this.NAME});
			this.dataGridView1.Location = new System.Drawing.Point(12, 251);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(243, 414);
			this.dataGridView1.TabIndex = 24;
			// 
			// MAC
			// 
			this.MAC.HeaderText = "MAC";
			this.MAC.Name = "MAC";
			// 
			// NAME
			// 
			this.NAME.HeaderText = "名称";
			this.NAME.Name = "NAME";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1268, 715);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.passBtn);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.logBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel3);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Ultrasonic toothbrush";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button buttonPortName;
		private System.Windows.Forms.TextBox logBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label ledBattery;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button passBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MAC;
		private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
	}
}

