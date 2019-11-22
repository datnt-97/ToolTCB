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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.gpBox_Actions = new System.Windows.Forms.GroupBox();
            this.pl_Actions = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.bt_Read = new Transaction_Statistical.AddOn.ButtonZ();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cb_FullTime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.gpBox_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-185, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 495);
            this.panel1.TabIndex = 0;
            // 
            // tb_Path
            // 
            this.tb_Path.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_Path.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tb_Path.BackColor = System.Drawing.Color.DimGray;
            this.tb_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Path.ForeColor = System.Drawing.Color.White;
            this.tb_Path.Location = new System.Drawing.Point(21, 33);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(642, 22);
            this.tb_Path.TabIndex = 1;
            this.tb_Path.Text = "d:\\06-NPSS\\Tool_TraSoat\\LOG tech\\LOG tech\\02-10-2019";
            // 
            // gpBox_Actions
            // 
            this.gpBox_Actions.Controls.Add(this.pl_Actions);
            this.gpBox_Actions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpBox_Actions.ForeColor = System.Drawing.Color.White;
            this.gpBox_Actions.Location = new System.Drawing.Point(21, 61);
            this.gpBox_Actions.Name = "gpBox_Actions";
            this.gpBox_Actions.Size = new System.Drawing.Size(645, 112);
            this.gpBox_Actions.TabIndex = 2;
            this.gpBox_Actions.TabStop = false;
            this.gpBox_Actions.Text = "Actions";
            // 
            // pl_Actions
            // 
            this.pl_Actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Actions.Location = new System.Drawing.Point(3, 18);
            this.pl_Actions.Name = "pl_Actions";
            this.pl_Actions.Size = new System.Drawing.Size(639, 91);
            this.pl_Actions.TabIndex = 0;
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.bt_Read);
            this.splitContainer_Main.Panel1.Controls.Add(this.treeView1);
            this.splitContainer_Main.Panel1.Controls.Add(this.cb_FullTime);
            this.splitContainer_Main.Panel1.Controls.Add(this.label2);
            this.splitContainer_Main.Panel1.Controls.Add(this.dateTimePicker_End);
            this.splitContainer_Main.Panel1.Controls.Add(this.label1);
            this.splitContainer_Main.Panel1.Controls.Add(this.dateTimePicker_Start);
            this.splitContainer_Main.Panel1.Controls.Add(this.tb_Path);
            this.splitContainer_Main.Panel1.Controls.Add(this.gpBox_Actions);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer_Main.Size = new System.Drawing.Size(1324, 639);
            this.splitContainer_Main.SplitterDistance = 674;
            this.splitContainer_Main.TabIndex = 3;
            // 
            // bt_Read
            // 
            this.bt_Read.BZBackColor = System.Drawing.Color.SteelBlue;
            this.bt_Read.DisplayText = "Read";
            this.bt_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Read.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Read.ForeColor = System.Drawing.Color.White;
            this.bt_Read.Location = new System.Drawing.Point(17, 224);
            this.bt_Read.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.bt_Read.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.bt_Read.Name = "bt_Read";
            this.bt_Read.Size = new System.Drawing.Size(649, 28);
            this.bt_Read.TabIndex = 9;
            this.bt_Read.Text = "Read";
            this.bt_Read.TextLocation_X = 210;
            this.bt_Read.TextLocation_Y = -3;
            this.bt_Read.UseVisualStyleBackColor = true;
            this.bt_Read.Click += new System.EventHandler(this.bt_Read_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(17, 269);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(649, 355);
            this.treeView1.TabIndex = 8;
            // 
            // cb_FullTime
            // 
            this.cb_FullTime.AutoSize = true;
            this.cb_FullTime.ForeColor = System.Drawing.Color.White;
            this.cb_FullTime.Location = new System.Drawing.Point(565, 185);
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
            this.label2.Location = new System.Drawing.Point(301, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CustomFormat = "HH:mm dd/mm/yy";
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_End.Location = new System.Drawing.Point(335, 184);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker_End.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CustomFormat = "HH:mm dd/mm/yy";
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(67, 184);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(18, 33);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(614, 355);
            this.propertyGrid1.TabIndex = 0;
            // 
            // UC_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.splitContainer_Main);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Transaction";
            this.Size = new System.Drawing.Size(1324, 639);
            this.gpBox_Actions.ResumeLayout(false);
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel1.PerformLayout();
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.GroupBox gpBox_Actions;
        private System.Windows.Forms.FlowLayoutPanel pl_Actions;
        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.CheckBox cb_FullTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private AddOn.ButtonZ bt_Read;
    }
}
