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
using System.IO;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Menu_About : UserControl
    {
        public UC_Menu_About()
        {
            InitializeComponent2();
            lv_Version.Text =String.Format("Version: {0}, build: {1:yyyy MMM dd}",  Assembly.GetExecutingAssembly().GetName().Version.ToString(), new DateTime(2019, 12, 25));
            #region Read Me File
            mode_FastColoredTextBox1.WordWrap = true;
            var pathReadme = AppDomain.CurrentDomain.BaseDirectory + @"\readme.txt";
            if (System.IO.File.Exists(pathReadme))
            {
                using (StreamReader file = new StreamReader(pathReadme))
                {
                    string ln = file.ReadToEnd();
                    mode_FastColoredTextBox1.Text += ln;

                }
            }
            #endregion
        }

        [Obsolete]
        private void mode_Label4_Click(object sender, EventArgs e)
        {
            string pathHelp = System.Configuration.ConfigurationSettings.AppSettings["HelpFile"];

            pathHelp = AppDomain.CurrentDomain.BaseDirectory + "/" + pathHelp;
            if (File.Exists(pathHelp))
            {
                var document = string.Empty;
                using (StreamReader file = new StreamReader(pathHelp))
                {
                    document = file.ReadToEnd();

                }
                WebBrowser web = new WebBrowser();
                web.Dock = DockStyle.Fill;
                web.DocumentText = document;
                Frm_TemplateDefault frm = new Frm_TemplateDefault(web);
                frm.titleCustom.Text = "Help";
                frm.Size = new Size(1000, 700);
                frm.ShowDialog();
            }
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
