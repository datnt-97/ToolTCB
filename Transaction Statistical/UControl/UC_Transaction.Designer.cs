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
        public void SlideMenuShow()
        {
            if (showMenu) showMenu = false; else showMenu = true;
            if (runningShowMenu) return;
            runningShowMenu = true;
            while (runningShowMenu)
            {
                if (showMenu)
                {
                    uc_Menu.Location = new Point(uc_Menu.Location.X + 3, uc_Menu.Location.Y);
                    if (uc_Menu.Location.X >= 0) break;
                }
                else
                {
                    uc_Menu.Location = new Point(uc_Menu.Location.X - 3, uc_Menu.Location.Y);
                    if (uc_Menu.Location.X <= -uc_Menu.Width) break;
                }
                this.Update();
            }
            runningShowMenu = false;
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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.cb_FullTime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Export = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.fctxt_FullLog = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Menu = new Transaction_Statistical.AddOn.ButtonMenu();
            this.btn_Read = new Transaction_Statistical.AddOn.ButtonZ();
            this.uc_Menu = new Transaction_Statistical.UControl.UC_Menu();
            this.uc_Explorer = new Transaction_Statistical.UControl.UC_Explorer();
            this.gpBox_Actions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_FullLog)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Path
            // 
            this.txt_Path.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Path.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_Path.BackColor = System.Drawing.Color.DimGray;
            this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Path.ForeColor = System.Drawing.Color.White;
            this.txt_Path.Location = new System.Drawing.Point(14, 150);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(484, 20);
            this.txt_Path.TabIndex = 1;
            this.txt_Path.Text = "E:\\Project\\NPS\\Document\\99147001_EJF\\99147001_EJF\\New folder";
            this.txt_Path.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Path_MouseEnter);
            // 
            // gpBox_Actions
            // 
            this.gpBox_Actions.Controls.Add(this.pl_Actions);
            this.gpBox_Actions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpBox_Actions.ForeColor = System.Drawing.Color.White;
            this.gpBox_Actions.Location = new System.Drawing.Point(14, 48);
            this.gpBox_Actions.Margin = new System.Windows.Forms.Padding(2);
            this.gpBox_Actions.Name = "gpBox_Actions";
            this.gpBox_Actions.Padding = new System.Windows.Forms.Padding(2);
            this.gpBox_Actions.Size = new System.Drawing.Size(484, 91);
            this.gpBox_Actions.TabIndex = 2;
            this.gpBox_Actions.TabStop = false;
            this.gpBox_Actions.Text = "Actions";
            // 
            // pl_Actions
            // 
            this.pl_Actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Actions.Location = new System.Drawing.Point(2, 15);
            this.pl_Actions.Margin = new System.Windows.Forms.Padding(2);
            this.pl_Actions.Name = "pl_Actions";
            this.pl_Actions.Size = new System.Drawing.Size(480, 74);
            this.pl_Actions.TabIndex = 0;
            // 
            // tre_LstTrans
            // 
            this.tre_LstTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tre_LstTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tre_LstTrans.ForeColor = System.Drawing.Color.White;
            this.tre_LstTrans.ImageIndex = 0;
            this.tre_LstTrans.ImageList = this.imageList;
            this.tre_LstTrans.Location = new System.Drawing.Point(10, 215);
            this.tre_LstTrans.Margin = new System.Windows.Forms.Padding(2);
            this.tre_LstTrans.Name = "tre_LstTrans";
            this.tre_LstTrans.SelectedImageIndex = 0;
            this.tre_LstTrans.Size = new System.Drawing.Size(488, 292);
            this.tre_LstTrans.TabIndex = 8;
            this.tre_LstTrans.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.tre_LstTrans_NodeMouseHover);
            this.tre_LstTrans.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_LstTrans_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Flag_b");
            this.imageList.Images.SetKeyName(1, "Flag_g");
            this.imageList.Images.SetKeyName(2, "Flag_r");
            this.imageList.Images.SetKeyName(3, "Flag_y");
            this.imageList.Images.SetKeyName(4, "Setting");
            this.imageList.Images.SetKeyName(5, "Setting_r");
            this.imageList.Images.SetKeyName(6, "Setting_y");
            this.imageList.Images.SetKeyName(7, "Date_open");
            this.imageList.Images.SetKeyName(8, "Date");
            this.imageList.Images.SetKeyName(9, "Terminal");
            this.imageList.Images.SetKeyName(10, "Cycle");
            // 
            // cb_FullTime
            // 
            this.cb_FullTime.AutoSize = true;
            this.cb_FullTime.ForeColor = System.Drawing.Color.White;
            this.cb_FullTime.Location = new System.Drawing.Point(429, 21);
            this.cb_FullTime.Margin = new System.Windows.Forms.Padding(2);
            this.cb_FullTime.Name = "cb_FullTime";
            this.cb_FullTime.Size = new System.Drawing.Size(64, 17);
            this.cb_FullTime.TabIndex = 7;
            this.cb_FullTime.Text = "Full time";
            this.cb_FullTime.UseVisualStyleBackColor = true;
            this.cb_FullTime.CheckedChanged += new System.EventHandler(this.cb_FullTime_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(242, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CustomFormat = "HH:mm dd/mm/yy";
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_End.Location = new System.Drawing.Point(267, 20);
            this.dateTimePicker_End.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker_End.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CustomFormat = "HH:mm dd/mm/yy";
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(85, 20);
            this.dateTimePicker_Start.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // panel1
            // 
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 519);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Export);
            this.panel2.Controls.Add(this.propertyGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(506, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 519);
            this.panel2.TabIndex = 5;
            // 
            // btn_Export
            // 
            this.btn_Export.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(2, 14);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(79, 34);
            this.btn_Export.TabIndex = 15;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(2, 53);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(297, 455);
            this.propertyGrid1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.fctxt_FullLog);
            this.panel3.Location = new System.Drawing.Point(812, 405);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 103);
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
            this.fctxt_FullLog.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctxt_FullLog.BackBrush = null;
            this.fctxt_FullLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.fctxt_FullLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctxt_FullLog.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctxt_FullLog.CharHeight = 14;
            this.fctxt_FullLog.CharWidth = 8;
            this.fctxt_FullLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctxt_FullLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctxt_FullLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctxt_FullLog.ForeColor = System.Drawing.Color.White;
            this.fctxt_FullLog.IndentBackColor = System.Drawing.Color.DimGray;
            this.fctxt_FullLog.IsReplaceMode = false;
            this.fctxt_FullLog.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctxt_FullLog.LeftBracket = '(';
            this.fctxt_FullLog.LeftBracket2 = '{';
            this.fctxt_FullLog.Location = new System.Drawing.Point(0, 0);
            this.fctxt_FullLog.Margin = new System.Windows.Forms.Padding(2);
            this.fctxt_FullLog.Name = "fctxt_FullLog";
            this.fctxt_FullLog.Paddings = new System.Windows.Forms.Padding(0);
            this.fctxt_FullLog.RightBracket = ')';
            this.fctxt_FullLog.RightBracket2 = '}';
            this.fctxt_FullLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctxt_FullLog.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctxt_FullLog.ServiceColors")));
            this.fctxt_FullLog.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.fctxt_FullLog.Size = new System.Drawing.Size(429, 103);
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
            this.panel4.Location = new System.Drawing.Point(812, 53);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 347);
            this.panel4.TabIndex = 7;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.Color4point = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_Menu.Color4pointDown = System.Drawing.Color.DeepSkyBlue;
            this.btn_Menu.Color4pointHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
            this.btn_Menu.Location = new System.Drawing.Point(2, 2);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(29, 32);
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
            this.btn_Read.Location = new System.Drawing.Point(10, 179);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Read.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btn_Read.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.NotchangeAfterMouseUP = false;
            this.btn_Read.Size = new System.Drawing.Size(487, 23);
            this.btn_Read.TabIndex = 9;
            this.btn_Read.Text = "Read";
            this.btn_Read.TextLocation_X = 210;
            this.btn_Read.TextLocation_Y = -3;
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.bt_Read_Click);
            // 
            // uc_Menu
            // 
            this.uc_Menu.BackColor = System.Drawing.Color.Transparent;
            this.uc_Menu.Location = new System.Drawing.Point(-10000, 100);
            this.uc_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uc_Menu.Name = "uc_Menu";
            this.uc_Menu.Size = new System.Drawing.Size(1066, 568);
            this.uc_Menu.TabIndex = 0;
            // 
            // uc_Explorer
            // 
            this.uc_Explorer.BackColor = System.Drawing.Color.Transparent;
            this.uc_Explorer.ForeColor = System.Drawing.Color.White;
            this.uc_Explorer.Location = new System.Drawing.Point(21, 189);
            this.uc_Explorer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uc_Explorer.Name = "uc_Explorer";
            this.uc_Explorer.Size = new System.Drawing.Size(645, 0);
            this.uc_Explorer.TabIndex = 1;
            // 
            // UC_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Transaction";
            this.Size = new System.Drawing.Size(1244, 519);
            this.gpBox_Actions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_FullLog)).EndInit();
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
        public UC_Menu uc_Menu;
        public UC_Explorer uc_Explorer;
        private Panel panel1;
        private Panel panel2;
        private PropertyGrid propertyGrid1;
        private ToolTip toolTip1;
        private Panel panel3;
        private Panel panel4;
        private FastColoredTextBoxNS.FastColoredTextBox fctxt_FullLog;
        private ImageList imageList;
        private Button btn_Export;
    }
}
