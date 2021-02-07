namespace Transaction_Statistical.UControl
{
    partial class UC_Search
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
            this.txt_Search = new Transaction_Statistical.Mode_TextBox();
            this.Icon_Search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // mode_TextBox1
            // 
            this.txt_Search.BackColor = InitGUI.Custom.Trans_Background.DisplayColor;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.CausesValidation = false;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = InitGUI.Custom.Trans_Terminal.DisplayColor;
            this.txt_Search.Location = new System.Drawing.Point(1, 0);
            this.txt_Search.Name = "mode_TextBox1";
            this.txt_Search.Size = new System.Drawing.Size(568, 24);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Search_Click);
            // 
            // pictureBox1
            // 
            this.Icon_Search.BackColor = System.Drawing.Color.Transparent;
            this.Icon_Search.BackgroundImage = global::Transaction_Statistical.Properties.Resources.next;
            this.Icon_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Icon_Search.Location = new System.Drawing.Point(584, 0);
            this.Icon_Search.Name = "pictureBox1";
            this.Icon_Search.Size = new System.Drawing.Size(27, 26);
            this.Icon_Search.TabIndex = 17;
            this.Icon_Search.TabStop = false;
            this.Icon_Search.Click += new System.EventHandler(this.Icon_Search_Click);
            this.Icon_Search.MouseLeave += new System.EventHandler(this.btn_MouseLeve);
            this.Icon_Search.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // UC_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Icon_Search);
            this.Controls.Add(this.txt_Search);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(611, 26);
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            InitGUI.Custom.Trans_Background.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Trans_Terminal.OnColorHandler += InitializeComponent_Refresh;
        }
        private void InitializeComponent_Refresh(object sender, System.Drawing.Color e)
        {
            // 
            // mode_TextBox1
            // 
            this.txt_Search.BackColor = TreeTrans.BackColor;
            this.txt_Search.ForeColor = InitGUI.Custom.Trans_Terminal.DisplayColor;
            // 
            // pictureBox1
            // 
            this.Icon_Search.BackColor = System.Drawing.Color.Transparent;
            // 
            // UC_Search
            // 
            this.BackColor = System.Drawing.Color.Transparent;
        }

        #endregion

        private Transaction_Statistical.Mode_TextBox txt_Search;
        private System.Windows.Forms.PictureBox Icon_Search;
    }
}
