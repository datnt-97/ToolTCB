using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Menu_History : UserControl
    {
        int step;
        List<string> lstFile; 
        public UC_Menu_History()
        {
            InitializeComponent();
            LoadFiles();
        }

        private void UC_History_Load(object sender, EventArgs e)
        {

        }

        private void LoadFiles()
        {
            try
            {
                cbo_TypeTrace.Items.Clear();
                cbo_TypeTrace.Items.Add("All Files");
                foreach (string file in Directory.GetFiles(InitParametar.FolderSystemTrace, "*.log"))
                {
                    cbo_TypeTrace.Items.Add("[Application] " + Path.GetFileName(file));
                }
                foreach (string file in Directory.GetFiles(InitParametar.PathDirectoryCurrentApp + "\\Trace", "*.log"))
                {
                    cbo_TypeTrace.Items.Add("[Service Scheduler] " + Path.GetFileName(file));
                }               
            }
            catch { }
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            
            UC_Menu_History uc = new UC_Menu_History();
            uc.Dock = DockStyle.Fill;
            uc.cbo_Keyword_LstKeyword.Text =this.cbo_Keyword_LstKeyword.Text;
            uc.btn_Maximize.Visible = false;
            uc.fctxt_Pattern.Text = this.fctxt_Pattern.Text;
            uc.btn_Refresh_Click(sender,e);
            Frm_TemplateDefault frm = new Frm_TemplateDefault(uc, "History");
            frm.Show();
           
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
          
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                fctxt_Pattern.Text = item.SubItems[3].Text;
                
            }           
        }
        private void cbo_Keyword_LstKeyword_TextChange(object sender, EventArgs e)
        {
            step = listView1.Items.Count;
            foreach (ListViewItem item in listView1.Items)
                item.BackColor = this.BackColor;
            Find();
        }
        private void cbo_Keyword_LstKeyword_OnKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               Find();
            }
        }
        private void Find()
        {
            if (cbo_Keyword_LstKeyword.Text != "")
            {
                for (int i = step-1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.SubItems[3].Text.ToLower().Contains(cbo_Keyword_LstKeyword.Text.ToLower()))
                    {
                        item.BackColor = Color.Aqua;
                        item.ForeColor = Color.Empty;
                        step = i;
                     //   listView1.Items[i].Selected = true;
                        listView1.Items[i].EnsureVisible();
                        break;
                    }
                    else
                        item.BackColor = this.BackColor;
                }

            }
        }

        private void cbo_TypeTrace_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> files=new List<string>();
            if(cbo_TypeTrace.Text.StartsWith("All Files"))
            {
                files.AddRange(Directory.GetFiles(InitParametar.FolderSystemTrace, "*.log"));
                files.AddRange(Directory.GetFiles(InitParametar.PathDirectoryCurrentApp + "\\Trace", "*.log"));                
            }
            else if(cbo_TypeTrace.Text.StartsWith("[Application]"))
            {
                files.AddRange(Directory.GetFiles(InitParametar.FolderSystemTrace, cbo_TypeTrace.Text.Replace("[Application]", "").Trim()));
            }
            else if(cbo_TypeTrace.Text.StartsWith("[Service Scheduler]"))
            {
                files.AddRange(Directory.GetFiles(InitParametar.PathDirectoryCurrentApp + "\\Trace", cbo_TypeTrace.Text.Replace("[Service Scheduler]", "").Trim()));
            }
            if (files.Count != 0)
                LoadLog(files);
        }
        private void LoadLog(List<string> files)
        {
            try
            {
                string reg = @"([-]+
(?<Trace>(?<Time>(\d+:\d+:\d+))\s+\d+\s+Class:\s+(?<Class>.*)
[\s\S]*?)
[-]+)|([-]+
(?<Trace>[\s\S]*?)
[-]+)";
                cbo_Keyword_LstKeyword.Items.Clear();
                int n = 0;

                foreach (string file in files)
                {
                    Dictionary<int, RegesValue> vls = new Dictionary<int, RegesValue>();
                    if (Regexs.RunPatternRegular(File.ReadAllText(file), reg, out vls))
                    {
                        foreach (RegesValue vl in vls.Values)
                        {
                            n++;
                            listView1.Items.Add(new ListViewItem(new string[] { n.ToString(), vl.value["Time"] + " in " + Path.GetFileName(file).Substring(0, Path.GetFileName(file).LastIndexOf('.')), vl.value["Class"], vl.value["Trace"] }));
                            if (!cbo_Keyword_LstKeyword.Items.Contains(vl.value["Class"]) && !string.IsNullOrEmpty(vl.value["Class"])) cbo_Keyword_LstKeyword.Items.Add(vl.value["Class"]);
                        }

                    }
                }
                if (listView1.Items.Count != 0) listView1.EnsureVisible(listView1.Items.Count - 1);
            }
            catch { }
        }
    }
}
