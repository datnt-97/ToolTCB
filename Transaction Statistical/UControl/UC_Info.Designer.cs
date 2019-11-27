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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Info));
            this.TextCustom = new FastColoredTextBoxNS.FastColoredTextBox();
            this.OkCustom = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // TextCustom
            // 
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
            this.TextCustom.AutoScrollMinSize = new System.Drawing.Size(2, 18);
            this.TextCustom.BackBrush = null;
            this.TextCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextCustom.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.TextCustom.CharHeight = 18;
            this.TextCustom.CharWidth = 10;
            this.TextCustom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextCustom.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextCustom.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TextCustom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TextCustom.IndentBackColor = System.Drawing.Color.DimGray;
            this.TextCustom.IsReplaceMode = false;
            this.TextCustom.Language = FastColoredTextBoxNS.Language.CSharp;
            this.TextCustom.LeftBracket = '(';
            this.TextCustom.LeftBracket2 = '{';
            this.TextCustom.Location = new System.Drawing.Point(0, 0);
            this.TextCustom.Name = "TextCustom";
            this.TextCustom.Paddings = new System.Windows.Forms.Padding(0);
            this.TextCustom.RightBracket = ')';
            this.TextCustom.RightBracket2 = '}';
            this.TextCustom.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TextCustom.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("TextCustom.ServiceColors")));
            this.TextCustom.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.TextCustom.ShowLineNumbers = false;
            this.TextCustom.Size = new System.Drawing.Size(1020, 483);
            this.TextCustom.TabIndex = 1;
            this.TextCustom.Zoom = 100;
            // 
            // OkCustom
            // 
            this.OkCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OkCustom.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.OkCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.OkCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.OkCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkCustom.ForeColor = System.Drawing.Color.White;
            this.OkCustom.Location = new System.Drawing.Point(438, 489);
            this.OkCustom.Name = "OkCustom";
            this.OkCustom.Size = new System.Drawing.Size(105, 31);
            this.OkCustom.TabIndex = 7;
            this.OkCustom.Text = "OK";
            this.OkCustom.UseVisualStyleBackColor = true;
            this.OkCustom.Click += new System.EventHandler(this.OkCustom_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(327, 489);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 31);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // UC_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.OkCustom);
            this.Controls.Add(this.TextCustom);
            this.Name = "UC_Info";
            this.Size = new System.Drawing.Size(1020, 529);
            ((System.ComponentModel.ISupportInitialize)(this.TextCustom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public FastColoredTextBoxNS.FastColoredTextBox TextCustom;
        private System.Windows.Forms.Button OkCustom;
        private System.Windows.Forms.Button btn_Save;
    }
}
