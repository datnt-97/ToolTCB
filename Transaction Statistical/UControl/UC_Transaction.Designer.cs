﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Transaction_Statistical.IconHelper;

namespace Transaction_Statistical.UControl
{
    partial class UC_Transaction
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Transaction));
			this.cMS_LstTrans = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.OpenSource = new System.Windows.Forms.ToolStripMenuItem();
			this.imageListTre = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.prb_Process = new Transaction_Statistical.TextProgressBar();
			this.label2 = new Transaction_Statistical.Mode_Label();
			this.btn_Menu = new Transaction_Statistical.AddOn.ButtonMenu();
			this.label1 = new Transaction_Statistical.Mode_Label();
			this.btn_Read = new Transaction_Statistical.AddOn.ButtonZ();
			this.gpBox_Actions = new Transaction_Statistical.Mode_GroupBox();
			this.label5 = new Transaction_Statistical.Mode_Label();
			this.cbo_Event_Status = new Transaction_Statistical.CheckedComboBox();
			this.label6 = new Transaction_Statistical.Mode_Label();
			this.cbo_Event = new Transaction_Statistical.CheckedComboBox();
			this.label4 = new Transaction_Statistical.Mode_Label();
			this.cbo_Trans_Status = new Transaction_Statistical.CheckedComboBox();
			this.label3 = new Transaction_Statistical.Mode_Label();
			this.cbo_Trans = new Transaction_Statistical.CheckedComboBox();
			this.txt_Path = new Transaction_Statistical.Mode_TextBox();
			this.tre_LstTrans = new Transaction_Statistical.Mode_TreeView();
			this.uc_Search = new Transaction_Statistical.UControl.UC_Search();
			this.dateTimePicker_Start = new Transaction_Statistical.Mode_DateTimePicker();
			this.cb_FullTime = new Transaction_Statistical.Mode_CheckBox();
			this.dateTimePicker_End = new Transaction_Statistical.Mode_DateTimePicker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pn_Bank = new Transaction_Statistical.Mode_Panel();
			this.bt_ManualHistory = new Transaction_Statistical.AddOn.ButtonZ();
			this.cb_AutoHistory = new Transaction_Statistical.Mode_CheckBox();
			this.bt_history = new Transaction_Statistical.AddOn.ButtonZ();
			this.bt_Banks = new Transaction_Statistical.AddOn.ButtonZ();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btn_Export = new Transaction_Statistical.AddOn.ButtonIcon();
			this.imageListControl = new System.Windows.Forms.ImageList(this.components);
			this.panel5 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tvListCycle = new Transaction_Statistical.Mode_TreeView();
			this.fctxt_FullLog = new Transaction_Statistical.Mode_FastColoredTextBox();
			this.cMS_LstTrans.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gpBox_Actions.SuspendLayout();
			this.tre_LstTrans.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pn_Bank.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fctxt_FullLog)).BeginInit();
			this.SuspendLayout();
			// 
			// cMS_LstTrans
			// 
			this.cMS_LstTrans.BackColor = System.Drawing.Color.Transparent;
			this.cMS_LstTrans.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cMS_LstTrans.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSource});
			this.cMS_LstTrans.Name = "cMS_LstTrans";
			this.cMS_LstTrans.ShowCheckMargin = true;
			this.cMS_LstTrans.Size = new System.Drawing.Size(162, 28);
			this.cMS_LstTrans.Opening += new System.ComponentModel.CancelEventHandler(this.cMS_LstTrans_Opening);
			// 
			// OpenSource
			// 
			this.OpenSource.Name = "OpenSource";
			this.OpenSource.Size = new System.Drawing.Size(161, 24);
			this.OpenSource.Text = "Open file";
			this.OpenSource.Click += new System.EventHandler(this.OpenSource_Click);
			// 
			// imageListTre
			// 
			this.imageListTre.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTre.ImageStream")));
			this.imageListTre.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListTre.Images.SetKeyName(0, "Flag");
			this.imageListTre.Images.SetKeyName(1, "Flag_Succeeded");
			this.imageListTre.Images.SetKeyName(2, "Flag_UnSucceeded");
			this.imageListTre.Images.SetKeyName(3, "Flag_Error");
			this.imageListTre.Images.SetKeyName(4, "Flag_Warning");
			this.imageListTre.Images.SetKeyName(5, "Device");
			this.imageListTre.Images.SetKeyName(6, "Device_Error");
			this.imageListTre.Images.SetKeyName(7, "Device_Warning");
			this.imageListTre.Images.SetKeyName(8, "Date");
			this.imageListTre.Images.SetKeyName(9, "Date_Error");
			this.imageListTre.Images.SetKeyName(10, "Date_Warning");
			this.imageListTre.Images.SetKeyName(11, "DateOpen");
			this.imageListTre.Images.SetKeyName(12, "DateOpen_Error");
			this.imageListTre.Images.SetKeyName(13, "DateOpen_Warning");
			this.imageListTre.Images.SetKeyName(14, "Cycle");
			this.imageListTre.Images.SetKeyName(15, "Cycle_Error");
			this.imageListTre.Images.SetKeyName(16, "Cycle_Warning");
			this.imageListTre.Images.SetKeyName(17, "Terminal");
			this.imageListTre.Images.SetKeyName(18, "Select");
			this.imageListTre.Images.SetKeyName(19, "Search");
			this.imageListTre.Images.SetKeyName(20, "Search_Warning");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.prb_Process);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btn_Menu);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_Read);
			this.panel1.Controls.Add(this.gpBox_Actions);
			this.panel1.Controls.Add(this.txt_Path);
			this.panel1.Controls.Add(this.tre_LstTrans);
			this.panel1.Controls.Add(this.dateTimePicker_Start);
			this.panel1.Controls.Add(this.cb_FullTime);
			this.panel1.Controls.Add(this.dateTimePicker_End);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(675, 639);
			this.panel1.TabIndex = 4;
			// 
			// prb_Process
			// 
			this.prb_Process.CustomText = "Reading start..";
			this.prb_Process.Location = new System.Drawing.Point(3, 212);
			this.prb_Process.Maximum = 1000;
			this.prb_Process.Name = "prb_Process";
			this.prb_Process.ProgressColor = System.Drawing.Color.White;
			this.prb_Process.Size = new System.Drawing.Size(0, 0);
			this.prb_Process.Step = 1;
			this.prb_Process.TabIndex = 0;
			this.prb_Process.TextColor = System.Drawing.Color.White;
			this.prb_Process.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			this.prb_Process.VisualMode = Transaction_Statistical.ProgressBarDisplayMode.TextAndPercentage;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(323, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "To";
			// 
			// btn_Menu
			// 
			this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
			this.btn_Menu.Color4point = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
			this.btn_Menu.Color4pointDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.btn_Menu.Color4pointHover = System.Drawing.Color.DeepSkyBlue;
			this.btn_Menu.Location = new System.Drawing.Point(3, 2);
			this.btn_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Menu.Name = "btn_Menu";
			this.btn_Menu.Size = new System.Drawing.Size(39, 39);
			this.btn_Menu.TabIndex = 1;
			this.btn_Menu.OnMouseDownHandler += new Transaction_Statistical.AddOn.ButtonMenu.MouseDownHandler(this.btn_Menu_OnMouseDownHandler);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(67, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "From";
			// 
			// btn_Read
			// 
			this.btn_Read.BorderLeft = false;
			this.btn_Read.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
			this.btn_Read.DisplayText = "Read";
			this.btn_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Read.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Read.ForeColor = System.Drawing.Color.White;
			this.btn_Read.Location = new System.Drawing.Point(13, 220);
			this.btn_Read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Read.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.btn_Read.MouseHoverColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_Read.Name = "btn_Read";
			this.btn_Read.NotchangeAfterMouseUP = false;
			this.btn_Read.Size = new System.Drawing.Size(649, 28);
			this.btn_Read.TabIndex = 9;
			this.btn_Read.Text = "Read";
			this.btn_Read.TextLocation_X = 210;
			this.btn_Read.TextLocation_Y = -3;
			this.btn_Read.UseVisualStyleBackColor = true;
			this.btn_Read.Click += new System.EventHandler(this.bt_Read_Click);
			// 
			// gpBox_Actions
			// 
			this.gpBox_Actions.BackColor = System.Drawing.Color.Transparent;
			this.gpBox_Actions.Controls.Add(this.label5);
			this.gpBox_Actions.Controls.Add(this.cbo_Event_Status);
			this.gpBox_Actions.Controls.Add(this.label6);
			this.gpBox_Actions.Controls.Add(this.cbo_Event);
			this.gpBox_Actions.Controls.Add(this.label4);
			this.gpBox_Actions.Controls.Add(this.cbo_Trans_Status);
			this.gpBox_Actions.Controls.Add(this.label3);
			this.gpBox_Actions.Controls.Add(this.cbo_Trans);
			this.gpBox_Actions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gpBox_Actions.ForeColor = System.Drawing.Color.White;
			this.gpBox_Actions.Location = new System.Drawing.Point(13, 59);
			this.gpBox_Actions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gpBox_Actions.Name = "gpBox_Actions";
			this.gpBox_Actions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gpBox_Actions.Size = new System.Drawing.Size(651, 112);
			this.gpBox_Actions.TabIndex = 2;
			this.gpBox_Actions.TabStop = false;
			this.gpBox_Actions.Text = "Actions";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(396, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 17);
			this.label5.TabIndex = 47;
			this.label5.Text = "Status";
			// 
			// cbo_Event_Status
			// 
			this.cbo_Event_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cbo_Event_Status.BorderColor = System.Drawing.Color.Blue;
			this.cbo_Event_Status.CheckOnClick = true;
			this.cbo_Event_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.cbo_Event_Status.DropDownHeight = 1;
			this.cbo_Event_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbo_Event_Status.ForeColor = System.Drawing.Color.White;
			this.cbo_Event_Status.FormattingEnabled = true;
			this.cbo_Event_Status.IntegralHeight = false;
			this.cbo_Event_Status.Location = new System.Drawing.Point(450, 62);
			this.cbo_Event_Status.Name = "cbo_Event_Status";
			this.cbo_Event_Status.Size = new System.Drawing.Size(191, 23);
			this.cbo_Event_Status.TabIndex = 46;
			this.cbo_Event_Status.Text = "All";
			this.cbo_Event_Status.ValueSeparator = ", ";
			this.cbo_Event_Status.SelectedValueChanged += new System.EventHandler(this.cbo_CheckAll_SelectedValueChanged);
			this.cbo_Event_Status.TextChanged += new System.EventHandler(this.cbo_CheckAll_SelectedValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(6, 65);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 17);
			this.label6.TabIndex = 45;
			this.label6.Text = "Device events";
			// 
			// cbo_Event
			// 
			this.cbo_Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cbo_Event.BorderColor = System.Drawing.Color.Blue;
			this.cbo_Event.CheckOnClick = true;
			this.cbo_Event.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.cbo_Event.DropDownHeight = 1;
			this.cbo_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbo_Event.ForeColor = System.Drawing.Color.White;
			this.cbo_Event.FormattingEnabled = true;
			this.cbo_Event.IntegralHeight = false;
			this.cbo_Event.Location = new System.Drawing.Point(115, 62);
			this.cbo_Event.Name = "cbo_Event";
			this.cbo_Event.Size = new System.Drawing.Size(262, 23);
			this.cbo_Event.TabIndex = 44;
			this.cbo_Event.Text = "All";
			this.cbo_Event.ValueSeparator = ", ";
			this.cbo_Event.TextChanged += new System.EventHandler(this.cbo_Event_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(396, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 17);
			this.label4.TabIndex = 43;
			this.label4.Text = "Status";
			// 
			// cbo_Trans_Status
			// 
			this.cbo_Trans_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cbo_Trans_Status.BorderColor = System.Drawing.Color.Blue;
			this.cbo_Trans_Status.CheckOnClick = true;
			this.cbo_Trans_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.cbo_Trans_Status.DropDownHeight = 1;
			this.cbo_Trans_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbo_Trans_Status.ForeColor = System.Drawing.Color.White;
			this.cbo_Trans_Status.FormattingEnabled = true;
			this.cbo_Trans_Status.IntegralHeight = false;
			this.cbo_Trans_Status.Location = new System.Drawing.Point(450, 23);
			this.cbo_Trans_Status.Name = "cbo_Trans_Status";
			this.cbo_Trans_Status.Size = new System.Drawing.Size(191, 23);
			this.cbo_Trans_Status.TabIndex = 42;
			this.cbo_Trans_Status.Text = "All";
			this.cbo_Trans_Status.ValueSeparator = ", ";
			this.cbo_Trans_Status.SelectedValueChanged += new System.EventHandler(this.cbo_CheckAll_SelectedValueChanged);
			this.cbo_Trans_Status.TextChanged += new System.EventHandler(this.cbo_CheckAll_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(13, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 17);
			this.label3.TabIndex = 41;
			this.label3.Text = "Transactions";
			// 
			// cbo_Trans
			// 
			this.cbo_Trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cbo_Trans.BorderColor = System.Drawing.Color.Blue;
			this.cbo_Trans.CheckOnClick = true;
			this.cbo_Trans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.cbo_Trans.DropDownHeight = 1;
			this.cbo_Trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbo_Trans.ForeColor = System.Drawing.Color.White;
			this.cbo_Trans.FormattingEnabled = true;
			this.cbo_Trans.IntegralHeight = false;
			this.cbo_Trans.Location = new System.Drawing.Point(115, 23);
			this.cbo_Trans.Name = "cbo_Trans";
			this.cbo_Trans.Size = new System.Drawing.Size(262, 23);
			this.cbo_Trans.TabIndex = 40;
			this.cbo_Trans.Text = "All";
			this.cbo_Trans.ValueSeparator = ", ";
			this.cbo_Trans.TextChanged += new System.EventHandler(this.cbo_Trans_TextChanged);
			// 
			// txt_Path
			// 
			this.txt_Path.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txt_Path.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.txt_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Path.ForeColor = System.Drawing.Color.White;
			this.txt_Path.Location = new System.Drawing.Point(13, 185);
			this.txt_Path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Path.Name = "txt_Path";
			this.txt_Path.Size = new System.Drawing.Size(651, 22);
			this.txt_Path.TabIndex = 1;
			this.txt_Path.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Path_MouseEnter);
			// 
			// tre_LstTrans
			// 
			this.tre_LstTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tre_LstTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.tre_LstTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tre_LstTrans.ContextMenuStrip = this.cMS_LstTrans;
			this.tre_LstTrans.Controls.Add(this.uc_Search);
			this.tre_LstTrans.ForeColor = System.Drawing.Color.White;
			this.tre_LstTrans.ImageIndex = 0;
			this.tre_LstTrans.ImageList = this.imageListTre;
			this.tre_LstTrans.Location = new System.Drawing.Point(13, 265);
			this.tre_LstTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tre_LstTrans.Name = "tre_LstTrans";
			this.tre_LstTrans.SelectedImageIndex = 0;
			this.tre_LstTrans.ShowNodeToolTips = true;
			this.tre_LstTrans.Size = new System.Drawing.Size(649, 358);
			this.tre_LstTrans.TabIndex = 8;
			this.tre_LstTrans.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.tre_LstTrans_NodeMouseHover);
			this.tre_LstTrans.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_LstTrans_AfterSelect);
			this.tre_LstTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tre_LstTrans_KeyPress);
			// 
			// uc_Search
			// 
			this.uc_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.uc_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.uc_Search.Location = new System.Drawing.Point(-580, 321);
			this.uc_Search.Name = "uc_Search";
			this.uc_Search.Size = new System.Drawing.Size(611, 26);
			this.uc_Search.TabIndex = 0;
			// 
			// dateTimePicker_Start
			// 
			this.dateTimePicker_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.dateTimePicker_Start.CustomFormat = "HH:mm dd/MM/yy";
			this.dateTimePicker_Start.ForeColor = System.Drawing.Color.White;
			this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_Start.Location = new System.Drawing.Point(113, 25);
			this.dateTimePicker_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker_Start.Name = "dateTimePicker_Start";
			this.dateTimePicker_Start.Size = new System.Drawing.Size(195, 22);
			this.dateTimePicker_Start.TabIndex = 3;
			// 
			// cb_FullTime
			// 
			this.cb_FullTime.AutoSize = true;
			this.cb_FullTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_FullTime.ForeColor = System.Drawing.Color.White;
			this.cb_FullTime.Location = new System.Drawing.Point(572, 26);
			this.cb_FullTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cb_FullTime.Name = "cb_FullTime";
			this.cb_FullTime.Size = new System.Drawing.Size(82, 21);
			this.cb_FullTime.TabIndex = 7;
			this.cb_FullTime.Text = "Full time";
			this.cb_FullTime.UseVisualStyleBackColor = true;
			this.cb_FullTime.CheckedChanged += new System.EventHandler(this.cb_FullTime_CheckedChanged);
			// 
			// dateTimePicker_End
			// 
			this.dateTimePicker_End.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.dateTimePicker_End.CustomFormat = "HH:mm dd/MM/yy";
			this.dateTimePicker_End.ForeColor = System.Drawing.Color.White;
			this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_End.Location = new System.Drawing.Point(356, 25);
			this.dateTimePicker_End.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker_End.Name = "dateTimePicker_End";
			this.dateTimePicker_End.Size = new System.Drawing.Size(195, 22);
			this.dateTimePicker_End.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pn_Bank);
			this.panel2.Controls.Add(this.propertyGrid1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(675, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(403, 639);
			this.panel2.TabIndex = 5;
			// 
			// pn_Bank
			// 
			this.pn_Bank.BackColor = System.Drawing.Color.Transparent;
			this.pn_Bank.BorderColor = System.Drawing.Color.Empty;
			this.pn_Bank.Controls.Add(this.bt_ManualHistory);
			this.pn_Bank.Controls.Add(this.cb_AutoHistory);
			this.pn_Bank.Controls.Add(this.bt_history);
			this.pn_Bank.Controls.Add(this.bt_Banks);
			this.pn_Bank.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_Bank.ForeColor = System.Drawing.Color.White;
			this.pn_Bank.Location = new System.Drawing.Point(0, 0);
			this.pn_Bank.Name = "pn_Bank";
			this.pn_Bank.Size = new System.Drawing.Size(403, 52);
			this.pn_Bank.TabIndex = 1;
			// 
			// bt_ManualHistory
			// 
			this.bt_ManualHistory.BorderLeft = false;
			this.bt_ManualHistory.BZBackColor = System.Drawing.Color.Teal;
			this.bt_ManualHistory.DisplayText = "Manual History";
			this.bt_ManualHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_ManualHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_ManualHistory.ForeColor = System.Drawing.Color.White;
			this.bt_ManualHistory.Location = new System.Drawing.Point(117, 3);
			this.bt_ManualHistory.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
			this.bt_ManualHistory.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
			this.bt_ManualHistory.Name = "bt_ManualHistory";
			this.bt_ManualHistory.NotchangeAfterMouseUP = false;
			this.bt_ManualHistory.Size = new System.Drawing.Size(110, 24);
			this.bt_ManualHistory.TabIndex = 4;
			this.bt_ManualHistory.Text = "Manual History";
			this.bt_ManualHistory.TextLocation_X = 6;
			this.bt_ManualHistory.TextLocation_Y = 2;
			this.bt_ManualHistory.UseVisualStyleBackColor = true;
			this.bt_ManualHistory.Click += new System.EventHandler(this.bt_ManualHistory_Click);
			// 
			// cb_AutoHistory
			// 
			this.cb_AutoHistory.AutoSize = true;
			this.cb_AutoHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_AutoHistory.ForeColor = System.Drawing.Color.White;
			this.cb_AutoHistory.Location = new System.Drawing.Point(6, 8);
			this.cb_AutoHistory.Name = "cb_AutoHistory";
			this.cb_AutoHistory.Size = new System.Drawing.Size(107, 21);
			this.cb_AutoHistory.TabIndex = 3;
			this.cb_AutoHistory.Text = "History Auto";
			this.cb_AutoHistory.UseVisualStyleBackColor = false;
			this.cb_AutoHistory.CheckedChanged += new System.EventHandler(this.cb_AutoHistory_CheckedChanged);
			// 
			// bt_history
			// 
			this.bt_history.BorderLeft = false;
			this.bt_history.BZBackColor = System.Drawing.Color.Teal;
			this.bt_history.DisplayText = "View History";
			this.bt_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_history.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_history.ForeColor = System.Drawing.Color.White;
			this.bt_history.Location = new System.Drawing.Point(233, 3);
			this.bt_history.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
			this.bt_history.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
			this.bt_history.Name = "bt_history";
			this.bt_history.NotchangeAfterMouseUP = false;
			this.bt_history.Size = new System.Drawing.Size(90, 24);
			this.bt_history.TabIndex = 2;
			this.bt_history.Text = "View History";
			this.bt_history.TextLocation_X = 6;
			this.bt_history.TextLocation_Y = 2;
			this.bt_history.UseVisualStyleBackColor = true;
			this.bt_history.Click += new System.EventHandler(this.bt_history_Click);
			// 
			// bt_Banks
			// 
			this.bt_Banks.BorderLeft = false;
			this.bt_Banks.BZBackColor = System.Drawing.Color.Teal;
			this.bt_Banks.DisplayText = "Banks";
			this.bt_Banks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Banks.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Banks.ForeColor = System.Drawing.Color.White;
			this.bt_Banks.Location = new System.Drawing.Point(329, 3);
			this.bt_Banks.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
			this.bt_Banks.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
			this.bt_Banks.Name = "bt_Banks";
			this.bt_Banks.NotchangeAfterMouseUP = false;
			this.bt_Banks.Size = new System.Drawing.Size(70, 24);
			this.bt_Banks.TabIndex = 1;
			this.bt_Banks.Text = "Banks";
			this.bt_Banks.TextLocation_X = 12;
			this.bt_Banks.TextLocation_Y = 2;
			this.bt_Banks.UseVisualStyleBackColor = true;
			this.bt_Banks.Click += new System.EventHandler(this.bt_Banks_Click);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.propertyGrid1.CategoryForeColor = System.Drawing.Color.White;
			this.propertyGrid1.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.propertyGrid1.Location = new System.Drawing.Point(3, 65);
			this.propertyGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(396, 560);
			this.propertyGrid1.TabIndex = 0;
			this.propertyGrid1.ViewForeColor = System.Drawing.Color.White;
			// 
			// toolTip1
			// 
			this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.toolTip1.ForeColor = System.Drawing.Color.White;
			// 
			// btn_Export
			// 
			this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btn_Export.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
			this.btn_Export.Enabled = false;
			this.btn_Export.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btn_Export.FlatAppearance.BorderSize = 0;
			this.btn_Export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btn_Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Export.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Export.ForeColor = System.Drawing.Color.White;
			this.btn_Export.IconClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.btn_Export.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
			this.btn_Export.IconHoverColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Export.ImageKey = "Excel";
			this.btn_Export.ImageList = this.imageListControl;
			this.btn_Export.Location = new System.Drawing.Point(1268, 8);
			this.btn_Export.Name = "btn_Export";
			this.btn_Export.Size = new System.Drawing.Size(60, 46);
			this.btn_Export.TabIndex = 23;
			this.btn_Export.Text = "_";
			this.btn_Export.TextLocation_X = 0;
			this.btn_Export.TextLocation_Y = 0;
			this.toolTip1.SetToolTip(this.btn_Export, "Export to Excel");
			this.btn_Export.UseVisualStyleBackColor = true;
			this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
			// 
			// imageListControl
			// 
			this.imageListControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListControl.ImageStream")));
			this.imageListControl.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListControl.Images.SetKeyName(0, "Excel");
			this.imageListControl.Images.SetKeyName(1, "Excel_Select");
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(266, 246);
			this.panel5.TabIndex = 8;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(1083, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.fctxt_FullLog);
			this.splitContainer1.Size = new System.Drawing.Size(266, 622);
			this.splitContainer1.SplitterDistance = 311;
			this.splitContainer1.TabIndex = 17;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tvListCycle);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.panel5);
			this.splitContainer2.Size = new System.Drawing.Size(266, 311);
			this.splitContainer2.SplitterDistance = 61;
			this.splitContainer2.TabIndex = 9;
			// 
			// tvListCycle
			// 
			this.tvListCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.tvListCycle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tvListCycle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvListCycle.ForeColor = System.Drawing.Color.White;
			this.tvListCycle.Location = new System.Drawing.Point(0, 0);
			this.tvListCycle.Margin = new System.Windows.Forms.Padding(4);
			this.tvListCycle.Name = "tvListCycle";
			this.tvListCycle.Size = new System.Drawing.Size(266, 61);
			this.tvListCycle.TabIndex = 0;
			this.tvListCycle.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvListCycle_AfterSelect);
			// 
			// fctxt_FullLog
			// 
			this.fctxt_FullLog.AllowSeveralTextStyleDrawing = true;
			this.fctxt_FullLog.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.fctxt_FullLog.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
			this.fctxt_FullLog.AutoScrollMinSize = new System.Drawing.Size(0, 18);
			this.fctxt_FullLog.BackBrush = null;
			this.fctxt_FullLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.fctxt_FullLog.BorderColor = System.Drawing.Color.Empty;
			this.fctxt_FullLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fctxt_FullLog.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.fctxt_FullLog.CharHeight = 18;
			this.fctxt_FullLog.CharWidth = 10;
			this.fctxt_FullLog.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fctxt_FullLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.fctxt_FullLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fctxt_FullLog.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.fctxt_FullLog.ForeColor = System.Drawing.Color.White;
			this.fctxt_FullLog.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
			this.fctxt_FullLog.IsReplaceMode = false;
			this.fctxt_FullLog.Language = FastColoredTextBoxNS.Language.CSharp;
			this.fctxt_FullLog.LeftBracket = '(';
			this.fctxt_FullLog.LeftBracket2 = '{';
			this.fctxt_FullLog.Location = new System.Drawing.Point(0, 0);
			this.fctxt_FullLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.fctxt_FullLog.Name = "fctxt_FullLog";
			this.fctxt_FullLog.Paddings = new System.Windows.Forms.Padding(0);
			this.fctxt_FullLog.RightBracket = ')';
			this.fctxt_FullLog.RightBracket2 = '}';
			this.fctxt_FullLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.fctxt_FullLog.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctxt_FullLog.ServiceColors")));
			this.fctxt_FullLog.ServiceLinesColor = System.Drawing.Color.DimGray;
			this.fctxt_FullLog.Size = new System.Drawing.Size(266, 307);
			this.fctxt_FullLog.TabIndex = 2;
			this.fctxt_FullLog.WordWrap = true;
			this.fctxt_FullLog.Zoom = 100;
			// 
			// UC_Transaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.Controls.Add(this.btn_Export);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "UC_Transaction";
			this.Size = new System.Drawing.Size(1355, 639);
			this.cMS_LstTrans.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gpBox_Actions.ResumeLayout(false);
			this.gpBox_Actions.PerformLayout();
			this.tre_LstTrans.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pn_Bank.ResumeLayout(false);
			this.pn_Bank.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fctxt_FullLog)).EndInit();
			this.ResumeLayout(false);

        }
        private void InitializeComponent2()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Transaction));
            this.txt_Path = new Mode_TextBox();
            this.gpBox_Actions = new Mode_GroupBox();
            this.label5 = new Mode_Label();
            this.cbo_Event_Status = new CheckedComboBox();
            this.label6 = new Mode_Label();
            this.cbo_Event = new CheckedComboBox();
            this.label4 = new Mode_Label();
            this.cbo_Trans_Status = new CheckedComboBox();
            this.label3 = new Mode_Label();
            this.cbo_Trans = new CheckedComboBox();
            this.tre_LstTrans = new Mode_TreeView();
            this.imageListTre = new System.Windows.Forms.ImageList(this.components);
            this.cb_FullTime = new Mode_CheckBox();
            this.label2 = new Mode_Label();
            this.label3 = new Mode_Label();
            this.dateTimePicker_End = new Mode_DateTimePicker();
            this.label1 = new Mode_Label();
            this.dateTimePicker_Start = new Mode_DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prb_Process = new Transaction_Statistical.TextProgressBar();
            this.btn_Menu = new Transaction_Statistical.AddOn.ButtonMenu();
            this.btn_Read = new Transaction_Statistical.AddOn.ButtonZ();
            this.panel2 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Export = new Transaction_Statistical.AddOn.ButtonIcon();
            this.imageListControl = new System.Windows.Forms.ImageList(this.components);

            this.label3 = new Mode_Label();
            this.fctxt_FullLog = new Mode_FastColoredTextBox();
            this.pn_Bank = new Transaction_Statistical.Mode_Panel();
            this.bt_Banks = new Transaction_Statistical.AddOn.ButtonZ();
            this.bt_history = new Transaction_Statistical.AddOn.ButtonZ();
            this.cb_AutoHistory = new Transaction_Statistical.Mode_CheckBox();
            this.bt_ManualHistory = new Transaction_Statistical.AddOn.ButtonZ();
            this.tvListCycle = new Mode_TreeView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cMS_LstTrans = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenSource = new System.Windows.Forms.ToolStripMenuItem();
            this.gpBox_Actions.SuspendLayout();
            this.tre_LstTrans.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_FullLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pn_Bank.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Path
            // 
            this.txt_Path.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Path.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Path.Location = new System.Drawing.Point(13, 185);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(651, 22);
            this.txt_Path.TabIndex = 1;
            this.txt_Path.Text = "";
            this.txt_Path.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Path_MouseEnter);
            // 
            // gpBox_Actions
            //             
            this.gpBox_Actions.Controls.Add(this.label5);
            this.gpBox_Actions.Controls.Add(this.cbo_Event_Status);
            this.gpBox_Actions.Controls.Add(this.label6);
            this.gpBox_Actions.Controls.Add(this.cbo_Event);
            this.gpBox_Actions.Controls.Add(this.label4);
            this.gpBox_Actions.Controls.Add(this.cbo_Trans_Status);
            this.gpBox_Actions.Controls.Add(this.label3);
            this.gpBox_Actions.Controls.Add(this.cbo_Trans);
            this.gpBox_Actions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpBox_Actions.Location = new System.Drawing.Point(13, 59);
            this.gpBox_Actions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBox_Actions.Name = "gpBox_Actions";
            this.gpBox_Actions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBox_Actions.Size = new System.Drawing.Size(651, 112);
            this.gpBox_Actions.TabIndex = 2;
            this.gpBox_Actions.TabStop = false;
            this.gpBox_Actions.Text = "Actions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Status";
            // 
            // cbo_Event_Status
            // 
            this.cbo_Event_Status.CheckOnClick = true;
            this.cbo_Event_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbo_Event_Status.DropDownHeight = 1;
            this.cbo_Event_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Event_Status.FormattingEnabled = true;
            this.cbo_Event_Status.IntegralHeight = false;
            this.cbo_Event_Status.Location = new System.Drawing.Point(450, 62);
            this.cbo_Event_Status.Name = "cbo_Event_Status";
            this.cbo_Event_Status.Size = new System.Drawing.Size(191, 23);
            this.cbo_Event_Status.TabIndex = 46;
            this.cbo_Event_Status.Text = "All";
            this.cbo_Event_Status.ValueSeparator = ", ";
            this.cbo_Event_Status.SelectedValueChanged += new System.EventHandler(this.cbo_CheckAll_SelectedValueChanged);
            this.cbo_Event_Status.TextChanged += new System.EventHandler(this.cbo_CheckAll_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Device events";
            // 
            // cbo_Event
            // 
            this.cbo_Event.CheckOnClick = true;
            this.cbo_Event.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbo_Event.DropDownHeight = 1;
            this.cbo_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Event.FormattingEnabled = true;
            this.cbo_Event.IntegralHeight = false;
            this.cbo_Event.Location = new System.Drawing.Point(115, 62);
            this.cbo_Event.Name = "cbo_Event";
            this.cbo_Event.Size = new System.Drawing.Size(262, 23);
            this.cbo_Event.TabIndex = 44;
            this.cbo_Event.Text = "All";
            this.cbo_Event.ValueSeparator = ", ";
            this.cbo_Event.TextChanged += new System.EventHandler(this.cbo_Event_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Status";
            // 
            // cbo_Trans_Status
            // 
            this.cbo_Trans_Status.CheckOnClick = true;
            this.cbo_Trans_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbo_Trans_Status.DropDownHeight = 1;
            this.cbo_Trans_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Trans_Status.FormattingEnabled = true;
            this.cbo_Trans_Status.IntegralHeight = false;
            this.cbo_Trans_Status.Location = new System.Drawing.Point(450, 23);
            this.cbo_Trans_Status.Name = "cbo_Trans_Status";
            this.cbo_Trans_Status.Size = new System.Drawing.Size(191, 23);
            this.cbo_Trans_Status.TabIndex = 42;
            this.cbo_Trans_Status.Text = "All";
            this.cbo_Trans_Status.ValueSeparator = ", ";
            this.cbo_Trans_Status.SelectedValueChanged += new System.EventHandler(this.cbo_CheckAll_SelectedValueChanged);
            this.cbo_Trans_Status.TextChanged += new System.EventHandler(this.cbo_CheckAll_SelectedValueChanged);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Transactions";
            // 
            // cbo_Trans
            // 
            this.cbo_Trans.CheckOnClick = true;
            this.cbo_Trans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbo_Trans.DropDownHeight = 1;
            this.cbo_Trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Trans.FormattingEnabled = true;
            this.cbo_Trans.IntegralHeight = false;
            this.cbo_Trans.Location = new System.Drawing.Point(115, 23);
            this.cbo_Trans.Name = "cbo_Trans";
            this.cbo_Trans.Size = new System.Drawing.Size(262, 23);
            this.cbo_Trans.TabIndex = 40;
            this.cbo_Trans.Text = "All";
            this.cbo_Trans.ValueSeparator = ", ";
            this.cbo_Trans.TextChanged += new System.EventHandler(this.cbo_Trans_TextChanged);
            // 
            // tre_LstTrans
            // 
            this.tre_LstTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tre_LstTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tre_LstTrans.ImageIndex = 0;
            this.tre_LstTrans.ImageList = this.imageListTre;
            this.tre_LstTrans.ContextMenuStrip = this.cMS_LstTrans;
            this.tre_LstTrans.Location = new System.Drawing.Point(13, 265);
            this.tre_LstTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tre_LstTrans.Name = "tre_LstTrans";
            this.tre_LstTrans.SelectedImageIndex = 0;
            this.tre_LstTrans.Size = new System.Drawing.Size(649, 358);
            this.tre_LstTrans.TabIndex = 8;
            this.tre_LstTrans.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.tre_LstTrans_NodeMouseHover);
            this.tre_LstTrans.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_LstTrans_AfterSelect);
            this.tre_LstTrans.KeyPress += new KeyPressEventHandler(tre_LstTrans_KeyPress);
            this.uc_Search = new UC_Search(tre_LstTrans);
            this.tre_LstTrans.Controls.Add(uc_Search);
            // 
            // imageListTre
            // 
            this.imageListTre.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTre.ImageStream")));
            this.imageListTre.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTre.Images.SetKeyName(0, "Flag");
            this.imageListTre.Images.SetKeyName(1, "Flag_Succeeded");
            this.imageListTre.Images.SetKeyName(2, "Flag_UnSucceeded");
            this.imageListTre.Images.SetKeyName(3, "Flag_Error");
            this.imageListTre.Images.SetKeyName(4, "Flag_Warning");
            this.imageListTre.Images.SetKeyName(5, "Device");
            this.imageListTre.Images.SetKeyName(6, "Device_Error");
            this.imageListTre.Images.SetKeyName(7, "Device_Warning");
            this.imageListTre.Images.SetKeyName(8, "Date");
            this.imageListTre.Images.SetKeyName(9, "Date_Error");
            this.imageListTre.Images.SetKeyName(10, "Date_Warning");
            this.imageListTre.Images.SetKeyName(11, "DateOpen");
            this.imageListTre.Images.SetKeyName(12, "DateOpen_Error");
            this.imageListTre.Images.SetKeyName(13, "DateOpen_Warning");
            this.imageListTre.Images.SetKeyName(14, "Cycle");
            this.imageListTre.Images.SetKeyName(15, "Cycle_Error");
            this.imageListTre.Images.SetKeyName(16, "Cycle_Warning");
            this.imageListTre.Images.SetKeyName(17, "Terminal");
            this.imageListTre.Images.SetKeyName(18, "Select");
            this.imageListTre.Images.SetKeyName(19, "Search");
            this.imageListTre.Images.SetKeyName(20, "Search_Warning");
            // 
            // cb_FullTime
            // 
            this.cb_FullTime.AutoSize = true;
            this.cb_FullTime.Location = new System.Drawing.Point(572, 26);
            this.cb_FullTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_FullTime.Name = "cb_FullTime";
            this.cb_FullTime.Size = new System.Drawing.Size(82, 21);
            this.cb_FullTime.TabIndex = 7;
            this.cb_FullTime.Text = "Full time";
            this.cb_FullTime.UseVisualStyleBackColor = true;
            this.cb_FullTime.CheckedChanged += new System.EventHandler(this.cb_FullTime_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CustomFormat = "HH:mm dd/MM/yy";
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_End.Location = new System.Drawing.Point(356, 25);
            this.dateTimePicker_End.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker_End.TabIndex = 5;
            this.dateTimePicker_End.MaxDate = InitParametar.DateMaximum;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CustomFormat = "HH:mm dd/MM/yy";
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(113, 25);
            this.dateTimePicker_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.prb_Process);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Menu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Read);
            this.panel1.Controls.Add(this.gpBox_Actions);
            this.panel1.Controls.Add(this.txt_Path);
            this.panel1.Controls.Add(this.tre_LstTrans);
            this.panel1.Controls.Add(this.dateTimePicker_Start);
            this.panel1.Controls.Add(this.cb_FullTime);
            this.panel1.Controls.Add(this.dateTimePicker_End);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 639);
            this.panel1.TabIndex = 4;
            // 
            // prb_Process
            // 
            this.prb_Process.CustomText = "Reading start..";
            this.prb_Process.Location = new System.Drawing.Point(3, 212);
            this.prb_Process.Maximum = 1000;
            this.prb_Process.Name = "prb_Process";
            this.prb_Process.ProgressColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.prb_Process.Size = new System.Drawing.Size(0, 0);
            this.prb_Process.Step = 1;
            this.prb_Process.TabIndex = 0;
            this.prb_Process.TextColor = System.Drawing.Color.White;
            this.prb_Process.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.prb_Process.VisualMode = Transaction_Statistical.ProgressBarDisplayMode.TextAndPercentage;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.Color4point = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Menu.Color4pointDown = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Menu.Color4pointHover = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.btn_Menu.Location = new System.Drawing.Point(3, 2);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(39, 39);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.OnMouseDownHandler += new Transaction_Statistical.AddOn.ButtonMenu.MouseDownHandler(this.btn_Menu_OnMouseDownHandler);
            // 
            // btn_Read
            // 
            this.btn_Read.BorderLeft = false;
            this.btn_Read.BZBackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Read.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Read.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.btn_Read.DisplayText = "Read";
            this.btn_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Read.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.btn_Read.Location = new System.Drawing.Point(13, 220);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.NotchangeAfterMouseUP = false;
            this.btn_Read.Size = new System.Drawing.Size(649, 28);
            this.btn_Read.TabIndex = 9;
            this.btn_Read.Text = "Read";
            this.btn_Read.TextLocation_X = 210;
            this.btn_Read.TextLocation_Y = -3;
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.bt_Read_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pn_Bank);
            this.panel2.Controls.Add(this.propertyGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(675, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 639);
            this.panel2.TabIndex = 5;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = InitGUI.Custom.TranInfo_Background.DisplayColor;
            this.propertyGrid1.CategoryForeColor = InitGUI.Custom.TranInfo_Tilte.DisplayColor;
            this.propertyGrid1.ViewForeColor = InitGUI.Custom.TranInfo_Text.DisplayColor;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 65);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(396, 560);
            this.propertyGrid1.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // imageListControl
            // 
            this.imageListControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListControl.ImageStream")));
            this.imageListControl.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListControl.Images.SetKeyName(0, "Excel");
            this.imageListControl.Images.SetKeyName(1, "Excel_Select");
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.BZBackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.BackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.FlatAppearance.BorderColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.IconColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Export.IconHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.btn_Export.IconClickColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Export.Enabled = false;
            this.btn_Export.Location = new System.Drawing.Point(1266, 8);
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Export.ImageKey = "Excel";
            this.btn_Export.ImageList = this.imageListControl;
            this.btn_Export.Name = "bt_Flip";
            this.btn_Export.Size = new System.Drawing.Size(60, 46);
            this.btn_Export.TabIndex = 23;
            this.btn_Export.Text = "_";
            this.btn_Export.TextLocation_X = 0;
            this.btn_Export.TextLocation_Y = 0;
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            this.toolTip1.SetToolTip(this.btn_Export, "Export to Excel");
            // 
            // fctxt_FullLog
            // 
            this.fctxt_FullLog.BackColor = InitGUI.Custom.Editor_Background.DisplayColor;
            this.fctxt_FullLog.ForeColor = InitGUI.Custom.Editor_ForeColor.DisplayColor;

            this.fctxt_FullLog.AllowSeveralTextStyleDrawing = true;
            this.fctxt_FullLog.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctxt_FullLog.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fctxt_FullLog.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.fctxt_FullLog.BackBrush = null;
            this.fctxt_FullLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctxt_FullLog.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctxt_FullLog.CharHeight = 18;
            this.fctxt_FullLog.CharWidth = 10;
            this.fctxt_FullLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctxt_FullLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctxt_FullLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctxt_FullLog.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctxt_FullLog.IsReplaceMode = false;
            this.fctxt_FullLog.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctxt_FullLog.LeftBracket = '(';
            this.fctxt_FullLog.LeftBracket2 = '{';
            this.fctxt_FullLog.Location = new System.Drawing.Point(0, 0);
            this.fctxt_FullLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fctxt_FullLog.Name = "fctxt_FullLog";
            this.fctxt_FullLog.Paddings = new System.Windows.Forms.Padding(0);
            this.fctxt_FullLog.RightBracket = ')';
            this.fctxt_FullLog.RightBracket2 = '}';
            this.fctxt_FullLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctxt_FullLog.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctxt_FullLog.ServiceColors")));
            this.fctxt_FullLog.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.fctxt_FullLog.TabIndex = 2;
            this.fctxt_FullLog.WordWrap = true;
            this.fctxt_FullLog.Zoom = 100;
            // 
            // pn_Bank
            // 
            this.pn_Bank.BackColor = System.Drawing.Color.Transparent;
            this.pn_Bank.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.pn_Bank.BorderStyle = BorderStyle.FixedSingle;
            this.pn_Bank.Controls.Add(this.bt_ManualHistory);
            this.pn_Bank.Controls.Add(this.cb_AutoHistory);
            this.pn_Bank.Controls.Add(this.bt_history);
            this.pn_Bank.Controls.Add(this.bt_Banks);
            this.pn_Bank.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Bank.ForeColor = System.Drawing.Color.White;
            this.pn_Bank.Location = new System.Drawing.Point(0, 0);
            this.pn_Bank.Name = "pn_Bank";
            this.pn_Bank.Size = new System.Drawing.Size(403, 52);
            this.pn_Bank.TabIndex = 1;
            // 
            // bt_ManualHistory
            // 
            this.bt_ManualHistory.BorderLeft = false;
            this.bt_ManualHistory.DisplayText = "Manual History";
            this.bt_ManualHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ManualHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ManualHistory.ForeColor = InitGUI.Custom.Editor_ForeColor.DisplayColor;
            this.bt_ManualHistory.Location = new System.Drawing.Point(110, 10);
            this.bt_ManualHistory.BZBackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.bt_ManualHistory.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.bt_ManualHistory.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.bt_ManualHistory.Name = "bt_ManualHistory";
            this.bt_ManualHistory.NotchangeAfterMouseUP = false;
            this.bt_ManualHistory.Size = new System.Drawing.Size(115, 24);
            this.bt_ManualHistory.TabIndex = 4;
            this.bt_ManualHistory.Text = "Manual History";
            this.bt_ManualHistory.TextLocation_X = 2;
            this.bt_ManualHistory.TextLocation_Y = 2;
            this.bt_ManualHistory.UseVisualStyleBackColor = true;
            this.bt_ManualHistory.Click += new System.EventHandler(this.bt_ManualHistory_Click);
            // 
            // cb_AutoHistory
            // 
            this.cb_AutoHistory.AutoSize = true;
            this.cb_AutoHistory.BackColor = System.Drawing.Color.Transparent;
            this.cb_AutoHistory.ForeColor = InitGUI.Custom.Editor_ForeColor.DisplayColor;
            this.cb_AutoHistory.Location = new System.Drawing.Point(0, 35);
            this.cb_AutoHistory.Name = "cb_AutoHistory";
            this.cb_AutoHistory.Size = new System.Drawing.Size(107, 21);
            this.cb_AutoHistory.TabIndex = 3;
            this.cb_AutoHistory.Text = "History Auto";
            this.cb_AutoHistory.UseVisualStyleBackColor = false;
            this.cb_AutoHistory.CheckedChanged += new System.EventHandler(this.cb_AutoHistory_CheckedChanged);
            // 
            // bt_history
            // 
            this.bt_history.BorderLeft = false;
            this.bt_history.DisplayText = "View History";
            this.bt_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_history.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_history.ForeColor = InitGUI.Custom.Editor_ForeColor.DisplayColor;
            this.bt_history.Location = new System.Drawing.Point(230, 10);
            this.bt_history.BZBackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.bt_history.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.bt_history.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.bt_history.Name = "bt_history";
            this.bt_history.NotchangeAfterMouseUP = false;
            this.bt_history.Size = new System.Drawing.Size(95, 24);
            this.bt_history.TabIndex = 2;
            this.bt_history.Text = "View History";
            this.bt_history.TextLocation_X = 2;
            this.bt_history.TextLocation_Y = 2;
            this.bt_history.UseVisualStyleBackColor = true;
            this.bt_history.Click += new System.EventHandler(this.bt_history_Click);
            // 
            // bt_Banks
            // 
            this.bt_Banks.BorderLeft = false;
            this.bt_Banks.DisplayText = "Banks";
            this.bt_Banks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Banks.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Banks.ForeColor = InitGUI.Custom.Editor_ForeColor.DisplayColor;
            this.bt_Banks.Location = new System.Drawing.Point(329, 10);
            this.bt_Banks.BZBackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.bt_Banks.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.bt_Banks.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.bt_Banks.Name = "bt_Banks";
            this.bt_Banks.NotchangeAfterMouseUP = false;
            this.bt_Banks.Size = new System.Drawing.Size(70, 24);
            this.bt_Banks.TabIndex = 1;
            this.bt_Banks.Text = "Banks";
            this.bt_Banks.TextLocation_X = 8;
            this.bt_Banks.TextLocation_Y = 2;
            this.bt_Banks.UseVisualStyleBackColor = true;
            this.bt_Banks.Click += new System.EventHandler(this.bt_Banks_Click);
            // 
            // tvListCycle
            // 
            this.tvListCycle.BackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.tvListCycle.ForeColor = InitGUI.Custom.Cycle_Tilte.DisplayColor;
            this.tvListCycle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvListCycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvListCycle.Location = new System.Drawing.Point(0, 0);
            this.tvListCycle.Margin = new System.Windows.Forms.Padding(4);
            this.tvListCycle.Name = "tvListCycle";
            this.tvListCycle.Size = new System.Drawing.Size(264, 190);
            this.tvListCycle.TabIndex = 0;
            this.tvListCycle.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvListCycle_AfterSelect);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 246);
            this.panel5.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1083, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fctxt_FullLog);
            this.splitContainer1.Size = new System.Drawing.Size(266, 622);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 17;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvListCycle);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel5);
            this.splitContainer2.Size = new System.Drawing.Size(266, 311);
            this.splitContainer2.SplitterDistance = 61;
            this.splitContainer2.TabIndex = 9;
            // 
            // cMS_LstTrans
            // 
            this.cMS_LstTrans.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.cMS_LstTrans.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.cMS_LstTrans.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cMS_LstTrans.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSource});
            this.cMS_LstTrans.Name = "cMS_LstTrans";
            this.cMS_LstTrans.ShowCheckMargin = true;
            this.cMS_LstTrans.Size = new System.Drawing.Size(233, 56);
            this.cMS_LstTrans.ShowImageMargin = false;
            this.cMS_LstTrans.ShowCheckMargin = false;
            this.cMS_LstTrans.Opening += new CancelEventHandler(cMS_LstTrans_Opening);
            // 
            // OpenSource
            // 
            this.OpenSource.Name = "OpenSource";
            this.OpenSource.Size = new System.Drawing.Size(232, 24);
            this.OpenSource.Text = "Open file";
            // 
            // UC_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Transaction";
            this.Size = new System.Drawing.Size(1355, 639);
            this.gpBox_Actions.ResumeLayout(false);
            this.gpBox_Actions.PerformLayout();
            this.tre_LstTrans.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_FullLog)).EndInit();                

            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.cMS_LstTrans.ResumeLayout(false);
            this.pn_Bank.ResumeLayout(false);
            this.pn_Bank.PerformLayout();
            this.ResumeLayout(false);
            //
            InitGUI.Custom.Menu_Button.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_Border.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_ButtonDown.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_ButtonHover.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_LeftBckgd.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_RightBckgd.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_Text.OnColorHandler += InitializeComponent_Refresh;

            InitGUI.Custom.Frm_ForeColor.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Frm_Background.OnColorHandler += InitializeComponent_Refresh;

            InitGUI.Custom.Editor_Background.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Editor_Border.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Editor_ForeColor.OnColorHandler += InitializeComponent_Refresh;

            InitGUI.Custom.TranInfo_Background.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.TranInfo_Border.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.TranInfo_Text.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.TranInfo_Tilte.OnColorHandler += InitializeComponent_Refresh;

            InitGUI.Custom.Cycle_Background.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Cycle_Border.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Cycle_Text.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Cycle_Tilte.OnColorHandler += InitializeComponent_Refresh;

            InitGUI.Custom.Tab_sel_forecolor.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Tab_unsel_forecolor.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Tab_UnSel_Backcolor.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Tab_UnSel_Backcolor.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Tab_MouseHvrColor.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Tab_MouseClkColor.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Tab_Ribbon_Color.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Tab_CtrlPanel_Backcolor.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Tab_CtrlButPanel_Backcolor.OnColorHandler += InitializeComponent_Refresh;

        }
        private void InitializeComponent_Refresh(object sender, System.Drawing.Color e)
        {
            // 
            // txt_Path
            // 
            this.txt_Path.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.txt_Path.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // gpBox_Actions
            //            
            this.gpBox_Actions.BackColor = Color.Transparent;
            this.gpBox_Actions.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // label5
            // 
            this.label5.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // cbo_Event_Status
            // 
            this.cbo_Event_Status.BackColor= InitGUI.Custom.Frm_Background.DisplayColor;
            this.cbo_Event_Status.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.cbo_Event_Status.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.cbo_Event_Status.Invalidate();
            // 
            // label6
            // 
            this.label6.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // cbo_Event
            // 
            this.cbo_Event.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.cbo_Event.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.cbo_Event.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.cbo_Event.Invalidate();
            // 
            // label4
            // 
            this.label4.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // cbo_Trans_Status
            // 
            this.cbo_Trans_Status.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.cbo_Trans_Status.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.cbo_Trans_Status.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.cbo_Trans_Status.Invalidate();
            // 
            // label3
            // 
            this.label3.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // cbo_Trans
            // 
            this.cbo_Trans.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.cbo_Trans.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.cbo_Trans.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            // 
            // propertyGrid1
            //           
            this.propertyGrid1.BackColor = InitGUI.Custom.TranInfo_Background.DisplayColor;
            this.propertyGrid1.CategoryForeColor = InitGUI.Custom.TranInfo_Tilte.DisplayColor;
            this.propertyGrid1.ViewForeColor = InitGUI.Custom.TranInfo_Text.DisplayColor;
           
            // 
            // tre_LstTrans
            // 
            tre_LstTrans.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            tre_LstTrans.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // cb_FullTime
            // 
            cb_FullTime.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            cb_FullTime.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // label2
            // 
            this.label2.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // dateTimePicker_End
            // 
            dateTimePicker_End.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            dateTimePicker_End.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // label1
            // 
            this.label1.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            // 
            // dateTimePicker_Start
            // 
            dateTimePicker_Start.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            dateTimePicker_Start.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;

            // 
            // prb_Process
            //            
            this.prb_Process.ProgressColor = InitGUI.Custom.Menu_Button.DisplayColor;         
            // 
            // btn_Menu
            // 
            this.btn_Menu.Color4point = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Menu.Color4pointDown = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Menu.Color4pointHover = InitGUI.Custom.Menu_ButtonHover.DisplayColor;           
            // 
            // btn_Read
            //           
            this.btn_Read.BZBackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Read.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Read.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            // 
            // btn_Export
            // 
            this.btn_Export.BZBackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.BackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.FlatAppearance.BorderColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            this.btn_Export.IconColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Export.IconHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.btn_Export.IconClickColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            // 
            // fctxt_FullLog
            // 
            fctxt_FullLog.BackColor = InitGUI.Custom.Editor_Background.DisplayColor;
            fctxt_FullLog.ForeColor = InitGUI.Custom.Editor_ForeColor.DisplayColor;
            fctxt_FullLog.IndentBackColor = Color.FromArgb(196, 196, 196);
            // 
            // bt_ManualHistory
            //
            this.bt_ManualHistory.BZBackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.bt_ManualHistory.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.bt_ManualHistory.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;           
            // 
            // cb_AutoHistory
            //           
            this.cb_AutoHistory.ForeColor = InitGUI.Custom.Editor_ForeColor.DisplayColor;            
            // 
            // bt_history
            //          
            this.bt_history.BZBackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.bt_history.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.bt_history.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;          
            // 
            // bt_Banks
            //            
            this.bt_Banks.BZBackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.bt_Banks.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.bt_Banks.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
    
            // 
            // tvListCycle
            // 
            tvListCycle.BackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            tvListCycle.ForeColor = InitGUI.Custom.Cycle_Tilte.DisplayColor;       
            // 
            // UC_Transaction
            // 
            this.prb_Process.ProgressColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.panel5.BackColor = InitGUI.Custom.Cycle_Background.DisplayColor;
            if(dataGrid!=null)
            {
                dataGrid.BackgroundColor = InitGUI.Custom.Cycle_Background.DisplayColor;
                dataGrid.ForeColor = InitGUI.Custom.Cycle_Text.DisplayColor;          
                dataGrid.DefaultCellStyle.BackColor= InitGUI.Custom.Cycle_Background.DisplayColor;
            }
        }
        #endregion
        private Mode_TextBox txt_Path;
        private Mode_GroupBox gpBox_Actions;
        private Mode_DateTimePicker dateTimePicker_Start;
        private Mode_CheckBox cb_FullTime;
        private Mode_Label label2;
        private Mode_DateTimePicker dateTimePicker_End;
        private Mode_Label label1;
        private Mode_TreeView tre_LstTrans;
        private AddOn.ButtonZ btn_Read;
        private AddOn.ButtonMenu btn_Menu;
        private Panel panel1;
        private Panel panel2;
        private PropertyGrid propertyGrid1;
        private ToolTip toolTip1;
        private Mode_FastColoredTextBox fctxt_FullLog;
        private ImageList imageListTre;
        private AddOn.ButtonIcon btn_Export;
        private ImageList imageListControl;
        private Panel panel5;
        private Mode_TreeView tvListCycle;
        private TextProgressBar prb_Process;
        private Mode_Label label5;
        private CheckedComboBox cbo_Event_Status;
        private Mode_Label label6;
        private CheckedComboBox cbo_Event;
        private Mode_Label label4;
        private CheckedComboBox cbo_Trans_Status;
        private Mode_Label label3;
        private CheckedComboBox cbo_Trans;
        private UC_Search uc_Search;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ContextMenuStrip cMS_LstTrans;
        private ToolStripMenuItem OpenSource;
		private Mode_Panel pn_Bank;
		private AddOn.ButtonZ bt_history;
		private AddOn.ButtonZ bt_Banks;
		private AddOn.ButtonZ bt_ManualHistory;
		private Mode_CheckBox cb_AutoHistory;
	}
}
