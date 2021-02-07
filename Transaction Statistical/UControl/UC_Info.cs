using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical
{
    public partial class UC_Info : UserControl
    {
        SQLiteHelper sqlite;
        string dataName;
        string rowID;
        public UC_Info()
        {
            InitializeComponent2();
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
     

        #endregion
        public UC_Info(string DataName, string RowID, string ColummShow)
        {
            InitializeComponent2();
            dataName = DataName;
            rowID = RowID;
            sqlite = new SQLiteHelper();
            btn_Save.Visible = true;
            DataTable cfg_data = sqlite.GetTableDataWithColumnName(DataName, "ID", RowID);
            DataRow R = cfg_data.Rows[0];
            TextCustom.Text = R[ColummShow].ToString();
        }
        public UC_Info(string sString)
        {
            InitializeComponent2();
            TextCustom.Text = sString;
        }
        private void LoadHelp()
        {
            try
            {
               
            }
            catch { }
        }

        private void OkCustom_Click(object sender, EventArgs e)
        {
            Control ctr = this.TopLevelControl;
            while (ctr != null)
            {
                if (ctr is Form) { (ctr as Form).Close(); break; }
                else
                    ctr = ctr.TopLevelControl;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = TextCustom.Text.Replace("\'", "\"");
                if (sqlite.Update1Entry(dataName, "Data", msg, "ID", rowID))
                {
                    MessageBox.Show("Update successful :)", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update successful :)", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }
    }
}
