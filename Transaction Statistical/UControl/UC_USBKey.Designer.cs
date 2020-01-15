namespace Transaction_Statistical.UControl
{
    partial class UC_USBKey
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
        private void InitializeComponent2()
        {
            this.mode_GroupBox1 = new Transaction_Statistical.Mode_GroupBox();
            this.SuspendLayout();
            // 
            // mode_GroupBox1
            // 
            this.mode_GroupBox1.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.mode_GroupBox1.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.mode_GroupBox1.Location = new System.Drawing.Point(14, 16);
            this.mode_GroupBox1.Name = "mode_GroupBox1";
            this.mode_GroupBox1.Size = new System.Drawing.Size(296, 191);
            this.mode_GroupBox1.TabIndex = 0;
            this.mode_GroupBox1.TabStop = false;
            this.mode_GroupBox1.Text = "List USB Device";
            // 
            // UC_USBKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mode_GroupBox1);
            this.Name = "UC_USBKey";
            this.Size = new System.Drawing.Size(325, 217);
            this.ResumeLayout(false);

        }

        #endregion

        private Mode_GroupBox mode_GroupBox1;
    }
}
