namespace Transaction_Statistical.UControl
{
    partial class UC_Feedback
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
            this.bt_Send = new Transaction_Statistical.Mode_Button();
            this.cp_Editor = new Transaction_Statistical.Mode_Panel();
            this.txt_Title = new Transaction_Statistical.Mode_TextBox();
            this.lb_Title = new Transaction_Statistical.Mode_Label();
            this.txt_From = new Transaction_Statistical.Mode_TextBox();
            this.lb_From = new Transaction_Statistical.Mode_Label();
            this.SuspendLayout();
            // 
            // bt_Send
            // 
            this.bt_Send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bt_Send.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt_Send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(215)))));
            this.bt_Send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Send.ForeColor = System.Drawing.Color.White;
            this.bt_Send.Location = new System.Drawing.Point(305, 444);
            this.bt_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(131, 33);
            this.bt_Send.TabIndex = 6;
            this.bt_Send.Text = "Send Feedback";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // cp_Editor
            // 
            this.cp_Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cp_Editor.BackColor = System.Drawing.Color.Transparent;
            this.cp_Editor.BorderColor = System.Drawing.Color.Aqua;
            this.cp_Editor.ForeColor = System.Drawing.Color.White;
            this.cp_Editor.Location = new System.Drawing.Point(18, 81);
            this.cp_Editor.Name = "cp_Editor";
            this.cp_Editor.Size = new System.Drawing.Size(750, 358);
            this.cp_Editor.TabIndex = 5;
            // 
            // txt_Title
            // 
            this.txt_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_Title.ForeColor = System.Drawing.Color.White;
            this.txt_Title.Location = new System.Drawing.Point(61, 39);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(464, 22);
            this.txt_Title.TabIndex = 4;
            this.txt_Title.Text = "Transaction Read/Export/Scheduler";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.lb_Title.ForeColor = System.Drawing.Color.Black;
            this.lb_Title.Location = new System.Drawing.Point(15, 42);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(35, 17);
            this.lb_Title.TabIndex = 3;
            this.lb_Title.Text = "Title";
            // 
            // txt_From
            // 
            this.txt_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_From.ForeColor = System.Drawing.Color.White;
            this.txt_From.Location = new System.Drawing.Point(61, 11);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(464, 22);
            this.txt_From.TabIndex = 1;
            this.txt_From.Text = "Company/Name/Email/Phone";
            // 
            // lb_From
            // 
            this.lb_From.AutoSize = true;
            this.lb_From.BackColor = System.Drawing.Color.Transparent;
            this.lb_From.ForeColor = System.Drawing.Color.Black;
            this.lb_From.Location = new System.Drawing.Point(15, 14);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(40, 17);
            this.lb_From.TabIndex = 0;
            this.lb_From.Text = "From";
            // 
            // UC_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.cp_Editor);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.lb_From);
            this.Name = "UC_Feedback";
            this.Size = new System.Drawing.Size(789, 490);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mode_Label lb_From;
        private Mode_TextBox txt_From;
        private Mode_TextBox txt_Title;
        private Mode_Label lb_Title;
        private Mode_Panel cp_Editor;
        private Mode_Button bt_Send;
    }
}
