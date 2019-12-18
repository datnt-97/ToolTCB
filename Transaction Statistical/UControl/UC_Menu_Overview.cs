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
    public partial class UC_Menu_Overview : UserControl
    {
        public UC_Menu_Overview()
        {
            InitializeComponent();
            LoadInfo();
        }
        public void LoadInfo()
        {
            try
            {
                cbo_LstTemplate.Items.Clear();
                DataTable cfg_vendor = InitParametar.sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "60", "Parent_ID", "54");
                foreach (DataRow R in cfg_vendor.Rows)
                {
                    ComboBoxItem cb = new ComboBoxItem();
                    cb.Text = R["Field"].ToString();
                    cb.Value = R["ID"].ToString();
                    cbo_LstTemplate.Items.Add(cb);
                    // if (cb.Value.Equals(InitParametar.TemplateTransactionID.ToString())) cbo_LstTemplate.SelectedItem = cb;
                    if (cb.Text.EndsWith(@"(default)"))
                    {
                        cbo_LstTemplate.SelectedItem = cb;                      
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem cb_tmp = cbo_LstTemplate.SelectedItem as ComboBoxItem;
                UC_CfgTemplate ucCfgTemplate = new UC_CfgTemplate(cb_tmp.Value.ToString());
                ucCfgTemplate.Dock = DockStyle.Fill;
                Frm_TemplateDefault frm = new Frm_TemplateDefault(ucCfgTemplate);
                frm.titleCustom.Text = "Modify template [" + cb_tmp.Text + "]";
                frm.Show();
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem cb_tmp = cbo_LstTemplate.SelectedItem as ComboBoxItem;
                InitParametar.ReadTrans.TemplateTransactionID = cb_tmp.Value.ToString();
                InitParametar.ReadTrans.LoadTemplateInfo();
                if (!cb_tmp.Text.EndsWith(@"(default)"))
                {

                    DataTable cfg_vendor = InitParametar.sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "60", "Parent_ID", "54");
                    foreach (DataRow R in cfg_vendor.Rows)
                    {
                        if (R["Field"].ToString().EndsWith(@"(default)"))
                            InitParametar.sqlite.Update1Entry("CfgData", "Field", R["Field"].ToString().Replace(@"(default)", string.Empty), "ID", R["ID"].ToString());
                    }
                    InitParametar.sqlite.Update1Entry("CfgData", "Field", cb_tmp.Text + @"(default)", "ID", cb_tmp.Value.ToString());
                    LoadInfo();
                }
                MessageBox.Show("Apply completed.", "Apply template config");
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                MessageBox.Show("Apply fail.\n" + ex.Message, "Apply template config", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            UC_NewTemplate ucNew = new UC_NewTemplate();
            ucNew.Dock = DockStyle.Fill;
            Frm_TemplateDefault frm = new Frm_TemplateDefault(ucNew);
            frm.ShowDialog();
            LoadInfo();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem cb_tmp = cbo_LstTemplate.SelectedItem as ComboBoxItem;
                if (MessageBox.Show("Do you want delete [" + cb_tmp.Text + "]", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    InitParametar.sqlite.DeleteEntry("CfgData", "ID", cb_tmp.Value.ToString());
                    InitParametar.sqlite.DeleteEntry("CfgData", "Parent_ID", cb_tmp.Value.ToString());
                    InitParametar.sqlite.DeleteEntry("Transactions", "TemplateID", cb_tmp.Value.ToString());
                    MessageBox.Show("Delete [" + cb_tmp.Text + "] complited.", "Delete template config");
                    LoadInfo();
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                MessageBox.Show("Delete fail.\n" + ex.Message, "Delete template config", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
