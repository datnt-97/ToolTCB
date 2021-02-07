using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Terminals : UserControl
    {
        SQLiteHelper sqlite;
        public UC_Terminals()
        {
            InitializeComponent();
            sqlite = new SQLiteHelper();
            LoadProvince();
            LoadBank();
            LoadModel();
            LoadAreaService();
            LoadNPSBranch();
        }
        private void LoadModel()
        {
            try
            {
                cb_Model.Items.Clear();
                cb_Model.Items.Add("All");
                foreach (DataRow row in sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", InitParametar.GetParent_ModelMachine()).Select().OrderBy(u => u["Field"]).ToArray())
                    cb_Model.Items.Add(row["Field"]);
                cb_Model.SelectedIndex = 0;
            }
            catch (Exception ex)
            { }
        }
        private void LoadNPSBranch()
        {
            try
            {
                cb_Branch.Items.Clear();
                cb_Branch.Items.Add("All");
                foreach (DataRow row in sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", InitParametar.GetParent_NPSBranch()).Select().OrderBy(u => u["Field"]).ToArray())
                    cb_Branch.Items.Add(row["Field"]);
                cb_Branch.SelectedIndex = 0;
            }
            catch (Exception ex)
            { }
        }

        private void LoadProvince()
        {
            try
            {
                cb_Province.Items.Clear();
                cb_Province.Items.Add("All");
                foreach (DataRow row in sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", InitParametar.GetParent_Province()).Select().OrderBy(u => u["Field"]).ToArray())
                    cb_Province.Items.Add(row["Field"]);
                cb_Province.SelectedIndex = 0;
            }
            catch (Exception ex)
            { }
        }

        private void LoadBank()
        {
            string ParentID_Banks = InitParametar.GetParent_Bank();
            DataTable tb = sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", ParentID_Banks);
            cb_Bank.Items.Clear();
            cb_Bank.Items.Add("All");
            for (int n = 0; n < tb.Rows.Count; n++)
            {
                cb_Bank.Items.Add(tb.Rows[n]["Field"].ToString());
            }
            cb_Bank.SelectedIndex = 0;
        }

        private void LoadAreaService()
        {
            string ParentID = InitParametar.GetParent_AreaService();
            DataTable tb = sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", ParentID);
            cb_Area.Items.Clear();
            cb_Area.Items.Add("All");
            for (int n = 0; n < tb.Rows.Count; n++)
            {
                cb_Area.Items.Add(tb.Rows[n]["Field"].ToString());
            }
            cb_Area.SelectedIndex = 0;
        }

        int n = 0;
		private void Control_TextChanged(object sender, EventArgs e)
		{
            bool exist = false;
            lv_Terminal.Items.Clear();
            n = 0;
            foreach (DataRow row in sqlite.GetTableData("Terminal").Rows)
            {
                try
                {
                    exist = false;
                    if (!string.IsNullOrEmpty(tb_SubName.Text))
                    {
                        if (row["TID"].ToString().ToUpper().Contains(tb_SubName.Text.ToUpper()) || row["Serial"].ToString().ToUpper().Contains(tb_SubName.Text.ToUpper()) || row["Address"].ToString().ToUpper().Contains(tb_SubName.Text.ToUpper()))
                            exist = true;
                    }
                    else
                    exist = true;
                    if(exist)
                    {
                        if (exist && !cb_Area.Text.Equals("All") && !cb_Area.Text.Equals(row["AreaID"]))
                            exist = false;
                        if (exist && !cb_Bank.Text.Equals("All") && !cb_Bank.Text.Equals(row["BankID"]))
                            exist = false;
                        if (exist && !cb_Branch.Text.Equals("All") && !cb_Branch.Text.Equals(row["BranchID"]))
                            exist = false;
                        if (exist && !cb_Model.Text.Equals("All") && !cb_Model.Text.Equals(row["ModelID"]))
                            exist = false;
                        if (exist && !cb_Province.Text.Equals("All") && !cb_Province.Text.Equals(row["ProvinceID"]))
                            exist = false;
                        if (exist)                       
                            LoadInfo(row);
                        continue;
                                       
                    }

                    if (cb_Area.Text.Equals("All") && row["AreaID"].ToString().ToUpper().Contains(tb_SubName.Text.ToUpper()))
                    {
                        LoadInfo(row);
                        continue;
                    }

                    if (cb_Bank.Text.Equals("All") && row["BankID"].ToString().ToUpper().Contains(tb_SubName.Text.ToUpper()))
                    {
                        LoadInfo(row);
                        continue;
                    }

                    if (cb_Branch.Text.Equals("All") && row["BranchID"].ToString().ToUpper().Contains(tb_SubName.Text.ToUpper()))
                    {
                        LoadInfo(row);
                        continue;
                    }

                    if (cb_Model.Text.Equals("All") && row["ModelID"].ToString().ToUpper().Contains(tb_SubName.Text.ToUpper()))
                    {
                        LoadInfo(row);
                        continue;
                    }

                    if (cb_Province.Text.Equals("All") && row["ProvinceID"].ToString().ToUpper().Contains(tb_SubName.Text.ToUpper()))
                    {
                        LoadInfo(row);
                        continue;
                    }
                }
                catch (Exception ex)
                { }

            }
		}
        private void LoadInfo(DataRow row)
        {
            try
            {
                n++;
                string[] item = { n.ToString(),row["TID"].ToString(), row["BankID"].ToString(),row["BranchID"].ToString(),row["Address"].ToString(), row["ModelID"].ToString(),row["DateInit"].ToString(), row["AreaID"].ToString(), row["ProvinceID"].ToString() };
                var listViewItem = new ListViewItem(item);
                listViewItem.Tag = row["ID"];
                lv_Terminal.Items.Add(listViewItem);
              
            }
            catch (Exception ex)
            { }
        }
        private void mode_Button2_Click(object sender, EventArgs e)
		{
            UC_Terminal_Update uc_Add = new UC_Terminal_Update(); 
            Frm_TemplateDefault frm = new Frm_TemplateDefault(uc_Add, @"New Terminal");
            frm.Width = uc_Add.Width + 5;
            frm.maxBtnCustom.Visible = false;
            frm.Show();
        }

		private void lv_Terminal_DoubleClick(object sender, EventArgs e)
		{
            if (lv_Terminal.SelectedItems.Count != 0)
            {
                UC_Terminal_Update uc_Add = new UC_Terminal_Update(lv_Terminal.SelectedItems[0].Tag.ToString());
                Frm_TemplateDefault frm = new Frm_TemplateDefault(uc_Add, @"Update Terminal");
                frm.Width = uc_Add.Width + 5;
                frm.maxBtnCustom.Visible = false;
                frm.Show();
            }
		}

		private void bt_Delete_Click(object sender, EventArgs e)
		{
            if (MessageBox.Show("Do you want delete " + lv_Terminal.SelectedItems.Count + " items ?", "Delete terminal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
           foreach(ListViewItem item in lv_Terminal.SelectedItems)
            {
                sqlite.DeleteEntry("Terminal", "ID", item.Tag.ToString());
            }
            Control_TextChanged(null, null);
        }

		private void bt_Import_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse excel file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xls",
                Filter = "excel file (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable tb = ExecuteQuery(openFileDialog1.FileName);
                foreach (DataRow r in tb.Rows)
                {
                    string date = r[@"Ngày Triển Khai"].ToString();
                    if (string.IsNullOrEmpty(date))
                        date = DateTime.Now.ToString("dd/MM/yyyy");
                  UC_Terminal_Update.AddTerminal(r["Tid"].ToString(), r["SerialNo"].ToString(), r["Địa Chỉ"].ToString(), r["Vùng Dịch Vụ"].ToString(), r["Khách Hàng"].ToString(), r["Chi Nhánh"].ToString(), r[@"Dòng Máy"].ToString(), r[@"Tỉnh/Tp"].ToString(), DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString(UC_Terminal_Update.DateFormat));
                }
                Control_TextChanged(null, null);
            }
        }
        private DataTable ExecuteQuery(string filePath)
        {
            DataTable dtexcel = new DataTable();
            try
            {

                bool hasHeaders = true;
                string HDR = hasHeaders ? "Yes" : "No";
                string strConn;
                if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=1\"";
                else
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=1\"";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                //Looping Total Sheet of Xl File
                /*foreach (DataRow schemaRow in schemaTable.Rows)
                {
                }*/
                //Looping a first Sheet of Xl File
                DataRow schemaRow = schemaTable.Rows[0];
                string sheet = schemaRow["TABLE_NAME"].ToString();
                if (!sheet.EndsWith("_"))
                {
                    string query = "SELECT  * FROM [DanhSachATM$]";
                    OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                    dtexcel.Locale = CultureInfo.CurrentCulture;
                    daexcel.Fill(dtexcel);
                }

                conn.Close();
                return dtexcel;

            }
            catch (Exception Ex)
            {


            }
            return dtexcel;
        }
    }

}
