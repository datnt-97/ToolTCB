namespace Transaction_Statistical.UControl
{
    partial class UC_RegisterLicense
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
        private void InitializeComponent2()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Export = new Transaction_Statistical.Mode_Button();
            this.btn_Send = new Transaction_Statistical.Mode_Button();
            this.nup_Day = new System.Windows.Forms.NumericUpDown();
            this.cbb_Date = new Transaction_Statistical.Mode_ComboBox();
            this.mode_GroupBox1 = new Transaction_Statistical.Mode_GroupBox();
            this.txt_Phone = new Transaction_Statistical.Mode_TextBox();
            this.mode_Label4 = new Transaction_Statistical.Mode_Label();
            this.txt_Email = new Transaction_Statistical.Mode_TextBox();
            this.mode_Label3 = new Transaction_Statistical.Mode_Label();
            this.txt_Name = new Transaction_Statistical.Mode_TextBox();
            this.mode_Label2 = new Transaction_Statistical.Mode_Label();
            this.txt_Company = new Transaction_Statistical.Mode_TextBox();
            this.mode_Label1 = new Transaction_Statistical.Mode_Label();
            this.gs_Module = new Transaction_Statistical.Mode_GroupBox();
            this.gs_Type = new Transaction_Statistical.Mode_GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Day)).BeginInit();
            this.mode_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Export.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.btn_Export.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Export.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.btn_Export.Location = new System.Drawing.Point(320, 415);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(117, 29);
            this.btn_Export.TabIndex = 4;
            this.btn_Export.Text = "Export request";
            this.btn_Export.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Export, "If your PC offline");
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Send.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.btn_Send.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Send.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.btn_Send.Location = new System.Drawing.Point(197, 415);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(117, 29);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send request";
            this.btn_Send.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Send, "If your PC connected internet");
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // nup_Day
            // 
            this.nup_Day.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.nup_Day.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.nup_Day.Location = new System.Drawing.Point(367, 193);
            this.nup_Day.Name = "nup_Day";
            this.nup_Day.Size = new System.Drawing.Size(120, 22);
            this.nup_Day.TabIndex = 13;
            this.nup_Day.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // cbb_Date
            // 
            this.cbb_Date.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.cbb_Date.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.cbb_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Date.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.cbb_Date.FormattingEnabled = true;
            this.cbb_Date.Items.AddRange(new object[] {
            "Days",
            "Months",
            "Years"});
            this.cbb_Date.Location = new System.Drawing.Point(493, 191);
            this.cbb_Date.Name = "cbb_Date";
            this.cbb_Date.Size = new System.Drawing.Size(150, 24);
            this.cbb_Date.TabIndex = 5;
            // 
            // mode_GroupBox1
            // 
            this.mode_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.mode_GroupBox1.Controls.Add(this.txt_Phone);
            this.mode_GroupBox1.Controls.Add(this.mode_Label4);
            this.mode_GroupBox1.Controls.Add(this.txt_Email);
            this.mode_GroupBox1.Controls.Add(this.mode_Label3);
            this.mode_GroupBox1.Controls.Add(this.txt_Name);
            this.mode_GroupBox1.Controls.Add(this.mode_Label2);
            this.mode_GroupBox1.Controls.Add(this.txt_Company);
            this.mode_GroupBox1.Controls.Add(this.mode_Label1);
            this.mode_GroupBox1.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.mode_GroupBox1.Location = new System.Drawing.Point(23, 236);
            this.mode_GroupBox1.Name = "mode_GroupBox1";
            this.mode_GroupBox1.Size = new System.Drawing.Size(620, 161);
            this.mode_GroupBox1.TabIndex = 2;
            this.mode_GroupBox1.TabStop = false;
            this.mode_GroupBox1.Text = "Order Info";
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.txt_Phone.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.txt_Phone.Location = new System.Drawing.Point(89, 115);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(512, 22);
            this.txt_Phone.TabIndex = 7;
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone_KeyPress);
            // 
            // mode_Label4
            // 
            this.mode_Label4.AutoSize = true;
            this.mode_Label4.BackColor = System.Drawing.Color.Transparent;
            this.mode_Label4.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.mode_Label4.Location = new System.Drawing.Point(34, 118);
            this.mode_Label4.Name = "mode_Label4";
            this.mode_Label4.Size = new System.Drawing.Size(49, 17);
            this.mode_Label4.TabIndex = 6;
            this.mode_Label4.Text = "Phone";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.txt_Email.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.txt_Email.Location = new System.Drawing.Point(89, 87);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(512, 22);
            this.txt_Email.TabIndex = 5;
            this.txt_Email.Validated += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // mode_Label3
            // 
            this.mode_Label3.AutoSize = true;
            this.mode_Label3.BackColor = System.Drawing.Color.Transparent;
            this.mode_Label3.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.mode_Label3.Location = new System.Drawing.Point(41, 90);
            this.mode_Label3.Name = "mode_Label3";
            this.mode_Label3.Size = new System.Drawing.Size(42, 17);
            this.mode_Label3.TabIndex = 4;
            this.mode_Label3.Text = "Email";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.txt_Name.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.txt_Name.Location = new System.Drawing.Point(89, 59);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(512, 22);
            this.txt_Name.TabIndex = 3;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // mode_Label2
            // 
            this.mode_Label2.AutoSize = true;
            this.mode_Label2.BackColor = System.Drawing.Color.Transparent;
            this.mode_Label2.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.mode_Label2.Location = new System.Drawing.Point(15, 34);
            this.mode_Label2.Name = "mode_Label2";
            this.mode_Label2.Size = new System.Drawing.Size(67, 17);
            this.mode_Label2.TabIndex = 2;
            this.mode_Label2.Text = "Company";
            // 
            // txt_Company
            // 
            this.txt_Company.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.txt_Company.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.txt_Company.Location = new System.Drawing.Point(89, 31);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.Size = new System.Drawing.Size(512, 22);
            this.txt_Company.TabIndex = 1;
            // 
            // mode_Label1
            // 
            this.mode_Label1.AutoSize = true;
            this.mode_Label1.BackColor = System.Drawing.Color.Transparent;
            this.mode_Label1.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.mode_Label1.Location = new System.Drawing.Point(38, 62);
            this.mode_Label1.Name = "mode_Label1";
            this.mode_Label1.Size = new System.Drawing.Size(45, 17);
            this.mode_Label1.TabIndex = 0;
            this.mode_Label1.Text = "Name";
            // 
            // gs_Module
            // 
            this.gs_Module.BackColor = System.Drawing.Color.Transparent;
            this.gs_Module.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.gs_Module.Location = new System.Drawing.Point(23, 98);
            this.gs_Module.Name = "gs_Module";
            this.gs_Module.Size = new System.Drawing.Size(620, 72);
            this.gs_Module.TabIndex = 1;
            this.gs_Module.TabStop = false;
            this.gs_Module.Text = "Modules";
            // 
            // gs_Type
            // 
            this.gs_Type.BackColor = System.Drawing.Color.Transparent;
            this.gs_Type.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.gs_Type.Location = new System.Drawing.Point(23, 12);
            this.gs_Type.Name = "gs_Type";
            this.gs_Type.Size = new System.Drawing.Size(620, 69);
            this.gs_Type.TabIndex = 0;
            this.gs_Type.TabStop = false;
            this.gs_Type.Text = "Types";
            // 
            // UC_RegisterLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_Date);
            this.Controls.Add(this.nup_Day);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.mode_GroupBox1);
            this.Controls.Add(this.gs_Module);
            this.Controls.Add(this.gs_Type);
            this.Name = "UC_RegisterLicense";
            this.Size = new System.Drawing.Size(666, 458);
            ((System.ComponentModel.ISupportInitialize)(this.nup_Day)).EndInit();
            this.mode_GroupBox1.ResumeLayout(false);
            this.mode_GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
      
        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private Mode_GroupBox gs_Type;
        private Mode_GroupBox gs_Module;
        private Mode_GroupBox mode_GroupBox1;
        private Mode_Label mode_Label1;
        private Mode_Button btn_Send;
        private Mode_Button btn_Export;
        private Mode_TextBox txt_Phone;
        private Mode_Label mode_Label4;
        private Mode_TextBox txt_Email;
        private Mode_Label mode_Label3;
        private Mode_TextBox txt_Name;
        private Mode_Label mode_Label2;
        private Mode_TextBox txt_Company;
        private Mode_ComboBox cbb_Date;
        private System.Windows.Forms.NumericUpDown nup_Day;
    }
}
