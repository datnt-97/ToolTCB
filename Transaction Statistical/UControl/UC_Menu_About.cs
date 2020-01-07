﻿using System;
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
            lv_Version.Text = String.Format("Version: {0}, build: {1:yyyy MMM dd}", Assembly.GetExecutingAssembly().GetName().Version.ToString(),
               InfoAssembly.fileVersion.CreationTime);
            if (InitParametar.TypeLicense.Equals(License.Types.Unknow)) mode_Label9.Text = "License: " + InitParametar.TypeLicense.ToString();
            else
            {
                string remaining = string.Empty;
                if ((InitParametar.DateMaximum - DateTime.Now).TotalDays / 365 >= 1)
                    remaining = (int)(InitParametar.DateMaximum - DateTime.Now).TotalDays / 365 + " years";
                else if ((InitParametar.DateMaximum - DateTime.Now).TotalDays >= 1)
                    remaining = (int)(InitParametar.DateMaximum - DateTime.Now).TotalDays + " days";
                else
                    remaining = (int)(InitParametar.DateMaximum - DateTime.Now).TotalHours + " hours";
                mode_Label9.Text = "License: " + InitParametar.TypeLicense.ToString() + "\n Remaining: " + remaining;
            }
            #region Read Me File
            mode_FastColoredTextBox1.WordWrap = true;
            var pathReadme = AppDomain.CurrentDomain.BaseDirectory + @"\readme.txt";
            if (System.IO.File.Exists(pathReadme))
            {
                using (StreamReader file = new StreamReader(pathReadme))
                {
                    string ln = file.ReadToEnd();
                    ln += Environment.NewLine;
                    ln += string.Format("Company :{0}", InfoAssembly.attributes.Company);
                    ln += Environment.NewLine;
                    ln += string.Format("Version :{0}", InfoAssembly.version.ToString());
                    ln += Environment.NewLine;
                    ln += string.Format("Built :{0}", InfoAssembly.fileVersion.CreationTime);
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
                Frm_TemplateDefault frm = new Frm_TemplateDefault(web, "Help");
                frm.Size = new Size(1000, 700);
                frm.ShowDialog();
            }
        }
        private void mode_Label6_Click(object sender, EventArgs e)
        {
            UC_RegisterLicense uc = new UC_RegisterLicense();
            Frm_TemplateDefault frm = new Frm_TemplateDefault(uc, mode_Label6.Text);
            frm.ShowDialog();
        }
        private void mode_Label_MouseHover(object sender, EventArgs e)
        {
            (sender as Mode_Label).ForeColor = Color.Blue;
        }

        private void mode_Label_Leave(object sender, EventArgs e)
        {
            (sender as Mode_Label).ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
        }

        private void mode_Label_MouseEnter(object sender, EventArgs e)
        {
            (sender as Mode_Label).ForeColor = Color.GreenYellow;
        }
    }
}