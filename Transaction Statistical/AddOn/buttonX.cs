using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace Transaction_Statistical.AddOn
{
    public class ButtonX : System.Windows.Forms.Button
    {
        Color clr1;
        private Color color = Color.Teal;
        private Color m_hovercolor = Color.FromArgb(0, 0, 140);
        private Color clickcolor = Color.FromArgb(160, 180, 200);
        private int textX = 6;
        private int textY = -20;
        private String text = "";
        private bool isChanged = true;
        private bool showCloseButton = true;


        public String DisplayText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }
        public Color BXBackColor
        {
            get { return color; }
            set { color = value; Invalidate(); }
        }

        public Color MouseHoverColor
        {
            get { return m_hovercolor; }
            set { m_hovercolor = value; Invalidate(); }
        }

        public Color MouseClickColor1
        {
            get { return clickcolor; }
            set { clickcolor = value; Invalidate(); }
        }

        public bool ChangeColorMouseHC
        {
            get { return isChanged; }
            set { isChanged = value; Invalidate(); }
        }

        public bool ShowCloseButton
        {
            get { return isChanged; }
            set { showCloseButton = value; Invalidate(); }
        }


        public int TextLocation_X
        {
            get { return textX; }
            set { textX = value; Invalidate(); }
        }
        public int TextLocation_Y
        {
            get { return textY; }
            set { textY = value; Invalidate(); }
        }


        public ButtonX()
        {
            this.Size = new System.Drawing.Size(31, 24);
            this.ForeColor = Color.White;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Text = "_";
            text = this.Text;

        }

        private Panel cp;
        private void SynColorClose(Color cl)
        {
            if (!showCloseButton) return;
            if (cp == null) AddClose();

            (cp.Controls[0] as ButtonZ).BZBackColor = cl;
        }
        private void AddClose()
        {
            if (!showCloseButton) return;
            this.Width = this.Width + 20;
            ButtonZ bt_close = new ButtonZ();
            bt_close.Text = "X";
            bt_close.Height = 20;
            bt_close.Width = 20;
            bt_close.Font = new Font("Arial", 10);
            bt_close.TextLocation_X = 4;
            bt_close.TextLocation_Y = 1;
            bt_close.BZBackColor = this.BackColor;
            bt_close.MouseHoverColor = Color.CornflowerBlue;
            bt_close.MouseClickColor1 = Color.DarkRed;
            cp = new Panel();
            cp.Height = 20;
            cp.Width = 20;
            cp.Location = new Point(this.Width - bt_close.Width - 2, (this.Height - bt_close.Height) / 2);
            cp.Controls.Add(bt_close);
            bt_close.Dock = DockStyle.Fill;
            bt_close.Click += Close_Button;
            this.Controls.Add(cp);
        }

        public delegate void ClickCloseHandler(object sender, EventArgs e);
        public event ClickCloseHandler OnClickCloseHandler;
        private void Close_Button(object sender, EventArgs e)
        {
            OnClickCloseHandler(this, e);
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            SynColorClose(this.BackColor);
        }
        //method mouse enter
        protected override void OnMouseEnter(EventArgs e)
        {
            if (cp == null) AddClose(); else cp.Visible = true;
            base.OnMouseEnter(e);
            clr1 = color;
            color = m_hovercolor;
            SynColorClose(m_hovercolor);
        }

        //method mouse leave
        protected override void OnMouseLeave(EventArgs e)
        {

            base.OnMouseLeave(e);
            if (isChanged)
            {
                color = clr1;
            }
            SynColorClose(this.BackColor);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (isChanged)
            {
                color = clickcolor;
            }
            SynColorClose(clickcolor);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (isChanged)
            {
                color = clr1;
            }
            SynColorClose(this.BackColor);
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            text = this.Text;
            if (textX == 100 && textY == 25)
            {
                textX = ((this.Width) / 3) + 10;
                textY = (this.Height / 2) - 1;
            }

            Point p = new Point(textX, textY);
            pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);
            pe.Graphics.DrawString(text, this.Font, new SolidBrush(this.ForeColor), p);

        }

    }
}