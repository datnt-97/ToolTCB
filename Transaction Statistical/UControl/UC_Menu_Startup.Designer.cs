namespace Transaction_Statistical
{
    partial class UC_Menu_Startup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_Active = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start at";
            // 
            // txt_Source
            // 
            this.txt_Source.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Source.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_Source.BackColor = System.Drawing.Color.DimGray;
            this.txt_Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Source.ForeColor = System.Drawing.Color.White;
            this.txt_Source.Location = new System.Drawing.Point(154, 49);
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(560, 22);
            this.txt_Source.TabIndex = 6;
            this.txt_Source.Text = "D:\\06-NPSS\\Tool_TraSoat\\LOG tech\\LOG tech\\02-10-2019";
            this.txt_Source.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_MouseDown);
            // 
            // txt_Destination
            // 
            this.txt_Destination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Destination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_Destination.BackColor = System.Drawing.Color.DimGray;
            this.txt_Destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Destination.ForeColor = System.Drawing.Color.White;
            this.txt_Destination.Location = new System.Drawing.Point(154, 77);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(560, 22);
            this.txt_Destination.TabIndex = 7;
            this.txt_Destination.Text = "D:\\Export";
            this.toolTip1.SetToolTip(this.txt_Destination, "Ex: D:\\Export\\Transaction_yyyyMMdd.xls");
            this.txt_Destination.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_HH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Apply);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chb_Active);
            this.groupBox1.Controls.Add(this.txt_Destination);
            this.groupBox1.Controls.Add(this.txt_Source);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(25, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 421);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "(HH:mm - 24h)";
            // 
            // txt_HH
            // 
            this.txt_HH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_HH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_HH.BackColor = System.Drawing.Color.DimGray;
            this.txt_HH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HH.ForeColor = System.Drawing.Color.White;
            this.txt_HH.Location = new System.Drawing.Point(154, 21);
            this.txt_HH.MaxLength = 8;
            this.txt_HH.Name = "txt_HH";
            this.txt_HH.Size = new System.Drawing.Size(55, 22);
            this.txt_HH.TabIndex = 18;
            this.txt_HH.Text = "02:00";
            this.txt_HH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_HH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_HH_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Export destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Import Source";
            // 
            // btn_Apply
            // 
            this.btn_Apply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.ForeColor = System.Drawing.Color.White;
            this.btn_Apply.Location = new System.Drawing.Point(742, 57);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(105, 42);
            this.btn_Apply.TabIndex = 15;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(35, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 277);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forms";
            // 
            // chb_Active
            // 
            this.chb_Active.AutoSize = true;
            this.chb_Active.ForeColor = System.Drawing.Color.White;
            this.chb_Active.Location = new System.Drawing.Point(6, -1);
            this.chb_Active.Name = "chb_Active";
            this.chb_Active.Size = new System.Drawing.Size(68, 21);
            this.chb_Active.TabIndex = 0;
            this.chb_Active.Text = "Active";
            this.chb_Active.UseVisualStyleBackColor = true;
            // 
            // UC_Menu_Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Menu_Startup";
            this.Size = new System.Drawing.Size(932, 480);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chb_Active;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HH;
    }
}
