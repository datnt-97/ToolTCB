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

namespace Transaction_Statistical
{
    public partial class UC_Menu_Startup : UserControl
    {
        public static Dictionary<int, string> Template = new Dictionary<int, string>()
        {
            {0,"Cân Quỹ Theo Counter Trên Máy" },
            {1,"Báo Cáo Giao Dịch Tài Chính" },
            {2,"Báo Cáo Giao Dịch Tài Chính Không Thành Công" },
            {3,"Báo Cáo Giao Dịch Tài Chính Bất Thường" },
            {4,"Báo Cáo Hoạt Động Bất Thường" },
        };
        string TaskName = "AutoRunTransaction_";
        UC_Explorer uc_Explorer;
        SQLiteHelper sqlite;
        string forms;
        Process process;
        public UC_Menu_Startup()
        {
            InitializeComponent();
            uc_Explorer = new UC_Explorer();
            sqlite = new SQLiteHelper();
            process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "schtasks";
            LoadTemplate();
            LoadTask();
        }
        public void LoadTemplate()
        {
            try
            {
                DataTable cfg_vendor = InitParametar.sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "60", "Parent_ID", "54");
                foreach (DataRow R in cfg_vendor.Rows)
                {
                    ComboBoxItem cb = new ComboBoxItem();
                    cb.Text = R["Field"].ToString();
                    cb.Value = R["ID"].ToString();
                    cbo_LstTemplate.Items.Add(cb);
                    if (cb.Value.Equals(InitParametar.TemplateTransactionID.ToString())) cbo_LstTemplate.SelectedItem = cb;
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
            DataTable cfg_data = sqlite.GetTableDataWithColumnName("CfgData", "Type_ID", "511");
            int n = 0;
            dataGridView_lsPermissions.Rows.Clear();
            foreach (DataRow rowData in cfg_data.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                string[] description = rowData["Data"].ToString().Split('|');
                row.CreateCells(dataGridView_lsPermissions);
                row.Cells[0].Value = n; n++;
                row.Cells[1].Value = rowData["Field"];
                row.Cells[2].Value = CheckTaskExist(rowData["Field"].ToString());
                row.Cells[3].Value = description[0];
                row.Cells[4].Value = string.Format("Template: {0}, source: {1}, destination: {2}, forms: {3} ", description[1], description[2], description[3], description[4]);
                row.Tag = rowData;
                dataGridView_lsPermissions.Rows.Add(row);
            }
        }
        private void txt_MouseDown(object sender, MouseEventArgs e)
        {
            uc_Explorer.ShowFromControl(this, sender as Control);
        }
        private void txt_HH_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = sender as TextBox;
            string pattern = "[0-1][0-9]:[0-6][0-9]";

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
            string fileExe = Process.GetCurrentProcess().MainModule.FileName + " Auto";
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
        private bool CreateTask(string time, string taskName)
        {
            string fileExe = Process.GetCurrentProcess().MainModule.FileName + " \"" + taskName + "\"";
            process.StartInfo.Arguments = string.Format("/Create /RU SYSTEM /SC DAILY /TN {0} /TR \"{1}\" /ST {2} /F", TaskName + taskName, fileExe, time);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            if (output.Contains("successfully been created")) return true;
            string err = process.StandardError.ReadToEnd();
            MessageBox.Show(output + Environment.NewLine + err, "Creates scheduled task", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private bool RemoveTask(string taskName)
        {
            string fileExe = Process.GetCurrentProcess().MainModule.FileName + " Auto";
            process.StartInfo.Arguments = string.Format("SCHTASKS /Delete /TN \"{0}\"", TaskName + taskName);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            string err = process.StandardError.ReadToEnd();
            if (output.Contains("ERROR:") || err.Contains("ERROR:"))
                return false;
            return true;
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_lsPermissions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select Task name to remove!", "Remove Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRow row = dataGridView_lsPermissions.SelectedRows[0].Tag as DataRow;
            RemoveTask(row["Field"].ToString());
            if (sqlite.DeleteEntry("CfgData", "ID", row["ID"].ToString()))
            {
                MessageBox.Show("Remove task successful", "Remove Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTask();
                return;
            }
            MessageBox.Show("Remmove task unsuccessful", "Remove Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            EntryList entr = new EntryList();
            entr.ColumnName.Add("Field");
            entr.Content.Add(txt_TaskName.Text);
            if (string.IsNullOrEmpty(txt_TaskName.Text) || string.IsNullOrEmpty(txt_Source.Text) || string.IsNullOrEmpty(txt_Destination.Text) || string.IsNullOrEmpty(cbo_LstTemplate.Text))
            {
                MessageBox.Show("Fields not empty.", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sqlite.CheckExistEntry("CfgData", entr))
            {
                MessageBox.Show("Task name existed.", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CreateTask(txt_HH.Text, txt_TaskName.Text))
            {
                string data = txt_HH.Text + "|" + (cbo_LstTemplate.SelectedItem as ComboBoxItem).Value + "|" + txt_Source.Text + "|" + txt_Destination.Text + "|" + forms;
                //foreach (var item in ckbl_Forms.CheckedItems) data += item.ToString() + ";"; data = data.TrimEnd(';');

                Dictionary<int, string> TemplateChoosen = new Dictionary<int, string>();
                foreach (var item in ckbl_Forms.CheckedItems)
                {
                    var row = (KeyValuePair<int, string>)(item);
                    TemplateChoosen.Add(row.Key, row.Value);
                }
                data += string.Join(";", TemplateChoosen);
                entr.ColumnName.Add("Type_ID");
                entr.Content.Add("511");
                entr.ColumnName.Add("Data");
                entr.Content.Add(data);
                if (sqlite.CreateEntry("CfgData", entr))
                {
                    MessageBox.Show("Add Task successful", "Add Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTask();
                    return;
                }
            }
            MessageBox.Show("Add Task unsuccessful", "Add Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataRow row = dataGridView_lsPermissions.SelectedRows[0].Tag as DataRow;
            string data = txt_HH.Text + "|" + (cbo_LstTemplate.SelectedItem as ComboBoxItem).Value + "|" + txt_Source.Text + "|" + txt_Destination.Text + "|" + forms;
            foreach (var item in ckbl_Forms.CheckedItems) data += item.ToString() + ";"; data = data.TrimEnd(';');
            if (sqlite.Update1Entry("CfgData", "Data", data, "ID", row["ID"].ToString()))
            {
                MessageBox.Show("Save Task  successful", "Save Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTask();
                return;
            }
            MessageBox.Show("Save task unsuccessful", "Save Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txt_TaskName_TextChanged(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            btn_Add.Enabled = true;
            btn_Remove.Enabled = false;
        }

        private void dataGridView_lsPermissions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_lsPermissions.SelectedRows.Count == 0) return;
            txt_TaskName.Text = (dataGridView_lsPermissions.SelectedRows[0].Tag as DataRow)["Field"].ToString();
            string[] field = (dataGridView_lsPermissions.SelectedRows[0].Tag as DataRow)["Data"].ToString().Split('|');
            if (field.Length != 0)
            {
                txt_HH.Text = field[0];
                foreach (ComboBoxItem cb in cbo_LstTemplate.Items) if (cb.Text.Equals(field[1])) cbo_LstTemplate.SelectedItem = cb;
                txt_Source.Text = field[2];
                txt_Destination.Text = field[3];
                forms = field[3];
            }
            btn_Add.Enabled = false;
            btn_Save.Enabled = true;
            btn_Remove.Enabled = true;
        }

        private void dataGridView_lsPermissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_lsPermissions.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewCheckBoxCell)
            {
                if ((bool)dataGridView_lsPermissions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    CreateTask(dataGridView_lsPermissions.Rows[e.RowIndex].Cells[3].Value.ToString(), dataGridView_lsPermissions.Rows[e.RowIndex].Cells[1].Value.ToString());
                else
                    RemoveTask(dataGridView_lsPermissions.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }
    }
}
