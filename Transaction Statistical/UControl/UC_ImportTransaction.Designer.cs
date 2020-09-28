namespace Transaction_Statistical.UControl
{
	partial class UC_ImportTransaction
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ImportTransaction));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.bt_CloseInfo = new Transaction_Statistical.Mode_Label();
			this.bt_WriteChange = new Transaction_Statistical.AddOn.ButtonZ();
			this.fc_Query = new Transaction_Statistical.Mode_FastColoredTextBox();
			this.bt_Delete = new Transaction_Statistical.AddOn.ButtonZ();
			this.bt_Refresh = new Transaction_Statistical.AddOn.ButtonZ();
			this.gridView = new Transaction_Statistical.Mode_DataGridView();
			this.prb_Process = new Transaction_Statistical.TextProgressBar();
			this.btn_Import = new Transaction_Statistical.AddOn.ButtonZ();
			this.cb_Bank = new Transaction_Statistical.Mode_ComboBox();
			this.mode_Label8 = new Transaction_Statistical.Mode_Label();
			this.mode_Label1 = new Transaction_Statistical.Mode_Label();
			this.cb_Terminal = new Transaction_Statistical.Mode_ComboBox();
			this.tre_LstTrans = new Transaction_Statistical.Mode_TreeView();
			this.uc_Search = new Transaction_Statistical.UControl.UC_Search();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fc_Query)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.tre_LstTrans.SuspendLayout();
			this.SuspendLayout();
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.propertyGrid1.CategoryForeColor = System.Drawing.Color.White;
			this.propertyGrid1.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(35, 591);
			this.propertyGrid1.TabIndex = 31;
			this.propertyGrid1.ViewForeColor = System.Drawing.Color.White;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(640, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.bt_CloseInfo);
			this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
			this.splitContainer1.Panel1MinSize = 35;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.bt_WriteChange);
			this.splitContainer1.Panel2.Controls.Add(this.fc_Query);
			this.splitContainer1.Panel2.Controls.Add(this.bt_Delete);
			this.splitContainer1.Panel2.Controls.Add(this.bt_Refresh);
			this.splitContainer1.Panel2.Controls.Add(this.gridView);
			this.splitContainer1.Panel2.Controls.Add(this.prb_Process);
			this.splitContainer1.Panel2.Controls.Add(this.btn_Import);
			this.splitContainer1.Panel2.Controls.Add(this.cb_Bank);
			this.splitContainer1.Panel2.Controls.Add(this.mode_Label8);
			this.splitContainer1.Panel2.Controls.Add(this.mode_Label1);
			this.splitContainer1.Panel2.Controls.Add(this.cb_Terminal);
			this.splitContainer1.Size = new System.Drawing.Size(712, 591);
			this.splitContainer1.SplitterDistance = 35;
			this.splitContainer1.TabIndex = 33;
			// 
			// bt_CloseInfo
			// 
			this.bt_CloseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bt_CloseInfo.AutoSize = true;
			this.bt_CloseInfo.BackColor = System.Drawing.Color.Transparent;
			this.bt_CloseInfo.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.bt_CloseInfo.ForeColor = System.Drawing.Color.White;
			this.bt_CloseInfo.Location = new System.Drawing.Point(3, 568);
			this.bt_CloseInfo.Name = "bt_CloseInfo";
			this.bt_CloseInfo.Size = new System.Drawing.Size(24, 17);
			this.bt_CloseInfo.TabIndex = 32;
			this.bt_CloseInfo.Text = ">>";
			this.bt_CloseInfo.Click += new System.EventHandler(this.bt_CloseInfo_Click);
			// 
			// bt_WriteChange
			// 
			this.bt_WriteChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_WriteChange.BorderLeft = false;
			this.bt_WriteChange.BZBackColor = System.Drawing.Color.Teal;
			this.bt_WriteChange.DisplayText = "Write Changes";
			this.bt_WriteChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_WriteChange.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_WriteChange.ForeColor = System.Drawing.Color.White;
			this.bt_WriteChange.Location = new System.Drawing.Point(508, 148);
			this.bt_WriteChange.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
			this.bt_WriteChange.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
			this.bt_WriteChange.Name = "bt_WriteChange";
			this.bt_WriteChange.NotchangeAfterMouseUP = false;
			this.bt_WriteChange.Size = new System.Drawing.Size(148, 24);
			this.bt_WriteChange.TabIndex = 38;
			this.bt_WriteChange.Text = "Write Changes";
			this.bt_WriteChange.TextLocation_X = 10;
			this.bt_WriteChange.TextLocation_Y = 2;
			this.bt_WriteChange.UseVisualStyleBackColor = true;
			this.bt_WriteChange.Click += new System.EventHandler(this.bt_WriteChange_Click);
			// 
			// fc_Query
			// 
			this.fc_Query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fc_Query.AutoCompleteBrackets = true;
			this.fc_Query.AutoCompleteBracketsList = new char[] {
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
			this.fc_Query.AutoScrollMinSize = new System.Drawing.Size(371, 18);
			this.fc_Query.BackBrush = null;
			this.fc_Query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.fc_Query.BorderColor = System.Drawing.Color.Empty;
			this.fc_Query.CharHeight = 18;
			this.fc_Query.CharWidth = 10;
			this.fc_Query.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fc_Query.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.fc_Query.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.fc_Query.ForeColor = System.Drawing.Color.White;
			this.fc_Query.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.fc_Query.IsReplaceMode = false;
			this.fc_Query.Location = new System.Drawing.Point(0, 118);
			this.fc_Query.Margin = new System.Windows.Forms.Padding(10);
			this.fc_Query.Name = "fc_Query";
			this.fc_Query.Paddings = new System.Windows.Forms.Padding(0);
			this.fc_Query.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.fc_Query.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fc_Query.ServiceColors")));
			this.fc_Query.ServiceLinesColor = System.Drawing.Color.DimGray;
			this.fc_Query.Size = new System.Drawing.Size(500, 98);
			this.fc_Query.TabIndex = 37;
			this.fc_Query.Text = "Select * from \'HistoryTransaction\'";
			this.fc_Query.Zoom = 100;
			// 
			// bt_Delete
			// 
			this.bt_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Delete.BorderLeft = false;
			this.bt_Delete.BZBackColor = System.Drawing.Color.Teal;
			this.bt_Delete.DisplayText = "Delete Rows Select";
			this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Delete.ForeColor = System.Drawing.Color.White;
			this.bt_Delete.Location = new System.Drawing.Point(508, 178);
			this.bt_Delete.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
			this.bt_Delete.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
			this.bt_Delete.Name = "bt_Delete";
			this.bt_Delete.NotchangeAfterMouseUP = false;
			this.bt_Delete.Size = new System.Drawing.Size(148, 24);
			this.bt_Delete.TabIndex = 35;
			this.bt_Delete.Text = "Delete Rows Select";
			this.bt_Delete.TextLocation_X = 15;
			this.bt_Delete.TextLocation_Y = 2;
			this.bt_Delete.UseVisualStyleBackColor = true;
			this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
			// 
			// bt_Refresh
			// 
			this.bt_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Refresh.BorderLeft = false;
			this.bt_Refresh.BZBackColor = System.Drawing.Color.Teal;
			this.bt_Refresh.DisplayText = "Execute Reader";
			this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Refresh.ForeColor = System.Drawing.Color.White;
			this.bt_Refresh.Location = new System.Drawing.Point(508, 118);
			this.bt_Refresh.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
			this.bt_Refresh.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
			this.bt_Refresh.Name = "bt_Refresh";
			this.bt_Refresh.NotchangeAfterMouseUP = false;
			this.bt_Refresh.Size = new System.Drawing.Size(148, 24);
			this.bt_Refresh.TabIndex = 34;
			this.bt_Refresh.Text = "Execute Reader";
			this.bt_Refresh.TextLocation_X = 10;
			this.bt_Refresh.TextLocation_Y = 2;
			this.bt_Refresh.UseVisualStyleBackColor = true;
			this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
			// 
			// gridView
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView.Location = new System.Drawing.Point(0, 218);
			this.gridView.Name = "gridView";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridView.RowHeadersVisible = false;
			this.gridView.RowHeadersWidth = 51;
			this.gridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
			this.gridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.gridView.RowTemplate.Height = 24;
			this.gridView.Size = new System.Drawing.Size(673, 373);
			this.gridView.TabIndex = 33;
			// 
			// prb_Process
			// 
			this.prb_Process.CustomText = "Export start..";
			this.prb_Process.Location = new System.Drawing.Point(17, 77);
			this.prb_Process.Maximum = 1000;
			this.prb_Process.Name = "prb_Process";
			this.prb_Process.ProgressColor = this.btn_Import.BZBackColor;
			this.prb_Process.Size = new System.Drawing.Size(0, 28);
			this.prb_Process.Step = 1;
			this.prb_Process.TabIndex = 0;
			this.prb_Process.TextColor = System.Drawing.Color.White;
			this.prb_Process.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			this.prb_Process.ValueF = 0F;
			this.prb_Process.VisualMode = Transaction_Statistical.ProgressBarDisplayMode.TextAndPercentage;
			// 
			// btn_Import
			// 
			this.btn_Import.BorderLeft = false;
			this.btn_Import.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
			this.btn_Import.DisplayText = "Import";
			this.btn_Import.Enabled = false;
			this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Import.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Import.ForeColor = System.Drawing.Color.White;
			this.btn_Import.Location = new System.Drawing.Point(17, 77);
			this.btn_Import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Import.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
			this.btn_Import.MouseHoverColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_Import.Name = "btn_Import";
			this.btn_Import.NotchangeAfterMouseUP = false;
			this.btn_Import.Size = new System.Drawing.Size(567, 28);
			this.btn_Import.TabIndex = 30;
			this.btn_Import.Text = "Import";
			this.btn_Import.TextLocation_X = 180;
			this.btn_Import.TextLocation_Y = -3;
			this.btn_Import.UseVisualStyleBackColor = true;
			this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
			// 
			// cb_Bank
			// 
			this.cb_Bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_Bank.BorderColor = System.Drawing.Color.Blue;
			this.cb_Bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Bank.ForeColor = System.Drawing.Color.White;
			this.cb_Bank.FormattingEnabled = true;
			this.cb_Bank.Location = new System.Drawing.Point(135, 18);
			this.cb_Bank.Name = "cb_Bank";
			this.cb_Bank.Size = new System.Drawing.Size(334, 24);
			this.cb_Bank.TabIndex = 26;
			this.cb_Bank.SelectedValueChanged += new System.EventHandler(this.cb_Bank_SelectedValueChanged);
			// 
			// mode_Label8
			// 
			this.mode_Label8.AutoSize = true;
			this.mode_Label8.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label8.ForeColor = System.Drawing.Color.White;
			this.mode_Label8.Location = new System.Drawing.Point(89, 21);
			this.mode_Label8.Name = "mode_Label8";
			this.mode_Label8.Size = new System.Drawing.Size(40, 17);
			this.mode_Label8.TabIndex = 27;
			this.mode_Label8.Text = "Bank";
			// 
			// mode_Label1
			// 
			this.mode_Label1.AutoSize = true;
			this.mode_Label1.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label1.ForeColor = System.Drawing.Color.White;
			this.mode_Label1.Location = new System.Drawing.Point(66, 51);
			this.mode_Label1.Name = "mode_Label1";
			this.mode_Label1.Size = new System.Drawing.Size(63, 17);
			this.mode_Label1.TabIndex = 29;
			this.mode_Label1.Text = "Terminal";
			// 
			// cb_Terminal
			// 
			this.cb_Terminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_Terminal.BorderColor = System.Drawing.Color.Blue;
			this.cb_Terminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Terminal.ForeColor = System.Drawing.Color.White;
			this.cb_Terminal.FormattingEnabled = true;
			this.cb_Terminal.Location = new System.Drawing.Point(135, 48);
			this.cb_Terminal.Name = "cb_Terminal";
			this.cb_Terminal.Size = new System.Drawing.Size(334, 24);
			this.cb_Terminal.TabIndex = 28;
			// 
			// tre_LstTrans
			// 
			this.tre_LstTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tre_LstTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.tre_LstTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tre_LstTrans.CheckBoxes = true;
			this.tre_LstTrans.Controls.Add(this.uc_Search);
			this.tre_LstTrans.ForeColor = System.Drawing.Color.White;
			this.tre_LstTrans.Location = new System.Drawing.Point(0, 0);
			this.tre_LstTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tre_LstTrans.Name = "tre_LstTrans";
			this.tre_LstTrans.ShowNodeToolTips = true;
			this.tre_LstTrans.Size = new System.Drawing.Size(640, 597);
			this.tre_LstTrans.TabIndex = 9;
			this.tre_LstTrans.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tre_LstTrans_AfterCheck);
			this.tre_LstTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tre_LstTrans_KeyPress);
			// 
			// uc_Search
			// 
			this.uc_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.uc_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.uc_Search.Location = new System.Drawing.Point(-580, 560);
			this.uc_Search.Name = "uc_Search";
			this.uc_Search.Size = new System.Drawing.Size(611, 26);
			this.uc_Search.TabIndex = 0;
			// 
			// UC_ImportTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.tre_LstTrans);
			this.Name = "UC_ImportTransaction";
			this.Size = new System.Drawing.Size(1352, 597);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fc_Query)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.tre_LstTrans.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Mode_TreeView tre_LstTrans;
		private UC_Search uc_Search;
		private Mode_ComboBox cb_Bank;
		private Mode_Label mode_Label8;
		private Mode_ComboBox cb_Terminal;
		private Mode_Label mode_Label1;
		private AddOn.ButtonZ btn_Import;
		private TextProgressBar prb_Process;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private Mode_Label bt_CloseInfo;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Mode_DataGridView gridView;
		private AddOn.ButtonZ bt_Delete;
		private AddOn.ButtonZ bt_Refresh;
		private Mode_FastColoredTextBox fc_Query;
		private AddOn.ButtonZ bt_WriteChange;
	}
}
