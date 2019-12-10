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
        UC_Explorer uc_Explorer;
        UC_Menu uc_Menu;
        
        public UC_Transaction()
        {
            sqlite = new SQLiteHelper();
            InitializeComponent();
            Add_GUI();
        }
        #region design     

        private void txt_Path_MouseEnter(object sender, EventArgs e)
        {
            uc_Explorer.ShowFromControl(this, sender as Control);
        }
        private void btn_Export_MouseHover(object sender, EventArgs e)
        {
            btn_Export.FlatAppearance.BorderColor = Color.FromArgb(20, 120, 204);
            btn_Export.ImageKey = "Excel_Select";
        }
        private void btn_Export_MouseLeave(object sender, EventArgs e)
        {
            btn_Export.FlatAppearance.BorderColor = this.BackColor;
            btn_Export.FlatAppearance.BorderSize = 1;
            btn_Export.ImageKey = "Excel";
        }
        #endregion
        private void Add_GUI()
        {
            uc_Explorer = new UC_Explorer();
            uc_Menu = new UC_Menu(this);
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
           
            DirectoryFileUtilities df = new DirectoryFileUtilities();
            if (File.Exists(txt_Path.Text))
                JournalAnalyze(new List<string> { txt_Path.Text });
            else if (Directory.Exists(txt_Path.Text))
            {
                FileInfo[] files = df.GetAllFilePath(txt_Path.Text, InitParametar.ExtensionFile);
                JournalAnalyze(files.Select(f => f.FullName).ToList());
                tre_LstTrans.ExpandAll();
            }
            else
                MessageBox.Show("File/Drectory not exist.", "Error File/Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void JournalAnalyze(List<string> lsFile_Journal)
        {
            try
            {
                InitParametar.ReadTrans = new ReadTransaction();
                tre_LstTrans.Nodes.Clear();
                btn_Export.Enabled = false;
                propertyGrid1.SelectedObject = null;
                fctxt_FullLog.Text = string.Empty;
                if (!cb_FullTime.Checked)
                {
                    InitParametar.ReadTrans.StartDate = dateTimePicker_Start.Value;
                    InitParametar.ReadTrans.EndDate = dateTimePicker_End.Value;
                }
                if (InitParametar.ReadTrans.Reads(lsFile_Journal))
                {
                    btn_Export.Enabled = true;
                    string day;
                    foreach (KeyValuePair<string, Dictionary<DateTime, object>> kTerminal in InitParametar.ReadTrans.ListTransaction)
                    {
                        int countCycle = kTerminal.Value.Where(x => (x.Value is Cycle)).ToList().Count;
                        int countTransaction = kTerminal.Value.Where(x => (x.Value is Transaction)).ToList().Count;
                        int countTransactionEvent = kTerminal.Value.Where(x => (x.Value is TransactionEvent)).ToList().Count;
                        TreeNode ndTerminal = tre_LstTrans.Nodes.Add(kTerminal.Key, String.Format("Terminal ID: {0} - Total: {1} transactions", kTerminal.Key, kTerminal.Value.Count), "Terminal", "Terminal");

                        foreach (KeyValuePair<DateTime, object> kTransaction in kTerminal.Value.OrderBy(x => x.Key))
                        {
                            day = String.Format("{0:" + InitParametar.ReadTrans.FormatDate + "}", kTransaction.Key);
                            TreeNode ndDay = new TreeNode(day);
                            if (ndTerminal.Nodes.ContainsKey(day))
                                ndDay = ndTerminal.Nodes[day];
                            else
                                ndDay = ndTerminal.Nodes.Add(day, day, "Date", "DateOpen");
                            string textDisplay = kTransaction.Value.ToString();
                            TreeNode ndTransaction = ndDay.Nodes.Add(textDisplay, textDisplay);
                            ndTransaction.Tag = kTransaction.Value;
                            if (ndTransaction.Tag is Transaction)
                            {
                                ndTransaction.ImageKey = "Flag";
                                ndTransaction.SelectedImageKey = "Flag_Success";
                            }
                            else if (ndTransaction.Tag is TransactionEvent)
                            {
                                ndTransaction.ImageKey = "Device";
                                ndTransaction.SelectedImageKey = "Device";
                            }
                            else
                            {
                                ndTransaction.ImageKey = "Cycle";
                                ndTransaction.SelectedImageKey = "Cycle";
                            }
                            ndDay.Text = day + " Total: " + ndDay.Nodes.Count + " transactions";
                        }
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
            uc_Menu.SlideMenuShow();
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
                else if (e.Node != null && e.Node.Tag != null && e.Node.Tag is TransactionEvent)
                {
                    propertyGrid1.SelectedObject = (TransactionEvent)e.Node.Tag;
                    fctxt_FullLog.Text = (e.Node.Tag as TransactionEvent).TContent;
                }
                else if (e.Node != null && e.Node.Tag != null && e.Node.Tag is Cycle)
                {
                    var cycle = (Cycle)e.Node.Tag;
                    fctxt_FullLog.Text = (e.Node.Tag as Cycle).LogTxt;
                    AddLayoutEventCycle(cycle, panel4);
                }
                else if (e.Node != null && e.Node.Tag != null && e.Node.Tag is List<KeyValuePair<DateTime, Cycle>>)
                {
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
        private void AddLayoutEventCycle(Cycle cycle, Panel panel4)
        {
            if (panel4.Controls.Count > 0)
            {
                TabControl control = (TabControl)panel4.Controls[0];
                panel4.Controls.Remove(control);
            }
            var denoCount = cycle.DenominationCount.ToList();
            var cashCount = cycle.Cashcount_Out.ToList();

            TabControl tabControlCycle = new TabControl();
            tabControlCycle.Height = panel4.Height;
            tabControlCycle.Width = panel4.Width;
            tabControlCycle.Dock = DockStyle.Fill;
            tabControlCycle.Name = "tcCycle";
            TabPage tabPageCycle = new TabPage("Cycle Genaral");

            PropertyGrid propertyGrid = new PropertyGrid();
            propertyGrid.BrowsableAttributes = new AttributeCollection(new CategoryAttribute("1. Info"));
            propertyGrid.Dock = DockStyle.Fill;
            propertyGrid.SelectedObject = cycle;
            tabPageCycle.Controls.Add(propertyGrid);
            tabControlCycle.Controls.Add(tabPageCycle);

            if (denoCount != null)
            {
                TabPage tabPageCycleDeno = new TabPage("Denomination Count");
                DataGridView dataGrid = new DataGridView();
                dataGrid.Dock = DockStyle.Fill;

                BindingSource dtsDeno = new BindingSource();
                dtsDeno.DataSource = typeof(Deno);
                dataGrid.DataSource = dtsDeno;
                denoCount.OrderByDescending(x => x.Value.Name).ToList().ForEach(x =>
                {
                    dtsDeno.Add(x.Value);
                });
                tabPageCycleDeno.Controls.Add(dataGrid);
                tabControlCycle.Controls.Add(tabPageCycleDeno);

            }
            if (cashCount != null)
            {

                TabPage tabPageCycleCash = new TabPage("Cash Count");
                DataGridView dataGridCash = new DataGridView();
                dataGridCash.Dock = DockStyle.Fill;
                BindingSource dtsCash = new BindingSource();
                dtsCash.DataSource = typeof(Cassette);
                dataGridCash.DataSource = dtsCash;
                cashCount.OrderByDescending(x => x.Value.Name).ToList().ForEach(x =>
                {
                    dtsCash.Add(x.Value);
                });
                tabPageCycleCash.Controls.Add(dataGridCash);
                tabControlCycle.Controls.Add(tabPageCycleCash);

            }



            panel4.Controls.Add(tabControlCycle);
        }
        private void tre_LstTrans_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {

        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                UC_ExportCus uc_MenuStartup = new UC_ExportCus();
                uc_MenuStartup.Dock = DockStyle.Fill;
                Frm_TemplateDefault frm= new Frm_TemplateDefault(uc_MenuStartup);
                frm.titleCustom.Text = "File Export";
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }


    }

}
