namespace FastColoredTextBoxNS
{
    partial class FindForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFind = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(56, 37);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(317, 22);
            this.tbFind.TabIndex = 0;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbFind);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbFind;
    }
}