namespace Transaction_Statistical
{
    partial class UC_Info
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
        private void InitializeComponent2()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Info));
            this.OkCustom = new Transaction_Statistical.Mode_Button();
            this.btn_Save = new Transaction_Statistical.Mode_Button();
            this.TextCustom = new Transaction_Statistical.Mode_FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // OkCustom
            // 
            this.OkCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
             this.OkCustom.AutoSize = false;
            this.OkCustom.Location = new System.Drawing.Point(438, 489);
            this.OkCustom.Name = "OkCustom";
            this.OkCustom.Size = new System.Drawing.Size(105, 31);
            this.OkCustom.TabIndex = 7;
            this.OkCustom.Text = "OK";
            this.OkCustom.Click += new System.EventHandler(this.OkCustom_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.AutoSize = false;
            this.btn_Save.Location = new System.Drawing.Point(327, 489);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 31);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // TextCustom
            // 
            this.TextCustom.BackColor = InitGUI.Custom.Editor_Background.DisplayColor;
            this.TextCustom.ForeColor = InitGUI.Custom.Editor_ForeColor.DisplayColor;
            this.TextCustom.AllowSeveralTextStyleDrawing = true;
            this.TextCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextCustom.AutoCompleteBracketsList = new char[] {
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
            this.TextCustom.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.TextCustom.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.TextCustom.BackBrush = null;
            this.TextCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextCustom.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.TextCustom.CharHeight = 18;
            this.TextCustom.CharWidth = 10;
            this.TextCustom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextCustom.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));     
            this.TextCustom.IsReplaceMode = false;
            this.TextCustom.Language = FastColoredTextBoxNS.Language.CSharp;
            this.TextCustom.LeftBracket = '(';
            this.TextCustom.LeftBracket2 = '{';
            this.TextCustom.Location = new System.Drawing.Point(0, 0);
            this.TextCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextCustom.Name = "TextCustom";
            this.TextCustom.Paddings = new System.Windows.Forms.Padding(0);
            this.TextCustom.RightBracket = ')';
            this.TextCustom.RightBracket2 = '}';
            this.TextCustom.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TextCustom.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("TextCustom.ServiceColors")));
            this.TextCustom.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.TextCustom.Size = new System.Drawing.Size(1018, 485);
            this.TextCustom.TabIndex = 9;
            this.TextCustom.WordWrap = true;
            this.TextCustom.Zoom = 100;
            this.TextCustom.ShowLineNumbers = false;
            // 
            // UC_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.Controls.Add(this.TextCustom);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.OkCustom);
            this.Name = "UC_Info";
            this.Size = new System.Drawing.Size(1020, 529);
            ((System.ComponentModel.ISupportInitialize)(this.TextCustom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Mode_Button OkCustom;
        private Mode_Button btn_Save;
        public Mode_FastColoredTextBox TextCustom;
    }
}
