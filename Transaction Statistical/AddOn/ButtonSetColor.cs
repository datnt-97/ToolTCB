using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical.AddOn
{
    public partial class ButtonSetColor : UserControl
    {
      
        public string property;   
        public ButtonSetColor()
        {
            InitializeComponent();
            DisplayColor = pn_Color.BackColor;
        }
       
        public string DisplayText
        {
            get
            {
                return lb_Display.Text;
            }
            set
            {
               lb_Display.Text = value;
                this.Width = pn_Color.Width + lb_Display.Width; Invalidate();
            }
        }
        public string ID { get; set; }

        public Color DisplayColor
        {
            get
            {
                return pn_Color.BackColor;
            }
            set
            {               
                pn_Color.BackColor = value;
                if (OnColorHandler != null) OnColorHandler(this, value);
                Invalidate();
            }
          
        }
        private void pn_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = pn_Color.BackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                DisplayColor = colorDlg.Color;
                WriteColorDB();
                
            }    
        }
        private bool WriteColorDB()
        {
            try
            {
                ID = InitParametar.sqlite.GetColumnDataWith2ColumnName("CfgData", "Field", this.Name, "Parent_ID", "52", "ID");
                if (string.IsNullOrEmpty(ID))
                {
                    EntryList entr = new EntryList();
                    entr.ColumnName.Add("Field");
                    entr.Content.Add(this.Name);

                    entr.ColumnName.Add("Data");
                    entr.Content.Add(DisplayColor.Name);

                    entr.ColumnName.Add("Parent_ID");
                    entr.Content.Add("52");

                    if (InitParametar.sqlite.CreateEntry("CfgData", entr)) return true;
                }
                else
                if (InitParametar.sqlite.Update1Entry("CfgData", "Data", DisplayColor.Name, "ID", this.ID)) return true;
            }
            catch { }
            return false;
        }

        protected void lb_Display_TextChanged(object sender, EventArgs e)
        {
            this.Width = pn_Color.Width + lb_Display.Width; Invalidate();
        }
        public delegate void ColorChanged(object sender, Color e);
        public event ColorChanged OnColorHandler;
    }
}
