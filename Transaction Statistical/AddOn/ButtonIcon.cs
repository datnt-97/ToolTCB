using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Transaction_Statistical.AddOn
{
    public class ButtonIcon : System.Windows.Forms.Button
    {
        private Color color = Color.Gray;
        private Color m_hovercolor = Color.FromArgb(180, 200, 240);
        private Color clickcolor = Color.FromArgb(160, 180, 200);
        private int textX = -20;
        private int textY = -20;
        private String text = "";

        public Color IconHoverColor
        {
            get { return m_hovercolor; }
            set
            {
                m_hovercolor = value; Invalidate();
            }
        }
        public Color IconColor
        {
            get { return color; }
            set
            {
                color = value; Invalidate();
            }
        }
        public Color IconClickColor
        {
            get { return clickcolor; }
            set
            {
                clickcolor = value; Invalidate();
            }
        }       
        public Color BZBackColor
        {
            get { return color; }
            set { color = value; Invalidate(); }
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

        public ButtonIcon()
        {
            this.Size = new System.Drawing.Size(31, 24);
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Text = "";
            text = this.Text;
        }

        //method mouse enter
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Image = IconHelper.ImageUltility.ChangeColor((System.Drawing.Bitmap)this.Image, m_hovercolor);
        }
        //method mouse leave
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Image = IconHelper.ImageUltility.ChangeColor((System.Drawing.Bitmap)this.Image, color);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.Image = IconHelper.ImageUltility.ChangeColor((System.Drawing.Bitmap)this.Image, clickcolor);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            this.Image = IconHelper.ImageUltility.ChangeColor((System.Drawing.Bitmap)this.Image, color);
        }
    }
}
