using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical.UControl
{
	public partial class UC_ExportOptionSelect : UserControl
	{
        DataTable dtTable = new DataTable();
        string tableName = string.Empty;
        string[] Tables;
        bool DataTables = false;
        public UC_ExportOptionSelect()
		{
			InitializeComponent();
		
		}
		public UC_ExportOptionSelect(string[] StrTable)
		{
			InitializeComponent();
            Tables = StrTable;
		}
		public UC_ExportOptionSelect(DataTable dt)
		{
			InitializeComponent();
			dtTable = dt;
			DataTables = true;
		}
        private void Select_Tables_Load(object sender, EventArgs e)
        {
            if (!DataTables)
            {
                if (Tables != null)
                {
                    for (int tables = 0; tables < Tables.Length; tables++)
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(Tables[tables])) continue;
                            ListViewItem lv = new ListViewItem();
                            lv.Text = Tables[tables].ToString();
                            lv.Tag = tables;
                            lstViewTables.Items.Add(lv);
                        }
                        catch (Exception ex)
                        { }
                    }
                }
            }
            else
            {
                if (dtTable.Rows.Count > 0)
                {
                    for (int tables = 0; tables < dtTable.Rows.Count; tables++)
                    {
                        try
                        {
                            ListViewItem lv = new ListViewItem();
                            lv.Text = dtTable.Rows[tables][0].ToString();
                            lv.Tag = dtTable.Rows[tables][0];
                            lstViewTables.Items.Add(lv);
                        }
                        catch (Exception ex)
                        { }
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstViewTables.Items.Count > 0)
            {
                if (tableName != string.Empty)
                {
                    UC_ExportOption.SelectedTable = tableName;
                    if (this.ParentForm != null) this.ParentForm.Close();  
                }
                else
                {
                    MessageBox.Show("Select a Table");
                }
            }
            else
            {
                if (this.ParentForm != null) this.ParentForm.Close();
            }
        }

        private void lstViewTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tableName = lstViewTables.Items[lstViewTables.SelectedIndices].ToString();
        }

        private void lstViewTables_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            tableName = e.Item.Text;
        }
    }
}
