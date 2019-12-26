using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Menu_About : UserControl
    {
        public UC_Menu_About()
        {
            InitializeComponent2();
            lv_Version.Text =String.Format("Version: {0}, build: {1:yyyy MMM dd}",  Assembly.GetExecutingAssembly().GetName().Version.ToString(), new DateTime(2019, 12, 25));
        }

        private void mode_Label4_MouseHover(object sender, EventArgs e)
        {
            (sender as Mode_Label).ForeColor = Color.Blue;
        }

        private void mode_Label4_Leave(object sender, EventArgs e)
        {
            (sender as Mode_Label).ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
        }

        private void mode_Label8_MouseEnter(object sender, EventArgs e)
        {
            (sender as Mode_Label).ForeColor = Color.GreenYellow;
        }
    }
}
