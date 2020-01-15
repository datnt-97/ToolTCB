namespace Transaction_Statistical
{
    partial class UC_Access
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
            this.btn_OK = new Transaction_Statistical.Mode_Button();
            this.txt_PrKey = new Transaction_Statistical.Mode_TextBox();
            this.mode_Label1 = new Transaction_Statistical.Mode_Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_OK.FlatAppearance.BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            this.btn_OK.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_OK.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
            this.btn_OK.Location = new System.Drawing.Point(371, 96);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 27);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_PrKey
            // 
            this.txt_PrKey.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.txt_PrKey.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.txt_PrKey.Location = new System.Drawing.Point(289, 55);
            this.txt_PrKey.Name = "txt_PrKey";
            this.txt_PrKey.Size = new System.Drawing.Size(253, 22);
            this.txt_PrKey.TabIndex = 1;
            this.txt_PrKey.UseSystemPasswordChar = true;
            // 
            // mode_Label1
            // 
            this.mode_Label1.AutoSize = true;
            this.mode_Label1.BackColor = System.Drawing.Color.Transparent;
            this.mode_Label1.ForeColor= InitGUI.Custom.Frm_ForeColor.DisplayColor;
            this.mode_Label1.Location = new System.Drawing.Point(286, 26);
            this.mode_Label1.Name = "mode_Label1";
            this.mode_Label1.Size = new System.Drawing.Size(243, 17);
            this.mode_Label1.TabIndex = 0;
            this.mode_Label1.Text = "Please, input USB Key or Private Key";
            // 
            // UC_Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Transaction_Statistical.Properties.Resources.keys;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_PrKey);
            this.Controls.Add(this.mode_Label1);
            this.DoubleBuffered = true;
            this.Name = "UC_Access";
            this.Size = new System.Drawing.Size(558, 319);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mode_Label mode_Label1;
        private Mode_TextBox txt_PrKey;
        private Mode_Button btn_OK;
    }
}
