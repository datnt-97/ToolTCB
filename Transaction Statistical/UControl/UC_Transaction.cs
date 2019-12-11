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
        List<string> sTransactionTypeDisplay = new List<string>();
        DataGridView dataGrid;
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

            CheckBox cb = new CheckBox();
            cb.Text = "ALL";
            cb.Checked = true;
            cb.CheckedChanged += new EventHandler(ckb_Actions_All_CheckedChanged);
            pl_Actions.Controls.Add(cb);

            foreach (string name in Enum.GetNames(typeof(Transaction.StatusS)))
            {
                cb = new CheckBox();
                cb.Text = name;
                cb.Checked = true;                
             //   cb.CheckedChanged += new EventHandler(cb_Action_CheckedChanged);
                pl_Actions.Controls.Add(cb);
            }
            InitParametar.ReadTrans.Template_TransType.Values.ToList().ForEach(x =>
            {
                cb = new CheckBox();
                cb.Text = x.Name;
                cb.Checked = true;
                cb.Tag = x;
                cb.CheckedChanged += new EventHandler(cb_Action_CheckedChanged);
                pl_Actions.Controls.Add(cb);
            });
           
        }
        private void ckb_Actions_All_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (CheckBox chk in pl_Actions.Controls)
                {
                    chk.Checked = (sender as CheckBox).Checked;
                }
            }
            catch { }
        }
        private void cb_Action_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as CheckBox).Checked)
                    sTransactionTypeDisplay.Add((sender as CheckBox).Text);
                else
                  sTransactionTypeDisplay.Remove((sender as CheckBox).Text);
            }
            catch { }
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
                        ndTerminal.Tag = kTerminal.Value.Where(x => (x.Value is Cycle)).ToDictionary(x => x.Key, x => (Cycle)x.Value);
                        foreach (KeyValuePair<DateTime, object> kTransaction in kTerminal.Value.OrderBy(x => x.Key))
                        {
                            day = String.Format("{0:" + InitParametar.ReadTrans.FormatDate + "}", kTransaction.Key);
                            TreeNode ndDay = new TreeNode(day);
                            if (ndTerminal.Nodes.ContainsKey(day))
                                ndDay = ndTerminal.Nodes[day];
                            else
                                ndDay = ndTerminal.Nodes.Add(day, day, "Date", "DateOpen");
                            string textDisplay = kTransaction.Value.ToString();
                            
                            if (kTransaction.Value is Transaction)
                            {
                                if (!FilterDisplayTransaction((kTransaction.Value as Transaction).ListRequest.Values.ToList())) continue;
                                 TreeNode ndTransaction = ndDay.Nodes.Add(textDisplay, textDisplay);
                                ndTransaction.Tag = kTransaction.Value;
                                ndTransaction.ImageKey = "Flag";
                                ndTransaction.SelectedImageKey = "Flag_Success";
                            }
                            else if (kTransaction.Value is TransactionEvent)
                            {
                                TreeNode ndTransaction = ndDay.Nodes.Add(textDisplay, textDisplay);
                                ndTransaction.Tag = kTransaction.Value;
                                ndTransaction.ImageKey = "Device";
                                ndTransaction.SelectedImageKey = "Device";
                            }
                            else
                            {
                                TreeNode ndTransaction = ndDay.Nodes.Add(textDisplay, textDisplay);
                                ndTransaction.Tag = kTransaction.Value;
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
        private bool FilterDisplayTransaction(List< TransactionRequest> names)
        {
            return names.Any(x => sTransactionTypeDisplay.Contains(x.Request));          
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
                   
                    fctxt_FullLog.Text = (e.Node.Tag as Transaction).TraceJournalFull;
                   
                   foreach (TransactionRequest req in (e.Node.Tag as Transaction).ListRequest.Values) 
                    {
                     //   propertyGrid1.BrowsableAttributes = new AttributeCollection(new CategoryAttribute(req.Request));
                      //   [CategoryAttribute("4. Requests"), DescriptionAttribute("Requests of the transaction")]
                    }   
                    propertyGrid1.SelectedObject = (Transaction)e.Node.Tag;                

                }
                else if (e.Node != null && e.Node.Tag != null && e.Node.Tag is TransactionEvent)
                {
                    propertyGrid1.SelectedObject = (TransactionEvent)e.Node.Tag;
                    fctxt_FullLog.Text = (e.Node.Tag as TransactionEvent).TContent;
                }
                else if (e.Node != null && e.Node.Tag != null && e.Node.Tag is Cycle)
                {
                    var cycle = (Cycle)e.Node.Tag;
                    showCycle(cycle);
                }
                else if (e.Node != null && e.Node.Tag != null && e.Node.Tag is Dictionary<DateTime, Cycle>)
                {
                    resetView();
                    var tagValue = ((Dictionary<DateTime, Cycle>)e.Node.Tag).ToList();
                    tvListCycle.Nodes.Clear();
                    tvListCycle.Scrollable = true;
                    string textDisplay = "Terminal ID : " + e.Node.Name + " - Total Cycle : " + tagValue.Count;
                    TreeNode ndCycle = tvListCycle.Nodes.Add(textDisplay, textDisplay);
                    if (tagValue.Count > 0)
                    {

                        tagValue.ForEach(x =>
                        {
                            TreeNode ndItem = ndCycle.Nodes.Add(x.Key.ToString(), x.Value.ToString());
                            ndItem.Tag = x.Value;
                            ndItem.ImageKey = "Cycle";
                            ndItem.SelectedImageKey = "Cycle";
                        });
                        ndCycle.Expand();
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void tvListCycle_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node != null && e.Node.Tag != null && e.Node.Tag is Cycle)
            {
                showCycle((Cycle)e.Node.Tag);
            }
        }
        private void resetView()
        {
            if (tvListCycle.Controls.Count > 0)
            {
                tvListCycle.Controls.Clear();
            }
            if (panel5.Controls.Count > 0)
            {
                panel5.Controls.RemoveAt(0);
            }
        }
        private void showCycle(Cycle cycle)
        {
            if (panel5.Controls.Count > 0)
            {
                panel5.Controls.RemoveAt(0);
            }
            dataGrid = new DataGridView();

            fctxt_FullLog.Text = cycle.LogTxt;
            var denoCount = cycle.DenominationCount.ToList();
            var cashCount = cycle.Cashcount_Out.ToList();
            if (denoCount != null)
            {
                dataGrid.Dock = DockStyle.Fill;
                BindingSource dtsDeno = new BindingSource();

                int rowMidle = denoCount.Count / 2;
                int rowMidleIdx = 0;
                SortableBindingList<object> denoCountS = new SortableBindingList<object>();
                denoCount.OrderByDescending(x => x.Value.Name).ToList().ForEach(x =>
                {
                    object c = new
                    {
                        TerminalID = rowMidleIdx == rowMidle ? cycle.TerminalID : "",
                        SettlementPeriodStart = rowMidleIdx == rowMidle ? cycle.SettlementPeriodDateBegin.ToString() : "",
                        SettlementPeriodEnd = rowMidleIdx == rowMidle ? cycle.SettlementPeriodDateEnd.ToString() : "",
                        Denomination = x.Value.Name,
                        Dispensed = x.Value.Dispensed,
                        Remaining = x.Value.Remaining,
                        Retracted = x.Value.Retracted,
                        Initial = x.Value.Initial,
                    };
                    rowMidleIdx++;
                    denoCountS.Add(c);
                });
                dtsDeno.DataSource = denoCountS;
                dataGrid.DataSource = dtsDeno;
                //dataGrid.ColumnHeaderMouseClick = gridViewClickHeader(sender,, dataGrid);
                dataGrid.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }

                dataGrid.AllowUserToAddRows = false;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                panel5.Controls.Add(dataGrid);

            }
        }
        bool IsTheSameCellValue(int column, int row)
        {
            return column <= 2 && row < dataGrid.RowCount;

        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                if (e.RowIndex == 0)
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
                }
                else
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

                }
            }
            else
            {
                e.AdvancedBorderStyle.Top = dataGrid.AdvancedCellBorderStyle.Top;
            }

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
                Frm_TemplateDefault frm = new Frm_TemplateDefault(uc_MenuStartup);
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
