namespace Ultrasonic_toothbrush
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
			this.buttonPortName = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.passBtn = new System.Windows.Forms.Button();
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.ledBattery = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.导入MAC地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.导出MAC地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.testListDataGridView = new System.Windows.Forms.DataGridView();
			this.MAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.testItemDataGridView = new System.Windows.Forms.DataGridView();
			this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TestResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leftRightSplitContainer = new System.Windows.Forms.SplitContainer();
			this.testListtabControl = new System.Windows.Forms.TabControl();
			this.testListTabPage = new System.Windows.Forms.TabPage();
			this.aboveBelowSplitContainer = new System.Windows.Forms.SplitContainer();
			this.testItmeTabControl = new System.Windows.Forms.TabControl();
			this.testItemTabPage = new System.Windows.Forms.TabPage();
			this.outputTabControl = new System.Windows.Forms.TabControl();
			this.outputTabPage = new System.Windows.Forms.TabPage();
			this.settingPanel = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.testListDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.testItemDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leftRightSplitContainer)).BeginInit();
			this.leftRightSplitContainer.Panel1.SuspendLayout();
			this.leftRightSplitContainer.Panel2.SuspendLayout();
			this.leftRightSplitContainer.SuspendLayout();
			this.testListtabControl.SuspendLayout();
			this.testListTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aboveBelowSplitContainer)).BeginInit();
			this.aboveBelowSplitContainer.Panel1.SuspendLayout();
			this.aboveBelowSplitContainer.Panel2.SuspendLayout();
			this.aboveBelowSplitContainer.SuspendLayout();
			this.testItmeTabControl.SuspendLayout();
			this.testItemTabPage.SuspendLayout();
			this.outputTabControl.SuspendLayout();
			this.outputTabPage.SuspendLayout();
			this.settingPanel.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonPortName
			// 
			this.buttonPortName.Location = new System.Drawing.Point(21, 17);
			this.buttonPortName.Name = "buttonPortName";
			this.buttonPortName.Size = new System.Drawing.Size(212, 48);
			this.buttonPortName.TabIndex = 3;
			this.buttonPortName.Text = "无串口";
			this.buttonPortName.UseVisualStyleBackColor = true;
			this.buttonPortName.Click += new System.EventHandler(this.buttonPortName_Click);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(369, 17);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(225, 48);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "开始";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// passBtn
			// 
			this.passBtn.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.passBtn.Location = new System.Drawing.Point(715, 17);
			this.passBtn.Name = "passBtn";
			this.passBtn.Size = new System.Drawing.Size(225, 48);
			this.passBtn.TabIndex = 14;
			this.passBtn.Text = "测试结果";
			this.passBtn.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(4, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
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
			this.logBox.Location = new System.Drawing.Point(0, 0);
			this.logBox.Multiline = true;
			this.logBox.Name = "logBox";
			this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.logBox.Size = new System.Drawing.Size(346, 71);
			this.logBox.TabIndex = 1;
			this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
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
			this.radioButton6.Checked = true;
			this.radioButton6.Location = new System.Drawing.Point(1228, 702);
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
			this.panel1.Location = new System.Drawing.Point(11, 77);
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
			// ledBattery
			// 
			this.ledBattery.AutoSize = true;
			this.ledBattery.BackColor = System.Drawing.SystemColors.Control;
			this.ledBattery.Location = new System.Drawing.Point(265, 97);
			this.ledBattery.Name = "ledBattery";
			this.ledBattery.Size = new System.Drawing.Size(41, 12);
			this.ledBattery.TabIndex = 13;
			this.ledBattery.Text = "label2";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 693);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1109, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(509, 17);
			this.toolStripStatusLabel1.Text = "配置信息----服务器：|MAC:000000-FFFFF| 串口:com4|产线号:1|设备名称:xxxxx|信号强度范围";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.ledBattery);
			this.panel3.Controls.Add(this.button12);
			this.panel3.Controls.Add(this.panel1);
			this.panel3.Controls.Add(this.button7);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.button11);
			this.panel3.Controls.Add(this.button10);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.button9);
			this.panel3.Controls.Add(this.button3);
			this.panel3.Controls.Add(this.button8);
			this.panel3.Controls.Add(this.button4);
			this.panel3.Controls.Add(this.button5);
			this.panel3.Controls.Add(this.button6);
			this.panel3.Location = new System.Drawing.Point(554, 535);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(500, 135);
			this.panel3.TabIndex = 17;
			this.panel3.Visible = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.设置ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1109, 25);
			this.menuStrip1.TabIndex = 23;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 打开ToolStripMenuItem
			// 
			this.打开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入MAC地址ToolStripMenuItem,
            this.导出MAC地址ToolStripMenuItem});
			this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
			this.打开ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.打开ToolStripMenuItem.Text = "打开";
			// 
			// 导入MAC地址ToolStripMenuItem
			// 
			this.导入MAC地址ToolStripMenuItem.Name = "导入MAC地址ToolStripMenuItem";
			this.导入MAC地址ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.导入MAC地址ToolStripMenuItem.Text = "导入MAC清单";
			// 
			// 导出MAC地址ToolStripMenuItem
			// 
			this.导出MAC地址ToolStripMenuItem.Name = "导出MAC地址ToolStripMenuItem";
			this.导出MAC地址ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.导出MAC地址ToolStripMenuItem.Text = "导出MAC清单";
			// 
			// 设置ToolStripMenuItem
			// 
			this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置ToolStripMenuItem});
			this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
			this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.设置ToolStripMenuItem.Text = "设置";
			// 
			// 配置ToolStripMenuItem
			// 
			this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
			this.配置ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.配置ToolStripMenuItem.Text = "配置";
			this.配置ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// testListDataGridView
			// 
			this.testListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.testListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.testListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.testListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAC,
            this.NAME});
			this.testListDataGridView.Location = new System.Drawing.Point(0, 0);
			this.testListDataGridView.Name = "testListDataGridView";
			this.testListDataGridView.RowTemplate.Height = 23;
			this.testListDataGridView.Size = new System.Drawing.Size(241, 124);
			this.testListDataGridView.TabIndex = 24;
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
			// testItemDataGridView
			// 
			this.testItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.testItemDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.testItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.testItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Range,
            this.Current,
            this.TestResult});
			this.testItemDataGridView.Location = new System.Drawing.Point(0, 3);
			this.testItemDataGridView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.testItemDataGridView.Name = "testItemDataGridView";
			this.testItemDataGridView.RowTemplate.Height = 23;
			this.testItemDataGridView.Size = new System.Drawing.Size(468, 85);
			this.testItemDataGridView.TabIndex = 25;
			this.testItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			// 
			// Item
			// 
			this.Item.HeaderText = "项目";
			this.Item.Name = "Item";
			// 
			// Range
			// 
			this.Range.HeaderText = "范围";
			this.Range.Name = "Range";
			// 
			// Current
			// 
			this.Current.HeaderText = "当前值";
			this.Current.Name = "Current";
			// 
			// TestResult
			// 
			this.TestResult.HeaderText = "状态";
			this.TestResult.Name = "TestResult";
			// 
			// leftRightSplitContainer
			// 
			this.leftRightSplitContainer.Location = new System.Drawing.Point(0, 203);
			this.leftRightSplitContainer.Name = "leftRightSplitContainer";
			// 
			// leftRightSplitContainer.Panel1
			// 
			this.leftRightSplitContainer.Panel1.Controls.Add(this.testListtabControl);
			this.leftRightSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.leftRightSplitContainer_Panel1_Paint);
			// 
			// leftRightSplitContainer.Panel2
			// 
			this.leftRightSplitContainer.Panel2.Controls.Add(this.aboveBelowSplitContainer);
			this.leftRightSplitContainer.Size = new System.Drawing.Size(1109, 311);
			this.leftRightSplitContainer.SplitterDistance = 357;
			this.leftRightSplitContainer.TabIndex = 26;
			// 
			// testListtabControl
			// 
			this.testListtabControl.Controls.Add(this.testListTabPage);
			this.testListtabControl.Location = new System.Drawing.Point(3, 3);
			this.testListtabControl.Name = "testListtabControl";
			this.testListtabControl.SelectedIndex = 0;
			this.testListtabControl.Size = new System.Drawing.Size(326, 186);
			this.testListtabControl.TabIndex = 25;
			// 
			// testListTabPage
			// 
			this.testListTabPage.Controls.Add(this.testListDataGridView);
			this.testListTabPage.Location = new System.Drawing.Point(4, 22);
			this.testListTabPage.Name = "testListTabPage";
			this.testListTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.testListTabPage.Size = new System.Drawing.Size(318, 160);
			this.testListTabPage.TabIndex = 0;
			this.testListTabPage.Text = "测试列表";
			this.testListTabPage.UseVisualStyleBackColor = true;
			// 
			// aboveBelowSplitContainer
			// 
			this.aboveBelowSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.aboveBelowSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.aboveBelowSplitContainer.Name = "aboveBelowSplitContainer";
			this.aboveBelowSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// aboveBelowSplitContainer.Panel1
			// 
			this.aboveBelowSplitContainer.Panel1.Controls.Add(this.testItmeTabControl);
			this.aboveBelowSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.aboveBelowSplitContainer_Panel1_Paint);
			// 
			// aboveBelowSplitContainer.Panel2
			// 
			this.aboveBelowSplitContainer.Panel2.Controls.Add(this.outputTabControl);
			this.aboveBelowSplitContainer.Size = new System.Drawing.Size(748, 311);
			this.aboveBelowSplitContainer.SplitterDistance = 173;
			this.aboveBelowSplitContainer.TabIndex = 0;
			// 
			// testItmeTabControl
			// 
			this.testItmeTabControl.Controls.Add(this.testItemTabPage);
			this.testItmeTabControl.Location = new System.Drawing.Point(3, 3);
			this.testItmeTabControl.Name = "testItmeTabControl";
			this.testItmeTabControl.SelectedIndex = 0;
			this.testItmeTabControl.Size = new System.Drawing.Size(690, 146);
			this.testItmeTabControl.TabIndex = 26;
			// 
			// testItemTabPage
			// 
			this.testItemTabPage.Controls.Add(this.testItemDataGridView);
			this.testItemTabPage.Location = new System.Drawing.Point(4, 22);
			this.testItemTabPage.Name = "testItemTabPage";
			this.testItemTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.testItemTabPage.Size = new System.Drawing.Size(682, 120);
			this.testItemTabPage.TabIndex = 0;
			this.testItemTabPage.Text = "测试项";
			this.testItemTabPage.UseVisualStyleBackColor = true;
			// 
			// outputTabControl
			// 
			this.outputTabControl.Controls.Add(this.outputTabPage);
			this.outputTabControl.Location = new System.Drawing.Point(3, 3);
			this.outputTabControl.Name = "outputTabControl";
			this.outputTabControl.SelectedIndex = 0;
			this.outputTabControl.Size = new System.Drawing.Size(593, 118);
			this.outputTabControl.TabIndex = 27;
			// 
			// outputTabPage
			// 
			this.outputTabPage.Controls.Add(this.logBox);
			this.outputTabPage.Location = new System.Drawing.Point(4, 22);
			this.outputTabPage.Name = "outputTabPage";
			this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.outputTabPage.Size = new System.Drawing.Size(585, 92);
			this.outputTabPage.TabIndex = 0;
			this.outputTabPage.Text = "输出";
			this.outputTabPage.UseVisualStyleBackColor = true;
			// 
			// settingPanel
			// 
			this.settingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.settingPanel.Controls.Add(this.panel4);
			this.settingPanel.Controls.Add(this.passBtn);
			this.settingPanel.Controls.Add(this.startButton);
			this.settingPanel.Controls.Add(this.buttonPortName);
			this.settingPanel.Location = new System.Drawing.Point(0, 28);
			this.settingPanel.Name = "settingPanel";
			this.settingPanel.Size = new System.Drawing.Size(1109, 169);
			this.settingPanel.TabIndex = 27;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.trackBar1);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Location = new System.Drawing.Point(21, 82);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(919, 68);
			this.panel4.TabIndex = 23;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(32, 17);
			this.trackBar1.Maximum = 0;
			this.trackBar1.Minimum = -100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(837, 45);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1109, 715);
			this.Controls.Add(this.settingPanel);
			this.Controls.Add(this.leftRightSplitContainer);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.radioButton6);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(1125, 754);
			this.Name = "MainForm";
			this.Text = "Ultrasonic toothbrush";
			this.MaximumSizeChanged += new System.EventHandler(this.MainForm_MaximumSizeChanged);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.testListDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.testItemDataGridView)).EndInit();
			this.leftRightSplitContainer.Panel1.ResumeLayout(false);
			this.leftRightSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.leftRightSplitContainer)).EndInit();
			this.leftRightSplitContainer.ResumeLayout(false);
			this.testListtabControl.ResumeLayout(false);
			this.testListTabPage.ResumeLayout(false);
			this.aboveBelowSplitContainer.Panel1.ResumeLayout(false);
			this.aboveBelowSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.aboveBelowSplitContainer)).EndInit();
			this.aboveBelowSplitContainer.ResumeLayout(false);
			this.testItmeTabControl.ResumeLayout(false);
			this.testItemTabPage.ResumeLayout(false);
			this.outputTabControl.ResumeLayout(false);
			this.outputTabPage.ResumeLayout(false);
			this.outputTabPage.PerformLayout();
			this.settingPanel.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button buttonPortName;
		private System.Windows.Forms.TextBox logBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label ledBattery;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button passBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
		private System.Windows.Forms.DataGridView testListDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn MAC;
		private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
		private System.Windows.Forms.ToolStripMenuItem 导入MAC地址ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 导出MAC地址ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
		private System.Windows.Forms.DataGridView testItemDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Item;
		private System.Windows.Forms.DataGridViewTextBoxColumn Range;
		private System.Windows.Forms.DataGridViewTextBoxColumn Current;
		private System.Windows.Forms.DataGridViewTextBoxColumn TestResult;
		private System.Windows.Forms.SplitContainer leftRightSplitContainer;
		private System.Windows.Forms.SplitContainer aboveBelowSplitContainer;
		private System.Windows.Forms.TabControl testListtabControl;
		private System.Windows.Forms.TabPage testListTabPage;
		private System.Windows.Forms.TabControl testItmeTabControl;
		private System.Windows.Forms.TabPage testItemTabPage;
		private System.Windows.Forms.TabControl outputTabControl;
		private System.Windows.Forms.TabPage outputTabPage;
		private System.Windows.Forms.Panel settingPanel;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
	}
}

