namespace Transaction_Statistical.UControl
{
    partial class UC_Menu
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
        private void InitializeComponent_Cus()
        {
            this.pnl_BorderLeft = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lv_Version = new Mode_Label();
            this.btn_History = new Transaction_Statistical.AddOn.ButtonZ();
            this.btn_Startup = new Transaction_Statistical.AddOn.ButtonZ();
            this.btn_Dashboard = new Transaction_Statistical.AddOn.ButtonZ();
            this.btn_Overview = new Transaction_Statistical.AddOn.ButtonZ();
            this.pnl_BorderLeftMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_BorderTop = new System.Windows.Forms.Panel();
            this.pnl_BorderBottom = new System.Windows.Forms.Panel();
            this.btn_About = new Transaction_Statistical.AddOn.ButtonZ();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BorderLeft
            // 
            this.pnl_BorderLeft.BackColor = System.Drawing.Color.Blue;
            this.pnl_BorderLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_BorderLeft.Location = new System.Drawing.Point(1081, 0);
            this.pnl_BorderLeft.Name = "pnl_BorderLeft";
            this.pnl_BorderLeft.Size = new System.Drawing.Size(1, 568);
            this.pnl_BorderLeft.TabIndex = 0;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Menu.Controls.Add(this.btn_About);
            this.pnl_Menu.Controls.Add(this.lv_Version);
            this.pnl_Menu.Controls.Add(this.btn_History);
            this.pnl_Menu.Controls.Add(this.btn_Startup);
            this.pnl_Menu.Controls.Add(this.btn_Dashboard);
            this.pnl_Menu.Controls.Add(this.btn_Overview);
            this.pnl_Menu.Controls.Add(this.pnl_BorderLeftMenu);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(149, 568);
            this.pnl_Menu.TabIndex = 1;
            // 
            // lv_Version
            // 
            this.lv_Version.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Version.ForeColor = System.Drawing.Color.White;
            this.lv_Version.Location = new System.Drawing.Point(0, 507);
            this.lv_Version.Name = "lv_Version";
            this.lv_Version.Size = new System.Drawing.Size(148, 61);
            this.lv_Version.TabIndex = 4;
            this.lv_Version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_History
            // 
            this.btn_History.BorderLeft = true;
            this.btn_History.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_History.DisplayText = "History";
            this.btn_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_History.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.ForeColor = System.Drawing.Color.White;
            this.btn_History.Location = new System.Drawing.Point(0, 174);
            this.btn_History.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
            this.btn_History.MouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_History.Name = "btn_History";
            this.btn_History.NotchangeAfterMouseUP = true;
            this.btn_History.Size = new System.Drawing.Size(148, 58);
            this.btn_History.TabIndex = 4;
            this.btn_History.Text = "History";
            this.btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_History.TextLocation_X = 30;
            this.btn_History.TextLocation_Y = 12;
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // btn_Startup
            // 
            this.btn_Startup.BorderLeft = true;
            this.btn_Startup.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Startup.DisplayText = "Scheduler";
            this.btn_Startup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Startup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Startup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Startup.ForeColor = System.Drawing.Color.White;
            this.btn_Startup.Location = new System.Drawing.Point(0, 116);
            this.btn_Startup.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
            this.btn_Startup.MouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Startup.Name = "btn_Startup";
            this.btn_Startup.NotchangeAfterMouseUP = true;
            this.btn_Startup.Size = new System.Drawing.Size(148, 58);
            this.btn_Startup.TabIndex = 3;
            this.btn_Startup.Text = "Scheduler";
            this.btn_Startup.TextLocation_X = 20;
            this.btn_Startup.TextLocation_Y = 12;
            this.btn_Startup.UseVisualStyleBackColor = true;
            this.btn_Startup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BorderLeft = true;
            this.btn_Dashboard.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Dashboard.DisplayText = "Dashboard";
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 58);
            this.btn_Dashboard.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
            this.btn_Dashboard.MouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.NotchangeAfterMouseUP = true;
            this.btn_Dashboard.Size = new System.Drawing.Size(148, 58);
            this.btn_Dashboard.TabIndex = 2;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Dashboard.TextLocation_X = 15;
            this.btn_Dashboard.TextLocation_Y = 12;
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // btn_Overview
            // 
            this.btn_Overview.BorderLeft = true;
            this.btn_Overview.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Overview.DisplayText = "Overview";
            this.btn_Overview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Overview.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Overview.ForeColor = System.Drawing.Color.White;
            this.btn_Overview.Location = new System.Drawing.Point(0, 0);
            this.btn_Overview.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
            this.btn_Overview.MouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Overview.Name = "btn_Overview";
            this.btn_Overview.NotchangeAfterMouseUP = true;
            this.btn_Overview.Size = new System.Drawing.Size(148, 58);
            this.btn_Overview.TabIndex = 1;
            this.btn_Overview.Text = "Overview";
            this.btn_Overview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Overview.TextLocation_X = 22;
            this.btn_Overview.TextLocation_Y = 12;
            this.btn_Overview.UseVisualStyleBackColor = true;
            this.btn_Overview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // pnl_BorderLeftMenu
            // 
            this.pnl_BorderLeftMenu.BackColor = System.Drawing.Color.Blue;
            this.pnl_BorderLeftMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_BorderLeftMenu.Location = new System.Drawing.Point(148, 0);
            this.pnl_BorderLeftMenu.Name = "pnl_BorderLeftMenu";
            this.pnl_BorderLeftMenu.Size = new System.Drawing.Size(1, 568);
            this.pnl_BorderLeftMenu.TabIndex = 0;
            // 
            // pnl_BorderTop
            // 
            this.pnl_BorderTop.BackColor = System.Drawing.Color.Blue;
            this.pnl_BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BorderTop.Location = new System.Drawing.Point(149, 0);
            this.pnl_BorderTop.Name = "pnl_BorderTop";
            this.pnl_BorderTop.Size = new System.Drawing.Size(932, 1);
            this.pnl_BorderTop.TabIndex = 2;
            // 
            // pnl_BorderBottom
            // 
            this.pnl_BorderBottom.BackColor = System.Drawing.Color.Blue;
            this.pnl_BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_BorderBottom.Location = new System.Drawing.Point(149, 567);
            this.pnl_BorderBottom.Name = "pnl_BorderBottom";
            this.pnl_BorderBottom.Size = new System.Drawing.Size(932, 1);
            this.pnl_BorderBottom.TabIndex = 3;
            // 
            // btn_About
            // 
            this.btn_About.BorderLeft = true;
            this.btn_About.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_About.DisplayText = "About";
            this.btn_About.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.Color.White;
            this.btn_About.Location = new System.Drawing.Point(0, 232);
            this.btn_About.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
            this.btn_About.MouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_About.Name = "btn_About";
            this.btn_About.NotchangeAfterMouseUP = true;
            this.btn_About.Size = new System.Drawing.Size(148, 58);
            this.btn_About.TabIndex = 5;
            this.btn_About.Text = "About";
            this.btn_About.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_About.TextLocation_X = 35;
            this.btn_About.TextLocation_Y = 12;
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // UC_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pnl_BorderBottom);
            this.Controls.Add(this.pnl_BorderTop);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_BorderLeft);
            this.Name = "UC_Menu";
            this.Size = new System.Drawing.Size(1082, 568);
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void InitializeComponent2()
        {
            this.pnl_BorderLeft = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_BorderLeftMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_BorderTop = new System.Windows.Forms.Panel();
            this.pnl_BorderBottom = new System.Windows.Forms.Panel();
            this.lv_Version = new Mode_Label();
            this.btn_About = new Transaction_Statistical.AddOn.ButtonZ();
            this.btn_History = new Transaction_Statistical.AddOn.ButtonZ();
            this.btn_Startup = new Transaction_Statistical.AddOn.ButtonZ();
            this.btn_Dashboard = new Transaction_Statistical.AddOn.ButtonZ();
            this.btn_Overview = new Transaction_Statistical.AddOn.ButtonZ();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BorderLeft
            // 
            this.pnl_BorderLeft.BackColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.pnl_BorderLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_BorderLeft.Location = new System.Drawing.Point(1081, 0);
            this.pnl_BorderLeft.Name = "pnl_BorderLeft";
            this.pnl_BorderLeft.Size = new System.Drawing.Size(1, 568);
            this.pnl_BorderLeft.TabIndex = 0;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;
            this.pnl_Menu.Controls.Add(this.lv_Version);
            this.pnl_Menu.Controls.Add(this.btn_About);
            this.pnl_Menu.Controls.Add(this.btn_History);
            this.pnl_Menu.Controls.Add(this.btn_Startup);
            this.pnl_Menu.Controls.Add(this.btn_Dashboard);
            this.pnl_Menu.Controls.Add(this.btn_Overview);
            this.pnl_Menu.Controls.Add(this.pnl_BorderLeftMenu);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(149, 568);
            this.pnl_Menu.TabIndex = 1;
            // 
            // pnl_BorderLeftMenu
            // 
            this.pnl_BorderLeftMenu.BackColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.pnl_BorderLeftMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_BorderLeftMenu.Location = new System.Drawing.Point(148, 0);
            this.pnl_BorderLeftMenu.Name = "pnl_BorderLeftMenu";
            this.pnl_BorderLeftMenu.Size = new System.Drawing.Size(1, 568);
            this.pnl_BorderLeftMenu.TabIndex = 0;
            // 
            // pnl_BorderTop
            // 
            this.pnl_BorderTop.BackColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.pnl_BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BorderTop.Location = new System.Drawing.Point(149, 0);
            this.pnl_BorderTop.Name = "pnl_BorderTop";
            this.pnl_BorderTop.Size = new System.Drawing.Size(932, 1);
            this.pnl_BorderTop.TabIndex = 2;
            // 
            // pnl_BorderBottom
            // 
            this.pnl_BorderBottom.BackColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.pnl_BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_BorderBottom.Location = new System.Drawing.Point(149, 567);
            this.pnl_BorderBottom.Name = "pnl_BorderBottom";
            this.pnl_BorderBottom.Size = new System.Drawing.Size(932, 1);
            this.pnl_BorderBottom.TabIndex = 3;
            // 
            // lv_Version
            // 
            this.lv_Version.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Version.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.lv_Version.Location = new System.Drawing.Point(0, 507);
            this.lv_Version.Name = "lv_Version";
            this.lv_Version.Size = new System.Drawing.Size(148, 61);
            this.lv_Version.TabIndex = 4;
            this.lv_Version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lv_Version.MouseEnter += new System.EventHandler(this.mode_Label8_MouseEnter);
            this.lv_Version.MouseLeave += new System.EventHandler(this.mode_Label4_Leave);
            this.lv_Version.MouseHover += new System.EventHandler(this.mode_Label4_MouseHover);
            // 
            // btn_About
            // 
            this.btn_About.BorderLeft = true;
            this.btn_About.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_About.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;
            this.btn_About.DisplayText = "About";
            this.btn_About.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.btn_About.Location = new System.Drawing.Point(0, 232);
            this.btn_About.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_About.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.btn_About.Name = "btn_About";
            this.btn_About.NotchangeAfterMouseUP = true;
            this.btn_About.Size = new System.Drawing.Size(148, 58);
            this.btn_About.TabIndex = 5;
            this.btn_About.Text = "About";
            this.btn_About.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_About.TextLocation_X = 35;
            this.btn_About.TextLocation_Y = 12;
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // btn_History
            // 
            this.btn_History.BorderLeft = true;
            this.btn_History.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_History.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;
            this.btn_History.DisplayText = "History";
            this.btn_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_History.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.btn_History.Location = new System.Drawing.Point(0, 174);
            this.btn_History.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_History.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_History.Name = "btn_History";
            this.btn_History.NotchangeAfterMouseUP = true;
            this.btn_History.Size = new System.Drawing.Size(148, 58);
            this.btn_History.TabIndex = 4;
            this.btn_History.Text = "History";
            this.btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_History.TextLocation_X = 30;
            this.btn_History.TextLocation_Y = 12;
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // btn_Startup
            // 
            this.btn_Startup.BorderLeft = true;
            this.btn_Startup.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Startup.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;
            this.btn_Startup.DisplayText = "Scheduler";
            this.btn_Startup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Startup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Startup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Startup.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.btn_Startup.Location = new System.Drawing.Point(0, 116);
            this.btn_Startup.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_Startup.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;//System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_Startup.Name = "btn_Startup";
            this.btn_Startup.NotchangeAfterMouseUP = true;
            this.btn_Startup.Size = new System.Drawing.Size(148, 58);
            this.btn_Startup.TabIndex = 3;
            this.btn_Startup.Text = "Scheduler";
            this.btn_Startup.TextLocation_X = 20;
            this.btn_Startup.TextLocation_Y = 12;
            this.btn_Startup.UseVisualStyleBackColor = true;
            this.btn_Startup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BorderLeft = true;
            this.btn_Dashboard.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Dashboard.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;
            this.btn_Dashboard.DisplayText = "Dashboard";
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 58);
            this.btn_Dashboard.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_Dashboard.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.NotchangeAfterMouseUP = true;
            this.btn_Dashboard.Size = new System.Drawing.Size(148, 58);
            this.btn_Dashboard.TabIndex = 2;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Dashboard.TextLocation_X = 15;
            this.btn_Dashboard.TextLocation_Y = 12;
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // btn_Overview
            // 
            this.btn_Overview.BorderLeft = true;
            this.btn_Overview.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Overview.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;
            this.btn_Overview.DisplayText = "Overview";
            this.btn_Overview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Overview.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Overview.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.btn_Overview.Location = new System.Drawing.Point(0, 0);
            this.btn_Overview.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_Overview.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_Overview.Name = "btn_Overview";
            this.btn_Overview.NotchangeAfterMouseUP = true;
            this.btn_Overview.Size = new System.Drawing.Size(148, 58);
            this.btn_Overview.TabIndex = 1;
            this.btn_Overview.Text = "Overview";
            this.btn_Overview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Overview.TextLocation_X = 22;
            this.btn_Overview.TextLocation_Y = 12;
            this.btn_Overview.UseVisualStyleBackColor = true;
            this.btn_Overview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // UC_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.Controls.Add(this.pnl_BorderBottom);
            this.Controls.Add(this.pnl_BorderTop);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_BorderLeft);
            this.Name = "UC_Menu";
            this.Size = new System.Drawing.Size(1082, 568);
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

            InitGUI.Custom.Frm_TopToolbar.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Frm_ForeColor.OnColorHandler += InitializeComponent_Refresh;

            InitGUI.Custom.Editor_Background.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Editor_Border.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Editor_ForeColor.OnColorHandler += InitializeComponent_Refresh;

            InitGUI.Custom.Menu_Border.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_Button.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_ButtonDown.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_ButtonHover.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_LeftBckgd.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_RightBckgd.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_Text.OnColorHandler += InitializeComponent_Refresh;
        }
        private void InitializeComponent_Refresh(object sender, System.Drawing.Color e)
        {
           
            // 
            // pnl_BorderLeft
            // 
            this.pnl_BorderLeft.BackColor = InitGUI.Custom.Menu_Border.DisplayColor;           
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;           
            // 
            // pnl_BorderLeftMenu
            // 
            this.pnl_BorderLeftMenu.BackColor = InitGUI.Custom.Menu_Border.DisplayColor;            
            // 
            // pnl_BorderTop
            // 
            this.pnl_BorderTop.BackColor = InitGUI.Custom.Menu_Border.DisplayColor;           
            // 
            // pnl_BorderBottom
            // 
            this.pnl_BorderBottom.BackColor = InitGUI.Custom.Menu_Border.DisplayColor;           
            // 
            // lv_Version
            // 

           this.lv_Version.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // btn_About
            // 
            this.btn_About.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_About.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;
            this.btn_About.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.btn_About.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_About.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            // 
            // btn_History
            // 
            this.btn_History.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_History.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;          
            this.btn_History.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;         
            this.btn_History.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_History.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;           
            // 
            // btn_Startup
            // 
            this.btn_Startup.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Startup.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;           
            this.btn_Startup.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.btn_Startup.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Startup.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
           
            // 
            // btn_Dashboard
            // 
       
            this.btn_Dashboard.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Dashboard.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;
            this.btn_Dashboard.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;           
            this.btn_Dashboard.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Dashboard.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            // 
            // btn_Overview
            //           
            this.btn_Overview.pnl_Left.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Overview.BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;          
            this.btn_Overview.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.btn_Overview.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Overview.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;          
            // 
            // UC_Menu
            //           
            this.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
        }
        #endregion

        private System.Windows.Forms.Panel pnl_BorderLeft;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.FlowLayoutPanel pnl_BorderLeftMenu;
        private AddOn.ButtonZ btn_Overview;
        private AddOn.ButtonZ btn_History;
        private AddOn.ButtonZ btn_Startup;
        private AddOn.ButtonZ btn_Dashboard;
        private System.Windows.Forms.Panel pnl_BorderTop;
        private System.Windows.Forms.Panel pnl_BorderBottom;
        private Mode_Label lv_Version;
        private AddOn.ButtonZ btn_About;
    }
}
