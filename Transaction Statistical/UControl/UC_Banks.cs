using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml.Style.XmlAccess;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Banks : UserControl
    {
        SQLiteHelper sqlite;
        public UC_Banks()
        {
            InitializeComponent();
            sqlite = new SQLiteHelper();
            bt_Refresh_Click(null, null);
        }
       
       
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            DataTable tb = sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", InitParametar.GetParent_Bank());
            lv_Banks.Items.Clear();
            bt_Delete.Visible = false;
            bt_UpdateBank.Visible = false;
            bt_AddBank.Visible = false;
            for (int n = 0; n < tb.Rows.Count; n++)
            {
                string[] row = { n.ToString(), tb.Rows[n]["Field"].ToString(), tb.Rows[n]["Data"].ToString().Split('|')[0].ToString(), tb.Rows[n]["Data"].ToString().Split('|')[1].ToString() };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = tb.Rows[n]["ID"];
                lv_Banks.Items.Add(listViewItem);
               lv_Banks.Update();
            }
        }
       
       

        private void bt_AddBank_Click(object sender, EventArgs e)
        {
            if (sqlite.CheckExist2Value("CfgData", "Field", tb_SubName.Text, "Parent_ID", InitParametar.GetParent_Bank()))
            {
                MessageBox.Show("Sub name: [" + tb_SubName.Text + "] existed.", "Add Bank");
                return;
            }
            EntryList entr = new EntryList();
            entr.ColumnName.Add("Field");
            entr.Content.Add(tb_SubName.Text);
            entr.ColumnName.Add("Parent_ID");
            entr.Content.Add(InitParametar.GetParent_Bank());
                entr.ColumnName.Add("Data");
            entr.Content.Add(tb_Name.Text + "|" + tb_Address.Text);

            if (sqlite.CreateEntry("CfgData", entr))
            {
                MessageBox.Show("Add Bank: [" + tb_SubName.Text + "] success.", "Add bank");
                bt_Refresh_Click(null, null);
            }
            else
                MessageBox.Show("Add Bank: [" + tb_SubName.Text + "] fail.", "Add bank", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void CheckValidateAdd()
        {
            if (string.IsNullOrWhiteSpace(tb_SubName.Text) || string.IsNullOrWhiteSpace(tb_Name.Text) || string.IsNullOrWhiteSpace(tb_Address.Text))
            {
                bt_AddBank.Visible = false;
                bt_UpdateBank.Visible = false;
            }
            else
            {
                bt_AddBank.Visible = true;
                bt_UpdateBank.Visible = true;
            }
        }

        private void tb_Detect_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidateAdd();
        }

		private void lv_Banks_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (lv_Banks.SelectedItems.Count != 0)
            {
                tb_SubName.Tag = lv_Banks.SelectedItems[0].Tag;
                tb_SubName.Text = lv_Banks.SelectedItems[0].SubItems[1].Text;
                tb_Name.Text = lv_Banks.SelectedItems[0].SubItems[2].Text;
                tb_Address.Text = lv_Banks.SelectedItems[0].SubItems[3].Text;
                bt_Delete.Visible = true;
            }
        }

		private void bt_UpdateBank_Click(object sender, EventArgs e)
		{
            try
            {
             foreach(DataRow row in   sqlite.GetTableDataWith2ColumnName("CfgData", "Field", tb_SubName.Text, "Parent_ID", InitParametar.GetParent_Bank()).Rows)
                if (!row["ID"].ToString().Equals(tb_SubName.Tag.ToString()))
                {
                    MessageBox.Show("Sub name: [" + tb_SubName.Text + "] existed.", "Update Bank");
                    return;
                }
                EntryList entr = new EntryList();
                entr.ColumnName.Add("Field");
                entr.Content.Add(tb_SubName.Text);
                entr.ColumnName.Add("Parent_ID");
                entr.Content.Add(InitParametar.GetParent_Bank());
                entr.ColumnName.Add("Data");
                entr.Content.Add(tb_Name.Text + "|" + tb_Address.Text);

                if (sqlite.UpdateEntry("CfgData", entr,"ID", tb_SubName.Tag.ToString()))
                {
                    MessageBox.Show("Update Bank: [" + tb_SubName.Text + "] success.", "Update bank");
                    bt_Refresh_Click(null, null);
                }
                else
                    MessageBox.Show("Update Bank: [" + tb_SubName.Text + "] fail.", "Update bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            { }
		}

		private void bt_Delete_Click(object sender, EventArgs e)
		{
            try
            {
                if (lv_Banks.SelectedItems.Count != 0)
                {
                    if (MessageBox.Show("Do you want delete [" + lv_Banks.SelectedItems[0].SubItems[1].Text + "] ?", "Delete Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    if (sqlite.DeleteEntry("CfgData", "ID", lv_Banks.SelectedItems[0].Tag.ToString()))
                    {
                        MessageBox.Show("Delete bank [" + lv_Banks.SelectedItems[0].SubItems[1].Text + "] success.", "Delete Bank");
                        bt_Refresh_Click(null, null);
                    }
                    else
                        MessageBox.Show("Delete bank [" + lv_Banks.SelectedItems[0].SubItems[1].Text + "] fail.","Delete Bank",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                { MessageBox.Show("Please, select Bank need delete.");
                    bt_Delete.Visible = false;
                    bt_UpdateBank.Visible = false;                    
                }
            }
            catch (Exception ex)
            { }
		}
	}
}
