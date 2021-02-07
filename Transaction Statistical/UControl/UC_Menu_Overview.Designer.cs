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
            this.gs_Form = new Transaction_Statistical.Mode_GroupBox();
            this.bt_AddForm = new Transaction_Statistical.Mode_Button();
            this.bt_Remove = new Transaction_Statistical.Mode_Button();
            this.bt_Refresh = new Transaction_Statistical.Mode_Button();
            this.ckbl_Forms = new Transaction_Statistical.Mode_CheckedListBox();
            this.mode_GroupBox1 = new Transaction_Statistical.Mode_GroupBox();
            this.txt_FortmatExtract = new Transaction_Statistical.Mode_TextBox();
            this.mode_Label2 = new Transaction_Statistical.Mode_Label();
            this.txt_FormatOpen = new Transaction_Statistical.Mode_TextBox();
            this.mode_Label1 = new Transaction_Statistical.Mode_Label();
            this.gr_Style = new Transaction_Statistical.Mode_GroupBox();
            this.flp_Style = new System.Windows.Forms.FlowLayoutPanel();
            this.rd_Mode_Dark = new Transaction_Statistical.Mode_RadioButton();
            this.rd_Mode_Ligh = new Transaction_Statistical.Mode_RadioButton();
            this.rd_Mode_Custom = new Transaction_Statistical.Mode_RadioButton();
            this.bt_Custom = new Transaction_Statistical.Mode_Button();
            this.gr_Admin = new Transaction_Statistical.Mode_GroupBox();
            this.flp_Admin = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_CreateLicensing = new Transaction_Statistical.Mode_Button();
            this.btn_CreateUSBKey = new Transaction_Statistical.Mode_Button();
            this.bt_Delete = new Transaction_Statistical.Mode_Button();
            this.btn_New = new Transaction_Statistical.Mode_Button();
            this.btn_Apply = new Transaction_Statistical.Mode_Button();
            this.btn_LogAdmin = new Transaction_Statistical.AddOn.MinMaxButton();
            this.cbo_LstTemplate = new Transaction_Statistical.Mode_ComboBox();
            this.btn_Edit = new Transaction_Statistical.Mode_Button();
            this.label1 = new Transaction_Statistical.Mode_Label();
            this.gs_Form.SuspendLayout();
            this.mode_GroupBox1.SuspendLayout();
            this.gr_Style.SuspendLayout();
            this.flp_Style.SuspendLayout();
            this.gr_Admin.SuspendLayout();
            this.flp_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gs_Form
            // 
            this.gs_Form.BackColor = System.Drawing.Color.Transparent;
            this.gs_Form.Controls.Add(this.bt_AddForm);
            this.gs_Form.Controls.Add(this.bt_Remove);
            this.gs_Form.Controls.Add(this.bt_Refresh);
            this.gs_Form.Controls.Add(this.ckbl_Forms);
            this.gs_Form.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.gs_Form.Location = new System.Drawing.Point(22, 252);
            this.gs_Form.Name = "gs_Form";
            this.gs_Form.Size = new System.Drawing.Size(887, 222);
            this.gs_Form.TabIndex = 23;
            this.gs_Form.TabStop = false;
            this.gs_Form.Text = "Form Export";
            // 
            // bt_AddForm
            // 
            this.bt_AddForm.AutoSize = true;
            this.bt_AddForm.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.bt_AddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddForm.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.bt_AddForm.Location = new System.Drawing.Point(776, 144);
            this.bt_AddForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_AddForm.Name = "bt_AddForm";
            this.bt_AddForm.Size = new System.Drawing.Size(105, 31);
            this.bt_AddForm.TabIndex = 31;
            this.bt_AddForm.Text = "Add";
            this.bt_AddForm.UseVisualStyleBackColor = false;
            this.bt_AddForm.Click += new System.EventHandler(this.bt_AddForm_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.AutoSize = true;
            this.bt_Remove.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.bt_Remove.Location = new System.Drawing.Point(776, 105);
            this.bt_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(105, 31);
            this.bt_Remove.TabIndex = 30;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.AutoSize = true;
            this.bt_Refresh.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.bt_Refresh.Location = new System.Drawing.Point(776, 65);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(105, 31);
            this.bt_Refresh.TabIndex = 29;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // ckbl_Forms
            // 
            this.ckbl_Forms.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.ckbl_Forms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ckbl_Forms.CheckOnClick = true;
            this.ckbl_Forms.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.ckbl_Forms.FormattingEnabled = true;
            this.ckbl_Forms.Location = new System.Drawing.Point(15, 22);
            this.ckbl_Forms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbl_Forms.Name = "ckbl_Forms";
            this.ckbl_Forms.Size = new System.Drawing.Size(755, 189);
            this.ckbl_Forms.TabIndex = 28;
            // 
            // mode_GroupBox1
            // 
            this.mode_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.mode_GroupBox1.Controls.Add(this.txt_FortmatExtract);
            this.mode_GroupBox1.Controls.Add(this.mode_Label2);
            this.mode_GroupBox1.Controls.Add(this.txt_FormatOpen);
            this.mode_GroupBox1.Controls.Add(this.mode_Label1);
            this.mode_GroupBox1.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.mode_GroupBox1.Location = new System.Drawing.Point(22, 135);
            this.mode_GroupBox1.Name = "mode_GroupBox1";
            this.mode_GroupBox1.Size = new System.Drawing.Size(887, 111);
            this.mode_GroupBox1.TabIndex = 22;
            this.mode_GroupBox1.TabStop = false;
            this.mode_GroupBox1.Text = "Open File";
            // 
            // txt_FortmatExtract
            // 
            this.txt_FortmatExtract.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.txt_FortmatExtract.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.txt_FortmatExtract.Location = new System.Drawing.Point(248, 61);
            this.txt_FortmatExtract.Name = "txt_FortmatExtract";
            this.txt_FortmatExtract.Size = new System.Drawing.Size(618, 22);
            this.txt_FortmatExtract.TabIndex = 3;
            this.txt_FortmatExtract.Text = "*.rar;*.zip;*.z;*.gzip";
            this.txt_FortmatExtract.Validated += new System.EventHandler(this.txt_FortmatExtract_Validated);
            // 
            // mode_Label2
            // 
            this.mode_Label2.AutoSize = true;
            this.mode_Label2.BackColor = System.Drawing.Color.Transparent;
            this.mode_Label2.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.mode_Label2.Location = new System.Drawing.Point(22, 64);
            this.mode_Label2.Name = "mode_Label2";
            this.mode_Label2.Size = new System.Drawing.Size(213, 17);
            this.mode_Label2.TabIndex = 2;
            this.mode_Label2.Text = "Format extract when double click";
            // 
            // txt_FormatOpen
            // 
            this.txt_FormatOpen.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.txt_FormatOpen.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.txt_FormatOpen.Location = new System.Drawing.Point(248, 26);
            this.txt_FormatOpen.Name = "txt_FormatOpen";
            this.txt_FormatOpen.Size = new System.Drawing.Size(618, 22);
            this.txt_FormatOpen.TabIndex = 1;
            this.txt_FormatOpen.Text = "*.log;*.txt;*.jrn;*.prn;*.xml";
            this.txt_FormatOpen.Validated += new System.EventHandler(this.txt_FormatOpen_Validated);
            // 
            // mode_Label1
            // 
            this.mode_Label1.AutoSize = true;
            this.mode_Label1.BackColor = System.Drawing.Color.Transparent;
            this.mode_Label1.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.mode_Label1.Location = new System.Drawing.Point(13, 29);
            this.mode_Label1.Name = "mode_Label1";
            this.mode_Label1.Size = new System.Drawing.Size(229, 17);
            this.mode_Label1.TabIndex = 0;
            this.mode_Label1.Text = "Format open text when double click";
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
            this.gr_Admin.Location = new System.Drawing.Point(22, 480);
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
            this.Controls.Add(this.gs_Form);
            this.Controls.Add(this.mode_GroupBox1);
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
            this.gs_Form.ResumeLayout(false);
            this.gs_Form.PerformLayout();
            this.mode_GroupBox1.ResumeLayout(false);
            this.mode_GroupBox1.PerformLayout();
            this.gr_Style.ResumeLayout(false);
            this.flp_Style.ResumeLayout(false);
            this.gr_Admin.ResumeLayout(false);
            this.flp_Admin.ResumeLayout(false);
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
        private void InitializeComponent()
        {
            this.gs_Form = new Transaction_Statistical.Mode_GroupBox();
            this.bt_AddForm = new Transaction_Statistical.Mode_Button();
            this.bt_Remove = new Transaction_Statistical.Mode_Button();
            this.bt_Refresh = new Transaction_Statistical.Mode_Button();
            this.ckbl_Forms = new Transaction_Statistical.Mode_CheckedListBox();
            this.mode_GroupBox1 = new Transaction_Statistical.Mode_GroupBox();
            this.txt_FortmatExtract = new Transaction_Statistical.Mode_TextBox();
            this.mode_Label2 = new Transaction_Statistical.Mode_Label();
            this.txt_FormatOpen = new Transaction_Statistical.Mode_TextBox();
            this.mode_Label1 = new Transaction_Statistical.Mode_Label();
            this.gr_Style = new Transaction_Statistical.Mode_GroupBox();
            this.flp_Style = new System.Windows.Forms.FlowLayoutPanel();
            this.rd_Mode_Dark = new Transaction_Statistical.Mode_RadioButton();
            this.rd_Mode_Ligh = new Transaction_Statistical.Mode_RadioButton();
            this.rd_Mode_Custom = new Transaction_Statistical.Mode_RadioButton();
            this.bt_Custom = new Transaction_Statistical.Mode_Button();
            this.gr_Admin = new Transaction_Statistical.Mode_GroupBox();
            this.flp_Admin = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_CreateLicensing = new Transaction_Statistical.Mode_Button();
            this.btn_CreateUSBKey = new Transaction_Statistical.Mode_Button();
            this.bt_Delete = new Transaction_Statistical.Mode_Button();
            this.btn_New = new Transaction_Statistical.Mode_Button();
            this.btn_Apply = new Transaction_Statistical.Mode_Button();
            this.btn_LogAdmin = new Transaction_Statistical.AddOn.MinMaxButton();
            this.cbo_LstTemplate = new Transaction_Statistical.Mode_ComboBox();
            this.btn_Edit = new Transaction_Statistical.Mode_Button();
            this.label1 = new Transaction_Statistical.Mode_Label();
            this.gs_Form.SuspendLayout();
            this.mode_GroupBox1.SuspendLayout();
            this.gr_Style.SuspendLayout();
            this.flp_Style.SuspendLayout();
            this.gr_Admin.SuspendLayout();
            this.flp_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gs_Form
            // 
            this.gs_Form.BackColor = System.Drawing.Color.Transparent;
            this.gs_Form.Controls.Add(this.bt_AddForm);
            this.gs_Form.Controls.Add(this.bt_Remove);
            this.gs_Form.Controls.Add(this.bt_Refresh);
            this.gs_Form.Controls.Add(this.ckbl_Forms);
            this.gs_Form.ForeColor = System.Drawing.Color.White;
            this.gs_Form.Location = new System.Drawing.Point(22, 252);
            this.gs_Form.Name = "gs_Form";
            this.gs_Form.Size = new System.Drawing.Size(887, 222);
            this.gs_Form.TabIndex = 23;
            this.gs_Form.TabStop = false;
            this.gs_Form.Text = "Form Export";
            // 
            // bt_AddForm
            // 
            this.bt_AddForm.AutoSize = true;
            this.bt_AddForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_AddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddForm.ForeColor = System.Drawing.Color.White;
            this.bt_AddForm.Location = new System.Drawing.Point(776, 144);
            this.bt_AddForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_AddForm.Name = "bt_AddForm";
            this.bt_AddForm.Size = new System.Drawing.Size(105, 31);
            this.bt_AddForm.TabIndex = 31;
            this.bt_AddForm.Text = "Add";
            this.bt_AddForm.UseVisualStyleBackColor = false;
            this.bt_AddForm.Click += new System.EventHandler(this.bt_AddForm_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.AutoSize = true;
            this.bt_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.ForeColor = System.Drawing.Color.White;
            this.bt_Remove.Location = new System.Drawing.Point(776, 105);
            this.bt_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(105, 31);
            this.bt_Remove.TabIndex = 30;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.AutoSize = true;
            this.bt_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.ForeColor = System.Drawing.Color.White;
            this.bt_Refresh.Location = new System.Drawing.Point(776, 65);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(105, 31);
            this.bt_Refresh.TabIndex = 29;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // ckbl_Forms
            // 
            this.ckbl_Forms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ckbl_Forms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ckbl_Forms.CheckOnClick = true;
            this.ckbl_Forms.ForeColor = System.Drawing.Color.White;
            this.ckbl_Forms.FormattingEnabled = true;
            this.ckbl_Forms.Location = new System.Drawing.Point(15, 22);
            this.ckbl_Forms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbl_Forms.Name = "ckbl_Forms";
            this.ckbl_Forms.Size = new System.Drawing.Size(755, 189);
            this.ckbl_Forms.TabIndex = 28;
            // 
            // mode_GroupBox1
            // 
            this.mode_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.mode_GroupBox1.Controls.Add(this.txt_FortmatExtract);
            this.mode_GroupBox1.Controls.Add(this.mode_Label2);
            this.mode_GroupBox1.Controls.Add(this.txt_FormatOpen);
            this.mode_GroupBox1.Controls.Add(this.mode_Label1);
            this.mode_GroupBox1.ForeColor = System.Drawing.Color.White;
            this.mode_GroupBox1.Location = new System.Drawing.Point(22, 135);
            this.mode_GroupBox1.Name = "mode_GroupBox1";
            this.mode_GroupBox1.Size = new System.Drawing.Size(887, 111);
            this.mode_GroupBox1.TabIndex = 22;
            this.mode_GroupBox1.TabStop = false;
            this.mode_GroupBox1.Text = "Open File";
            // 
            // txt_FortmatExtract
            // 
            this.txt_FortmatExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_FortmatExtract.ForeColor = System.Drawing.Color.White;
            this.txt_FortmatExtract.Location = new System.Drawing.Point(248, 61);
            this.txt_FortmatExtract.Name = "txt_FortmatExtract";
            this.txt_FortmatExtract.Size = new System.Drawing.Size(618, 22);
            this.txt_FortmatExtract.TabIndex = 3;
            this.txt_FortmatExtract.Text = "*.rar;*.zip;*.z;*.gzip";
            this.txt_FortmatExtract.Validated += new System.EventHandler(this.txt_FortmatExtract_Validated);
            // 
            // mode_Label2
            // 
            this.mode_Label2.AutoSize = true;
            this.mode_Label2.BackColor = System.Drawing.Color.Transparent;
            this.mode_Label2.ForeColor = System.Drawing.Color.White;
            this.mode_Label2.Location = new System.Drawing.Point(22, 64);
            this.mode_Label2.Name = "mode_Label2";
            this.mode_Label2.Size = new System.Drawing.Size(213, 17);
            this.mode_Label2.TabIndex = 2;
            this.mode_Label2.Text = "Format extract when double click";
            // 
            // txt_FormatOpen
            // 
            this.txt_FormatOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_FormatOpen.ForeColor = System.Drawing.Color.White;
            this.txt_FormatOpen.Location = new System.Drawing.Point(248, 26);
            this.txt_FormatOpen.Name = "txt_FormatOpen";
            this.txt_FormatOpen.Size = new System.Drawing.Size(618, 22);
            this.txt_FormatOpen.TabIndex = 1;
            this.txt_FormatOpen.Text = "*.log;*.txt;*.jrn;*.prn;*.xml";
            this.txt_FormatOpen.Validated += new System.EventHandler(this.txt_FormatOpen_Validated);
            // 
            // mode_Label1
            // 
            this.mode_Label1.AutoSize = true;
            this.mode_Label1.BackColor = System.Drawing.Color.Transparent;
            this.mode_Label1.ForeColor = System.Drawing.Color.White;
            this.mode_Label1.Location = new System.Drawing.Point(13, 29);
            this.mode_Label1.Name = "mode_Label1";
            this.mode_Label1.Size = new System.Drawing.Size(229, 17);
            this.mode_Label1.TabIndex = 0;
            this.mode_Label1.Text = "Format open text when double click";
            // 
            // gr_Style
            // 
            this.gr_Style.BackColor = System.Drawing.Color.Transparent;
            this.gr_Style.Controls.Add(this.flp_Style);
            this.gr_Style.ForeColor = System.Drawing.Color.White;
            this.gr_Style.Location = new System.Drawing.Point(22, 58);
            this.gr_Style.Name = "gr_Style";
            this.gr_Style.Size = new System.Drawing.Size(887, 71);
            this.gr_Style.TabIndex = 20;
            this.gr_Style.TabStop = false;
            this.gr_Style.Text = "Color style";
            // 
            // flp_Style
            // 
            this.flp_Style.Controls.Add(this.rd_Mode_Dark);
            this.flp_Style.Controls.Add(this.rd_Mode_Ligh);
            this.flp_Style.Controls.Add(this.rd_Mode_Custom);
            this.flp_Style.Controls.Add(this.bt_Custom);
            this.flp_Style.Location = new System.Drawing.Point(16, 21);
            this.flp_Style.Name = "flp_Style";
            this.flp_Style.Size = new System.Drawing.Size(865, 31);
            this.flp_Style.TabIndex = 0;
            // 
            // rd_Mode_Dark
            // 
            this.rd_Mode_Dark.BackColor = System.Drawing.Color.Transparent;
            this.rd_Mode_Dark.ForeColor = System.Drawing.Color.White;
            this.rd_Mode_Dark.Location = new System.Drawing.Point(3, 3);
            this.rd_Mode_Dark.Name = "rd_Mode_Dark";
            this.rd_Mode_Dark.Size = new System.Drawing.Size(104, 24);
            this.rd_Mode_Dark.TabIndex = 0;
            this.rd_Mode_Dark.Text = "Dark";
            this.rd_Mode_Dark.UseVisualStyleBackColor = false;
            // 
            // rd_Mode_Ligh
            // 
            this.rd_Mode_Ligh.BackColor = System.Drawing.Color.Transparent;
            this.rd_Mode_Ligh.ForeColor = System.Drawing.Color.White;
            this.rd_Mode_Ligh.Location = new System.Drawing.Point(113, 3);
            this.rd_Mode_Ligh.Name = "rd_Mode_Ligh";
            this.rd_Mode_Ligh.Size = new System.Drawing.Size(104, 24);
            this.rd_Mode_Ligh.TabIndex = 1;
            this.rd_Mode_Ligh.Text = "Light";
            this.rd_Mode_Ligh.UseVisualStyleBackColor = false;
            // 
            // rd_Mode_Custom
            // 
            this.rd_Mode_Custom.BackColor = System.Drawing.Color.Transparent;
            this.rd_Mode_Custom.ForeColor = System.Drawing.Color.White;
            this.rd_Mode_Custom.Location = new System.Drawing.Point(223, 3);
            this.rd_Mode_Custom.Name = "rd_Mode_Custom";
            this.rd_Mode_Custom.Size = new System.Drawing.Size(104, 24);
            this.rd_Mode_Custom.TabIndex = 2;
            this.rd_Mode_Custom.Text = "Custom";
            this.rd_Mode_Custom.UseVisualStyleBackColor = false;
            // 
            // bt_Custom
            // 
            this.bt_Custom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_Custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Custom.ForeColor = System.Drawing.Color.White;
            this.bt_Custom.Location = new System.Drawing.Point(333, 2);
            this.bt_Custom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Custom.Name = "bt_Custom";
            this.bt_Custom.Size = new System.Drawing.Size(75, 23);
            this.bt_Custom.TabIndex = 3;
            this.bt_Custom.Text = "Setting";
            this.bt_Custom.UseVisualStyleBackColor = false;
            this.bt_Custom.Click += new System.EventHandler(this.btn_Edit_Custom_Click);
            // 
            // gr_Admin
            // 
            this.gr_Admin.BackColor = System.Drawing.Color.Transparent;
            this.gr_Admin.Controls.Add(this.flp_Admin);
            this.gr_Admin.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.gr_Admin.Location = new System.Drawing.Point(22, 480);
            this.gr_Admin.Name = "gr_Admin";
            this.gr_Admin.Size = new System.Drawing.Size(850, 71);
            this.gr_Admin.TabIndex = 21;
            this.gr_Admin.TabStop = false;
            this.gr_Admin.Text = "Admin Tool";
            // 
            // flp_Admin
            // 
            this.flp_Admin.Controls.Add(this.btn_CreateLicensing);
            this.flp_Admin.Controls.Add(this.btn_CreateUSBKey);
            this.flp_Admin.Location = new System.Drawing.Point(16, 21);
            this.flp_Admin.Name = "flp_Admin";
            this.flp_Admin.Size = new System.Drawing.Size(865, 40);
            this.flp_Admin.TabIndex = 0;
            // 
            // btn_CreateLicensing
            // 
            this.btn_CreateLicensing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_CreateLicensing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateLicensing.ForeColor = System.Drawing.Color.White;
            this.btn_CreateLicensing.Location = new System.Drawing.Point(3, 2);
            this.btn_CreateLicensing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateLicensing.Name = "btn_CreateLicensing";
            this.btn_CreateLicensing.Size = new System.Drawing.Size(105, 31);
            this.btn_CreateLicensing.TabIndex = 17;
            this.btn_CreateLicensing.Text = "Licensing";
            this.btn_CreateLicensing.UseVisualStyleBackColor = false;
            this.btn_CreateLicensing.Click += new System.EventHandler(this.btn_CreateLicensing_Click);
            // 
            // btn_CreateUSBKey
            // 
            this.btn_CreateUSBKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_CreateUSBKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateUSBKey.ForeColor = System.Drawing.Color.White;
            this.btn_CreateUSBKey.Location = new System.Drawing.Point(114, 2);
            this.btn_CreateUSBKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateUSBKey.Name = "btn_CreateUSBKey";
            this.btn_CreateUSBKey.Size = new System.Drawing.Size(105, 31);
            this.btn_CreateUSBKey.TabIndex = 17;
            this.btn_CreateUSBKey.Text = "USB Key";
            this.btn_CreateUSBKey.UseVisualStyleBackColor = false;
            this.btn_CreateUSBKey.Click += new System.EventHandler(this.btn_CreateUSBKey_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.AutoSize = true;
            this.bt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete.ForeColor = System.Drawing.Color.White;
            this.bt_Delete.Location = new System.Drawing.Point(547, 5);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(105, 31);
            this.bt_Delete.TabIndex = 19;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = false;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.AutoSize = true;
            this.btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.ForeColor = System.Drawing.Color.White;
            this.btn_New.Location = new System.Drawing.Point(325, 5);
            this.btn_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(105, 31);
            this.btn_New.TabIndex = 18;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.ForeColor = System.Drawing.Color.White;
            this.btn_Apply.Location = new System.Drawing.Point(658, 5);
            this.btn_Apply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(105, 31);
            this.btn_Apply.TabIndex = 17;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = false;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_LogAdmin
            // 
            this.btn_LogAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LogAdmin.BZBackColor = System.Drawing.Color.Transparent;
            this.btn_LogAdmin.CFormState = Transaction_Statistical.AddOn.MinMaxButton.CustomFormState.Normal;
            this.btn_LogAdmin.DisplayText = "";
            this.btn_LogAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_LogAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_LogAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogAdmin.ForeColor = System.Drawing.Color.White;
            this.btn_LogAdmin.Image = global::Transaction_Statistical.Properties.Resources.key;
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
            // 
            // cbo_LstTemplate
            // 
            this.cbo_LstTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbo_LstTemplate.BorderColor = System.Drawing.Color.Blue;
            this.cbo_LstTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LstTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_LstTemplate.ForeColor = System.Drawing.Color.White;
            this.cbo_LstTemplate.FormattingEnabled = true;
            this.cbo_LstTemplate.Location = new System.Drawing.Point(76, 9);
            this.cbo_LstTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_LstTemplate.Name = "cbo_LstTemplate";
            this.cbo_LstTemplate.Size = new System.Drawing.Size(217, 24);
            this.cbo_LstTemplate.TabIndex = 16;
            // 
            // btn_Edit
            // 
            this.btn_Edit.AutoSize = true;
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(436, 5);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(105, 31);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Template";
            // 
            // UC_Menu_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.gs_Form);
            this.Controls.Add(this.mode_GroupBox1);
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
            this.gs_Form.ResumeLayout(false);
            this.gs_Form.PerformLayout();
            this.mode_GroupBox1.ResumeLayout(false);
            this.mode_GroupBox1.PerformLayout();
            this.gr_Style.ResumeLayout(false);
            this.flp_Style.ResumeLayout(false);
            this.gr_Admin.ResumeLayout(false);
            this.flp_Admin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeComponent_Refresh(object sender, System.Drawing.Color e)
        {
            // 
            // gs_Form
            //           
            this.gs_Form.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;           
            // 
            // bt_AddForm
            //           
            this.bt_AddForm.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.bt_AddForm.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.bt_AddForm.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.bt_AddForm.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.bt_AddForm.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.bt_Remove.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.bt_Remove.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.bt_Remove.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.bt_Remove.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.bt_Refresh.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.bt_Refresh.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.bt_Refresh.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.bt_Refresh.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            // 
            // ckbl_Forms
            // 
            this.ckbl_Forms.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.ckbl_Forms.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            // 
            // mode_GroupBox1
            // 
            this.mode_GroupBox1.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            // 
            // txt_FortmatExtract
            // 
            this.txt_FortmatExtract.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.txt_FortmatExtract.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            // 
            // mode_Label2
            // 
            this.mode_Label2.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            // 
            // txt_FormatOpen
            // 
            this.txt_FormatOpen.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.txt_FormatOpen.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            // 
            // mode_Label1
            // 
            this.mode_Label1.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            // 
            // label1
            // 
            this.label1.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            btn_Edit.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            btn_Edit.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
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
            btn_Apply.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            btn_Apply.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            btn_Apply.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;

            // 
            // btn_New
            // 
            btn_New.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            btn_New.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            btn_New.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            btn_New.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            btn_New.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            // 
            // bt_Delete
            // 
            bt_Delete.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            bt_Delete.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            bt_Delete.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
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
            btn_CreateUSBKey.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            btn_CreateUSBKey.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            btn_CreateUSBKey.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            //
            //btn_CreateLicensing
            //
            btn_CreateLicensing.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            btn_CreateLicensing.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            btn_CreateLicensing.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
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
            //
            //gr_Admin
            //
            gr_Admin.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
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
        private Mode_GroupBox mode_GroupBox1;
        private Mode_TextBox txt_FormatOpen;
        private Mode_Label mode_Label1;
        private Mode_TextBox txt_FortmatExtract;
        private Mode_Label mode_Label2;
        public Mode_CheckedListBox ckbl_Forms;
        private Mode_GroupBox gs_Form;
        private Mode_Button bt_AddForm;
        private Mode_Button bt_Remove;
        private Mode_Button bt_Refresh;
    }
}
