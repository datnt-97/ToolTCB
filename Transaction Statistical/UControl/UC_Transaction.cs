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
        SQLiteHelper sqlite;
        List<Transaction> transactions = new List<Transaction>();
        ReadTransaction readtran;
        public Dictionary<string, Dictionary<DateTime, object>> ListTransaction;

        public UC_Transaction()
        {
            sqlite = new SQLiteHelper();
            InitializeComponent();
            Add_GUI();
            uc_Menu.Location = new Point(-uc_Menu.Width, uc_Menu.Location.Y);
        }
        #region design
        bool runningShowMenu = false;
        bool showMenu = false;

        bool runningShowExplorer = false;
        bool showExplorer = false;

        private void uc_Explorer_Leave(object sender, EventArgs e)
        {
            SlideExplorerShow(sender, e);
        }
        private void txt_Path_MouseEnter(object sender, EventArgs e)
        {
            if (!showExplorer) SlideExplorerShow(sender, e);
        }
        public void SlideExplorerShow(object sender, EventArgs e)
        {
            if (showExplorer) showExplorer = false; else showExplorer = true;
            if (runningShowExplorer) return;
            runningShowExplorer = true;
            while (runningShowExplorer)
            {
                if (showExplorer)
                {
                    //uc_Explorer.Location = new Point(uc_Explorer.Location.X + 3, uc_Explorer.Location.Y);
                    //if (uc_Explorer.Location.X >= 0) break;
                    uc_Explorer.Height += 5;
                    if (uc_Explorer.Height >= 500)
                    {
                        uc_Explorer.SelectPath(txt_Path.Text);
                        break;
                    }
                }
                else
                {
                    uc_Explorer.Height -= 3;
                    if (uc_Explorer.Height == 0) break;
                    //uc_Explorer.Location = new Point(uc_Explorer.Location.X - 3, uc_Explorer.Location.Y);
                    //if (uc_Explorer.Location.X <= -uc_Explorer.Width) break;
                }
                this.Update();
            }
            runningShowExplorer = false;
        }
        public void SlideMenuShow()
        {
            if (showMenu) showMenu = false; else showMenu = true;
            if (runningShowMenu) return;
            runningShowMenu = true;
            while (runningShowMenu)
            {
                if (showMenu)
                {
                    uc_Menu.Location = new Point(uc_Menu.Location.X + 3, uc_Menu.Location.Y);
                    if (uc_Menu.Location.X >= 0) break;
                }
                else
                {
                    uc_Menu.Location = new Point(uc_Menu.Location.X - 3, uc_Menu.Location.Y);
                    if (uc_Menu.Location.X <= -uc_Menu.Width) break;
                }
                this.Update();
            }
            runningShowMenu = false;
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
            tre_LstTrans.ExpandAll();
        }
        private void JournalAnalyze(FileInfo[] File_Journal)
        {
            try
            {
                readtran = new ReadTransaction();

                FileComparer comp = new FileComparer(FileComparer.CompareBy.Name);
                List<string> filesReadJournal = File_Journal.Select(f => f.FullName).ToList();
                filesReadJournal.Sort(comp);
                //  Reads(filesReadJournal);
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
                        int countCycle = kTerminal.Value.Where(x => (x.Value is Cycle)).ToList().Count;
                        int countTransaction = kTerminal.Value.Where(x => (x.Value is Transaction)).ToList().Count;
                        int countTransactionEvent = kTerminal.Value.Where(x => (x.Value is TransactionEvent)).ToList().Count;
                        ////TreeNodeX ndTerminal = new TreeNodeX(String.Format("Terminal ID: {0} - Total: {1} transactions", kTerminal.Key, kTerminal.Value.Count));
                        ///CHANGE 6/12
                        TreeNodeX ndTerminal = new TreeNodeX(String.Format("Terminal ID: {0} - Transactions:{1} - Cycle:{2} - Event :{3} ",
                            kTerminal.Key, countTransaction, countCycle, countTransactionEvent));
                        ndTerminal.Tag = kTerminal.Value.Where(x => x.Value is Cycle).ToList();
                        foreach (KeyValuePair<DateTime, object> kTransaction in kTerminal.Value.OrderBy(x => x.Key))
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
                            ndDay.Text = day + " Total: " + ndDay.Nodes.Count + " items";
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
                    fctxt_FullLog.Text = (e.Node.Tag as Transaction).TraceJournalFull;
                }
                else if (e.Node != null && e.Node.Tag != null && e.Node.Tag is Cycle)
                {
                    propertyGrid1.SelectedObject = (Cycle)e.Node.Tag;
                    fctxt_FullLog.Text = (e.Node.Tag as Cycle).LogTxt;
                }
                else if (e.Node != null && e.Node.Tag != null && e.Node.Tag is List<KeyValuePair<DateTime, Cycle>>)
                {
                    var tag = (List<KeyValuePair<DateTime, Cycle>>)e.Node.Tag;
                    ListPropertyGrid<Cycle> listProperty = new ListPropertyGrid<Cycle>(tag);
                    propertyGrid1.SelectedObject = listProperty;
                    var tagValue = ((List<KeyValuePair<DateTime, Cycle>>)e.Node.Tag).ToList();
                    ListBox listBox = new ListBox();
                    listBox.Dock = DockStyle.Fill;
                    tagValue.ForEach(x =>
                    {
                        listBox.Items.Add(x.Value.ToString());
                    });
                    panel4.Controls.Add(listBox);
                }

            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void tre_LstTrans_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            if (e.Node.Tag is Transaction)
            {
                //toolTip1.Show((e.Node.Tag as Transaction).TraceJournalFull, tre_LstTrans);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (readtran != null)
                {
                    readtran.Export();
                    MessageBox.Show("Export Successfully");
                }
                else
                {
                    MessageBox.Show("Please Read Transaction");
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

            }

        }
    }

}
