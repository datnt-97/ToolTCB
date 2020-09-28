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
	public partial class UC_Terminal_Update : UserControl
	{
      static  SQLiteHelper sqlite;
        string ID;
      public static  string DateFormat = @"dd/MM/yyyy HH:mm";
        public UC_Terminal_Update()
		{
			InitializeComponent();
            sqlite = new SQLiteHelper();
            LoadProvince();
            LoadBank();
            LoadModel();
            LoadAreaService();
            LoadNPSBranch();
            bt_Add.Visible = true;
            bt_Add.Enabled = false;
            bt_Update.Visible = false;
        }
        public UC_Terminal_Update(string id)
        {
            ID = id;
            InitializeComponent();
            sqlite = new SQLiteHelper();
            LoadProvince();
            LoadBank();
            LoadModel();
            LoadAreaService();
            LoadNPSBranch();
            bt_Update.Visible = true;
            LoadInfoTerminal(id);
        }
        private void CheckInvalid()
        {
            try
            {
                if (!cb_Province.Items.Contains(cb_Province.Text) ||!cb_Model.Items.Contains(cb_Model.Text) || !cb_Branch.Items.Contains(cb_Branch.Text)||!cb_Bank.Items.Contains(cb_Bank.Text) ||!cb_Area.Items.Contains(cb_Area.Text) || string.IsNullOrEmpty(tb_TID.Text.Trim()) || string.IsNullOrEmpty(tb_Serial.Text.Trim()) || string.IsNullOrEmpty(tb_Address.Text.Trim()))
                {
                    bt_Add.Enabled = false;
                    return;
                }
                bt_Add.Enabled = true;

            }
            catch (Exception ex)
            { }
        }
        private void LoadInfoTerminal(string id)
        {
            try
            {
                DataRow row = sqlite.GetRowDataWithColumnName("Terminal", "ID", ID);
                if (row == null)
                {
                    MessageBox.Show("Terminal not exist.", "Load Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tb_Address.Text = row["Address"].ToString();
                tb_Serial.Text = row["Serial"].ToString();
                tb_TID.Text = row["TID"].ToString();
                dt_Day.Value = DateTime.ParseExact(row["DateInit"].ToString(),DateFormat, System.Globalization.CultureInfo.InvariantCulture);

                cb_Area.SelectedText = row["AreaID"].ToString();
                cb_Bank.SelectedText = row["BankID"].ToString();
                cb_Branch.SelectedText = row["BranchID"].ToString();
                cb_Province.SelectedText = row["ProvinceID"].ToString();
                cb_Model.SelectedText = row["ModelID"].ToString();
                if (!cb_Area.Items.Contains(row["AreaID"].ToString()))
                    if (MessageBox.Show("Area [" + row["AreaID"] + "] not exist. Do you want create ?", "Not exist.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bt_Area.Text = "Add";
                        bt_Area_Click(null, null);
                    }

                if (!cb_Bank.Items.Contains(row["BankID"].ToString()))
                    MessageBox.Show("Bank [" + row["BankID"] + "] not exist. You need create it.", "Not exist.", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (!cb_Branch.Items.Contains(row["BranchID"].ToString()))
                    if (MessageBox.Show("Branch [" + row["BranchID"] + "] not exist. Do you want create ?", "Not exist.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bt_Branch.Text = "Add";
                        bt_Branch_Click(null, null);
                    }

                if (!cb_Province.Items.Contains(row["ProvinceID"].ToString()))
                    if (MessageBox.Show("Province [" + row["ProvinceID"] + "] not exist. Do you want create ?", "Not exist.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bt_Province.Text = "Add";
                        bt_Province_Click(null, null);
                    }

                if (!cb_Model.Items.Contains(row["ModelID"].ToString()))
                    if (MessageBox.Show("Model [" + row["ModelID"] + "] not exist. Do you want create ?", "Not exist.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bt_Model.Text = "Add";
                        bt_Model_Click(null, null);
                    }
            }
            catch (Exception ex)
            { }
        }
        private void LoadModel()
        {
            try
            {
                cb_Model.Items.Clear();
                foreach (DataRow row in sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID",InitParametar.GetParent_ModelMachine()).Select().OrderBy(u => u["Field"]).ToArray())
                    cb_Model.Items.Add(row["Field"]);
            }
            catch (Exception ex)
            { }
        }
        private void LoadNPSBranch()
        {
            try
            {
                cb_Branch.Items.Clear();
                foreach (DataRow row in sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", InitParametar.GetParent_NPSBranch()).Select().OrderBy(u => u["Field"]).ToArray())
                    cb_Branch.Items.Add(row["Field"]);
            }
            catch (Exception ex)
            { }
        }
      
        private void LoadProvince()
        {
            try
            {
                cb_Province.Items.Clear();
                foreach (DataRow row in sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", InitParametar.GetParent_Province()).Select().OrderBy(u => u["Field"]).ToArray())
                    cb_Province.Items.Add(row["Field"]);
            }
            catch (Exception ex)
            { }
        }
      
        private void LoadBank()
        {
            string ParentID_Banks =InitParametar.GetParent_Bank();
            DataTable tb = sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", ParentID_Banks);
            cb_Bank.Items.Clear();
            for (int n = 0; n < tb.Rows.Count; n++)
            {
                cb_Bank.Items.Add(tb.Rows[n]["Field"].ToString());
            }
        }
     
        private void LoadAreaService()
        {
            string ParentID =InitParametar.GetParent_AreaService();
            DataTable tb = sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", ParentID);
            cb_Area.Items.Clear();
            for (int n = 0; n < tb.Rows.Count; n++)
            {
                cb_Area.Items.Add(tb.Rows[n]["Field"].ToString());
            }
        }
       

        private void cb_Model_TextChanged(object sender, EventArgs e)
        {
            CheckInvalid();
            if (string.IsNullOrEmpty(cb_Model.Text.Trim()))
            {
                bt_Model.Visible = false;
                return;
            }
            bt_Model.Visible = true;
            bt_Model.Text = "Add";
            foreach (object s in cb_Model.Items)
                if (s.ToString().Equals(cb_Model.Text))
                    bt_Model.Text = "Remove";
        }
        private void bt_Model_Click(object sender, EventArgs e)
        {
            if (bt_Model.Text.Equals("Add"))
            {
                if (sqlite.CheckExist2Value("CfgData", "Field", cb_Model.Text, "Parent_ID", InitParametar.GetParent_ModelMachine()))
                {
                    MessageBox.Show("Sub name: [" + cb_Model.Text + "] existed.", "Add Model");
                    return;
                }
                EntryList entr = new EntryList();
                entr.ColumnName.Add("Field");
                entr.Content.Add(cb_Model.Text);
                entr.ColumnName.Add("Parent_ID");
                entr.Content.Add(InitParametar.GetParent_ModelMachine());
                entr.ColumnName.Add("Data");
                entr.Content.Add(cb_Model.Text);

                if (sqlite.CreateEntry("CfgData", entr))
                {
                    MessageBox.Show("Add Model: [" + cb_Model.Text + "] success.", "Add model");
                    LoadModel();
                }
                else
                    MessageBox.Show("Add Molde: [" + cb_Model.Text + "] fail.", "Add model", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bt_Model.Text.Equals("Remove"))
            {
                if (MessageBox.Show("Do you want remove: [" + cb_Model.Text + "]", "Remove model", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                string id = sqlite.GetColumnDataWith2ColumnName("CfgData", "Field", cb_Model.Text, "Parent_ID", InitParametar.GetParent_ModelMachine(), "ID");

                if (sqlite.DeleteEntry("CfgData", "ID", id))
                {
                    MessageBox.Show("Remove Model: [" + cb_Model.Text + "] success.", "Remove model");
                    LoadModel();
                }
                else
                    MessageBox.Show("Remove Model: [" + cb_Model.Text + "] fail.", "Remove model", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

		private void cb_Area_TextChanged(object sender, EventArgs e)
		{
            CheckInvalid();
            if (string.IsNullOrEmpty(cb_Area.Text.Trim()))
            {
                bt_Area.Visible = false;
                return;
            }
            bt_Area.Visible = true;
            bt_Area.Text = "Add";
            foreach (object s in cb_Area.Items)
                if (s.ToString().Equals(cb_Area.Text))
                    bt_Area.Text = "Remove";
        }

		private void bt_Area_Click(object sender, EventArgs e)
		{
            if (bt_Area.Text.Equals("Add"))
            {
                if (sqlite.CheckExist2Value("CfgData", "Field", cb_Area.Text, "Parent_ID", InitParametar.GetParent_AreaService()))
                {
                    MessageBox.Show("Area name: [" + cb_Area.Text + "] existed.", "Add Area");
                    return;
                }
                EntryList entr = new EntryList();
                entr.ColumnName.Add("Field");
                entr.Content.Add(cb_Area.Text);
                entr.ColumnName.Add("Parent_ID");
                entr.Content.Add(InitParametar.GetParent_AreaService());
                entr.ColumnName.Add("Data");
                entr.Content.Add(cb_Area.Text);

                if (sqlite.CreateEntry("CfgData", entr))
                {
                    MessageBox.Show("Add Area: [" + cb_Area.Text + "] success.", "Add area");
                    LoadAreaService();
                }
                else
                    MessageBox.Show("Add Area: [" + cb_Area.Text + "] fail.", "Add area", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bt_Area.Text.Equals("Remove"))
            {
                if (MessageBox.Show("Do you want remove: [" + cb_Area.Text + "]", "Remove area", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                string id = sqlite.GetColumnDataWith2ColumnName("CfgData", "Field", cb_Area.Text, "Parent_ID", InitParametar.GetParent_AreaService(), "ID");

                if (sqlite.DeleteEntry("CfgData", "ID", id))
                {
                    MessageBox.Show("Remove Area: [" + cb_Area.Text + "] success.", "Remove area");
                    LoadModel();
                }
                else
                    MessageBox.Show("Remove Area: [" + cb_Area.Text + "] fail.", "Remove area", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void cb_Province_TextChanged(object sender, EventArgs e)
		{
            CheckInvalid();
            if (string.IsNullOrEmpty(cb_Province.Text.Trim()))
            {
                bt_Province.Visible = false;
                return;
            }
            bt_Province.Visible = true;
            bt_Province.Text = "Add";
            foreach (object s in cb_Province.Items)
                if (s.ToString().Equals(cb_Province.Text))
                    bt_Province.Text = "Remove";
        }

		private void bt_Province_Click(object sender, EventArgs e)
		{
            if (bt_Province.Text.Equals("Add"))
            {
                if (sqlite.CheckExist2Value("CfgData", "Field", cb_Province.Text, "Parent_ID", InitParametar.GetParent_Province()))
                {
                    MessageBox.Show("Province name: [" + cb_Province.Text + "] existed.", "Add Province");
                    return;
                }
                EntryList entr = new EntryList();
                entr.ColumnName.Add("Field");
                entr.Content.Add(cb_Province.Text);
                entr.ColumnName.Add("Parent_ID");
                entr.Content.Add(InitParametar.GetParent_Province());
                entr.ColumnName.Add("Data");
                entr.Content.Add(cb_Province.Text);

                if (sqlite.CreateEntry("CfgData", entr))
                {
                    MessageBox.Show("Add Province: [" + cb_Province.Text + "] success.", "Add Province");
                    LoadProvince();
                }
                else
                    MessageBox.Show("Add Province: [" + cb_Province.Text + "] fail.", "Add Province", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bt_Province.Text.Equals("Remove"))
            {
                if (MessageBox.Show("Do you want remove: [" + cb_Province.Text + "]", "Remove province", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                string id = sqlite.GetColumnDataWith2ColumnName("CfgData", "Field", cb_Province.Text, "Parent_ID", InitParametar.GetParent_Province(), "ID");

                if (sqlite.DeleteEntry("CfgData", "ID", id))
                {
                    MessageBox.Show("Remove Province: [" + cb_Province.Text + "] success.", "Remove Province");
                    LoadProvince();
                }
                else
                    MessageBox.Show("Remove Province: [" + cb_Province.Text + "] fail.", "Remove Province", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void tb_TID_TextChanged(object sender, EventArgs e)
		{
            CheckInvalid();

        }

		private void tb_Serial_TextChanged(object sender, EventArgs e)
		{
            CheckInvalid();
        }

		private void tb_Address_TextChanged(object sender, EventArgs e)
		{
            CheckInvalid();
        }

		private void cb_Bank_TextChanged(object sender, EventArgs e)
		{
            CheckInvalid();
        }

		private void cb_Branch_TextChanged(object sender, EventArgs e)
		{
            CheckInvalid();
            if (string.IsNullOrEmpty(cb_Branch.Text.Trim()))
            {
                bt_Branch.Visible = false;
                return;
            }
            bt_Branch.Visible = true;
            bt_Branch.Text = "Add";
            if(cb_Branch.Items.Contains(cb_Branch.Text))             
                    bt_Branch.Text = "Remove";
        }

		private void bt_Branch_Click(object sender, EventArgs e)
		{
            if (bt_Branch.Text.Equals("Add"))
            {
                if (sqlite.CheckExist2Value("CfgData", "Field", cb_Branch.Text, "Parent_ID", InitParametar.GetParent_NPSBranch()))
                {
                    MessageBox.Show("Branch name: [" + cb_Branch.Text + "] existed.", "Add Branch");
                    return;
                }
                EntryList entr = new EntryList();
                entr.ColumnName.Add("Field");
                entr.Content.Add(cb_Branch.Text);
                entr.ColumnName.Add("Parent_ID");
                entr.Content.Add(InitParametar.GetParent_NPSBranch());
                entr.ColumnName.Add("Data");
                entr.Content.Add(cb_Branch.Text);

                if (sqlite.CreateEntry("CfgData", entr))
                {
                    MessageBox.Show("Add Branch: [" + cb_Branch.Text + "] success.", "Add Branch");
                    LoadNPSBranch();
                }
                else
                    MessageBox.Show("Add Branch: [" + cb_Branch.Text + "] fail.", "Add Branch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bt_Branch.Text.Equals("Remove"))
            {
                if (MessageBox.Show("Do you want remove: [" + cb_Branch.Text + "]", "Remove Branch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                string id = sqlite.GetColumnDataWith2ColumnName("CfgData", "Field", cb_Branch.Text, "Parent_ID", InitParametar.GetParent_NPSBranch(), "ID");

                if (sqlite.DeleteEntry("CfgData", "ID", id))
                {
                    MessageBox.Show("Remove Branch: [" + cb_Branch.Text + "] success.", "Remove Branch");
                    LoadNPSBranch();
                }
                else
                    MessageBox.Show("Remove Branch: [" + cb_Branch.Text + "] fail.", "Remove Branch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void bt_Add_Click(object sender, EventArgs e)
		{
            try
            { 
                if (AddTerminal(tb_TID.Text,tb_Serial.Text,tb_Address.Text,cb_Area.Text,cb_Bank.Text,cb_Branch.Text,cb_Model.Text,cb_Province.Text,dt_Day.Value.ToString(DateFormat)))              
                    MessageBox.Show("Create Terminal [" + tb_TID.Text + "] success.", "Create Terminal");                
                else
                    MessageBox.Show("Create Terminal [" + tb_TID.Text + "] fail.", "Create Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            { }
		}
       
		private void bt_Update_Click(object sender, EventArgs e)
		{
            try
            {
                foreach (DataRow row in sqlite.GetTableDataWith2ColumnName("Terminal", "TID", tb_TID.Text, "BankID", cb_Bank.Text).Rows)
                    if (row["ID"].ToString() != ID)
                    {
                        MessageBox.Show("Terminal [" + tb_TID.Text + "] existed.", "Update Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                foreach (DataRow row in sqlite.GetTableDataWithColumnName("Terminal", "Serial", tb_Serial.Text).Rows)
                    if (row["ID"].ToString() != ID)
                    {
                        MessageBox.Show("Serial [" + tb_Serial.Text + "] existed.", "Update Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                EntryList entr = new EntryList();
                entr.ColumnName.Add("TID");
                entr.Content.Add(tb_TID.Text);

                entr.ColumnName.Add("Serial");
                entr.Content.Add(tb_Serial.Text);

                entr.ColumnName.Add("Address");
                entr.Content.Add(tb_Address.Text);

                entr.ColumnName.Add("AreaID");
                entr.Content.Add(cb_Area.Text);

                entr.ColumnName.Add("BankID");
                entr.Content.Add(cb_Bank.Text);

                entr.ColumnName.Add("BranchID");
                entr.Content.Add(cb_Branch.Text);

                entr.ColumnName.Add("ModelID");
                entr.Content.Add(cb_Model.Text);

                entr.ColumnName.Add("ProvinceID");
                entr.Content.Add(cb_Province.Text);

                entr.ColumnName.Add("DateInit");
                entr.Content.Add(dt_Day.Value.ToString(DateFormat));
                if (sqlite.UpdateEntry("Terminal", entr,"ID",ID))
                    MessageBox.Show("Update Terminal [" + tb_TID.Text + "] success.", "Update Terminal");
                else
                    MessageBox.Show("Update Terminal [" + tb_TID.Text + "] fail.", "Update Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            { }
        }
        public static bool AddTerminal(string TID, string Serial, string Address, string Area, string Bank, string Branch, string Model, string Province, string dt_Day)
        {
            try
            {
                if (sqlite == null) sqlite = new SQLiteHelper();
                if (!string.IsNullOrEmpty(TID) && sqlite.CheckExist2Value("Terminal", "TID", TID, "BankID", Bank))
                {
                    MessageBox.Show("Terminal [" + TID + "] existed.", "Create Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (sqlite.CheckExistValue("Terminal", "Serial", Serial))
                {
                    MessageBox.Show("Serial [" + Serial + "] existed.", "Create Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                EntryList entr = new EntryList();
                entr.ColumnName.Add("TID");
                entr.Content.Add(TID);

                entr.ColumnName.Add("Serial");
                entr.Content.Add(Serial);

                entr.ColumnName.Add("Address");
                entr.Content.Add(Address);

                entr.ColumnName.Add("AreaID");
                entr.Content.Add(Area);

                entr.ColumnName.Add("BankID");
                entr.Content.Add(Bank);

                entr.ColumnName.Add("BranchID");
                entr.Content.Add(Branch);

                entr.ColumnName.Add("ModelID");
                entr.Content.Add(Model);

                entr.ColumnName.Add("ProvinceID");
                entr.Content.Add(Province);

                entr.ColumnName.Add("DateInit");
                entr.Content.Add(dt_Day);
                return sqlite.CreateEntry("Terminal", entr);
            }
            catch (Exception ex)
            { }
            return false;
        }
     
    }
}
