namespace Transaction_Statistical.UControl
{
    partial class UC_Menu_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Menu_History));
            this.fctxt_Pattern = new FastColoredTextBoxNS.FastColoredTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cbo_Keyword_LstKeyword = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Pattern)).BeginInit();
            this.SuspendLayout();
            // 
            // fctxt_Pattern
            // 
            this.fctxt_Pattern.AllowSeveralTextStyleDrawing = true;
            this.fctxt_Pattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctxt_Pattern.AutoCompleteBracketsList = new char[] {
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
            this.fctxt_Pattern.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fctxt_Pattern.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.fctxt_Pattern.BackBrush = null;
            this.fctxt_Pattern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.fctxt_Pattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctxt_Pattern.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctxt_Pattern.CharHeight = 18;
            this.fctxt_Pattern.CharWidth = 10;
            this.fctxt_Pattern.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctxt_Pattern.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctxt_Pattern.ForeColor = System.Drawing.Color.White;
            this.fctxt_Pattern.IndentBackColor = System.Drawing.Color.DimGray;
            this.fctxt_Pattern.IsReplaceMode = false;
            this.fctxt_Pattern.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctxt_Pattern.LeftBracket = '(';
            this.fctxt_Pattern.LeftBracket2 = '{';
            this.fctxt_Pattern.Location = new System.Drawing.Point(3, 197);
            this.fctxt_Pattern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fctxt_Pattern.Name = "fctxt_Pattern";
            this.fctxt_Pattern.Paddings = new System.Windows.Forms.Padding(0);
            this.fctxt_Pattern.RightBracket = ')';
            this.fctxt_Pattern.RightBracket2 = '}';
            this.fctxt_Pattern.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctxt_Pattern.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctxt_Pattern.ServiceColors")));
            this.fctxt_Pattern.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.fctxt_Pattern.ShowLineNumbers = false;
            this.fctxt_Pattern.Size = new System.Drawing.Size(926, 368);
            this.fctxt_Pattern.TabIndex = 2;
            this.fctxt_Pattern.WordWrap = true;
            this.fctxt_Pattern.Zoom = 100;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(926, 142);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 650;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AutoSize = true;
            this.btn_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(824, 150);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(105, 31);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cbo_Keyword_LstKeyword
            // 
            this.cbo_Keyword_LstKeyword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_Keyword_LstKeyword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_Keyword_LstKeyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbo_Keyword_LstKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Keyword_LstKeyword.ForeColor = System.Drawing.Color.White;
            this.cbo_Keyword_LstKeyword.FormattingEnabled = true;
            this.cbo_Keyword_LstKeyword.Location = new System.Drawing.Point(3, 157);
            this.cbo_Keyword_LstKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Keyword_LstKeyword.Name = "cbo_Keyword_LstKeyword";
            this.cbo_Keyword_LstKeyword.Size = new System.Drawing.Size(431, 24);
            this.cbo_Keyword_LstKeyword.Sorted = true;
            this.cbo_Keyword_LstKeyword.TabIndex = 17;
            // 
            // UC_Menu_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.cbo_Keyword_LstKeyword);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fctxt_Pattern);
            this.Name = "UC_Menu_History";
            this.Size = new System.Drawing.Size(932, 568);
            this.Load += new System.EventHandler(this.UC_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Pattern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctxt_Pattern;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cbo_Keyword_LstKeyword;
    }
}
