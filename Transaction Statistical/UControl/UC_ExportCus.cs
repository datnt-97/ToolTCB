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
using System.Threading;

namespace Transaction_Statistical.UControl
{
    public partial class UC_ExportCus : UserControl
    {       
        public UC_ExportCus()
        {
            InitializeComponent();
            LoadTemplate();
        }
        public void LoadTemplate()
        {
            try
            {
                string lst = "CanQuyTheoCouterTrenMay;BaoCaoGiaoDichTaiChinh";
                foreach (string s in lst.Split(';')) ckbl_Forms.Items.Add(s, true);
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                if (InitParametar.ReadTrans.Export(txt_Destination.Text))
                {
                    MessageBox.Show("Export successfully.", "Export");
                    if (chb_Open.Checked)
                        new Thread(() => UC_Explorer.OpenFile(InitParametar.ReadTrans.FileExport, false)).Start();
                    (this.Parent as Form).Close();
                }
            }
            catch { }
        }
    }
}
