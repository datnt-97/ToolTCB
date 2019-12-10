namespace Transaction_Statistical.UControl
{
    partial class UC_ExportCus
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
            this.label7 = new System.Windows.Forms.Label();
            this.ckbl_Forms = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.chb_Open = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Forms select";
            // 
            // ckbl_Forms
            // 
            this.ckbl_Forms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ckbl_Forms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ckbl_Forms.CheckOnClick = true;
            this.ckbl_Forms.ForeColor = System.Drawing.Color.White;
            this.ckbl_Forms.FormattingEnabled = true;
            this.ckbl_Forms.Location = new System.Drawing.Point(156, 40);
            this.ckbl_Forms.Name = "ckbl_Forms";
            this.ckbl_Forms.Size = new System.Drawing.Size(560, 87);
            this.ckbl_Forms.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Export destination";
            // 
            // txt_Destination
            // 
            this.txt_Destination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Destination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_Destination.BackColor = System.Drawing.Color.DimGray;
            this.txt_Destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Destination.ForeColor = System.Drawing.Color.White;
            this.txt_Destination.Location = new System.Drawing.Point(156, 12);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(560, 22);
            this.txt_Destination.TabIndex = 28;
            this.txt_Destination.Text = "D:\\Export";
            // 
            // btn_Export
            // 
            this.btn_Export.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(351, 133);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(105, 42);
            this.btn_Export.TabIndex = 33;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // chb_Open
            // 
            this.chb_Open.AutoSize = true;
            this.chb_Open.Checked = true;
            this.chb_Open.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_Open.ForeColor = System.Drawing.Color.White;
            this.chb_Open.Location = new System.Drawing.Point(581, 145);
            this.chb_Open.Name = "chb_Open";
            this.chb_Open.Size = new System.Drawing.Size(135, 21);
            this.chb_Open.TabIndex = 34;
            this.chb_Open.Text = "Open after finish";
            this.chb_Open.UseVisualStyleBackColor = true;
            // 
            // UC_ExportCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.chb_Open);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ckbl_Forms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Destination);
            this.Name = "UC_ExportCus";
            this.Size = new System.Drawing.Size(751, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Export;
        public System.Windows.Forms.CheckedListBox ckbl_Forms;
        public System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.CheckBox chb_Open;
    }
}
