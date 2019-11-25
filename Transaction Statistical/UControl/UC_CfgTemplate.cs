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
using FastColoredTextBoxNS;

namespace Transaction_Statistical
{
    public partial class UC_CfgTemplate : UserControl
    {
        SQLiteHelper sqlite;
        string template_ID;
        public UC_CfgTemplate(string Template_ID)
        {
            InitializeComponent();
            sqlite = new SQLiteHelper();
            template_ID = Template_ID;
        }

        private void btn_Keyword_Help_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "8", "Parent_ID", "9");

                UC_Info uc = new UC_Info("CfgData", cfg_data.Rows[0]["ID"].ToString(), "Data");              
                uc.Dock = DockStyle.Fill;
                Frm_TemplateDefault frm = new Frm_TemplateDefault(uc);
                frm.titleCustom.Text = "Regular Expression trong C#";
                frm.Show();
            }
            catch
            { }
        }

        private void spc_Main_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void spc_Keyword_Main_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void fctxt_Unsuccessful_Load(object sender, EventArgs e)
        {

        }

        private void fctxt_Successful_Load(object sender, EventArgs e)
        {

        }

        private void fctxt_Identification_Load(object sender, EventArgs e)
        {

        }

        private void btn_Transaction_Remove_Click(object sender, EventArgs e)
        {

            ComboBoxItem item = cbo_Transactions.SelectedItem as ComboBoxItem;
            try
            {
                if (item != null)
                {
                    if (sqlite.DeleteEntry("Transactions", "ID", item.Value.ToString()))
                        MessageBox.Show("Delete transaction [" + item.Text + "] info successful", "Delete transaction info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Delete transaction [" + item.Text + "] info fail", "Delete transaction info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_Transaction_Refresh_Click(null,null);
                    return;
                }
                else
                {
                }
            }
            catch { }
            MessageBox.Show("Delete transaction [" + item.Text + "] info fail", "Delete transaction info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Transaction_Save_Click(object sender, EventArgs e)
        {
            ComboBoxItem item = cbo_Transactions.SelectedItem as ComboBoxItem;
            try
            {
                if (item != null)
                {

                    EntryList entr = new EntryList();
                    entr.ColumnName.Add("Name");
                    entr.Content.Add(cbo_Transactions.Text);
                    entr.ColumnName.Add("TemplateID");
                    entr.Content.Add(template_ID);
                    entr.ColumnName.Add("IdentificationTxt");
                    entr.Content.Add(fctxt_Identification.Text);
                    entr.ColumnName.Add("SuccessfulTxt");
                    entr.Content.Add(fctxt_Successful.Text);
                    entr.ColumnName.Add("UnsuccessfulTxt");
                    entr.Content.Add(fctxt_Unsuccessful.Text);
                    sqlite.UpdateEntry("Transactions", entr, "ID", item.Value.ToString());
                    MessageBox.Show("Save transaction [" + item.Text + "] info successful", "Save transaction info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Transaction_Refresh_Click(null,null);
                    return;
                }
                else
                {
                }
            }
            catch { }
            MessageBox.Show("Save transaction [" + item.Text + "] info fail", "Save transaction info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Transaction_Add_Click(object sender, EventArgs e)
        {
            try
            {

                if (sqlite.CheckExistValue("Transactions", "Name", cbo_Transactions.Text))
                {
                    MessageBox.Show("Transaction [" + cbo_Transactions.Text + "] already exists", "Add transaction info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    EntryList entr = new EntryList();
                    entr.ColumnName.Add("Name");
                    entr.Content.Add(cbo_Transactions.Text);
                    entr.ColumnName.Add("TemplateID");
                    entr.Content.Add(template_ID);
                    entr.ColumnName.Add("IdentificationTxt");
                    entr.Content.Add(fctxt_Identification.Text);
                    entr.ColumnName.Add("SuccessfulTxt");
                    entr.Content.Add(fctxt_Successful.Text);
                    entr.ColumnName.Add("UnsuccessfulTxt");
                    entr.Content.Add(fctxt_Unsuccessful.Text);
                    sqlite.CreateEntry("Transactions", entr);
                    MessageBox.Show("Add transaction [" + cbo_Transactions.Text + "] info successful", "Add transaction info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Transaction_Refresh_Click(null, null);
                    return;
                }
            }
            catch { }
            MessageBox.Show("Add transaction [" + cbo_Transactions.Text + "] info fail", "Add transaction info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        private void grp_Keyword_Enter(object sender, EventArgs e)
        {

        }

        private void spc_Keyword_Level_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void spc_Keyword_Pattern_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void spc_Keyword_Test_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chk_Keywork_Pattern_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Keywork_Pattern.Checked) fctxt_Pattern.WordWrap = true;
            else fctxt_Pattern.WordWrap = false;
        }

        private void btn_Keyword_Add_Click(object sender, EventArgs e)
        {
            try
            {
              ComboBoxItem  cb = cbo_Keyword_LstKeyword.SelectedItem as ComboBoxItem;
                if (cb != null && cb.Value is DataRow) { MessageBox.Show("Data existed !!", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                if (cbo_Keyword_LstKeyword.Text == string.Empty) { MessageBox.Show("Map Contents not empty !!", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (fctxt_Pattern.Text == string.Empty) { MessageBox.Show("Pattern string not empty !!", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                EntryList entry = new EntryList();
                entry.ColumnName.Add("Field");
                entry.Content.Add(cbo_Keyword_LstKeyword.Text);
                entry.ColumnName.Add("Data");
                entry.Content.Add(fctxt_Pattern.Text);
                entry.ColumnName.Add("Type_ID");
                entry.Content.Add("67");
                entry.ColumnName.Add("Parent_ID");
                entry.Content.Add(template_ID);
                if (sqlite.CreateEntry("CfgData", entry))
                {
                    MessageBox.Show("Add data successful", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Keyword_Resfresh_Click(sender, e);
                    return;
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            if (MessageBox.Show("Add data fail", "Add data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                btn_Keyword_Add_Click(sender, e);
        }

        private void btn_Keyword_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem cb = cbo_Keyword_LstKeyword.SelectedItem as ComboBoxItem;
                if (cb != null && cb.Value is DataRow)
                {
                    DataRow R = cb.Value as DataRow;
                    if (sqlite.DeleteEntry("CfgData", "ID", R["ID"].ToString()))
                    {
                        MessageBox.Show("Remove data successful", "Remove data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Keyword_Resfresh_Click(sender, e);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please, select Map Contens", "Remove data", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }

            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            if (MessageBox.Show("Remove data fail", "Remove data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                btn_Keyword_Remove_Click(sender, e);
        }

        private void btn_Keyword_Save_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem cb = cbo_Keyword_LstKeyword.SelectedItem as ComboBoxItem;
                if (cb != null && cb.Value is DataRow)
                {
                    DataRow R = cb.Value as DataRow;
                    if (sqlite.Update1Entry("CfgData", "Data", fctxt_Pattern.Text, "ID", R["ID"].ToString()))
                    {
                        MessageBox.Show("Save successful", "Save data", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                    }

                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            if (MessageBox.Show("Save fail", "Save data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                btn_Keyword_Save_Click(sender, e);
        }

        private void grp_Transaction_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chk_Keywork_Test_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Keywork_Test.Checked) fctxt_Test.WordWrap = true;
            else fctxt_Test.WordWrap = false;
        }
    

        private void btn_Keyword_Import_Click(object sender, EventArgs e)
        {

        }

        private void btn_Keyword_Run_Click(object sender, EventArgs e)
        {
            try
            {
                UC_Info uc = new UC_Info();
                uc.Dock = DockStyle.Fill;
                Frm_TemplateDefault frm = new Frm_TemplateDefault(uc);
                frm.titleCustom.Text = "Test map";
                DateTime timeStart = DateTime.Now;
                if (fctxt_Pattern.Text.Trim() == string.Empty || fctxt_Test.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please, input data Pattern string and Test string", "Run test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Style fontTitle = new TextStyle(Brushes.Blue, null, FontStyle.Bold);
                    Style fontBody = new TextStyle(Brushes.Green, null, FontStyle.Bold);
                    string sReg = fctxt_Pattern.Text;
                    string sString = fctxt_Test.Text;
                    Dictionary<int, RegesValue> listResult = new Dictionary<int, RegesValue>();
                    if (Regexs.RunPatternRegular(sString, sReg, out listResult))
                    {
                        uc.TextCustom.AppendText("Time: " + (DateTime.Now - timeStart).TotalMilliseconds + " milliseconds ~ " + (DateTime.Now - timeStart).TotalSeconds + " seconds\n", fontTitle);
                        int k = 0;
                        foreach (KeyValuePair<int, RegesValue> group in listResult)
                        {
                            k++;
                            uc.TextCustom.AppendText(Environment.NewLine + "Found map: " + k.ToString() + "/" + listResult.Count.ToString() + Environment.NewLine +  "-----------Group var map-----------" + Environment.NewLine, fontTitle);
                            foreach (KeyValuePair<string, string> var in group.Value.value)
                            {
                                uc.TextCustom.AppendText(var.Key + "=" + var.Value + Environment.NewLine, fontTitle);
                            }
                            uc.TextCustom.AppendText("-----------Map string--------------" + Environment.NewLine, fontTitle);
                            uc.TextCustom.AppendText(group.Value.stringfind + Environment.NewLine, fontBody);
                        }
                    }
                    else
                    {
                        uc.TextCustom.AppendText("Time: " + (DateTime.Now - timeStart).TotalMilliseconds + " milliseconds ~ " + (DateTime.Now - timeStart).TotalSeconds + " seconds\n", fontTitle);
                        uc.TextCustom.AppendText("Not math :(", new TextStyle(Brushes.Red, null, FontStyle.Italic));
                    }
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void fctxt_Pattern_Load(object sender, EventArgs e)
        {

        }

        private void fctxt_Test_Load(object sender, EventArgs e)
        {

        }

        private void btn_Keyword_Resfresh_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "67", "Parent_ID", template_ID);
                cbo_Keyword_LstKeyword.Items.Clear();
                foreach (DataRow R in cfg_data.Rows)
                {
                    ComboBoxItem cb = new ComboBoxItem();
                    cb.Text = R["Field"].ToString();
                    cb.Value = R;
                    cbo_Keyword_LstKeyword.Items.Add(cb);
                }
                if (cbo_Keyword_LstKeyword.Items.Count != 0) cbo_Keyword_LstKeyword.SelectedIndex = 0;
            }
            catch { }
        }

        private void cbo_Keyword_LstKeyword_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fctxt_Pattern.Clear();
                ComboBoxItem cb = cbo_Keyword_LstKeyword.SelectedItem as ComboBoxItem;
                if (cb != null && cb.Value is DataRow)
                {
                    DataRow R = cb.Value as DataRow;
                    fctxt_Pattern.Text = R["Data"].ToString();
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            }

        private void cbo_Keyword_LstKeyword_MouseDown(object sender, MouseEventArgs e)
        {
            if (cbo_Keyword_LstKeyword.Items.Count == 0) btn_Keyword_Resfresh_Click(sender, e);
        }

        private void cbo_Transactions_MouseDown(object sender, MouseEventArgs e)
        {
            if (cbo_Transactions.Items.Count == 0) btn_Transaction_Refresh_Click(sender, e);
        }
        private void cbo_Transactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem item = cbo_Transactions.SelectedItem as ComboBoxItem;
            if (item != null)
            {
                DataRow r = sqlite.GetRowDataWithColumnName("Transactions", "ID", item.Value.ToString());
                btn_Transaction_Remove.Enabled = true;
                btn_Transaction_Save.Enabled = true;
                btn_Transaction_Add.Enabled = false;
                fctxt_Identification.Text = r["IdentificationTxt"].ToString();
                fctxt_Successful.Text = r["SuccessfulTxt"].ToString();
                fctxt_Unsuccessful.Text = r["UnsuccessfulTxt"].ToString(); ;
            }
            else
            {
                btn_Transaction_Remove.Enabled = false;
                btn_Transaction_Save.Enabled = false;
                btn_Transaction_Add.Enabled = true;
            }
        }

        private void cbo_Transactions_TextChanged(object sender, EventArgs e)
        {
            btn_Transaction_Remove.Enabled = false;
            btn_Transaction_Save.Enabled = false;
            btn_Transaction_Add.Enabled = true;
        }

        private void btn_Transaction_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                cbo_Transactions.Items.Clear();
                cbo_Transactions.Text = string.Empty;
                DataTable tb_trans = sqlite.GetTableDataWithColumnName("Transactions", "TemplateID", template_ID);
                foreach (DataRow r in tb_trans.Rows)
                {
                    ComboBoxItem cb = new ComboBoxItem();
                    cb.Text = r["Name"].ToString();
                    cb.Value = r["ID"].ToString();
                    cbo_Transactions.Items.Add(cb);
                }
            }
            catch (Exception ex) { InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); }
        }
    }
}
