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

namespace Transaction_Statistical
{
    public partial class UC_Menu_Startup : UserControl
    {
        string TaskName = "AutoRunTransaction_";
        UC_Explorer uc_Explorer;
        SQLiteHelper sqlite;
        string forms;
        public UC_Menu_Startup()
        {
            InitializeComponent();
            uc_Explorer = new UC_Explorer();

            sqlite = new SQLiteHelper();
            LoadTask();
            //DataTable cfg_data = sqlite.GetTableDataWithColumnName("CfgData", "ID", "511");

            //string[] field = cfg_data.Rows[0]["Data"].ToString().Split('|');
            //if (field.Length != 0)
            //{
            //    txt_HH.Text = field[0];
            //    txt_Source.Text = field[1];
            //    txt_Destination.Text = field[2];
            //    forms= field[3];
            //    CreateTask(txt_HH.Text);
                
            //}
        }
        private void LoadTask()
        {
            DataTable cfg_data = sqlite.GetTableDataWithColumnName("CfgData", "Type_ID", "511");
            int n = 0;
            
            foreach (DataRow rowData in cfg_data.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                string[] description = rowData["Data"].ToString().Split('|');
                row.CreateCells(dataGridView_lsPermissions);
                row.Cells[0].Value = n;
                row.Cells[1].Value = rowData["Field"];
                row.Cells[2].Value = ChecckTaskExist(rowData["Field"].ToString());
                row.Cells[3].Value = description[0];
                row.Cells[4].Value = string.Format("Template: {0}, source: {1}, destination: {2}, forms: {3} ", description[1], description[2], description[3], description[4]);
                row.Tag = row;
                dataGridView_lsPermissions.Rows.Add(row);
            }
        }
        private void txt_MouseDown(object sender, MouseEventArgs e)
        {
            uc_Explorer.ShowFromControl(this, sender as Control);
        }
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            CreateTask(txt_HH.Text);
           string data=txt_HH.Text + "|" + txt_Source.Text + "|" + txt_Destination.Text + "|" + forms;
            if (sqlite.Update1Entry("CfgData", "Data",data,"ID","511"))
                MessageBox.Show("Add data successful", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Add data unsuccessful", "Add data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool ChecckTaskExist(string taskName)
        {
        return true;
        }
        private void CreateTask(string time)
        {
            string fileExe = Process.GetCurrentProcess().MainModule.FileName + " Auto";
            Process process = new Process();
            process.StartInfo.FileName = "schtasks";
            process.StartInfo.Arguments = string.Format("/Create /RU SYSTEM /SC DAILY /TN {0} /TR \"{1}\" /ST {2} /F", TaskName, fileExe, time);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            if (!output.Contains("successfully been created"))
            {
                string err = process.StandardError.ReadToEnd();
                MessageBox.Show(output + Environment.NewLine + err, "Creates scheduled task", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private bool RemoveTask(string taskName)
        {
            string fileExe = Process.GetCurrentProcess().MainModule.FileName + " Auto";
            Process process = new Process();
            process.StartInfo.FileName = "schtasks";
            process.StartInfo.Arguments = string.Format("SCHTASKS /Delete /TN \"{0}\"", taskName);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            if (!output.Contains("successfully been created"))
            {
                string err = process.StandardError.ReadToEnd();
                MessageBox.Show(output + Environment.NewLine + err, "Creates scheduled task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
    }
}
