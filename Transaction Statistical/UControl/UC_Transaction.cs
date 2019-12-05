using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Transaction_Statistical.AddOn;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Transaction : UserControl
    {
        SQLiteHelper sqlite = new SQLiteHelper();
        List<Transaction> transactions = new List<Transaction>();
        ReadTransaction readTransactions;
        public UC_Transaction()
        {
            InitializeComponent();
            Add_GUI();
            uc_Menu.Location = new Point(-uc_Menu.Width, uc_Menu.Location.Y);
            readTransactions = new ReadTransaction();
        }
        #region design

        private void uc_Explorer_Leave(object sender, EventArgs e)
        {
            SlideExplorerShow(sender, e);
        }
        private void txt_Path_MouseEnter(object sender, EventArgs e)
        {
            if (!showExplorer) SlideExplorerShow(sender, e);
        }
        #endregion
        private void Add_GUI()
        {
            CheckBox cb1 = new CheckBox();
            cb1.Text = "All";
            pl_Actions.Controls.Add(cb1);

            CheckBox cb2 = new CheckBox();
            cb2.Text = "All Success";
            pl_Actions.Controls.Add(cb2);

            CheckBox cb3 = new CheckBox();
            cb3.Text = "UnSuccess";
            pl_Actions.Controls.Add(cb3);

            CheckBox cb4 = new CheckBox();
            cb4.Text = "Withdrawal";
            pl_Actions.Controls.Add(cb4);

            CheckBox cb5 = new CheckBox();
            cb5.Text = "Deposit";
            pl_Actions.Controls.Add(cb5);

            CheckBox cb6 = new CheckBox();
            cb6.Text = "Safe door";
            pl_Actions.Controls.Add(cb6);
        }

        private void cb_FullTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_FullTime.Checked)
            {
                dateTimePicker_Start.Enabled = false;
                dateTimePicker_End.Enabled = false;
            }
            else
            {
                dateTimePicker_Start.Enabled = true;
                dateTimePicker_End.Enabled = true;
            }
        }

        private void bt_Read_Click(object sender, EventArgs e)
        {
            string[] extension = { "*.txt", "*.log" };
            DirectoryFileUtilities df = new DirectoryFileUtilities();
            FileInfo[] files = df.GetAllFilePath(txt_Path.Text, extension);
            JournalAnalyze(files);

        }
        private void JournalAnalyze(FileInfo[] File_Journal)
        {
            try
            {
                FileComparer comp = new FileComparer(FileComparer.CompareBy.Name);
                List<string> filesReadJournal = File_Journal.Select(f => f.FullName).ToList();
                filesReadJournal.Sort(comp);
                //  Reads(filesReadJournal);
                ReadTransaction readtran = new ReadTransaction();
                if (!cb_FullTime.Checked)
                {
                    readtran.StartDate = dateTimePicker_Start.Value;
                    readtran.EndDate = dateTimePicker_End.Value;
                }
                if (readtran.Reads(filesReadJournal))
                {
                    string day;
                    foreach (KeyValuePair<string, Dictionary<DateTime, object>> kTerminal in readtran.ListTransaction)
                    {
                        TreeNodeX ndTerminal = new TreeNodeX(String.Format("Terminal ID: {0} - Total: {1} transactions", kTerminal.Key, kTerminal.Value.Count));
                        foreach (KeyValuePair<DateTime, object> kTransaction in kTerminal.Value)
                        {
                            day = String.Format("{0:" + readtran.FormatDate + "}", kTransaction.Key);
                            TreeNode ndDay = new TreeNode(day);
                            if (ndTerminal.Nodes.ContainsKey(day))
                                ndDay = ndTerminal.Nodes[day];
                            else
                                ndDay = ndTerminal.Nodes.Add(day, day);
                            string textDisplay = kTransaction.Value.ToString();                         
                            TreeNode ndTransaction = ndDay.Nodes.Add(textDisplay, textDisplay);
                            ndTransaction.Tag = kTransaction.Value;
                            ndDay.Text = day + " Total: " + ndDay.Nodes.Count + " transactions";
                        }
                        tre_LstTrans.Nodes.Add(ndTerminal);
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private bool GetDateFromFormatLine(string row, string rowFormat, Dictionary<string, string> listDateFormat, out DateTime date)
        {
            date = DateTime.Now;
            try
            {
                foreach (KeyValuePair<string, string> key in listDateFormat)
                {
                    if (rowFormat.Contains(key.Key))
                    {
                        if (rowFormat.Contains(@"#Reg#"))
                        {
                            rowFormat = rowFormat.Replace(@"#Reg#", "");
                            Regex r = new Regex(rowFormat);
                            Match m = r.Match(row);
                            if (!m.Success) return false;
                        }
                        else
                        {
                            string snew = rowFormat.Replace(key.Key, "");
                            foreach (string s in snew.Trim().Split(' '))
                                row = row.Replace(s, "").Trim();
                        }
                        if (DateTime.TryParseExact(row, key.Value, CultureInfo.InvariantCulture, DateTimeStyles.None, out date)) return true;
                        return false;
                    }
                }
            }
            catch { }
            return false;
        }

        private void btn_Menu_OnMouseDownHandler(object sender, EventArgs e)
        {
            this.SlideMenuShow();
        }

        private void tre_LstTrans_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node != null && e.Node.Tag != null && e.Node.Tag is Transaction)
                {
                    propertyGrid1.SelectedObject = (Transaction)e.Node.Tag;
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
    }

}
