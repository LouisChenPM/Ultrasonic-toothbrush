namespace Ultrasonic_toothbrush.Setting
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
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TestResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.deviceNameComboBox = new System.Windows.Forms.ComboBox();
			this.deviceNameLable = new System.Windows.Forms.Label();
			this.loadSettingButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.serverNameComboBox = new System.Windows.Forms.ComboBox();
			this.serverNameLabel = new System.Windows.Forms.Label();
			this.productionLineComboBox = new System.Windows.Forms.ComboBox();
			this.productLineLabel1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Range,
            this.Current,
            this.TestResult});
			this.dataGridView2.Location = new System.Drawing.Point(6, 157);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.Size = new System.Drawing.Size(678, 183);
			this.dataGridView2.TabIndex = 26;
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
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.deviceNameComboBox);
			this.panel1.Controls.Add(this.deviceNameLable);
			this.panel1.Controls.Add(this.serverNameComboBox);
			this.panel1.Controls.Add(this.serverNameLabel);
			this.panel1.Controls.Add(this.productionLineComboBox);
			this.panel1.Controls.Add(this.productLineLabel1);
			this.panel1.Location = new System.Drawing.Point(9, 17);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(675, 117);
			this.panel1.TabIndex = 27;
			// 
			// deviceNameComboBox
			// 
			this.deviceNameComboBox.CausesValidation = false;
			this.deviceNameComboBox.FormattingEnabled = true;
			this.deviceNameComboBox.Location = new System.Drawing.Point(521, 11);
			this.deviceNameComboBox.Name = "deviceNameComboBox";
			this.deviceNameComboBox.Size = new System.Drawing.Size(121, 20);
			this.deviceNameComboBox.TabIndex = 56;
			// 
			// deviceNameLable
			// 
			this.deviceNameLable.AutoSize = true;
			this.deviceNameLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deviceNameLable.Location = new System.Drawing.Point(445, 14);
			this.deviceNameLable.Name = "deviceNameLable";
			this.deviceNameLable.Size = new System.Drawing.Size(53, 12);
			this.deviceNameLable.TabIndex = 55;
			this.deviceNameLable.Text = "设备名称";
			// 
			// loadSettingButton
			// 
			this.loadSettingButton.Location = new System.Drawing.Point(204, 17);
			this.loadSettingButton.Name = "loadSettingButton";
			this.loadSettingButton.Size = new System.Drawing.Size(145, 27);
			this.loadSettingButton.TabIndex = 39;
			this.loadSettingButton.Text = "加载";
			this.loadSettingButton.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(11, 17);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(145, 27);
			this.saveButton.TabIndex = 38;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
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
			this.serverNameComboBox.Location = new System.Drawing.Point(297, 11);
			this.serverNameComboBox.Name = "serverNameComboBox";
			this.serverNameComboBox.Size = new System.Drawing.Size(121, 20);
			this.serverNameComboBox.TabIndex = 37;
			this.serverNameComboBox.Text = "localhost";
			// 
			// serverNameLabel
			// 
			this.serverNameLabel.AutoSize = true;
			this.serverNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.serverNameLabel.Location = new System.Drawing.Point(226, 14);
			this.serverNameLabel.Name = "serverNameLabel";
			this.serverNameLabel.Size = new System.Drawing.Size(65, 12);
			this.serverNameLabel.TabIndex = 36;
			this.serverNameLabel.Text = "服务器名称";
			// 
			// productionLineComboBox
			// 
			this.productionLineComboBox.CausesValidation = false;
			this.productionLineComboBox.FormattingEnabled = true;
			this.productionLineComboBox.Location = new System.Drawing.Point(79, 14);
			this.productionLineComboBox.Name = "productionLineComboBox";
			this.productionLineComboBox.Size = new System.Drawing.Size(121, 20);
			this.productionLineComboBox.TabIndex = 17;
			// 
			// productLineLabel1
			// 
			this.productLineLabel1.AutoSize = true;
			this.productLineLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productLineLabel1.Location = new System.Drawing.Point(3, 17);
			this.productLineLabel1.Name = "productLineLabel1";
			this.productLineLabel1.Size = new System.Drawing.Size(41, 12);
			this.productLineLabel1.TabIndex = 16;
			this.productLineLabel1.Text = "产线号";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(388, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 27);
			this.button1.TabIndex = 40;
			this.button1.Text = "导出";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(734, 389);
			this.tabControl1.TabIndex = 41;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.dataGridView2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(726, 363);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "参数";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(192, 74);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "例外";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.loadSettingButton);
			this.panel2.Controls.Add(this.saveButton);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(16, 419);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(675, 60);
			this.panel2.TabIndex = 42;
			// 
			// SettingPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 509);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.tabControl1);
			this.Name = "SettingPanel";
			this.Text = "SettingPanel";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Item;
		private System.Windows.Forms.DataGridViewTextBoxColumn Range;
		private System.Windows.Forms.DataGridViewTextBoxColumn Current;
		private System.Windows.Forms.DataGridViewTextBoxColumn TestResult;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox deviceNameComboBox;
		private System.Windows.Forms.Label deviceNameLable;
		private System.Windows.Forms.ComboBox serverNameComboBox;
		private System.Windows.Forms.Label serverNameLabel;
		private System.Windows.Forms.ComboBox productionLineComboBox;
		private System.Windows.Forms.Label productLineLabel1;
		private System.Windows.Forms.Button loadSettingButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel2;
	}
}