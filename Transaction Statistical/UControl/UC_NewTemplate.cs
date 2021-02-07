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
    public partial class UC_NewTemplate : UserControl
    {
        public UC_NewTemplate()
        {
            InitializeComponent2();
            LoadInfo();
        }
        public void LoadInfo()
        {
            try
            {
                DataTable cfg_vendor = InitParametar.sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "60", "Parent_ID", "54");
                foreach (DataRow R in cfg_vendor.Rows)
                {
                    ComboBoxItem cb = new ComboBoxItem();
                    cb.Text = R["Field"].ToString();
                    cb.Value = R["ID"].ToString();
                    cbo_Template.Items.Add(cb);
                    cbo_Template.SelectedIndex = 0;
                }
               foreach(DataRow row in InitParametar.sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", InitParametar.GetParent_Bank()).Rows)
                {
                    cb_Bank.Items.Add(row["Field"].ToString());
                    cb_Bank.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txt_Name.Text.Trim())) return;
                EntryList entr = new EntryList();
                entr.ColumnName.Add("Field");
                entr.Content.Add(txt_Name.Text);

                entr.ColumnName.Add("Type_ID");
                entr.Content.Add("60");

                entr.ColumnName.Add("Parent_ID");
                entr.Content.Add("54");

                entr.ColumnName.Add("Data");
                entr.Content.Add(cb_Bank.Text);

                if ( InitParametar.sqlite.CreateEntry("CfgData",entr))
                {
                    string id = InitParametar.sqlite.GetColumnDataWithColumnName("CfgData", "Field", txt_Name.Text, "ID");
                    if (cbo_Template.SelectedItem != null)
                    {
                        var cfg_temp = InitParametar.sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", (cbo_Template.SelectedItem as ComboBoxItem).Value.ToString());
                        foreach (DataRow row in cfg_temp.Rows)
                        {
                            entr = new EntryList();
                            entr.ColumnName.Add("Field");
                            entr.Content.Add(row["Field"].ToString());

                            entr.ColumnName.Add("Type_ID");
                            entr.Content.Add(row["Type_ID"].ToString());

                            entr.ColumnName.Add("Parent_ID");
                            entr.Content.Add(id);

                            entr.ColumnName.Add("Data");
                            entr.Content.Add(row["Data"].ToString());
                            InitParametar.sqlite.CreateEntry("CfgData", entr);
                        }
                        DataTable tb_transtype = InitParametar.sqlite.GetTableDataWithColumnName("Transactions", "TemplateID", (cbo_Template.SelectedItem as ComboBoxItem).Value.ToString());
                        foreach (DataRow row in tb_transtype.Rows)
                        {
                            entr = new EntryList();
                            entr.ColumnName.Add("Name");
                            entr.Content.Add(row["Name"].ToString());

                            entr.ColumnName.Add("IdentificationTxt");
                            entr.Content.Add(row["IdentificationTxt"].ToString());
                            
                            entr.ColumnName.Add("SuccessfulTxt");
                            entr.Content.Add(row["SuccessfulTxt"].ToString());

                            entr.ColumnName.Add("UnsuccessfulTxt");
                            entr.Content.Add(row["UnsuccessfulTxt"].ToString());

                            entr.ColumnName.Add("TemplateID");
                            entr.Content.Add(id);
                                                        
                            InitParametar.sqlite.CreateEntry("Transactions", entr);
                        }
                    }
                    MessageBox.Show("Create template [" + txt_Name.Text + "] successfully", "Create template");
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                MessageBox.Show("Create template [" + txt_Name.Text + "] unsuccessful\n" + ex.Message, "Create template", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
