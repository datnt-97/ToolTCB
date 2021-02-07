namespace Transaction_Statistical
{
    partial class Frm_TemplateDefault
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
        private void InitializeComponent(string tilte)
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TemplateDefault));
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.titleCustom = new System.Windows.Forms.Label();
            this.iconCustom = new System.Windows.Forms.PictureBox();
            this.maxBtnCustom = new Transaction_Statistical.AddOn.MinMaxButton();
            this.minBtnCustom = new Transaction_Statistical.AddOn.ButtonZ();
            this.closebtnCustom = new Transaction_Statistical.AddOn.ButtonZ();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.BackColor = InitGUI.Custom.Frm_Border.DisplayColor;
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(800, 1);
            this.TopBorderPanel.TabIndex = 0;
            this.TopBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseDown);
            this.TopBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseMove);
            this.TopBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseUp);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.TopPanel.Controls.Add(this.titleCustom);
            this.TopPanel.Controls.Add(this.iconCustom);
            this.TopPanel.Controls.Add(this.maxBtnCustom);
            this.TopPanel.Controls.Add(this.minBtnCustom);
            this.TopPanel.Controls.Add(this.closebtnCustom);
            this.TopPanel.Location = new System.Drawing.Point(0, 1);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 30);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // titleCustom
            // 
            this.titleCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleCustom.AutoSize = false;
            this.titleCustom.Text = tilte;
            this.titleCustom.BackColor = System.Drawing.Color.Transparent;
            this.titleCustom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCustom.ForeColor = InitGUI.Custom.Frm_TextTilte.DisplayColor;
            this.titleCustom.Name = "titleCustom";
          
            this.titleCustom.TabIndex = 8;
            
            this.titleCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleCustom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.titleCustom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.titleCustom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // iconCustom
            // 
            this.iconCustom.BackColor = System.Drawing.Color.Transparent;
            this.iconCustom.BackgroundImage = global::Transaction_Statistical.Properties.Resources.favticon;
            this.iconCustom.ErrorImage = global::Transaction_Statistical.Properties.Resources.favticon;
            this.iconCustom.Image = global::Transaction_Statistical.Properties.Resources.favticon;
            this.iconCustom.InitialImage = global::Transaction_Statistical.Properties.Resources.favticon;
            this.iconCustom.Location = new System.Drawing.Point(9, 0);
            this.iconCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCustom.Name = "iconCustom";
            this.iconCustom.Size = new System.Drawing.Size(29, 30);
            this.iconCustom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconCustom.TabIndex = 7;
            this.iconCustom.TabStop = false;
            // 
            // maxBtnCustom
            // 
            this.maxBtnCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtnCustom.BZBackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.maxBtnCustom.CFormState = Transaction_Statistical.AddOn.MinMaxButton.CustomFormState.Normal;
            this.maxBtnCustom.DisplayText = "_";
            this.maxBtnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBtnCustom.ForeColor = System.Drawing.Color.White;
            this.maxBtnCustom.Location = new System.Drawing.Point(720, 0);
            this.maxBtnCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxBtnCustom.MouseClickColor1 = System.Drawing.Color.Silver;
            this.maxBtnCustom.MouseHoverColor = System.Drawing.Color.Gray;
            this.maxBtnCustom.Name = "maxBtnCustom";
            this.maxBtnCustom.Size = new System.Drawing.Size(40, 30);
            this.maxBtnCustom.TabIndex = 5;
            this.maxBtnCustom.Text = "minMaxButton1";
            this.maxBtnCustom.TextLocation_X = 6;
            this.maxBtnCustom.TextLocation_Y = 5;
            this.maxBtnCustom.UseVisualStyleBackColor = true;
            this.maxBtnCustom.Click += new System.EventHandler(this.bt_MaxButton_Click);
            // 
            // minBtnCustom
            // 
            this.minBtnCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtnCustom.BorderLeft = false;
            this.minBtnCustom.BZBackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.minBtnCustom.DisplayText = "_";
            this.minBtnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtnCustom.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.minBtnCustom.ForeColor = System.Drawing.Color.White;
            this.minBtnCustom.Location = new System.Drawing.Point(680, 0);
            this.minBtnCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minBtnCustom.MouseClickColor1 = System.Drawing.Color.Silver;
            this.minBtnCustom.MouseHoverColor = System.Drawing.Color.Gray;
            this.minBtnCustom.Name = "minBtnCustom";
            this.minBtnCustom.NotchangeAfterMouseUP = false;
            this.minBtnCustom.Size = new System.Drawing.Size(40, 30);
            this.minBtnCustom.TabIndex = 1;
            this.minBtnCustom.Text = "_";
            this.minBtnCustom.TextLocation_X = 4;
            this.minBtnCustom.TextLocation_Y = -20;
            this.toolTip1.SetToolTip(this.minBtnCustom, "Minimize");
            this.minBtnCustom.UseVisualStyleBackColor = true;
            this.minBtnCustom.Click += new System.EventHandler(this.bt_MinButton_Click);
            // 
            // closebtnCustom
            // 
            this.closebtnCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtnCustom.BorderLeft = false;
            this.closebtnCustom.BZBackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.closebtnCustom.DisplayText = "X";
            this.closebtnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtnCustom.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.closebtnCustom.ForeColor = System.Drawing.Color.White;
            this.closebtnCustom.Location = new System.Drawing.Point(760, 0);
            this.closebtnCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closebtnCustom.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closebtnCustom.MouseHoverColor = System.Drawing.Color.Gray;
            this.closebtnCustom.Name = "closebtnCustom";
            this.closebtnCustom.NotchangeAfterMouseUP = false;
            this.closebtnCustom.Size = new System.Drawing.Size(40, 30);
            this.closebtnCustom.TabIndex = 0;
            this.closebtnCustom.Text = "X";
            this.closebtnCustom.TextLocation_X = 6;
            this.closebtnCustom.TextLocation_Y = 0;
            this.toolTip1.SetToolTip(this.closebtnCustom, "Close");
            this.closebtnCustom.UseVisualStyleBackColor = true;
            this.closebtnCustom.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = InitGUI.Custom.Frm_Border.DisplayColor;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 1);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(1, 599);
            this.LeftPanel.TabIndex = 2;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            this.LeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = InitGUI.Custom.Frm_Border.DisplayColor;
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(799, 1);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(1, 599);
            this.RightPanel.TabIndex = 3;
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = InitGUI.Custom.Frm_Border.DisplayColor;
            this.BottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(1, 599);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(798, 1);
            this.BottomPanel.TabIndex = 4;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Main.Location = new System.Drawing.Point(4, 30);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(792, 563);
            this.pnl_Main.TabIndex = 5;
            this.pnl_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Main_Paint);
            // 
            // Frm_TemplateDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_TemplateDefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Statistical";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCustom)).EndInit();
            this.ResumeLayout(false);

            InitGUI.Custom.Frm_TopToolbar.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Frm_Border.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Frm_TextTilte.OnColorHandler += InitializeComponent_Refresh;
            InitGUI.Custom.Frm_Background.OnColorHandler += InitializeComponent_Refresh;
        }

        private void InitializeComponent_Refresh(object sender, System.Drawing.Color e)
        {
            this.TopBorderPanel.BackColor = InitGUI.Custom.Frm_Border.DisplayColor;
            this.titleCustom.ForeColor = InitGUI.Custom.Frm_TextTilte.DisplayColor;
            this.TopPanel.BackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.maxBtnCustom.BZBackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.maxBtnCustom.ForeColor = InitGUI.Custom.Frm_TextTilte.DisplayColor;
            this.minBtnCustom.BZBackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.minBtnCustom.ForeColor = InitGUI.Custom.Frm_TextTilte.DisplayColor;
            this.closebtnCustom.BZBackColor = InitGUI.Custom.Frm_TopToolbar.DisplayColor;
            this.closebtnCustom.ForeColor = InitGUI.Custom.Frm_TextTilte.DisplayColor;
            this.LeftPanel.BackColor = InitGUI.Custom.Frm_Border.DisplayColor;
            this.RightPanel.BackColor = InitGUI.Custom.Frm_Border.DisplayColor;
            this.BottomPanel.BackColor = InitGUI.Custom.Frm_Border.DisplayColor;
            this.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
        }
        #endregion

        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnl_Main;
        public System.Windows.Forms.PictureBox iconCustom;
        public System.Windows.Forms.Label titleCustom;
        public AddOn.ButtonZ closebtnCustom;
        public AddOn.MinMaxButton maxBtnCustom;
        public AddOn.ButtonZ minBtnCustom;
    }
}

