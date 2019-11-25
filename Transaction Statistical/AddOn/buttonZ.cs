using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Transaction_Statistical.AddOn
{
    public class ButtonZ : System.Windows.Forms.Button
    {
        Color clr1;
        private Color color = Color.Teal;
        private Color m_hovercolor = Color.FromArgb(0, 0, 140);
        private Color clickcolor = Color.FromArgb(160, 180, 200);
        private int textX = 6;
        private int textY = -20;
        private String text = "_";
        public bool borderLeft = false;
        public bool notchangeAfterMouseUP = false;
        Panel pnl_Left;
        public bool Clicked = false;

        public bool BorderLeft
        {
            get { return borderLeft; }
            set { borderLeft = value; Invalidate(); }
        }

        public bool NotchangeAfterMouseUP
        {
            get { return notchangeAfterMouseUP; }
            set { notchangeAfterMouseUP = value; Invalidate(); }
        }
        public String DisplayText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }
        public Color BZBackColor
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

        public ButtonZ()
        {
            this.Size = new System.Drawing.Size(31, 24);
            this.ForeColor = Color.White;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "_";
            text = this.Text;
            pnl_Left = new Panel();
            pnl_Left.Dock = DockStyle.Right;
            pnl_Left.Width = 2;
            pnl_Left.BackColor = Color.FromArgb(20, 120, 240);
            pnl_Left.Visible = false;
            this.Controls.Add(pnl_Left);
        }
        //method mouse enter
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (BorderLeft) pnl_Left.Visible = true;
            if (Clicked) return;
            clr1 = color;
            color = m_hovercolor;

        }
        //method mouse leave
        protected override void OnMouseLeave(EventArgs e)
        { base.OnMouseLeave(e);
            if (BorderLeft) pnl_Left.Visible = false;
            if (Clicked) return;           
            color = clr1;
           
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            Clicked = true;
            base.OnMouseDown(mevent);
            color = clickcolor;
            if (borderLeft) pnl_Left.Visible = true;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        { base.OnMouseUp(mevent);
            if (notchangeAfterMouseUP) return;           
            color = clr1;
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
