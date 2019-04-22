namespace Ultrasonic_toothbrush.UserSetting
{
	partial class SettingPanel
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.deviceNameLable = new System.Windows.Forms.Label();
			this.bleChipComboBox = new System.Windows.Forms.ComboBox();
			this.bleChipLabel = new System.Windows.Forms.Label();
			this.serverNameComboBox = new System.Windows.Forms.ComboBox();
			this.serverNameLabel = new System.Windows.Forms.Label();
			this.productLineLabel1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mini = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(509, 396);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(501, 370);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "常规";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView);
			this.groupBox2.Location = new System.Drawing.Point(9, 125);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(467, 166);
			this.groupBox2.TabIndex = 29;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "参数设置";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AllowUserToResizeColumns = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.Item,
            this.Mini,
            this.Max,
            this.Count});
			this.dataGridView.Location = new System.Drawing.Point(0, 20);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.Size = new System.Drawing.Size(461, 139);
			this.dataGridView.TabIndex = 27;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.deviceNameLable);
			this.groupBox1.Controls.Add(this.bleChipComboBox);
			this.groupBox1.Controls.Add(this.bleChipLabel);
			this.groupBox1.Controls.Add(this.serverNameComboBox);
			this.groupBox1.Controls.Add(this.serverNameLabel);
			this.groupBox1.Controls.Add(this.productLineLabel1);
			this.groupBox1.Location = new System.Drawing.Point(9, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(467, 97);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "基本设置";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(53, 28);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(76, 21);
			this.textBox2.TabIndex = 74;
		
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(53, 66);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(76, 21);
			this.textBox1.TabIndex = 73;

			// 
			// deviceNameLable
			// 
			this.deviceNameLable.AutoSize = true;
			this.deviceNameLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deviceNameLable.Location = new System.Drawing.Point(6, 69);
			this.deviceNameLable.Name = "deviceNameLable";
			this.deviceNameLable.Size = new System.Drawing.Size(41, 12);
			this.deviceNameLable.TabIndex = 72;
			this.deviceNameLable.Text = "设备名";
			// 
			// bleChipComboBox
			// 
			this.bleChipComboBox.FormattingEnabled = true;
			this.bleChipComboBox.Items.AddRange(new object[] {
            "CYPRESS",
            "AMICCOM",
            "TELINK"});
			this.bleChipComboBox.Location = new System.Drawing.Point(208, 67);
			this.bleChipComboBox.Name = "bleChipComboBox";
			this.bleChipComboBox.Size = new System.Drawing.Size(76, 20);
			this.bleChipComboBox.TabIndex = 71;

			// 
			// bleChipLabel
			// 
			this.bleChipLabel.AutoSize = true;
			this.bleChipLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bleChipLabel.Location = new System.Drawing.Point(173, 73);
			this.bleChipLabel.Name = "bleChipLabel";
			this.bleChipLabel.Size = new System.Drawing.Size(29, 12);
			this.bleChipLabel.TabIndex = 70;
			this.bleChipLabel.Text = "芯片";
			// 
			// serverNameComboBox
			// 
			this.serverNameComboBox.CausesValidation = false;
			this.serverNameComboBox.FormattingEnabled = true;
			this.serverNameComboBox.Items.AddRange(new object[] {
            "localhost",
            "ServerPCBA",
            "ServerPCBA2",
            "ServerProduct",
            "ServerProduct2",
            "127.0.0.1"});
			this.serverNameComboBox.Location = new System.Drawing.Point(208, 26);
			this.serverNameComboBox.Name = "serverNameComboBox";
			this.serverNameComboBox.Size = new System.Drawing.Size(76, 20);
			this.serverNameComboBox.TabIndex = 69;
			this.serverNameComboBox.Text = "localhost";

			// 
			// serverNameLabel
			// 
			this.serverNameLabel.AutoSize = true;
			this.serverNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.serverNameLabel.Location = new System.Drawing.Point(149, 29);
			this.serverNameLabel.Name = "serverNameLabel";
			this.serverNameLabel.Size = new System.Drawing.Size(41, 12);
			this.serverNameLabel.TabIndex = 68;
			this.serverNameLabel.Text = "服务器";
			// 
			// productLineLabel1
			// 
			this.productLineLabel1.AutoSize = true;
			this.productLineLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productLineLabel1.Location = new System.Drawing.Point(6, 31);
			this.productLineLabel1.Name = "productLineLabel1";
			this.productLineLabel1.Size = new System.Drawing.Size(41, 12);
			this.productLineLabel1.TabIndex = 67;
			this.productLineLabel1.Text = "产线号";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(282, 297);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 30);
			this.button3.TabIndex = 3;
			this.button3.Text = "导出";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(142, 297);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 30);
			this.button2.TabIndex = 2;
			this.button2.Text = "导入";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(17, 297);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "保存";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(501, 370);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "例外";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.trackBar1);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Location = new System.Drawing.Point(6, 123);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(489, 100);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "信号强度";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(69, 45);
			this.trackBar1.Maximum = 0;
			this.trackBar1.Minimum = -100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(312, 45);
			this.trackBar1.TabIndex = 11;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(11, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "0";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Controls.Add(this.button7);
			this.groupBox3.Location = new System.Drawing.Point(6, 17);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(489, 100);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "开发选项";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.Control;
			this.button6.Location = new System.Drawing.Point(149, 20);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(54, 22);
			this.button6.TabIndex = 2;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(83, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "不复位";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(85, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "脱   机";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.Control;
			this.button4.Location = new System.Drawing.Point(149, 60);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(54, 22);
			this.button4.TabIndex = 6;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button5.Location = new System.Drawing.Point(149, 20);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(148, 22);
			this.button5.TabIndex = 3;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button7.Location = new System.Drawing.Point(149, 60);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(148, 22);
			this.button7.TabIndex = 7;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Checked
			// 
			this.Checked.FillWeight = 63.45177F;
			this.Checked.HeaderText = " 选测";
			this.Checked.MinimumWidth = 25;
			this.Checked.Name = "Checked";
			this.Checked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Checked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Item
			// 
			this.Item.FillWeight = 109.1371F;
			this.Item.HeaderText = "项目";
			this.Item.Name = "Item";
			// 
			// Mini
			// 
			this.Mini.FillWeight = 109.1371F;
			this.Mini.HeaderText = "最小值";
			this.Mini.Name = "Mini";
			// 
			// Max
			// 
			this.Max.FillWeight = 109.1371F;
			this.Max.HeaderText = "最大值";
			this.Max.Name = "Max";
			// 
			// Count
			// 
			this.Count.FillWeight = 109.1371F;
			this.Count.HeaderText = "常量";
			this.Count.Name = "Count";
			// 
			// SettingPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 417);
			this.Controls.Add(this.tabControl1);
			this.MaximumSize = new System.Drawing.Size(554, 456);
			this.MinimumSize = new System.Drawing.Size(554, 456);
			this.Name = "SettingPanel";
			this.Text = "SettingPanel";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label deviceNameLable;
		private System.Windows.Forms.ComboBox bleChipComboBox;
		private System.Windows.Forms.Label bleChipLabel;
		private System.Windows.Forms.ComboBox serverNameComboBox;
		private System.Windows.Forms.Label serverNameLabel;
		private System.Windows.Forms.Label productLineLabel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
		private System.Windows.Forms.DataGridViewTextBoxColumn Item;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mini;
		private System.Windows.Forms.DataGridViewTextBoxColumn Max;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
	}
}