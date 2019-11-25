namespace Transaction_Statistical
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_MaxButton = new Transaction_Statistical.AddOn.MinMaxButton();
            this.btn_MinButton = new Transaction_Statistical.AddOn.ButtonZ();
            this.btn_Close = new Transaction_Statistical.AddOn.ButtonZ();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlX1 = new Transaction_Statistical.AddOn.TabControlX();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.BackColor = System.Drawing.Color.Blue;
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(1333, 1);
            this.TopBorderPanel.TabIndex = 0;
            this.TopBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseDown);
            this.TopBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseMove);
            this.TopBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseUp);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.btn_MaxButton);
            this.TopPanel.Controls.Add(this.btn_MinButton);
            this.TopPanel.Controls.Add(this.btn_Close);
            this.TopPanel.Location = new System.Drawing.Point(0, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1333, 30);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pictureBox1.BackgroundImage = global::Transaction_Statistical.Properties.Resources.favticon;
            this.pictureBox1.ErrorImage = global::Transaction_Statistical.Properties.Resources.favticon;
            this.pictureBox1.Image = global::Transaction_Statistical.Properties.Resources.favticon;
            this.pictureBox1.InitialImage = global::Transaction_Statistical.Properties.Resources.favticon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_MaxButton
            // 
            this.btn_MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_MaxButton.CFormState = Transaction_Statistical.AddOn.MinMaxButton.CustomFormState.Normal;
            this.btn_MaxButton.DisplayText = "_";
            this.btn_MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MaxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaxButton.ForeColor = System.Drawing.Color.White;
            this.btn_MaxButton.Location = new System.Drawing.Point(1253, 0);
            this.btn_MaxButton.MouseClickColor1 = System.Drawing.Color.Silver;
            this.btn_MaxButton.MouseHoverColor = System.Drawing.Color.Gray;
            this.btn_MaxButton.Name = "btn_MaxButton";
            this.btn_MaxButton.Size = new System.Drawing.Size(40, 30);
            this.btn_MaxButton.TabIndex = 5;
            this.btn_MaxButton.Text = "minMaxButton1";
            this.btn_MaxButton.TextLocation_X = 6;
            this.btn_MaxButton.TextLocation_Y = 5;
            this.btn_MaxButton.UseVisualStyleBackColor = true;
            this.btn_MaxButton.Click += new System.EventHandler(this.bt_MaxButton_Click);
            // 
            // btn_MinButton
            // 
            this.btn_MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_MinButton.DisplayText = "_";
            this.btn_MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn_MinButton.ForeColor = System.Drawing.Color.White;
            this.btn_MinButton.Location = new System.Drawing.Point(1213, 0);
            this.btn_MinButton.MouseClickColor1 = System.Drawing.Color.Silver;
            this.btn_MinButton.MouseHoverColor = System.Drawing.Color.Gray;
            this.btn_MinButton.Name = "btn_MinButton";
            this.btn_MinButton.Size = new System.Drawing.Size(40, 30);
            this.btn_MinButton.TabIndex = 1;
            this.btn_MinButton.Text = "_";
            this.btn_MinButton.TextLocation_X = 4;
            this.btn_MinButton.TextLocation_Y = -20;
            this.toolTip1.SetToolTip(this.btn_MinButton, "Minimize");
            this.btn_MinButton.UseVisualStyleBackColor = true;
            this.btn_MinButton.Click += new System.EventHandler(this.bt_MinButton_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_Close.DisplayText = "X";
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(1293, 0);
            this.btn_Close.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Close.MouseHoverColor = System.Drawing.Color.Gray;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 30);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.TextLocation_X = 6;
            this.btn_Close.TextLocation_Y = 0;
            this.toolTip1.SetToolTip(this.btn_Close, "Close");
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Blue;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 1);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(1, 531);
            this.LeftPanel.TabIndex = 2;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            this.LeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.Blue;
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(1332, 1);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(1, 531);
            this.RightPanel.TabIndex = 3;
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Blue;
            this.BottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(1, 531);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1331, 1);
            this.BottomPanel.TabIndex = 4;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // tabControlX1
            // 
            this.tabControlX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlX1.CtrlPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabControlX1.Location = new System.Drawing.Point(2, 30);
            this.tabControlX1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlX1.MouseClkTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tabControlX1.MouseHrTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.tabControlX1.Name = "tabControlX1";
            this.tabControlX1.RibbonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.tabControlX1.SelTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.tabControlX1.SelTabForeColor = System.Drawing.Color.White;
            this.tabControlX1.Size = new System.Drawing.Size(1329, 496);
            this.tabControlX1.TabIndex = 5;
            this.tabControlX1.TabPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabControlX1.TabSize = new System.Drawing.Size(110, 25);
            this.tabControlX1.UnSelTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabControlX1.UnSelTabForeColor = System.Drawing.Color.White;
            this.tabControlX1.X_TextLoc = 10;
            this.tabControlX1.Y_TextLoc = 5;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1333, 532);
            this.Controls.Add(this.tabControlX1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Statistical";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel TopPanel;
        private AddOn.ButtonZ btn_Close;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private AddOn.MinMaxButton btn_MaxButton;
        private AddOn.ButtonZ btn_MinButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AddOn.TabControlX tabControlX1;
    }
}

