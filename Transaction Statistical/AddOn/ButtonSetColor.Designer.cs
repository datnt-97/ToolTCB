namespace Transaction_Statistical.AddOn
{
    partial class ButtonSetColor
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
			this.pn_Color = new System.Windows.Forms.Panel();
			this.lb_Display = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pn_Color
			// 
			this.pn_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pn_Color.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pn_Color.Dock = System.Windows.Forms.DockStyle.Left;
			this.pn_Color.Location = new System.Drawing.Point(0, 0);
			this.pn_Color.Name = "pn_Color";
			this.pn_Color.Size = new System.Drawing.Size(30, 20);
			this.pn_Color.TabIndex = 0;
			this.pn_Color.Click += new System.EventHandler(this.pn_Color_Click);
			// 
			// lb_Display
			// 
			this.lb_Display.AutoSize = true;
			this.lb_Display.Dock = System.Windows.Forms.DockStyle.Left;
			this.lb_Display.ForeColor = System.Drawing.Color.White;
			this.lb_Display.Location = new System.Drawing.Point(30, 0);
			this.lb_Display.Name = "lb_Display";
			this.lb_Display.Size = new System.Drawing.Size(41, 17);
			this.lb_Display.TabIndex = 1;
			this.lb_Display.Text = "Color";
			this.lb_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lb_Display.TextChanged += new System.EventHandler(this.lb_Display_TextChanged);
			// 
			// ButtonSetColor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lb_Display);
			this.Controls.Add(this.pn_Color);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "ButtonSetColor";
			this.Size = new System.Drawing.Size(80, 20);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Color;
        private System.Windows.Forms.Label lb_Display;
    }
}
