namespace Transaction_Statistical.UControl
{
	partial class UC_ExportOption
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ExportOption));
			this.gridView = new System.Windows.Forms.DataGridView();
			this.Nud_Rows = new System.Windows.Forms.NumericUpDown();
			this.Nud_Colunms = new System.Windows.Forms.NumericUpDown();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.bt_PagePre = new Transaction_Statistical.Mode_Label();
			this.lb_Pages = new Transaction_Statistical.Mode_Label();
			this.bt_PageNext = new Transaction_Statistical.Mode_Label();
			this.mode_GroupBox1 = new Transaction_Statistical.Mode_GroupBox();
			this.bt_Export = new Transaction_Statistical.AddOn.ButtonZ();
			this.mode_Label5 = new Transaction_Statistical.Mode_Label();
			this.mode_Label4 = new Transaction_Statistical.Mode_Label();
			this.lb_infoTable = new Transaction_Statistical.Mode_Label();
			this.cb_ShowEntries = new Transaction_Statistical.Mode_ComboBox();
			this.cb_Wrap = new Transaction_Statistical.Mode_CheckBox();
			this.bt_Execute = new Transaction_Statistical.AddOn.ButtonZ();
			this.fc_Query = new Transaction_Statistical.Mode_FastColoredTextBox();
			this.mode_Label2 = new Transaction_Statistical.Mode_Label();
			this.mode_Label1 = new Transaction_Statistical.Mode_Label();
			this.cb_Sheets = new Transaction_Statistical.Mode_ComboBox();
			this.tb_loadFile = new Transaction_Statistical.Mode_TextBox();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Nud_Rows)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Nud_Colunms)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.mode_GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fc_Query)).BeginInit();
			this.SuspendLayout();
			// 
			// gridView
			// 
			this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView.EnableHeadersVisualStyles = false;
			this.gridView.Location = new System.Drawing.Point(4, 226);
			this.gridView.Margin = new System.Windows.Forms.Padding(4);
			this.gridView.Name = "gridView";
			this.gridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.gridView.Size = new System.Drawing.Size(978, 303);
			this.gridView.TabIndex = 3;
			this.gridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridView_DataError);
			// 
			// Nud_Rows
			// 
			this.Nud_Rows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Nud_Rows.Location = new System.Drawing.Point(205, 531);
			this.Nud_Rows.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.Nud_Rows.Name = "Nud_Rows";
			this.Nud_Rows.Size = new System.Drawing.Size(77, 22);
			this.Nud_Rows.TabIndex = 27;
			this.Nud_Rows.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.Nud_Rows.ValueChanged += new System.EventHandler(this.Nud_Rows_ValueChanged);
			// 
			// Nud_Colunms
			// 
			this.Nud_Colunms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Nud_Colunms.Location = new System.Drawing.Point(74, 531);
			this.Nud_Colunms.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.Nud_Colunms.Name = "Nud_Colunms";
			this.Nud_Colunms.Size = new System.Drawing.Size(77, 22);
			this.Nud_Colunms.TabIndex = 29;
			this.Nud_Colunms.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
			this.Nud_Colunms.ValueChanged += new System.EventHandler(this.Nud_Colunms_ValueChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.flowLayoutPanel1.Controls.Add(this.bt_PagePre);
			this.flowLayoutPanel1.Controls.Add(this.lb_Pages);
			this.flowLayoutPanel1.Controls.Add(this.bt_PageNext);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(510, 534);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 22);
			this.flowLayoutPanel1.TabIndex = 49;
			// 
			// bt_PagePre
			// 
			this.bt_PagePre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bt_PagePre.AutoSize = true;
			this.bt_PagePre.BackColor = System.Drawing.Color.Transparent;
			this.bt_PagePre.Cursor = System.Windows.Forms.Cursors.PanWest;
			this.bt_PagePre.ForeColor = System.Drawing.Color.White;
			this.bt_PagePre.Location = new System.Drawing.Point(3, 0);
			this.bt_PagePre.Name = "bt_PagePre";
			this.bt_PagePre.Size = new System.Drawing.Size(24, 17);
			this.bt_PagePre.TabIndex = 47;
			this.bt_PagePre.Text = "<<";
			this.bt_PagePre.Click += new System.EventHandler(this.bt_PagePre_Click);
			// 
			// lb_Pages
			// 
			this.lb_Pages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_Pages.AutoSize = true;
			this.lb_Pages.BackColor = System.Drawing.Color.Transparent;
			this.lb_Pages.ForeColor = System.Drawing.Color.White;
			this.lb_Pages.Location = new System.Drawing.Point(33, 0);
			this.lb_Pages.Name = "lb_Pages";
			this.lb_Pages.Size = new System.Drawing.Size(16, 17);
			this.lb_Pages.TabIndex = 48;
			this.lb_Pages.Text = "0";
			// 
			// bt_PageNext
			// 
			this.bt_PageNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bt_PageNext.AutoSize = true;
			this.bt_PageNext.BackColor = System.Drawing.Color.Transparent;
			this.bt_PageNext.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.bt_PageNext.ForeColor = System.Drawing.Color.White;
			this.bt_PageNext.Location = new System.Drawing.Point(55, 0);
			this.bt_PageNext.Name = "bt_PageNext";
			this.bt_PageNext.Size = new System.Drawing.Size(24, 17);
			this.bt_PageNext.TabIndex = 46;
			this.bt_PageNext.Text = ">>";
			this.bt_PageNext.Click += new System.EventHandler(this.bt_PageNext_Click);
			// 
			// mode_GroupBox1
			// 
			this.mode_GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mode_GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.mode_GroupBox1.Controls.Add(this.bt_Export);
			this.mode_GroupBox1.ForeColor = System.Drawing.Color.White;
			this.mode_GroupBox1.Location = new System.Drawing.Point(616, 82);
			this.mode_GroupBox1.Name = "mode_GroupBox1";
			this.mode_GroupBox1.Size = new System.Drawing.Size(366, 143);
			this.mode_GroupBox1.TabIndex = 50;
			this.mode_GroupBox1.TabStop = false;
			this.mode_GroupBox1.Text = "Export";
			// 
			// bt_Export
			// 
			this.bt_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Export.BorderLeft = false;
			this.bt_Export.BZBackColor = System.Drawing.Color.Teal;
			this.bt_Export.DisplayText = "Export";
			this.bt_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Export.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Export.ForeColor = System.Drawing.Color.White;
			this.bt_Export.Location = new System.Drawing.Point(6, 113);
			this.bt_Export.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
			this.bt_Export.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
			this.bt_Export.Name = "bt_Export";
			this.bt_Export.NotchangeAfterMouseUP = false;
			this.bt_Export.Size = new System.Drawing.Size(73, 24);
			this.bt_Export.TabIndex = 51;
			this.bt_Export.Text = "Export";
			this.bt_Export.TextLocation_X = 10;
			this.bt_Export.TextLocation_Y = 2;
			this.bt_Export.UseVisualStyleBackColor = true;
			this.bt_Export.Click += new System.EventHandler(this.bt_Export_Click);
			// 
			// mode_Label5
			// 
			this.mode_Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mode_Label5.AutoSize = true;
			this.mode_Label5.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label5.ForeColor = System.Drawing.Color.White;
			this.mode_Label5.Location = new System.Drawing.Point(449, 533);
			this.mode_Label5.Name = "mode_Label5";
			this.mode_Label5.Size = new System.Drawing.Size(51, 17);
			this.mode_Label5.TabIndex = 45;
			this.mode_Label5.Text = "entries";
			// 
			// mode_Label4
			// 
			this.mode_Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mode_Label4.AutoSize = true;
			this.mode_Label4.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label4.ForeColor = System.Drawing.Color.White;
			this.mode_Label4.Location = new System.Drawing.Point(300, 533);
			this.mode_Label4.Name = "mode_Label4";
			this.mode_Label4.Size = new System.Drawing.Size(42, 17);
			this.mode_Label4.TabIndex = 44;
			this.mode_Label4.Text = "Show";
			// 
			// lb_infoTable
			// 
			this.lb_infoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_infoTable.BackColor = System.Drawing.Color.Transparent;
			this.lb_infoTable.ForeColor = System.Drawing.Color.White;
			this.lb_infoTable.Location = new System.Drawing.Point(595, 534);
			this.lb_infoTable.Name = "lb_infoTable";
			this.lb_infoTable.Size = new System.Drawing.Size(379, 16);
			this.lb_infoTable.TabIndex = 43;
			this.lb_infoTable.Text = "Showing 0 to 0 of 0 entries";
			this.lb_infoTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cb_ShowEntries
			// 
			this.cb_ShowEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cb_ShowEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_ShowEntries.BorderColor = System.Drawing.Color.Blue;
			this.cb_ShowEntries.ForeColor = System.Drawing.Color.White;
			this.cb_ShowEntries.FormattingEnabled = true;
			this.cb_ShowEntries.Items.AddRange(new object[] {
            "50",
            "100",
            "500",
            "1000",
            "2000"});
			this.cb_ShowEntries.Location = new System.Drawing.Point(348, 530);
			this.cb_ShowEntries.Name = "cb_ShowEntries";
			this.cb_ShowEntries.Size = new System.Drawing.Size(95, 24);
			this.cb_ShowEntries.TabIndex = 42;
			this.cb_ShowEntries.Text = "50";
			// 
			// cb_Wrap
			// 
			this.cb_Wrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_Wrap.AutoSize = true;
			this.cb_Wrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_Wrap.Checked = true;
			this.cb_Wrap.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cb_Wrap.ForeColor = System.Drawing.Color.White;
			this.cb_Wrap.Location = new System.Drawing.Point(511, 174);
			this.cb_Wrap.Name = "cb_Wrap";
			this.cb_Wrap.Size = new System.Drawing.Size(64, 21);
			this.cb_Wrap.TabIndex = 41;
			this.cb_Wrap.Text = "Wrap";
			this.cb_Wrap.UseVisualStyleBackColor = false;
			this.cb_Wrap.CheckedChanged += new System.EventHandler(this.cb_Wrap_CheckedChanged);
			// 
			// bt_Execute
			// 
			this.bt_Execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Execute.BorderLeft = false;
			this.bt_Execute.BZBackColor = System.Drawing.Color.Teal;
			this.bt_Execute.DisplayText = "Execute";
			this.bt_Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Execute.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Execute.ForeColor = System.Drawing.Color.White;
			this.bt_Execute.Location = new System.Drawing.Point(511, 201);
			this.bt_Execute.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
			this.bt_Execute.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
			this.bt_Execute.Name = "bt_Execute";
			this.bt_Execute.NotchangeAfterMouseUP = false;
			this.bt_Execute.Size = new System.Drawing.Size(73, 24);
			this.bt_Execute.TabIndex = 40;
			this.bt_Execute.Text = "Execute";
			this.bt_Execute.TextLocation_X = 10;
			this.bt_Execute.TextLocation_Y = 2;
			this.bt_Execute.UseVisualStyleBackColor = true;
			this.bt_Execute.Click += new System.EventHandler(this.bt_Execute_Click);
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
			this.fc_Query.AutoScrollMinSize = new System.Drawing.Size(0, 360);
			this.fc_Query.BackBrush = null;
			this.fc_Query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.fc_Query.BorderColor = System.Drawing.Color.Empty;
			this.fc_Query.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fc_Query.CharHeight = 18;
			this.fc_Query.CharWidth = 10;
			this.fc_Query.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fc_Query.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.fc_Query.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.fc_Query.ForeColor = System.Drawing.Color.White;
			this.fc_Query.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.fc_Query.IsReplaceMode = false;
			this.fc_Query.Location = new System.Drawing.Point(7, 82);
			this.fc_Query.Margin = new System.Windows.Forms.Padding(10);
			this.fc_Query.Name = "fc_Query";
			this.fc_Query.Paddings = new System.Windows.Forms.Padding(0);
			this.fc_Query.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.fc_Query.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fc_Query.ServiceColors")));
			this.fc_Query.ServiceLinesColor = System.Drawing.Color.DimGray;
			this.fc_Query.Size = new System.Drawing.Size(500, 143);
			this.fc_Query.TabIndex = 39;
			this.fc_Query.Text = resources.GetString("fc_Query.Text");
			this.fc_Query.WordWrap = true;
			this.fc_Query.Zoom = 100;
			// 
			// mode_Label2
			// 
			this.mode_Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mode_Label2.AutoSize = true;
			this.mode_Label2.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label2.ForeColor = System.Drawing.Color.White;
			this.mode_Label2.Location = new System.Drawing.Point(6, 533);
			this.mode_Label2.Name = "mode_Label2";
			this.mode_Label2.Size = new System.Drawing.Size(62, 17);
			this.mode_Label2.TabIndex = 30;
			this.mode_Label2.Text = "Colunms";
			// 
			// mode_Label1
			// 
			this.mode_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mode_Label1.AutoSize = true;
			this.mode_Label1.BackColor = System.Drawing.Color.Transparent;
			this.mode_Label1.ForeColor = System.Drawing.Color.White;
			this.mode_Label1.Location = new System.Drawing.Point(157, 533);
			this.mode_Label1.Name = "mode_Label1";
			this.mode_Label1.Size = new System.Drawing.Size(42, 17);
			this.mode_Label1.TabIndex = 28;
			this.mode_Label1.Text = "Rows";
			// 
			// cb_Sheets
			// 
			this.cb_Sheets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cb_Sheets.BorderColor = System.Drawing.Color.Blue;
			this.cb_Sheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Sheets.ForeColor = System.Drawing.Color.White;
			this.cb_Sheets.FormattingEnabled = true;
			this.cb_Sheets.Location = new System.Drawing.Point(4, 45);
			this.cb_Sheets.Name = "cb_Sheets";
			this.cb_Sheets.Size = new System.Drawing.Size(259, 24);
			this.cb_Sheets.TabIndex = 26;
			this.cb_Sheets.SelectedIndexChanged += new System.EventHandler(this.cb_Sheets_SelectedIndexChanged);
			// 
			// tb_loadFile
			// 
			this.tb_loadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.tb_loadFile.ForeColor = System.Drawing.Color.White;
			this.tb_loadFile.Location = new System.Drawing.Point(4, 17);
			this.tb_loadFile.Name = "tb_loadFile";
			this.tb_loadFile.Size = new System.Drawing.Size(639, 22);
			this.tb_loadFile.TabIndex = 0;
			this.tb_loadFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_loadFile_MouseClick);
			// 
			// UC_ExportOption
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.Controls.Add(this.mode_GroupBox1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.mode_Label5);
			this.Controls.Add(this.mode_Label4);
			this.Controls.Add(this.lb_infoTable);
			this.Controls.Add(this.cb_ShowEntries);
			this.Controls.Add(this.cb_Wrap);
			this.Controls.Add(this.bt_Execute);
			this.Controls.Add(this.fc_Query);
			this.Controls.Add(this.mode_Label2);
			this.Controls.Add(this.Nud_Colunms);
			this.Controls.Add(this.mode_Label1);
			this.Controls.Add(this.Nud_Rows);
			this.Controls.Add(this.cb_Sheets);
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.tb_loadFile);
			this.Name = "UC_ExportOption";
			this.Size = new System.Drawing.Size(986, 557);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Nud_Rows)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Nud_Colunms)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.mode_GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fc_Query)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mode_TextBox tb_loadFile;
		private System.Windows.Forms.DataGridView gridView;
		private Mode_ComboBox cb_Sheets;
		private System.Windows.Forms.NumericUpDown Nud_Rows;
		private Mode_Label mode_Label1;
		private Mode_Label mode_Label2;
		private System.Windows.Forms.NumericUpDown Nud_Colunms;
		private Mode_FastColoredTextBox fc_Query;
		private AddOn.ButtonZ bt_Execute;
		private Mode_CheckBox cb_Wrap;
		private Mode_ComboBox cb_ShowEntries;
		private Mode_Label lb_infoTable;
		private Mode_Label mode_Label4;
		private Mode_Label mode_Label5;
		private Mode_Label bt_PageNext;
		private Mode_Label bt_PagePre;
		private Mode_Label lb_Pages;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private Mode_GroupBox mode_GroupBox1;
		private AddOn.ButtonZ bt_Export;
	}
}
