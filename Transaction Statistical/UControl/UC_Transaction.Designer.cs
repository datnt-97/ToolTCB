using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.gpBox_Actions = new System.Windows.Forms.GroupBox();
            this.pl_Actions = new System.Windows.Forms.FlowLayoutPanel();
            this.tre_LstTrans = new System.Windows.Forms.TreeView();
            this.imageListTre = new System.Windows.Forms.ImageList(this.components);
            this.cb_FullTime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prb_Process = new Transaction_Statistical.TextProgressBar();
            this.btn_Menu = new Transaction_Statistical.AddOn.ButtonMenu();
            this.btn_Read = new Transaction_Statistical.AddOn.ButtonZ();
            this.panel2 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Export = new Transaction_Statistical.AddOn.MinMaxButton();
            this.imageListControl = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.fctxt_FullLog = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tvListCycle = new System.Windows.Forms.TreeView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gpBox_Actions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_FullLog)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Path
            // 
            this.txt_Path.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Path.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_Path.BackColor = System.Drawing.Color.DimGray;
            this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Path.ForeColor = System.Drawing.Color.White;
            this.txt_Path.Location = new System.Drawing.Point(13, 185);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(651, 22);
            this.txt_Path.TabIndex = 1;
            this.txt_Path.Text = "D:\\06-NPSS\\Tool_TraSoat\\LOG tech\\LOG tech\\60File";
            this.txt_Path.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Path_MouseEnter);
            // 
            // gpBox_Actions
            // 
            this.gpBox_Actions.Controls.Add(this.pl_Actions);
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
            // pl_Actions
            // 
            this.pl_Actions.AutoScroll = true;
            this.pl_Actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Actions.Location = new System.Drawing.Point(3, 17);
            this.pl_Actions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pl_Actions.Name = "pl_Actions";
            this.pl_Actions.Size = new System.Drawing.Size(645, 93);
            this.pl_Actions.TabIndex = 0;
            // 
            // tre_LstTrans
            // 
            this.tre_LstTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tre_LstTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tre_LstTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tre_LstTrans.ForeColor = System.Drawing.Color.White;
            this.tre_LstTrans.ImageIndex = 0;
            this.tre_LstTrans.ImageList = this.imageListTre;
            this.tre_LstTrans.Location = new System.Drawing.Point(13, 265);
            this.tre_LstTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tre_LstTrans.Name = "tre_LstTrans";
            this.tre_LstTrans.SelectedImageIndex = 0;
            this.tre_LstTrans.Size = new System.Drawing.Size(649, 358);
            this.tre_LstTrans.TabIndex = 8;
            this.tre_LstTrans.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.tre_LstTrans_NodeMouseHover);
            this.tre_LstTrans.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_LstTrans_AfterSelect);
            // 
            // imageListTre
            // 
            this.imageListTre.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTre.ImageStream")));
            this.imageListTre.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTre.Images.SetKeyName(0, "Flag_Success");
            this.imageListTre.Images.SetKeyName(1, "Flag_Error");
            this.imageListTre.Images.SetKeyName(2, "Flag_Warning");
            this.imageListTre.Images.SetKeyName(3, "Device");
            this.imageListTre.Images.SetKeyName(4, "Device_Error");
            this.imageListTre.Images.SetKeyName(5, "Device_Warning");
            this.imageListTre.Images.SetKeyName(6, "Date");
            this.imageListTre.Images.SetKeyName(7, "Date_Error");
            this.imageListTre.Images.SetKeyName(8, "Date_Warning");
            this.imageListTre.Images.SetKeyName(9, "DateOpen");
            this.imageListTre.Images.SetKeyName(10, "DateOpen_Error");
            this.imageListTre.Images.SetKeyName(11, "DateOpen_Warning");
            this.imageListTre.Images.SetKeyName(12, "Cycle");
            this.imageListTre.Images.SetKeyName(13, "Cycle_Error");
            this.imageListTre.Images.SetKeyName(14, "Cycle_Warning");
            this.imageListTre.Images.SetKeyName(15, "Terminal");
            this.imageListTre.Images.SetKeyName(16, "Flag");
            // 
            // cb_FullTime
            // 
            this.cb_FullTime.AutoSize = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CustomFormat = "HH:mm dd/mm/yy";
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_End.Location = new System.Drawing.Point(356, 25);
            this.dateTimePicker_End.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker_End.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CustomFormat = "HH:mm dd/mm/yy";
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
            this.prb_Process.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
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
            this.btn_Menu.Color4point = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_Menu.Color4pointDown = System.Drawing.Color.DeepSkyBlue;
            this.btn_Menu.Color4pointHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
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
            this.btn_Read.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_Read.DisplayText = "Read";
            this.btn_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Read.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = System.Drawing.Color.White;
            this.btn_Read.Location = new System.Drawing.Point(13, 220);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Read.MouseClickColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_Read.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
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
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.BZBackColor = System.Drawing.Color.Transparent;
            this.btn_Export.CFormState = Transaction_Statistical.AddOn.MinMaxButton.CustomFormState.Normal;
            this.btn_Export.DisplayText = "";
            this.btn_Export.Enabled = false;
            this.btn_Export.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_Export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.ImageKey = "Excel";
            this.btn_Export.ImageList = this.imageListControl;
            this.btn_Export.Location = new System.Drawing.Point(1291, 14);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Export.MouseClickColor1 = System.Drawing.Color.Empty;
            this.btn_Export.MouseHoverColor = System.Drawing.Color.Empty;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(60, 46);
            this.btn_Export.TabIndex = 16;
            this.btn_Export.TextLocation_X = -20;
            this.btn_Export.TextLocation_Y = -20;
            this.toolTip1.SetToolTip(this.btn_Export, "Export to Excel");
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            this.btn_Export.MouseLeave += new System.EventHandler(this.btn_Export_MouseLeave);
            this.btn_Export.MouseHover += new System.EventHandler(this.btn_Export_MouseHover);
            // 
            // imageListControl
            // 
            this.imageListControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListControl.ImageStream")));
            this.imageListControl.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListControl.Images.SetKeyName(0, "Excel");
            this.imageListControl.Images.SetKeyName(1, "Excel_Select");
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.fctxt_FullLog);
            this.panel3.Location = new System.Drawing.Point(1083, 580);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 46);
            this.panel3.TabIndex = 6;
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
            this.fctxt_FullLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.fctxt_FullLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctxt_FullLog.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctxt_FullLog.CharHeight = 18;
            this.fctxt_FullLog.CharWidth = 10;
            this.fctxt_FullLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctxt_FullLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctxt_FullLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctxt_FullLog.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctxt_FullLog.ForeColor = System.Drawing.Color.White;
            this.fctxt_FullLog.IndentBackColor = System.Drawing.Color.DimGray;
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
            this.fctxt_FullLog.Size = new System.Drawing.Size(268, 46);
            this.fctxt_FullLog.TabIndex = 2;
            this.fctxt_FullLog.WordWrap = true;
            this.fctxt_FullLog.Zoom = 100;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tvListCycle);
            this.panel4.Location = new System.Drawing.Point(1083, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 192);
            this.panel4.TabIndex = 7;
            // 
            // tvListCycle
            // 
            this.tvListCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tvListCycle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvListCycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvListCycle.ForeColor = System.Drawing.Color.White;
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
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(1083, 262);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 312);
            this.panel5.TabIndex = 8;
            // 
            // UC_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Transaction";
            this.Size = new System.Drawing.Size(1355, 639);
            this.gpBox_Actions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_FullLog)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.GroupBox gpBox_Actions;
        private System.Windows.Forms.FlowLayoutPanel pl_Actions;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.CheckBox cb_FullTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tre_LstTrans;
        private AddOn.ButtonZ btn_Read;
        private AddOn.ButtonMenu btn_Menu;
        private Panel panel1;
        private Panel panel2;
        private PropertyGrid propertyGrid1;
        private ToolTip toolTip1;
        private Panel panel3;
        private Panel panel4;
        private FastColoredTextBoxNS.FastColoredTextBox fctxt_FullLog;
        private ImageList imageListTre;
        private AddOn.MinMaxButton btn_Export;
        private ImageList imageListControl;
        private Panel panel5;
        private TreeView tvListCycle;
        private TextProgressBar prb_Process;
    }
}
