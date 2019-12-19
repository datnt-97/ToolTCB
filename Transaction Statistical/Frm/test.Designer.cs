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
            this.checkedComboBox3 = new Transaction_Statistical.CheckedComboBox();
            this.SuspendLayout();
            // 
            // checkedComboBox3
            // 
            this.checkedComboBox3.CheckOnClick = true;
            this.checkedComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.checkedComboBox3.DropDownHeight = 1;
            this.checkedComboBox3.FormattingEnabled = true;
            this.checkedComboBox3.IntegralHeight = false;
            this.checkedComboBox3.Location = new System.Drawing.Point(172, 72);
            this.checkedComboBox3.Name = "checkedComboBox3";
            this.checkedComboBox3.Size = new System.Drawing.Size(426, 23);
            this.checkedComboBox3.TabIndex = 2;
            this.checkedComboBox3.ValueSeparator = ", ";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedComboBox3);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedComboBox checkedComboBox3;
    }
}