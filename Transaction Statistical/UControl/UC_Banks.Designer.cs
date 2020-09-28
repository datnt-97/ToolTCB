namespace Transaction_Statistical.UControl
{
	partial class UC_Banks
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
			this.lv_Banks = new Transaction_Statistical.Mode_ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bt_Refresh = new Transaction_Statistical.Mode_Button();
			this.bt_Delete = new Transaction_Statistical.Mode_Button();
			this.mode_GroupBox1 = new Transaction_Statistical.Mode_GroupBox();
			this.bt_UpdateBank = new Transaction_Statistical.Mode_Button();
			this.bt_AddBank = new Transaction_Statistical.Mode_Button();
			this.mode_Label3 = new Transaction_Statistical.Mode_Label();
			this.tb_Address = new Transaction_Statistical.Mode_TextBox();
			this.mode_Label1 = new Transaction_Statistical.Mode_Label();
			this.tb_Name = new Transaction_Statistical.Mode_TextBox();
			this.mode_Label2 = new Transaction_Statistical.Mode_Label();
			this.tb_SubName = new Transaction_Statistical.Mode_TextBox();
			this.mode_GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lv_Banks
			// 
			this.lv_Banks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_Banks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.lv_Banks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lv_Banks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
			this.lv_Banks.ForeColor = System.Drawing.Color.White;
			this.lv_Banks.FullRowSelect = true;
			this.lv_Banks.HideSelection = false;
			this.lv_Banks.Location = new System.Drawing.Point(6, 188);
			this.lv_Banks.MultiSelect = false;
			this.lv_Banks.Name = "lv_Banks";
			this.lv_Banks.ShowItemToolTips = true;
			this.lv_Banks.Size = new System.Drawing.Size(876, 309);
			this.lv_Banks.TabIndex = 16;
			this.lv_Banks.UseCompatibleStateImageBehavior = false;
			this.lv_Banks.View = System.Windows.Forms.View.Details;
			this.lv_Banks.SelectedIndexChanged += new System.EventHandler(this.lv_Banks_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "No.";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Sub Name";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Name";
			this.columnHeader4.Width = 352;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Address";
			this.columnHeader3.Width = 396;
			// 
			// bt_Refresh
			// 
			this.bt_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.bt_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Refresh.ForeColor = System.Drawing.Color.White;
			this.bt_Refresh.Location = new System.Drawing.Point(777, 155);
			this.bt_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_Refresh.Name = "bt_Refresh";
			this.bt_Refresh.Size = new System.Drawing.Size(105, 28);
			this.bt_Refresh.TabIndex = 15;
			this.bt_Refresh.Text = "Refresh";
			this.bt_Refresh.UseVisualStyleBackColor = true;
			this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
			// 
			// bt_Delete
			// 
			this.bt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.bt_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Delete.ForeColor = System.Drawing.Color.White;
			this.bt_Delete.Location = new System.Drawing.Point(666, 155);
			this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_Delete.Name = "bt_Delete";
			this.bt_Delete.Size = new System.Drawing.Size(105, 28);
			this.bt_Delete.TabIndex = 14;
			this.bt_Delete.Text = "Delete";
			this.bt_Delete.UseVisualStyleBackColor = true;
			this.bt_Delete.Visible = false;
			this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
			// 
			// mode_GroupBox1
			// 
			this.mode_GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.mode_GroupBox1.Controls.Add(this.bt_UpdateBank);
			this.mode_GroupBox1.Controls.Add(this.bt_AddBank);
			this.mode_GroupBox1.Controls.Add(this.mode_Label3);
			this.mode_GroupBox1.Controls.Add(this.tb_Address);
			this.mode_GroupBox1.Controls.Add(this.mode_Label1);
			this.mode_GroupBox1.Controls.Add(this.tb_Name);
			this.mode_GroupBox1.Controls.Add(this.mode_Label2);
			this.mode_GroupBox1.Controls.Add(this.tb_SubName);
			this.mode_GroupBox1.ForeColor = System.Drawing.Color.White;
			this.mode_GroupBox1.Location = new System.Drawing.Point(6, 5);
			this.mode_GroupBox1.Name = "mode_GroupBox1";
			this.mode_GroupBox1.Size = new System.Drawing.Size(876, 145);
			this.mode_GroupBox1.TabIndex = 0;
			this.mode_GroupBox1.TabStop = false;
			this.mode_GroupBox1.Text = "Bank Info";
			// 
			// bt_UpdateBank
			// 
			this.bt_UpdateBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_UpdateBank.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.bt_UpdateBank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_UpdateBank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.bt_UpdateBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_UpdateBank.ForeColor = System.Drawing.Color.White;
			this.bt_UpdateBank.Location = new System.Drawing.Point(199, 112);
			this.bt_UpdateBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_UpdateBank.Name = "bt_UpdateBank";
			this.bt_UpdateBank.Size = new System.Drawing.Size(105, 28);
			this.bt_UpdateBank.TabIndex = 13;
			this.bt_UpdateBank.Text = "Update";
			this.bt_UpdateBank.UseVisualStyleBackColor = true;
			this.bt_UpdateBank.Visible = false;
			this.bt_UpdateBank.Click += new System.EventHandler(this.bt_UpdateBank_Click);
			// 
			// bt_AddBank
			// 
			this.bt_AddBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_AddBank.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.bt_AddBank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.bt_AddBank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.bt_AddBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_AddBank.ForeColor = System.Drawing.Color.White;
			this.bt_AddBank.Location = new System.Drawing.Point(88, 112);
			this.bt_AddBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_AddBank.Name = "bt_AddBank";
			this.bt_AddBank.Size = new System.Drawing.Size(105, 28);
			this.bt_AddBank.TabIndex = 12;
			this.bt_AddBank.Text = "Add";
			this.bt_AddBank.UseVisualStyleBackColor = true;
			this.bt_AddBank.Visible = false;
			this.bt_AddBank.Click += new System.EventHandler(this.bt_AddBank_Click);
			// 
			// mode_Label3
			// 
			this.mode_Label3.AutoSize = true;
			this.mode_Label3.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label3.ForeColor = System.Drawing.Color.White;
			this.mode_Label3.Location = new System.Drawing.Point(8, 80);
			this.mode_Label3.Name = "mode_Label3";
			this.mode_Label3.Size = new System.Drawing.Size(60, 17);
			this.mode_Label3.TabIndex = 8;
			this.mode_Label3.Text = "Address";
			// 
			// tb_Address
			// 
			this.tb_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.tb_Address.ForeColor = System.Drawing.Color.White;
			this.tb_Address.Location = new System.Drawing.Point(88, 77);
			this.tb_Address.Name = "tb_Address";
			this.tb_Address.Size = new System.Drawing.Size(596, 22);
			this.tb_Address.TabIndex = 7;
			this.tb_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Detect_KeyPress);
			// 
			// mode_Label1
			// 
			this.mode_Label1.AutoSize = true;
			this.mode_Label1.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label1.ForeColor = System.Drawing.Color.White;
			this.mode_Label1.Location = new System.Drawing.Point(8, 52);
			this.mode_Label1.Name = "mode_Label1";
			this.mode_Label1.Size = new System.Drawing.Size(45, 17);
			this.mode_Label1.TabIndex = 6;
			this.mode_Label1.Text = "Name";
			// 
			// tb_Name
			// 
			this.tb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.tb_Name.ForeColor = System.Drawing.Color.White;
			this.tb_Name.Location = new System.Drawing.Point(88, 49);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(596, 22);
			this.tb_Name.TabIndex = 5;
			this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Detect_KeyPress);
			// 
			// mode_Label2
			// 
			this.mode_Label2.AutoSize = true;
			this.mode_Label2.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label2.ForeColor = System.Drawing.Color.White;
			this.mode_Label2.Location = new System.Drawing.Point(8, 24);
			this.mode_Label2.Name = "mode_Label2";
			this.mode_Label2.Size = new System.Drawing.Size(74, 17);
			this.mode_Label2.TabIndex = 4;
			this.mode_Label2.Text = "Sub Name";
			// 
			// tb_SubName
			// 
			this.tb_SubName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.tb_SubName.ForeColor = System.Drawing.Color.White;
			this.tb_SubName.Location = new System.Drawing.Point(88, 21);
			this.tb_SubName.Name = "tb_SubName";
			this.tb_SubName.Size = new System.Drawing.Size(133, 22);
			this.tb_SubName.TabIndex = 3;
			this.tb_SubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Detect_KeyPress);
			// 
			// UC_Banks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Controls.Add(this.lv_Banks);
			this.Controls.Add(this.bt_Refresh);
			this.Controls.Add(this.bt_Delete);
			this.Controls.Add(this.mode_GroupBox1);
			this.Name = "UC_Banks";
			this.Size = new System.Drawing.Size(896, 504);
			this.mode_GroupBox1.ResumeLayout(false);
			this.mode_GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mode_GroupBox mode_GroupBox1;
		private Mode_Label mode_Label3;
		private Mode_TextBox tb_Address;
		private Mode_Label mode_Label1;
		private Mode_TextBox tb_Name;
		private Mode_Label mode_Label2;
		private Mode_TextBox tb_SubName;
		private Mode_Button bt_Delete;
		private Mode_Button bt_UpdateBank;
		private Mode_Button bt_AddBank;
		private Mode_Button bt_Refresh;
		private Mode_ListView lv_Banks;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}
