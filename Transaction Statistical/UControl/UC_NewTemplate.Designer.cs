namespace Transaction_Statistical.UControl
{
    partial class UC_NewTemplate
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
            this.label1 = new Mode_Label();
            this.txt_Name = new Mode_TextBox();
            this.label2 = new Mode_Label();
            this.cbo_Template = new Mode_ComboBox();
            this.btn_Create = new Mode_Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(97, 9);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(233, 22);
            this.txt_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copy from";
            // 
            // cbo_Template
            // 
            this.cbo_Template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Template.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Template.FormattingEnabled = true;
            this.cbo_Template.Location = new System.Drawing.Point(97, 41);
            this.cbo_Template.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Template.Name = "cbo_Template";
            this.cbo_Template.Size = new System.Drawing.Size(233, 24);
            this.cbo_Template.Sorted = true;
            this.cbo_Template.TabIndex = 16;
            // 
            // btn_Create
            // 
            this.btn_Create.AutoSize = true;
            this.btn_Create.Location = new System.Drawing.Point(135, 80);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(105, 31);
            this.btn_Create.TabIndex = 17;
            this.btn_Create.Text = "Create";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // UC_NewTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.cbo_Template);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Name = "UC_NewTemplate";
            this.Size = new System.Drawing.Size(366, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mode_Label label1;
        private Mode_TextBox txt_Name;
        private Mode_Label label2;
        private Mode_ComboBox cbo_Template;
        private Mode_Button btn_Create;
    }
}
