namespace Transaction_Statistical.UControl
{
	partial class UC_Terminals
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bt_Delete = new Transaction_Statistical.Mode_Button();
			this.lv_Terminal = new Transaction_Statistical.Mode_ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mode_Button2 = new Transaction_Statistical.Mode_Button();
			this.mode_GroupBox1 = new Transaction_Statistical.Mode_GroupBox();
			this.cb_Bank = new Transaction_Statistical.Mode_ComboBox();
			this.mode_Label8 = new Transaction_Statistical.Mode_Label();
			this.cb_Branch = new Transaction_Statistical.Mode_ComboBox();
			this.mode_Label7 = new Transaction_Statistical.Mode_Label();
			this.cb_Area = new Transaction_Statistical.Mode_ComboBox();
			this.cb_Model = new Transaction_Statistical.Mode_ComboBox();
			this.mode_Label6 = new Transaction_Statistical.Mode_Label();
			this.cb_Province = new Transaction_Statistical.Mode_ComboBox();
			this.mode_Label4 = new Transaction_Statistical.Mode_Label();
			this.mode_Label1 = new Transaction_Statistical.Mode_Label();
			this.mode_Label2 = new Transaction_Statistical.Mode_Label();
			this.tb_SubName = new Transaction_Statistical.Mode_TextBox();
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bt_Import = new Transaction_Statistical.Mode_Button();
			this.mode_GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bt_Delete
			// 
			this.bt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.bt_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Delete.ForeColor = System.Drawing.Color.White;
			this.bt_Delete.Location = new System.Drawing.Point(788, 122);
			this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_Delete.Name = "bt_Delete";
			this.bt_Delete.Size = new System.Drawing.Size(105, 28);
			this.bt_Delete.TabIndex = 19;
			this.bt_Delete.Text = "Delete";
			this.bt_Delete.UseVisualStyleBackColor = true;
			this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
			// 
			// lv_Terminal
			// 
			this.lv_Terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_Terminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.lv_Terminal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lv_Terminal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.lv_Terminal.ForeColor = System.Drawing.Color.White;
			this.lv_Terminal.FullRowSelect = true;
			this.lv_Terminal.HideSelection = false;
			this.lv_Terminal.Location = new System.Drawing.Point(3, 154);
			this.lv_Terminal.Name = "lv_Terminal";
			this.lv_Terminal.ShowItemToolTips = true;
			this.lv_Terminal.Size = new System.Drawing.Size(890, 347);
			this.lv_Terminal.TabIndex = 17;
			this.lv_Terminal.UseCompatibleStateImageBehavior = false;
			this.lv_Terminal.View = System.Windows.Forms.View.Details;
			this.lv_Terminal.DoubleClick += new System.EventHandler(this.lv_Terminal_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "No.";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "TerminalID";
			this.columnHeader2.Width = 85;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Bank";
			this.columnHeader3.Width = 71;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Branch";
			this.columnHeader4.Width = 132;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Address";
			this.columnHeader5.Width = 267;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Model";
			this.columnHeader6.Width = 169;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "DateInit";
			this.columnHeader7.Width = 122;
			// 
			// mode_Button2
			// 
			this.mode_Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.mode_Button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.mode_Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.mode_Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.mode_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mode_Button2.ForeColor = System.Drawing.Color.White;
			this.mode_Button2.Location = new System.Drawing.Point(677, 122);
			this.mode_Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mode_Button2.Name = "mode_Button2";
			this.mode_Button2.Size = new System.Drawing.Size(105, 28);
			this.mode_Button2.TabIndex = 18;
			this.mode_Button2.Text = "New";
			this.mode_Button2.UseVisualStyleBackColor = true;
			this.mode_Button2.Click += new System.EventHandler(this.mode_Button2_Click);
			// 
			// mode_GroupBox1
			// 
			this.mode_GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.mode_GroupBox1.Controls.Add(this.cb_Bank);
			this.mode_GroupBox1.Controls.Add(this.mode_Label8);
			this.mode_GroupBox1.Controls.Add(this.cb_Branch);
			this.mode_GroupBox1.Controls.Add(this.mode_Label7);
			this.mode_GroupBox1.Controls.Add(this.cb_Area);
			this.mode_GroupBox1.Controls.Add(this.cb_Model);
			this.mode_GroupBox1.Controls.Add(this.mode_Label6);
			this.mode_GroupBox1.Controls.Add(this.cb_Province);
			this.mode_GroupBox1.Controls.Add(this.mode_Label4);
			this.mode_GroupBox1.Controls.Add(this.mode_Label1);
			this.mode_GroupBox1.Controls.Add(this.mode_Label2);
			this.mode_GroupBox1.Controls.Add(this.tb_SubName);
			this.mode_GroupBox1.ForeColor = System.Drawing.Color.White;
			this.mode_GroupBox1.Location = new System.Drawing.Point(12, 3);
			this.mode_GroupBox1.Name = "mode_GroupBox1";
			this.mode_GroupBox1.Size = new System.Drawing.Size(881, 114);
			this.mode_GroupBox1.TabIndex = 1;
			this.mode_GroupBox1.TabStop = false;
			this.mode_GroupBox1.Text = "Filter";
			// 
			// cb_Bank
			// 
			this.cb_Bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_Bank.BorderColor = System.Drawing.Color.Blue;
			this.cb_Bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Bank.ForeColor = System.Drawing.Color.White;
			this.cb_Bank.FormattingEnabled = true;
			this.cb_Bank.Location = new System.Drawing.Point(101, 79);
			this.cb_Bank.Name = "cb_Bank";
			this.cb_Bank.Size = new System.Drawing.Size(259, 24);
			this.cb_Bank.TabIndex = 25;
			this.cb_Bank.TextChanged += new System.EventHandler(this.Control_TextChanged);
			// 
			// mode_Label8
			// 
			this.mode_Label8.AutoSize = true;
			this.mode_Label8.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label8.ForeColor = System.Drawing.Color.White;
			this.mode_Label8.Location = new System.Drawing.Point(8, 82);
			this.mode_Label8.Name = "mode_Label8";
			this.mode_Label8.Size = new System.Drawing.Size(40, 17);
			this.mode_Label8.TabIndex = 24;
			this.mode_Label8.Text = "Bank";
			// 
			// cb_Branch
			// 
			this.cb_Branch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_Branch.BorderColor = System.Drawing.Color.Blue;
			this.cb_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Branch.ForeColor = System.Drawing.Color.White;
			this.cb_Branch.FormattingEnabled = true;
			this.cb_Branch.Location = new System.Drawing.Point(613, 79);
			this.cb_Branch.Name = "cb_Branch";
			this.cb_Branch.Size = new System.Drawing.Size(259, 24);
			this.cb_Branch.TabIndex = 23;
			this.cb_Branch.TextChanged += new System.EventHandler(this.Control_TextChanged);
			// 
			// mode_Label7
			// 
			this.mode_Label7.AutoSize = true;
			this.mode_Label7.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label7.ForeColor = System.Drawing.Color.White;
			this.mode_Label7.Location = new System.Drawing.Point(512, 82);
			this.mode_Label7.Name = "mode_Label7";
			this.mode_Label7.Size = new System.Drawing.Size(95, 17);
			this.mode_Label7.TabIndex = 22;
			this.mode_Label7.Text = "NPS\'s Branch";
			// 
			// cb_Area
			// 
			this.cb_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_Area.BorderColor = System.Drawing.Color.Blue;
			this.cb_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Area.ForeColor = System.Drawing.Color.White;
			this.cb_Area.FormattingEnabled = true;
			this.cb_Area.Location = new System.Drawing.Point(101, 49);
			this.cb_Area.Name = "cb_Area";
			this.cb_Area.Size = new System.Drawing.Size(394, 24);
			this.cb_Area.TabIndex = 21;
			this.cb_Area.TextChanged += new System.EventHandler(this.Control_TextChanged);
			// 
			// cb_Model
			// 
			this.cb_Model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_Model.BorderColor = System.Drawing.Color.Blue;
			this.cb_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Model.ForeColor = System.Drawing.Color.White;
			this.cb_Model.FormattingEnabled = true;
			this.cb_Model.Location = new System.Drawing.Point(613, 19);
			this.cb_Model.Name = "cb_Model";
			this.cb_Model.Size = new System.Drawing.Size(259, 24);
			this.cb_Model.TabIndex = 20;
			this.cb_Model.TextChanged += new System.EventHandler(this.Control_TextChanged);
			// 
			// mode_Label6
			// 
			this.mode_Label6.AutoSize = true;
			this.mode_Label6.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label6.ForeColor = System.Drawing.Color.White;
			this.mode_Label6.Location = new System.Drawing.Point(561, 22);
			this.mode_Label6.Name = "mode_Label6";
			this.mode_Label6.Size = new System.Drawing.Size(46, 17);
			this.mode_Label6.TabIndex = 19;
			this.mode_Label6.Text = "Model";
			// 
			// cb_Province
			// 
			this.cb_Province.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_Province.BorderColor = System.Drawing.Color.Blue;
			this.cb_Province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Province.ForeColor = System.Drawing.Color.White;
			this.cb_Province.FormattingEnabled = true;
			this.cb_Province.Location = new System.Drawing.Point(613, 49);
			this.cb_Province.Name = "cb_Province";
			this.cb_Province.Size = new System.Drawing.Size(259, 24);
			this.cb_Province.TabIndex = 15;
			this.cb_Province.TextChanged += new System.EventHandler(this.Control_TextChanged);
			// 
			// mode_Label4
			// 
			this.mode_Label4.AutoSize = true;
			this.mode_Label4.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label4.ForeColor = System.Drawing.Color.White;
			this.mode_Label4.Location = new System.Drawing.Point(544, 52);
			this.mode_Label4.Name = "mode_Label4";
			this.mode_Label4.Size = new System.Drawing.Size(63, 17);
			this.mode_Label4.TabIndex = 9;
			this.mode_Label4.Text = "Province";
			// 
			// mode_Label1
			// 
			this.mode_Label1.AutoSize = true;
			this.mode_Label1.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label1.ForeColor = System.Drawing.Color.White;
			this.mode_Label1.Location = new System.Drawing.Point(8, 52);
			this.mode_Label1.Name = "mode_Label1";
			this.mode_Label1.Size = new System.Drawing.Size(87, 17);
			this.mode_Label1.TabIndex = 6;
			this.mode_Label1.Text = "Area service";
			// 
			// mode_Label2
			// 
			this.mode_Label2.AutoSize = true;
			this.mode_Label2.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label2.ForeColor = System.Drawing.Color.White;
			this.mode_Label2.Location = new System.Drawing.Point(8, 24);
			this.mode_Label2.Name = "mode_Label2";
			this.mode_Label2.Size = new System.Drawing.Size(66, 17);
			this.mode_Label2.TabIndex = 4;
			this.mode_Label2.Text = "Text filter";
			// 
			// tb_SubName
			// 
			this.tb_SubName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.tb_SubName.ForeColor = System.Drawing.Color.White;
			this.tb_SubName.Location = new System.Drawing.Point(101, 21);
			this.tb_SubName.Name = "tb_SubName";
			this.tb_SubName.Size = new System.Drawing.Size(394, 22);
			this.tb_SubName.TabIndex = 3;
			this.tb_SubName.TextChanged += new System.EventHandler(this.Control_TextChanged);
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Area";
			this.columnHeader8.Width = 250;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Province";
			this.columnHeader9.Width = 200;
			// 
			// bt_Import
			// 
			this.bt_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_Import.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.bt_Import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_Import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.bt_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Import.ForeColor = System.Drawing.Color.White;
			this.bt_Import.Location = new System.Drawing.Point(12, 122);
			this.bt_Import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_Import.Name = "bt_Import";
			this.bt_Import.Size = new System.Drawing.Size(125, 28);
			this.bt_Import.TabIndex = 34;
			this.bt_Import.Text = "Import from excel";
			this.bt_Import.UseVisualStyleBackColor = true;
			this.bt_Import.Click += new System.EventHandler(this.bt_Import_Click);
			// 
			// UC_Terminals
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Controls.Add(this.bt_Import);
			this.Controls.Add(this.bt_Delete);
			this.Controls.Add(this.lv_Terminal);
			this.Controls.Add(this.mode_Button2);
			this.Controls.Add(this.mode_GroupBox1);
			this.Name = "UC_Terminals";
			this.Size = new System.Drawing.Size(896, 504);
			this.mode_GroupBox1.ResumeLayout(false);
			this.mode_GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mode_GroupBox mode_GroupBox1;
		private Mode_ComboBox cb_Province;
		private Mode_Label mode_Label4;
		private Mode_Label mode_Label1;
		private Mode_Label mode_Label2;
		private Mode_TextBox tb_SubName;
		private Mode_ComboBox cb_Bank;
		private Mode_Label mode_Label8;
		private Mode_ComboBox cb_Branch;
		private Mode_Label mode_Label7;
		private Mode_ComboBox cb_Area;
		private Mode_ComboBox cb_Model;
		private Mode_Label mode_Label6;
		private Mode_ListView lv_Terminal;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private Mode_Button bt_Delete;
		private Mode_Button mode_Button2;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private Mode_Button bt_Import;
	}
}
