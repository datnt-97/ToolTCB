
namespace Transaction_Statistical
{
    partial class Frm_LoadingApp
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
        private void InitializeComponent2()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_mini = new Transaction_Statistical.AddOn.ButtonZ();
            this.bt_Close = new Transaction_Statistical.AddOn.ButtonZ();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.bt_mini);
            this.mainPanel.Controls.Add(this.bt_Close);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor; System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(443, 251);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;// System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transaction Statistical";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;// System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Processing...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pictureBox1.BackgroundImage = global::Transaction_Statistical.Properties.Resources.favticon;
            this.pictureBox1.ErrorImage = global::Transaction_Statistical.Properties.Resources.favticon;
            this.pictureBox1.Image = global::Transaction_Statistical.Properties.Resources.favticon;
            this.pictureBox1.InitialImage = global::Transaction_Statistical.Properties.Resources.favticon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bt_mini
            // 
            this.bt_mini.BorderLeft = false;
            this.bt_mini.BZBackColor = InitGUI.Custom.Frm_Background.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_mini.DisplayText = "-";
            this.bt_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mini.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mini.ForeColor = InitGUI.Custom.Frm_TextTilte.DisplayColor;// System.Drawing.Color.White;
            this.bt_mini.Location = new System.Drawing.Point(380, 1);
            this.bt_mini.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_mini.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_mini.Name = "bt_mini";
            this.bt_mini.NotchangeAfterMouseUP = false;
            this.bt_mini.Size = new System.Drawing.Size(31, 24);
            this.bt_mini.TabIndex = 1;
            this.bt_mini.Text = "-";
            this.bt_mini.TextLocation_X = 5;
            this.bt_mini.TextLocation_Y = 0;
            this.bt_mini.UseVisualStyleBackColor = true;
            this.bt_mini.Click += new System.EventHandler(this.bt_mini_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.BorderLeft = false;
            this.bt_Close.BZBackColor = InitGUI.Custom.Frm_Background.DisplayColor;// System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_Close.DisplayText = "X";
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.ForeColor = InitGUI.Custom.Frm_TextTilte.DisplayColor;// System.Drawing.Color.White;
            this.bt_Close.Location = new System.Drawing.Point(411, 1);
            this.bt_Close.MouseClickColor1 = System.Drawing.Color.Red;
            this.bt_Close.MouseHoverColor = System.Drawing.Color.Red;
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.NotchangeAfterMouseUP = false;
            this.bt_Close.Size = new System.Drawing.Size(31, 24);
            this.bt_Close.TabIndex = 0;
            this.bt_Close.Text = "X";
            this.bt_Close.TextLocation_X = 4;
            this.bt_Close.TextLocation_Y = 0;
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // Frm_LoadingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 251);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LoadingApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading..";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Frm_LoadingApp_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_LoadingApp_FormClosed);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.Icon= ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private AddOn.ButtonZ bt_mini;
        private AddOn.ButtonZ bt_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}