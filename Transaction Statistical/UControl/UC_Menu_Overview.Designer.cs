namespace Transaction_Statistical.UControl
{
    partial class UC_Menu_Overview
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
            this.label1 = new Mode_Label();
            this.btn_Edit = new Mode_Button();
            this.cbo_LstTemplate = new Mode_ComboBox();
            this.btn_Apply = new Mode_Button();
            this.btn_New = new Mode_Button();
            this.bt_Delete = new Mode_Button();
            this.btn_CreateLicensing = new Mode_Button();
            this.btn_CreateUSBKey = new Mode_Button();
            this.btn_LogAdmin = new AddOn.MinMaxButton();
            this.gr_Style = new Mode_GroupBox();
            this.gr_Admin = new Mode_GroupBox();
            this.flp_Style = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_Admin = new System.Windows.Forms.FlowLayoutPanel();
            this.gr_Style.SuspendLayout();
            this.gr_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Template";
            // 
            // btn_Edit
            // 
            this.btn_Edit.AutoSize = true;
           this.btn_Edit.BackColor= InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.btn_Edit.Location = new System.Drawing.Point(436, 5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(105, 31);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // cbo_LstTemplate
            // 
            this.cbo_LstTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LstTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_LstTemplate.BackColor= InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.cbo_LstTemplate.FormattingEnabled = true;
            this.cbo_LstTemplate.Location = new System.Drawing.Point(76, 9);
            this.cbo_LstTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_LstTemplate.Name = "cbo_LstTemplate";
            this.cbo_LstTemplate.Size = new System.Drawing.Size(217, 24);
            this.cbo_LstTemplate.TabIndex = 16;
            // 
            // btn_Apply
            // 
            this.btn_Apply.AutoSize = false;
            this.btn_Apply.BackColor= InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.btn_Apply.Location = new System.Drawing.Point(658, 5);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(105, 31);
            this.btn_Apply.TabIndex = 17;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            
            // 
            // btn_New
            // 
            this.btn_New.AutoSize = true;
            this.btn_New.BackColor= InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.btn_New.Location = new System.Drawing.Point(325, 5);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(105, 31);
            this.btn_New.TabIndex = 18;
            this.btn_New.Text = "New";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.AutoSize = true;    
            this.bt_Delete.BackColor= InitGUI.Custom.Menu_RightBckgd.DisplayColor; 
            this.bt_Delete.Location = new System.Drawing.Point(547, 5);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(105, 31);
            this.bt_Delete.TabIndex = 19;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            //
            // rd_Mode_Dark
            //
            rd_Mode_Dark = new Mode_RadioButton();
            rd_Mode_Dark.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            rd_Mode_Dark.Text = InitGUI_Mode.Dark.ToString();
            flp_Style.Controls.Add(rd_Mode_Dark);
            //
            // rd_Mode_Ligh
            //
            rd_Mode_Ligh = new Mode_RadioButton();
            rd_Mode_Ligh.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            rd_Mode_Ligh.Text = InitGUI_Mode.Light.ToString();
            flp_Style.Controls.Add(rd_Mode_Ligh);
            //
            // rd_Mode_Custom
            //
            rd_Mode_Custom = new Mode_RadioButton();
            rd_Mode_Custom.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            rd_Mode_Custom.Text = InitGUI_Mode.Custom.ToString();
            flp_Style.Controls.Add(rd_Mode_Custom);
            //
            //bt_Custom
            //
            bt_Custom = new Mode_Button();
            bt_Custom.Text = "Setting";
            this.bt_Custom.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
           this.bt_Custom.Click += new System.EventHandler(btn_Edit_Custom_Click);
            flp_Style.Controls.Add(bt_Custom);
            // 
            // gr_Style
            // 
            this.gr_Style.BackColor = System.Drawing.Color.Transparent;
            this.gr_Style.Controls.Add(this.flp_Style);
            this.gr_Style.Location = new System.Drawing.Point(22, 58);
            this.gr_Style.Name = "gr_Style";
            this.gr_Style.Size = new System.Drawing.Size(887, 71);
            this.gr_Style.TabIndex = 20;
            this.gr_Style.TabStop = false;
            this.gr_Style.Text = "Color style";
            // 
            // flp_Style
            // 
            this.flp_Style.Location = new System.Drawing.Point(16, 21);
            this.flp_Style.Name = "flp_Style";
            this.flp_Style.Size = new System.Drawing.Size(865, 31);
            this.flp_Style.TabIndex = 0;
            // 
            // gr_Admin
            // 
            this.gr_Admin.BackColor = System.Drawing.Color.Transparent;
            this.gr_Admin.Controls.Add(this.flp_Admin);           
            this.gr_Admin.Location = new System.Drawing.Point(22, 139);
            this.gr_Admin.Name = "gr_Admin";
            this.gr_Admin.Size = new System.Drawing.Size(887, 71);
            this.gr_Admin.TabIndex = 21;
            this.gr_Admin.TabStop = false;
            this.gr_Admin.Text = "Admin Tool";
            this.gr_Admin.Visible = (InitParametar.Admin_Key || InitParametar.Admin_USB);
            // 
            // flp_Admin
            // 
            this.flp_Admin.Location = new System.Drawing.Point(16, 21);
            this.flp_Admin.Name = "flp_Admin";
            this.flp_Admin.Size = new System.Drawing.Size(865, 40);
            this.flp_Admin.TabIndex = 0;
            this.flp_Admin.Controls.Add(btn_CreateLicensing);
            this.flp_Admin.Controls.Add(btn_CreateUSBKey);
            // 
            // btn_CreateLicensing
            // 
            this.btn_CreateLicensing.AutoSize = false;
            this.btn_CreateLicensing.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;            
            this.btn_CreateLicensing.Name = "btn_CreateLicensing";
            this.btn_CreateLicensing.Size = new System.Drawing.Size(105, 31);
            this.btn_CreateLicensing.TabIndex = 17;
            this.btn_CreateLicensing.Text = "Licensing";
            this.btn_CreateLicensing.Click += new System.EventHandler(this.btn_CreateLicensing_Click);
            //
            //btn_CreateUSBKey
            //
            this.btn_CreateUSBKey.AutoSize = false;
            this.btn_CreateUSBKey.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.btn_CreateUSBKey.Name = "btn_CreateUSBKey";
            this.btn_CreateUSBKey.Size = new System.Drawing.Size(105, 31);
            this.btn_CreateUSBKey.TabIndex = 17;
            this.btn_CreateUSBKey.Text = "USB Key";
            this.btn_CreateUSBKey.Click += new System.EventHandler(this.btn_CreateUSBKey_Click);
            // 
            // btn_LogAdmin
            // 
            this.btn_LogAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LogAdmin.BZBackColor = System.Drawing.Color.Transparent;
            this.btn_LogAdmin.CFormState = Transaction_Statistical.AddOn.MinMaxButton.CustomFormState.Normal;
            this.btn_LogAdmin.DisplayText = "";
            this.btn_LogAdmin.Enabled = true;
            this.btn_LogAdmin.FlatAppearance.BorderColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.btn_LogAdmin.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.btn_LogAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogAdmin.ForeColor = System.Drawing.Color.White;
            this.btn_LogAdmin.Image= IconHelper.ImageUltility.ChangeColor(global::Transaction_Statistical.Properties.Resources.key, InitGUI.Custom.Menu_Button.DisplayColor);
            this.btn_LogAdmin.Location = new System.Drawing.Point(870, 515);
            this.btn_LogAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LogAdmin.MouseClickColor1 = System.Drawing.Color.Empty;
            this.btn_LogAdmin.MouseHoverColor = System.Drawing.Color.Empty;
            this.btn_LogAdmin.Name = "btn_LogAdmin";
            this.btn_LogAdmin.Size = new System.Drawing.Size(60, 46);
            this.btn_LogAdmin.TabIndex = 16;
            this.btn_LogAdmin.TextLocation_X = -20;
            this.btn_LogAdmin.TextLocation_Y = -20;
            this.btn_LogAdmin.UseVisualStyleBackColor = true;
            this.btn_LogAdmin.Click += new System.EventHandler(this.btn_LogAdmin_Click);
            this.btn_LogAdmin.Visible= !(InitParametar.Admin_Key || InitParametar.Admin_USB);
            // this.btn_LogAdmin.MouseLeave += new System.EventHandler(this.btn_Export_MouseLeave);
            //  this.btn_LogAdmin.MouseHover += new System.EventHandler(this.btn_Export_MouseHover);
            // 
            // UC_Menu_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.Controls.Add(this.gr_Style);
            this.Controls.Add(this.gr_Admin);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.btn_LogAdmin);
            this.Controls.Add(this.cbo_LstTemplate);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Menu_Overview";
            this.Size = new System.Drawing.Size(932, 568);
            this.gr_Style.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            InitGUI.Custom.Frm_Background.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Frm_ForeColor.OnColorHandler += InitializeComponent_Refresh;

            InitGUI.Custom.Menu_RightBckgd.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_ButtonDown.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_ButtonHover.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_Border.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_Text.OnColorHandler += InitializeComponent_Refresh;
        }
        private void InitializeComponent_Refresh(object sender, System.Drawing.Color e)
        {
            // 
            // label1
            // 
            this.label1.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            btn_Edit.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btn_Edit.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            btn_Edit.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            // 
            // cbo_LstTemplate
            // 
            this.cbo_LstTemplate.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.cbo_LstTemplate.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.cbo_LstTemplate.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // btn_Apply
            // 
            btn_Apply.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            btn_Apply.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            btn_Apply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btn_Apply.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            btn_Apply.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;

            // 
            // btn_New
            // 
            btn_New.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            btn_New.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            btn_New.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btn_New.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            btn_New.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            // 
            // bt_Delete
            // 
            bt_Delete.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            bt_Delete.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            bt_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            bt_Delete.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            bt_Delete.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            //
            // rd_Mode_Dark
            //
            rd_Mode_Dark.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            //
            // rd_Mode_Ligh
            //
            rd_Mode_Ligh.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            //
            // rd_Mode_Custom
            //
            rd_Mode_Custom.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            //
            //bt_Custom
            //
            bt_Custom.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            bt_Custom.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            bt_Custom.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            bt_Custom.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            bt_Custom.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            //
            //btn_CreateUSBKey
            //
            btn_CreateUSBKey.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            btn_CreateUSBKey.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            btn_CreateUSBKey.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btn_CreateUSBKey.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            btn_CreateUSBKey.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            //
            //btn_CreateLicensing
            //
            btn_CreateLicensing.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            btn_CreateLicensing.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            btn_CreateLicensing.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btn_CreateLicensing.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            btn_CreateLicensing.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;

            this.btn_LogAdmin.FlatAppearance.BorderColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.btn_LogAdmin.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.btn_LogAdmin.Image = IconHelper.ImageUltility.ChangeColor(global::Transaction_Statistical.Properties.Resources.key, InitGUI.Custom.Menu_Button.DisplayColor);

            // 
            // gr_Style
            // 
            this.gr_Style.ForeColor= InitGUI.Custom.Frm_ForeColor.DisplayColor;            
            // 
            // UC_Menu_Overview
            //             
            this.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;

        }
        #endregion
        private Mode_RadioButton rd_Mode_Dark;
        private Mode_RadioButton rd_Mode_Ligh;
        private Mode_RadioButton rd_Mode_Custom;
        private Mode_Label label1;
        private Mode_Button btn_Edit;
        private Mode_ComboBox cbo_LstTemplate;
        private Mode_Button btn_Apply;
        private Mode_Button btn_New;
        private Mode_Button bt_Delete;
        private Mode_Button btn_CreateLicensing;
        private Mode_Button btn_CreateUSBKey;
        private AddOn.MinMaxButton btn_LogAdmin;
        private Mode_GroupBox gr_Style;
        private Mode_GroupBox gr_Admin;
        private System.Windows.Forms.FlowLayoutPanel flp_Style;
        private System.Windows.Forms.FlowLayoutPanel flp_Admin;
    }
}
