namespace Transaction_Statistical.Frm
{
    partial class test
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
            this.buttonZ1 = new Transaction_Statistical.AddOn.ButtonZ();
            this.buttonX1 = new Transaction_Statistical.AddOn.ButtonX();
            this.buttonX2 = new Transaction_Statistical.AddOn.ButtonX();
            this.SuspendLayout();
            // 
            // buttonZ1
            // 
            this.buttonZ1.BZBackColor = System.Drawing.Color.Teal;
            this.buttonZ1.DisplayText = "buttonZ1";
            this.buttonZ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ1.ForeColor = System.Drawing.Color.White;
            this.buttonZ1.Location = new System.Drawing.Point(451, 125);
            this.buttonZ1.MouseClickColor1 = System.Drawing.Color.CornflowerBlue;
            this.buttonZ1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.buttonZ1.Name = "buttonZ1";
            this.buttonZ1.Size = new System.Drawing.Size(178, 130);
            this.buttonZ1.TabIndex = 1;
            this.buttonZ1.Text = "buttonZ1";
            this.buttonZ1.TextLocation_X = 6;
            this.buttonZ1.TextLocation_Y = -20;
            this.buttonZ1.UseVisualStyleBackColor = true;
            this.buttonZ1.BackColorChanged += new System.EventHandler(this.buttonZ1_BackColorChanged);
            this.buttonZ1.Click += new System.EventHandler(this.buttonZ1_Click);
            this.buttonZ1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonZ1_MouseClick);
            // 
            // buttonX1
            // 
            this.buttonX1.BXBackColor = System.Drawing.Color.Teal;
            this.buttonX1.ChangeColorMouseHC = true;
            this.buttonX1.DisplayText = "buttonX1";
            this.buttonX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX1.ForeColor = System.Drawing.Color.White;
            this.buttonX1.Location = new System.Drawing.Point(572, 330);
            this.buttonX1.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.buttonX1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(31, 24);
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "buttonX1";
            this.buttonX1.TextLocation_X = 6;
            this.buttonX1.TextLocation_Y = -20;
            this.buttonX1.UseVisualStyleBackColor = true;
            // 
            // buttonX2
            // 
            this.buttonX2.BXBackColor = System.Drawing.Color.Teal;
            this.buttonX2.ChangeColorMouseHC = true;
            this.buttonX2.DisplayText = "buttonX2";
            this.buttonX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX2.ForeColor = System.Drawing.Color.White;
            this.buttonX2.Location = new System.Drawing.Point(157, 255);
            this.buttonX2.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.buttonX2.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.ShowCloseButton = true;
            this.buttonX2.Size = new System.Drawing.Size(31, 24);
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "buttonX2";
            this.buttonX2.TextLocation_X = 6;
            this.buttonX2.TextLocation_Y = -20;
            this.buttonX2.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonZ1);
            this.Controls.Add(this.buttonX1);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private AddOn.ButtonX buttonX1;
        private AddOn.ButtonZ buttonZ1;
        private AddOn.ButtonX buttonX2;
    }
}