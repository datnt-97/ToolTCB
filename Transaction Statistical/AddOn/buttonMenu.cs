using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Transaction_Statistical.AddOn
{  
    public class ButtonMenu : System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Panel pnl_2;
        private System.Windows.Forms.Panel pnl_3;
        private System.Windows.Forms.Panel pnl_4;
        int zoomSite = 1;
        bool zoomed = false;
        Color color4point=Color.FromArgb(20,120,240);
        Color color4pointHover=Color.DeepSkyBlue;
        Color color4pointDown = Color.FromArgb(0, 98, 215);

        public ButtonMenu()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pnl_2 = new System.Windows.Forms.Panel();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.pnl_4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.pnl_1.Location = new System.Drawing.Point(1, 1);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(16, 16);
            this.pnl_1.TabIndex = 0;
            this.pnl_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseDown);
            this.pnl_1.MouseEnter += new System.EventHandler(this.ButtonMenu_MouseEnter);
            this.pnl_1.MouseLeave += new System.EventHandler(this.BubuttonMenu_MouseLeave);
            this.pnl_1.MouseHover += new System.EventHandler(this.ButtonMenu_MouseEnter);
            this.pnl_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseUp);
            // 
            // pnl_2
            // 
            this.pnl_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.pnl_2.Location = new System.Drawing.Point(20, 1);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Size = new System.Drawing.Size(16, 16);
            this.pnl_2.TabIndex = 1;
            this.pnl_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseDown);
            this.pnl_2.MouseEnter += new System.EventHandler(this.ButtonMenu_MouseEnter);
            this.pnl_2.MouseLeave += new System.EventHandler(this.BubuttonMenu_MouseLeave);
            this.pnl_2.MouseHover += new System.EventHandler(this.ButtonMenu_MouseEnter);
            this.pnl_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseUp);
            // 
            // pnl_3
            // 
            this.pnl_3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.pnl_3.Location = new System.Drawing.Point(1, 20);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Size = new System.Drawing.Size(16, 16);
            this.pnl_3.TabIndex = 2;
            this.pnl_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseDown);
            this.pnl_3.MouseEnter += new System.EventHandler(this.ButtonMenu_MouseEnter);
            this.pnl_3.MouseLeave += new System.EventHandler(this.BubuttonMenu_MouseLeave);
            this.pnl_3.MouseHover += new System.EventHandler(this.ButtonMenu_MouseEnter);
            this.pnl_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseUp);
            // 
            // pnl_4
            // 
            this.pnl_4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.pnl_4.Location = new System.Drawing.Point(20, 20);
            this.pnl_4.Name = "pnl_4";
            this.pnl_4.Size = new System.Drawing.Size(16, 16);
            this.pnl_4.TabIndex = 2;
            this.pnl_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseDown);
            this.pnl_4.MouseEnter += new System.EventHandler(this.ButtonMenu_MouseEnter);
            this.pnl_4.MouseLeave += new System.EventHandler(this.BubuttonMenu_MouseLeave);
            this.pnl_4.MouseHover += new System.EventHandler(this.ButtonMenu_MouseEnter);
            this.pnl_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseUp);
            // 
            // ButtonMenu
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_4);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.pnl_1);
            this.Name = "ButtonMenu";
            this.Size = new System.Drawing.Size(39, 39);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseDown);
            this.ResumeLayout(false);

        }
        public Color Color4point
        {
            get { return color4point; }
            set { color4point = value; Invalidate(); }
        }
        public Color Color4pointHover
        {
            get { return color4pointHover; }
            set { color4pointHover = value; Invalidate(); }
        }
        public Color Color4pointDown
        {
            get { return color4pointDown; }
            set { color4pointDown = value; Invalidate(); }
        }

        public delegate void MouseEnterHandler(object sender, EventArgs e);
        public event MouseEnterHandler OnMouseEnterHandler;
        private void ButtonMenu_MouseEnter(object sender, EventArgs e)
        {
            if (zoomed) return;
            zoomed = true;
            Thread.Sleep(10);
          if(OnMouseEnterHandler!=null)  OnMouseEnterHandler(this, e);
            int n = 0;
            while (zoomSite >= n)
            {
                Thread.Sleep(10);
                pnl_1.Location = new System.Drawing.Point(pnl_1.Location.X - 1, pnl_1.Location.Y - 1);
                pnl_1.Size = new System.Drawing.Size(pnl_1.Width + 1, pnl_1.Height + 1);

                pnl_2.Location = new System.Drawing.Point(pnl_2.Location.X + 1, pnl_2.Location.Y - 1);
                pnl_2.Size = new System.Drawing.Size(pnl_2.Width + 1, pnl_2.Height + 1);

                pnl_3.Location = new System.Drawing.Point(pnl_3.Location.X - 1, pnl_3.Location.Y + 1);
                pnl_3.Size = new System.Drawing.Size(pnl_3.Width + 1, pnl_3.Height + 1);

                pnl_4.Location = new System.Drawing.Point(pnl_4.Location.X + 1, pnl_4.Location.Y + 1);
                pnl_4.Size = new System.Drawing.Size(pnl_4.Width + 1, pnl_4.Height + 1);               
                n++;
            }
        }

        private void BubuttonMenu_MouseLeave(object sender, EventArgs e)
        {
            if (!zoomed) return;
            zoomed = false;
            Thread.Sleep(10);
            int n = 0;
            while (zoomSite >= n)
            {
                Thread.Sleep(10);
                pnl_1.Location = new System.Drawing.Point(pnl_1.Location.X + 1, pnl_1.Location.Y + 1);
                pnl_1.Size = new System.Drawing.Size(pnl_1.Width - 1, pnl_1.Height - 1);

                pnl_2.Location = new System.Drawing.Point(pnl_2.Location.X - 1, pnl_2.Location.Y + 1);
                pnl_2.Size = new System.Drawing.Size(pnl_2.Width - 1, pnl_2.Height - 1);

                pnl_3.Location = new System.Drawing.Point(pnl_3.Location.X + 1, pnl_3.Location.Y - 1);
                pnl_3.Size = new System.Drawing.Size(pnl_3.Width - 1, pnl_3.Height - 1);

                pnl_4.Location = new System.Drawing.Point(pnl_4.Location.X - 1, pnl_4.Location.Y - 1);
                pnl_4.Size = new System.Drawing.Size(pnl_4.Width - 1, pnl_4.Height - 1);
                n++;
            }
           
        }
        
       

        public delegate void MouseDownHandler(object sender, EventArgs e);
        public event MouseDownHandler OnMouseDownHandler;
        private void ButtonMenu_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pnl_1.BackColor = pnl_2.BackColor = pnl_3.BackColor = pnl_4.BackColor = color4pointDown;
            if (OnMouseDownHandler != null)   OnMouseDownHandler(this, e);
        }

        private void ButtonMenu_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pnl_1.BackColor = pnl_2.BackColor = pnl_3.BackColor = pnl_4.BackColor = color4point;
        }
    }
}
