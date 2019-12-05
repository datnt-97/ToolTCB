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
        SQLiteHelper sqlite;
        public UC_Menu_Overview()
        {
            sqlite = new SQLiteHelper();
            InitializeComponent();          
            LoadInfo();
            
        }
        public void LoadInfo()
        {
            try
            {
              
                DataTable cfg_vendor = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "60", "Parent_ID", "54");
                foreach (DataRow R in cfg_vendor.Rows)
                {
                    ComboBoxItem cb = new ComboBoxItem();
                    cb.Text = R["Field"].ToString();
                    cb.Value = R["ID"].ToString();
                    cbo_LstTemplate.Items.Add(cb);
                    if (cb.Value.Equals(InitParametar.TemplateTransactionID.ToString())) cbo_LstTemplate.SelectedItem = cb;
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
                InitParametar.TemplateTransactionID = cb_tmp.Value.ToString();
                InitParametar.LoadTemplateInfo();
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
    }
}
