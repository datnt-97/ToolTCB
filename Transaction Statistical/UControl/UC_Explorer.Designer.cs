namespace Transaction_Statistical.UControl
{
    partial class UC_Explorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Explorer));
            this.pnl_BorderTop = new System.Windows.Forms.Panel();
            this.pnl_BorderRight = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_BorderBottom = new System.Windows.Forms.Panel();
            this.pnl_BorderLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.tre_Explorer = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // pnl_BorderTop
            // 
            this.pnl_BorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.pnl_BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BorderTop.Location = new System.Drawing.Point(0, 0);
            this.pnl_BorderTop.Name = "pnl_BorderTop";
            this.pnl_BorderTop.Size = new System.Drawing.Size(456, 1);
            this.pnl_BorderTop.TabIndex = 3;
            // 
            // pnl_BorderRight
            // 
            this.pnl_BorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.pnl_BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_BorderRight.Location = new System.Drawing.Point(455, 1);
            this.pnl_BorderRight.Name = "pnl_BorderRight";
            this.pnl_BorderRight.Size = new System.Drawing.Size(1, 499);
            this.pnl_BorderRight.TabIndex = 4;
            // 
            // pnl_BorderBottom
            // 
            this.pnl_BorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.pnl_BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_BorderBottom.Location = new System.Drawing.Point(0, 499);
            this.pnl_BorderBottom.Name = "pnl_BorderBottom";
            this.pnl_BorderBottom.Size = new System.Drawing.Size(455, 1);
            this.pnl_BorderBottom.TabIndex = 5;
            // 
            // pnl_BorderLeft
            // 
            this.pnl_BorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.pnl_BorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_BorderLeft.Location = new System.Drawing.Point(0, 1);
            this.pnl_BorderLeft.Name = "pnl_BorderLeft";
            this.pnl_BorderLeft.Size = new System.Drawing.Size(1, 498);
            this.pnl_BorderLeft.TabIndex = 6;
            // 
            // tre_Explorer
            // 
            this.tre_Explorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tre_Explorer.BackColor = System.Drawing.Color.White;
            this.tre_Explorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tre_Explorer.ForeColor = System.Drawing.Color.Black;
            this.tre_Explorer.ImageIndex = 0;
            this.tre_Explorer.ImageList = this.imageList;
            this.tre_Explorer.Location = new System.Drawing.Point(1, 1);
            this.tre_Explorer.Name = "tre_Explorer";
            this.tre_Explorer.SelectedImageIndex = 0;
            this.tre_Explorer.Size = new System.Drawing.Size(454, 490);
            this.tre_Explorer.TabIndex = 7;
            this.tre_Explorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_Explorer_AfterSelect);
            this.tre_Explorer.DoubleClick += new System.EventHandler(this.tre_Explorer_DoubleClick);
            this.tre_Explorer.MouseLeave += new System.EventHandler(this.tre_Explorer_MouseLeave);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "CDROM.ico");
            this.imageList.Images.SetKeyName(1, "Computer");
            this.imageList.Images.SetKeyName(2, "Folder_Close");
            this.imageList.Images.SetKeyName(3, "Folder_Hide");
            this.imageList.Images.SetKeyName(4, "Folder_Hide_Lock");
            this.imageList.Images.SetKeyName(5, "Folder_Open");
            this.imageList.Images.SetKeyName(6, "Fixed");
            this.imageList.Images.SetKeyName(7, "NewFile");
            // 
            // UC_Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.tre_Explorer);
            this.Controls.Add(this.pnl_BorderLeft);
            this.Controls.Add(this.pnl_BorderBottom);
            this.Controls.Add(this.pnl_BorderRight);
            this.Controls.Add(this.pnl_BorderTop);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_Explorer";
            this.Size = new System.Drawing.Size(456, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BorderTop;
        private System.Windows.Forms.FlowLayoutPanel pnl_BorderRight;
        private System.Windows.Forms.Panel pnl_BorderBottom;
        private System.Windows.Forms.FlowLayoutPanel pnl_BorderLeft;
        public System.Windows.Forms.TreeView tre_Explorer;
        private System.Windows.Forms.ImageList imageList;
    }
}
