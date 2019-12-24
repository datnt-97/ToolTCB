namespace Transaction_Statistical.UControl
{
    partial class UC_Menu_Dashboard
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
            this.SuspendLayout();
            // 
            // UC_Menu_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.Name = "UC_Menu_Dashboard";
            this.Size = new System.Drawing.Size(932, 568);
            this.ResumeLayout(false);
            InitGUI.Custom.Menu_RightBckgd.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_Border.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_ButtonDown.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_ButtonHover.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Menu_Text.OnColorHandler += InitializeComponent_Refresh;
        }
        private void InitializeComponent_Refresh(object sender, System.Drawing.Color e)
        {
            this.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
        }

            #endregion
        }
}
