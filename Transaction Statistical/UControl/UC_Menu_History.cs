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
        public UC_Menu_History()
        {
            InitializeComponent2();
        }

        private void UC_History_Load(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string reg = @"[-]+
(?<Trace>(?<Time>(\d+:\d+:\d+))\s+\d+\s+Class:\s+(?<Class>.*)
[\s\S]*?)
[-]+";
            cbo_Keyword_LstKeyword.Items.Clear();
            int n = 0;

            foreach (string file in Directory.GetFiles(InitParametar.FolderSystemTrace))
            {
                Dictionary<int, RegesValue> vls = new Dictionary<int, RegesValue>();
                if (Regexs.RunPatternRegular(File.ReadAllText(file), reg, out vls))
                {
                    foreach (RegesValue vl in vls.Values)
                    {
                        n++;
                        listView1.Items.Add(new ListViewItem(new string[] { n.ToString(), vl.value["Time"], vl.value["Class"], vl.value["Trace"] }));
                        if (!cbo_Keyword_LstKeyword.Items.Contains(vl.value["Class"])) cbo_Keyword_LstKeyword.Items.Add(vl.value["Class"]);
                    }
                    
                }
            }
            if (listView1.Items.Count != 0) listView1.EnsureVisible(listView1.Items.Count - 1);
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                fctxt_Pattern.Text = item.SubItems[3].Text;
                
            }           
        }
    }
}
