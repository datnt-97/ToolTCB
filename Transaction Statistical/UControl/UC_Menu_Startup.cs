using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;
using Transaction_Statistical.Class;
using System.Threading;
using Microsoft.Win32;

namespace Transaction_Statistical
{
    public partial class UC_Menu_Startup : UserControl
    {
        RegistryWatcher watcherReg;
        public static Dictionary<int, string> Template = new Dictionary<int, string>()
        {
            {(int)TemplateHelper.TEMPLATE.CanQuyTheoCouterTrenMay,"Cân Quỹ Theo Counter Trên Máy" },
            {(int)TemplateHelper.TEMPLATE.BaoCaoGiaoDichTaiChinh,"GD Tài Chính" },
            {(int)TemplateHelper.TEMPLATE.BaoCaoGiaoDichTaiChinhKhongThanhCong,"GD Tài Chính Không Thành Công" },
            {(int)TemplateHelper.TEMPLATE.BaoCaoGiaoDichTaiChinhBatThuong,"GD Tài Chính Bất Thường" },
            {(int)TemplateHelper.TEMPLATE.BaoCaoHoatDongBatThuong,"BC HD Bất Thường" },
            {(int)TemplateHelper.TEMPLATE.BaoCaoHoatDongBatThuongTheoChuKy,"BC HD Bất Thường Theo Chu Kỳ" },
        };
        string[] TypeStart = { "DAILY", "ONCE", "WEEKLY", "MONTHLY" };
        // string[] Months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC", "*" };
        //  string[] Days = { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };

        string TaskName = "AutoRunTransaction_";
        UC_Explorer uc_Explorer;
        SQLiteHelper sqlite;
        string forms;
        Process process;
        public UC_Menu_Startup()
        {
            InitializeComponent2();
            uc_Explorer = new UC_Explorer();
            sqlite = new SQLiteHelper();
            process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "SCHTASKS";
            LoadTemplate();
            LoadTask();
        }
        
        public void LoadTemplate()
        {
            try
            {
                cbo_TypeStart.Items.AddRange(TypeStart);
                for (int i = 0; i < 7; i++)
                    cbo_Week.Items.Add(DateTime.Now.AddDays(i).ToString("ddd").ToUpper());
                for (int i = 0; i < 12; i++)
                    cbo_Month.Items.Add(DateTime.Now.AddMonths(i).ToString("MMM").ToUpper());

                DataTable cfg_vendor = InitParametar.sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "60", "Parent_ID", "54");
                foreach (DataRow R in cfg_vendor.Rows)
                {
                    ComboBoxItem cb = new ComboBoxItem();
                    cb.Text = R["Field"].ToString();
                    cb.Value = R["ID"].ToString();
                    cbo_LstTemplate.Items.Add(cb);
                    if (cb.Value.Equals(InitParametar.ReadTrans.TemplateTransactionID.ToString())) cbo_LstTemplate.SelectedItem = cb;
                }
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = UC_Menu_Startup.Template;
                ckbl_Forms.DataSource = bindingSource;
                ckbl_Forms.DisplayMember = "Value";
                Template.ToList().ForEach(x => { ckbl_Forms.SetItemChecked(x.Key, true); });
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void LoadTask()
        {
            // DataTable cfg_data = sqlite.GetTableDataWithColumnName("CfgData", "Type_ID", "511");
            int n = 0;
            dataGridView_lsPermissions.Rows.Clear();
            try
            {
                //foreach (DataRow rowData in cfg_data.Rows)
                //{
                //    DataGridViewRow row = new DataGridViewRow();
                //    string[] description = rowData["Data"].ToString().Split('|');
                //    row.CreateCells(dataGridView_lsPermissions);
                //    row.Cells[0].Value = n; n++;
                //    row.Cells[1].Value = rowData["Field"];
                //    row.Cells[2].Value = CheckTaskExist(rowData["Field"].ToString());
                //    row.Cells[3].Value = description[0].Split(';')[0];
                //    row.Cells[5].Value = string.Format("Template: {0}, source: {1}, destination: {2}, forms: {3} ", description[1], description[2], description[3], description[4]);
                //    row.Tag = rowData;
                //    dataGridView_lsPermissions.Rows.Add(row);
                //}
                foreach (string task in RegistryCus.GetValues(InitParametar.SubkeyTaskCurrentUser))
                {
                    string value = RegistryCus.GetValue(InitParametar.SubkeyTaskCurrentUser, task);
                    string[] description = value.Split('|');
                    if (description.Length == 6)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView_lsPermissions);
                        row.Cells[0].Value = n; n++;
                        row.Cells[1].Value = task;
                        row.Cells[2].Value = bool.Parse(description[5]);// CheckTaskExist(task);
                        row.Cells[3].Value = description[0].Split(';')[0];
                        row.Cells[5].Value = string.Format("Template: {0}, source: {1}, destination: {2}, forms: {3} ", description[1], description[2], description[3], description[4]);
                        row.Tag = value;
                        dataGridView_lsPermissions.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void txt_MouseDown(object sender, MouseEventArgs e)
        {
            uc_Explorer.ShowUp2DownFromControl(this, sender as Control);
        }
        private void txt_HH_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = sender as TextBox;
            string pattern = @"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$";

            if (box != null)
            {
                if (!Regex.IsMatch(box.Text, pattern, RegexOptions.CultureInvariant))
                {
                    MessageBox.Show("Not a valid time format ('HH:mm').");
                    e.Cancel = true;
                    box.Select(0, box.Text.Length);
                }
            }
        }
        private bool CheckTaskExist(string taskName)
        {
            process.StartInfo.Arguments = string.Format("/query /TN \"{0}\"", TaskName + taskName);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            string err = process.StandardError.ReadToEnd();

            if (output.Contains(taskName) || err.Contains(taskName)) return true;
            return false;
        }
        private bool EnableTask(string taskName)
        {
            try
            {
                string value = RegistryCus.GetValue(InitParametar.SubkeyTaskCurrentUser, taskName);
                string[] values = value.Split('|');
                if (values.Length == 6)
                {
                    values[5] = true.ToString();
                    return RegistryCus.WriteValue(InitParametar.SubkeyTaskCurrentUser, taskName, string.Join("|", values));
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        private bool DisableTask(string taskName)
        {
            try
            {
                string value = RegistryCus.GetValue(InitParametar.SubkeyTaskCurrentUser, taskName);
                string[] values = value.Split('|');
                if (values.Length == 6)
                {
                    values[5] = false.ToString();
                    return RegistryCus.WriteValue(InitParametar.SubkeyTaskCurrentUser, taskName, string.Join("|", values));
                }
            }
            catch (Exception ex)
            { InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);  }
            return false;
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_lsPermissions.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please, select Task name to remove!", "Remove Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              //  DataRow row = dataGridView_lsPermissions.SelectedRows[0].Tag as DataRow;
              //  DisableTask(row["Field"].ToString());
                //if (sqlite.DeleteEntry("CfgData", "ID", row["ID"].ToString()))
                //{
                //    MessageBox.Show("Remove task successful", "Remove Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    LoadTask();
                //    return;
                //}
                if (RegistryCus.DeleteValue(InitParametar.SubkeyTaskCurrentUser , dataGridView_lsPermissions.SelectedRows[0].Cells[1].Value.ToString()))
                {
                    MessageBox.Show("Remove task successful", "Remove Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTask();
                    SendCommandService ("ReloadTask");
                    return;
                }
                MessageBox.Show("Remmove task unsuccessful", "Remove Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); ;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //EntryList entr = new EntryList();
                //entr.ColumnName.Add("Field");
                //entr.Content.Add(txt_TaskName.Text);
                if (string.IsNullOrEmpty(txt_TaskName.Text) || string.IsNullOrEmpty(txt_Source.Text) || string.IsNullOrEmpty(txt_Destination.Text) || string.IsNullOrEmpty(cbo_LstTemplate.Text))
                {
                    MessageBox.Show("Fields not empty.", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //if (sqlite.CheckExistEntry("CfgData", entr))
                //{
                //    MessageBox.Show("Task name existed.", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (RegistryCus.ExistValue(InitParametar.SubkeyTaskCurrentUser, txt_TaskName.Text.Trim()))
                {
                    MessageBox.Show("Task name existed.", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string data = string.Format("{0};{1};{2};{3}", txt_HH.Text, cbo_TypeStart.Text, cbo_TypeStart.SelectedItem.Equals(TypeStart[2]) ? cbo_Week.Text : cbo_Month.Text, Nud_Day.Value);
                data += "|" + (cbo_LstTemplate.SelectedItem as ComboBoxItem).Value + "|" + txt_Source.Text + "|" + txt_Destination.Text + "|" + forms;
                //foreach (var item in ckbl_Forms.CheckedItems) data += item.ToString() + ";"; data = data.TrimEnd(';');

                Dictionary<int, string> TemplateChoosen = new Dictionary<int, string>();
                foreach (var item in ckbl_Forms.CheckedItems)
                {
                    var row = (KeyValuePair<int, string>)(item);
                    TemplateChoosen.Add(row.Key, row.Value);
                }
                data += string.Join(";", TemplateChoosen) + "|" + true.ToString();
                //entr.ColumnName.Add("Type_ID");
                //entr.Content.Add("511");
                //entr.ColumnName.Add("Data");
                //entr.Content.Add(data);
                //if (sqlite.CreateEntry("CfgData", entr))
                //{
                //    MessageBox.Show("Add Task successful", "Add Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    LoadTask();
                //    return;
                //}
                if (RegistryCus.WriteValue(InitParametar.SubkeyTaskCurrentUser, txt_TaskName.Text.Trim(), data))
                {
                    MessageBox.Show("Add Task successful", "Add Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTask();
                    SendCommandService("ReloadTask"); 
                    return;
                }
                else
                    MessageBox.Show("Add Task unsuccessful", "Add Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); ;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //  DataRow row = dataGridView_lsPermissions.SelectedRows[0].Tag as DataRow;
                string data = string.Format("{0};{1};{2};{3}", txt_HH.Text, cbo_TypeStart.Text, cbo_TypeStart.SelectedItem.Equals(TypeStart[2]) ? cbo_Week.Text : cbo_Month.Text, Nud_Day.Value) + "|" + (cbo_LstTemplate.SelectedItem as ComboBoxItem).Value + "|" + txt_Source.Text + "|" + txt_Destination.Text + "|" + forms;
                //foreach (var item in ckbl_Forms.CheckedItems) data += item.ToString() + ";"; data = data.TrimEnd(';');

                Dictionary<int, string> TemplateChoosen = new Dictionary<int, string>();
                foreach (var item in ckbl_Forms.CheckedItems)
                {
                    var rows = (KeyValuePair<int, string>)(item);
                    TemplateChoosen.Add(rows.Key, rows.Value);
                }
                data += string.Join(";", TemplateChoosen) + "|" + true.ToString();
                //if (sqlite.Update1Entry("CfgData", "Data", data, "ID", row["ID"].ToString()))
                //{
                //    RegistryCus.CreateSubKey(InitParametar.Subkey, Environment.UserName);
                //    RegistryCus.SetValueKey(InitParametar.Subkey + "\\" + Environment.UserName, row["Field"].ToString(), data);
                //    MessageBox.Show("Save Task  successful", "Save Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    LoadTask();
                //    return;
                //}
                if (RegistryCus.WriteValue(InitParametar.SubkeyTaskCurrentUser, txt_TaskName.Text.Trim(), data))
                {
                   // RegistryCus.CreateSubKey(InitParametar.SubkeyTaskCurrentUser, Environment.UserName);
                    MessageBox.Show("Save Task  successful", "Save Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTask();
                    SendCommandService("ReloadTask");
                    return;
                }
                MessageBox.Show("Save task unsuccessful", "Save Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); ;
            }
        }
        private void txt_TaskName_TextChanged(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            btn_Add.Enabled = true;
            btn_Remove.Enabled = false;
        }

        private void dataGridView_lsPermissions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_lsPermissions.SelectedRows.Count == 0) return;
                txt_TaskName.Text = dataGridView_lsPermissions.SelectedRows[0].Cells[1].Value.ToString();
                string[] field = dataGridView_lsPermissions.SelectedRows[0].Tag.ToString().Split('|');
                if (field.Length == 6)
                {
                    txt_HH.Text = field[0].Split(';')[0];
                    cbo_TypeStart.SelectedItem = field[0].Split(';').Length >= 2 ? field[0].Split(';')[1] : cbo_TypeStart.Items[0];
                    if (cbo_TypeStart.SelectedItem.Equals(TypeStart[2])) cbo_Week.Text = field[0].Split(';')[2];
                    else if (cbo_TypeStart.SelectedItem.Equals(TypeStart[3])) { cbo_Month.Text = field[0].Split(';')[2]; Nud_Day.Value = (decimal)int.Parse(field[0].Split(';')[3]); }

                    foreach (ComboBoxItem cb in cbo_LstTemplate.Items) if (cb.Text.Equals(field[1])) cbo_LstTemplate.SelectedItem = cb;
                    txt_Source.Text = field[2];
                    txt_Destination.Text = field[3];
                    forms = field[3];
                }
                btn_Add.Enabled = false;
                btn_Save.Enabled = true;
                btn_Remove.Enabled = true;
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); 
            }
        }

        private void dataGridView_lsPermissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (dataGridView_lsPermissions.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewCheckBoxCell)
            {
                if ((bool)dataGridView_lsPermissions.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue)
                {
                    EnableTask(dataGridView_lsPermissions.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                else
                {
                    DisableTask(dataGridView_lsPermissions.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }
            else if (dataGridView_lsPermissions.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                if ((bool)dataGridView_lsPermissions.Rows[e.RowIndex].Cells[2].EditedFormattedValue)
                {
                    SendCommandService(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [WFA] RunTask " + InitParametar.CurrentUser + "/" + dataGridView_lsPermissions.Rows[e.RowIndex].Cells[1].Value);
                    MessageBox.Show("Sent the command successfully.", "Run Task");
                }
                else
                    MessageBox.Show("Task not Active", "Run Task");
            }
            Cursor = Cursors.Default;
        }

        private void UC_Menu_Startup_Load(object sender, EventArgs e)
        {

        }

        private void cbo_TypeStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TypeStart.Text.Equals(TypeStart[0]) || cbo_TypeStart.Text.Equals(TypeStart[1]))
            {
                pnl_Week.Visible = false;
                pnl_Month.Visible = false;
            }
            else if (cbo_TypeStart.Text.Equals(TypeStart[2]))
            {
                pnl_Week.Visible = true;
                pnl_Month.Visible = false;
            }
            else
            {
                pnl_Week.Visible = false;
                pnl_Month.Visible = true;
            }
        }
        
        private void SendCommandService(string cmd)
        {
            try
            {
                RegistryCus.WriteValue(InitParametar.SubkeyApp, "WFA", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [WFA] " + cmd);
                if (watcherReg == null)
                {
                    watcherReg = new RegistryWatcher(new Tuple<string, string>(InitParametar.SubkeyApp, "SRV"));
                    watcherReg.RegistryChange += RegistryChanged;
                }
            }
            catch(Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); ;
            }
        }
        private void RegistryChanged(object sender, RegistryWatcher.RegistryChangeEventArgs args)
        {
            try
            {
                if (!string.IsNullOrEmpty(args.Value.ToString()))
                {
                    MessageBox.Show(args.Value.ToString(), "Info from Service Scheduler");
                    Registry.SetValue(args.KeyName, args.ValueName, string.Empty);

                }
            }
            catch(Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); ;
            }
        }
    }
}
