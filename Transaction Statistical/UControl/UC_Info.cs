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
        public UC_Info()
        {
            InitializeComponent();
        }
        public UC_Info(string DataName, string RowID, string ColummShow)
        {
            InitializeComponent();
            sqlite = new SQLiteHelper();
                        
            DataTable cfg_data = sqlite.GetTableDataWithColumnName(DataName, "ID", RowID);
            DataRow R = cfg_data.Rows[0];
            TextCustom.Text = R[ColummShow].ToString();
        }
        public UC_Info(string sString)
        {
            InitializeComponent();
            TextCustom.Text = sString;
        }
        private void LoadHelp()
        {
            try
            {
               
            }
            catch { }
        }
    }
}
