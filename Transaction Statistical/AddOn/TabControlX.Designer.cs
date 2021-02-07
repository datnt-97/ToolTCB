namespace Transaction_Statistical.AddOn
{
    partial class TabControlX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControlX));
            this.BackTopPanel = new System.Windows.Forms.Panel();
            this.RibbonPanel = new System.Windows.Forms.Panel();
            this.TabButtonPanel = new System.Windows.Forms.Panel();
            this.TabPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cMS_Tab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToTheLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToTheRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConteningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripZ1 = new Transaction_Statistical.AddOn.ToolStripZ();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.BackTopPanel.SuspendLayout();
            this.cMS_Tab.SuspendLayout();
            this.toolStripZ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackTopPanel
            // 
            this.BackTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BackTopPanel.Controls.Add(this.RibbonPanel);
            this.BackTopPanel.Controls.Add(this.toolStripZ1);
            this.BackTopPanel.Controls.Add(this.TabButtonPanel);
            this.BackTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackTopPanel.Location = new System.Drawing.Point(0, 0);
            this.BackTopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BackTopPanel.Name = "BackTopPanel";
            this.BackTopPanel.Size = new System.Drawing.Size(557, 49);
            this.BackTopPanel.TabIndex = 0;
            // 
            // RibbonPanel
            // 
            this.RibbonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.RibbonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RibbonPanel.Location = new System.Drawing.Point(0, 47);
            this.RibbonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RibbonPanel.Name = "RibbonPanel";
            this.RibbonPanel.Size = new System.Drawing.Size(557, 2);
            this.RibbonPanel.TabIndex = 0;
            // 
            // TabButtonPanel
            // 
            this.TabButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.TabButtonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TabButtonPanel.Name = "TabButtonPanel";
            this.TabButtonPanel.Size = new System.Drawing.Size(461, 46);
            this.TabButtonPanel.TabIndex = 1;
            // 
            // TabPanel
            // 
            this.TabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel.Location = new System.Drawing.Point(0, 49);
            this.TabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(557, 288);
            this.TabPanel.TabIndex = 1;
            // 
            // cMS_Tab
            // 
            this.cMS_Tab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cMS_Tab.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMS_Tab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeAllButThisToolStripMenuItem,
            this.closeAllToTheLeftToolStripMenuItem,
            this.closeAllToTheRightToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openConteningToolStripMenuItem});
            this.cMS_Tab.Name = "cMS_Tab";
            this.cMS_Tab.ShowImageMargin = false;
            this.cMS_Tab.Size = new System.Drawing.Size(208, 200);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeAllButThisToolStripMenuItem
            // 
            this.closeAllButThisToolStripMenuItem.Name = "closeAllButThisToolStripMenuItem";
            this.closeAllButThisToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.closeAllButThisToolStripMenuItem.Text = "Close All but this";
            this.closeAllButThisToolStripMenuItem.Click += new System.EventHandler(this.closeAllButThisToolStripMenuItem_Click);
            // 
            // closeAllToTheLeftToolStripMenuItem
            // 
            this.closeAllToTheLeftToolStripMenuItem.Name = "closeAllToTheLeftToolStripMenuItem";
            this.closeAllToTheLeftToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.closeAllToTheLeftToolStripMenuItem.Text = "Close All to the left";
            this.closeAllToTheLeftToolStripMenuItem.Click += new System.EventHandler(this.closeAllToTheLeftToolStripMenuItem_Click);
            // 
            // closeAllToTheRightToolStripMenuItem
            // 
            this.closeAllToTheRightToolStripMenuItem.Name = "closeAllToTheRightToolStripMenuItem";
            this.closeAllToTheRightToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.closeAllToTheRightToolStripMenuItem.Text = "Close All to the right";
            this.closeAllToTheRightToolStripMenuItem.Click += new System.EventHandler(this.closeAllToTheRightToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openConteningToolStripMenuItem
            // 
            this.openConteningToolStripMenuItem.Name = "openConteningToolStripMenuItem";
            this.openConteningToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.openConteningToolStripMenuItem.Text = "Open containing folder";
            this.openConteningToolStripMenuItem.Click += new System.EventHandler(this.openConteningToolStripMenuItem_Click);
            // 
            // toolStripZ1
            // 
            this.toolStripZ1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripZ1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripZ1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripZ1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStripZ1.Location = new System.Drawing.Point(511, 2);
            this.toolStripZ1.Name = "toolStripZ1";
            this.toolStripZ1.Size = new System.Drawing.Size(46, 31);
            this.toolStripZ1.TabIndex = 0;
            this.toolStripZ1.Text = "toolStripZ1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 28);
            this.toolStripDropDownButton1.Text = ">";
            this.toolStripDropDownButton1.DropDownOpening += new System.EventHandler(this.toolStripButton1_DropDownOpening);
            // 
            // TabControlX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabPanel);
            this.Controls.Add(this.BackTopPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabControlX";
            this.Size = new System.Drawing.Size(557, 337);
            this.BackTopPanel.ResumeLayout(false);
            this.BackTopPanel.PerformLayout();
            this.cMS_Tab.ResumeLayout(false);
            this.toolStripZ1.ResumeLayout(false);
            this.toolStripZ1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackTopPanel;
        private System.Windows.Forms.Panel TabButtonPanel;
        private System.Windows.Forms.Panel RibbonPanel;
        private System.Windows.Forms.Panel TabPanel;
        private ToolStripZ toolStripZ1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip cMS_Tab;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllButThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToTheLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToTheRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConteningToolStripMenuItem;
    }
}
