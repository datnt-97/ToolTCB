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
            this.bt_MaxButton = new Transaction_Statistical.AddOn.MinMaxButton();
            this.bt_MinButton = new Transaction_Statistical.AddOn.ButtonZ();
            this.bt_Close = new Transaction_Statistical.AddOn.ButtonZ();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlX1 = new Transaction_Statistical.AddOn.TabControlX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.TopPanel.Controls.Add(this.bt_MaxButton);
            this.TopPanel.Controls.Add(this.bt_MinButton);
            this.TopPanel.Controls.Add(this.bt_Close);
            this.TopPanel.Location = new System.Drawing.Point(0, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1333, 30);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // bt_MaxButton
            // 
            this.bt_MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_MaxButton.CFormState = Transaction_Statistical.AddOn.MinMaxButton.CustomFormState.Normal;
            this.bt_MaxButton.DisplayText = "_";
            this.bt_MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_MaxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MaxButton.ForeColor = System.Drawing.Color.White;
            this.bt_MaxButton.Location = new System.Drawing.Point(1253, 0);
            this.bt_MaxButton.MouseClickColor1 = System.Drawing.Color.Silver;
            this.bt_MaxButton.MouseHoverColor = System.Drawing.Color.Gray;
            this.bt_MaxButton.Name = "bt_MaxButton";
            this.bt_MaxButton.Size = new System.Drawing.Size(40, 30);
            this.bt_MaxButton.TabIndex = 5;
            this.bt_MaxButton.Text = "minMaxButton1";
            this.bt_MaxButton.TextLocation_X = 6;
            this.bt_MaxButton.TextLocation_Y = 5;
            this.bt_MaxButton.UseVisualStyleBackColor = true;
            this.bt_MaxButton.Click += new System.EventHandler(this.bt_MaxButton_Click);
            // 
            // bt_MinButton
            // 
            this.bt_MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_MinButton.DisplayText = "_";
            this.bt_MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.bt_MinButton.ForeColor = System.Drawing.Color.White;
            this.bt_MinButton.Location = new System.Drawing.Point(1213, 0);
            this.bt_MinButton.MouseClickColor1 = System.Drawing.Color.Silver;
            this.bt_MinButton.MouseHoverColor = System.Drawing.Color.Gray;
            this.bt_MinButton.Name = "bt_MinButton";
            this.bt_MinButton.Size = new System.Drawing.Size(40, 30);
            this.bt_MinButton.TabIndex = 1;
            this.bt_MinButton.Text = "_";
            this.bt_MinButton.TextLocation_X = 4;
            this.bt_MinButton.TextLocation_Y = -20;
            this.toolTip1.SetToolTip(this.bt_MinButton, "Minimize");
            this.bt_MinButton.UseVisualStyleBackColor = true;
            this.bt_MinButton.Click += new System.EventHandler(this.bt_MinButton_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_Close.DisplayText = "X";
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_Close.ForeColor = System.Drawing.Color.White;
            this.bt_Close.Location = new System.Drawing.Point(1293, 0);
            this.bt_Close.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Close.MouseHoverColor = System.Drawing.Color.Gray;
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(40, 30);
            this.bt_Close.TabIndex = 0;
            this.bt_Close.Text = "X";
            this.bt_Close.TextLocation_X = 6;
            this.bt_Close.TextLocation_Y = 0;
            this.toolTip1.SetToolTip(this.bt_Close, "Close");
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
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
            this.RightPanel.Location = new System.Drawing.Point(1331, 1);
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
            this.BottomPanel.Location = new System.Drawing.Point(2, 530);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1329, 1);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Main_MouseDown);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel TopPanel;
        private AddOn.ButtonZ bt_Close;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private AddOn.MinMaxButton bt_MaxButton;
        private AddOn.ButtonZ bt_MinButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AddOn.TabControlX tabControlX1;
    }
}

