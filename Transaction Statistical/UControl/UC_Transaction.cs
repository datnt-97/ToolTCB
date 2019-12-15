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
        List<string> sTransactionTypeDisplay;
        DataGridView dataGrid;
        public UC_Transaction()
        {
            sqlite = new SQLiteHelper();
            InitializeComponent();
            Add_GUI();
            sTransactionTypeDisplay = InitParametar.ReadTrans.Template_TransType.Keys.ToList();
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

        private async void bt_Read_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Read.Enabled = false;
                DirectoryFileUtilities df = new DirectoryFileUtilities();
                if (File.Exists(txt_Path.Text))
              await   JournalAnalyze(new List<string> { txt_Path.Text });
                else if (Directory.Exists(txt_Path.Text))
                {
                   
                    FileInfo[] files = df.GetAllFilePath(txt_Path.Text, InitParametar.ExtensionFile);
                    await JournalAnalyze(files.Select(f => f.FullName).ToList());
                    if (tre_LstTrans.Nodes.Count != 0) tre_LstTrans.Nodes[0].Expand();
                }
                else
                    MessageBox.Show("File/Drectory not exist.", "Error File/Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            btn_Read.Enabled = true;
        }
        private async Task<bool> JournalAnalyze(List<string> lsFile_Journal)
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


                var watch = System.Diagnostics.Stopwatch.StartNew();
                watch.Start();
                if (await InitParametar.ReadTrans.Reads(lsFile_Journal))
                { 
                    //test time
                    var mili = watch.ElapsedMilliseconds;
                watch.Stop();
                MessageBox.Show((mili / 1000).ToString());
                    ///
                    btn_Export.Enabled = true;
                    string day;
                    int countDisplay = 10;
                    foreach (KeyValuePair<string, Dictionary<DateTime, object>> kTerminal in InitParametar.ReadTrans.ListTransaction)
                    {
                        int countCycle = kTerminal.Value.Where(x => (x.Value is Cycle)).ToList().Count;
                        int countTransaction = kTerminal.Value.Where(x => (x.Value is Transaction)).ToList().Count;
                        int countTransactionEvent = kTerminal.Value.Where(x => (x.Value is TransactionEvent)).ToList().Count;
                        TreeNode ndTerminal = tre_LstTrans.Nodes.Add(kTerminal.Key, String.Format("Terminal ID: [{0}] - Total: {1} transactions", kTerminal.Key, kTerminal.Value.Count), "Terminal", "Terminal");
                        ndTerminal.Tag = kTerminal.Value.Where(x => (x.Value is Cycle)).ToDictionary(x => x.Key, x => (Cycle)x.Value);
                       
                        foreach (KeyValuePair<DateTime, object> kTransaction in kTerminal.Value.OrderBy(x => x.Key))
                        {
                           
                            day = String.Format("{0:" + InitParametar.ReadTrans.FormatDate + "}", kTransaction.Key);
                            TreeNode ndDay = new TreeNode(day);
                            if (ndTerminal.Nodes.ContainsKey(day))
                                ndDay = ndTerminal.Nodes[day];
                            else
                            {                                        
                                ndDay = ndTerminal.Nodes.Add(day, day, "Date", "DateOpen");
                                ndDay.Text =String.Format("{0} Total: {1} transactions, {2} events",day, kTerminal.Value.Where(x => (x.Value is Transaction) && x.Key.ToString(InitParametar.ReadTrans.FormatDate).Equals(day)).ToList().Count, kTerminal.Value.Where(x => (x.Value is TransactionEvent) && x.Key.ToString(InitParametar.ReadTrans.FormatDate).Equals(day)).ToList().Count);
                            }
  
                            if (countDisplay == ndDay.Nodes.Count) continue;
                          ndDay.Tag = kTransaction.Key;
                            AddTransactionToNode(ndDay, kTransaction.Key, kTerminal.Key, kTransaction.Value);
                          // 

                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        private void AddTransactionToNode(TreeNode ndDay,DateTime date, string terminal, object obj)
        {
            try
            {
                DateTime dNode = (DateTime)ndDay.Tag;
                if (!date.ToString(InitParametar.ReadTrans.FormatDate).Equals(dNode.ToString(InitParametar.ReadTrans.FormatDate))) return;               
                string textDisplay = obj.ToString();
                if (ndDay.Nodes.ContainsKey(textDisplay))
                {
                    return;
                }
                ndDay.Tag = date;

                if (obj is Transaction)
                {
                    //if (!FilterDisplayTransaction((obj as Transaction).ListRequest.Values.ToList())) return;
                    TreeNode ndTransaction = ndDay.Nodes.Add(textDisplay, textDisplay);
                    ndTransaction.Tag = obj;
                    ndTransaction.ImageKey = "Flag";
                    ndTransaction.SelectedImageKey = "Flag_Success";                  
                }
                else if (obj is TransactionEvent)
                {
                    TreeNode ndTransaction = ndDay.Nodes.Add(textDisplay, textDisplay);
                    ndTransaction.Tag = obj;
                    ndTransaction.ImageKey = "Device";
                    ndTransaction.SelectedImageKey = "Device";
                    ndDay.Tag = (obj as TransactionEvent).DateBegin;
                }
                else
                {
                    TreeNode ndTransaction = ndDay.Nodes.Add(textDisplay, textDisplay);
                    ndTransaction.Tag = obj;
                    ndTransaction.ImageKey = "Cycle";
                    ndTransaction.SelectedImageKey = "Cycle";
                    ndDay.Tag = (obj as Cycle).DateBegin;
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private bool FilterDisplayTransaction(List<TransactionRequest> names)
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
                TreeNode ndRoot = e.Node;
                while (ndRoot.Parent != null)
                    ndRoot = ndRoot.Parent;
                string terminal = ndRoot.Text.Substring(ndRoot.Text.IndexOf('[') + 1, ndRoot.Text.IndexOf(']') - ndRoot.Text.IndexOf('[') - 1);
                if (e.Node != null && e.Node.Tag != null && e.Node.Tag is Transaction)
                {

                    fctxt_FullLog.Text = (e.Node.Tag as Transaction).TraceJournalFull;
                    var trans = (Transaction)e.Node.Tag;
                    trans.Properties = new List<CustomProperty>();
                    int cCount = 1;
                    if (trans.Value_10K != 0)
                    {
                        trans.Properties.Add(new CustomProperty
                        {
                            Name = cCount + ". 10,000 VND",
                            Type = typeof(int),
                            Desc = "Cash counter of In/Out",
                            Cate = "5.Cash In / Out",
                            DefaultValue = trans.Value_10K
                        }); cCount += 1;
                    }
                    if (trans.Value_20K != 0)
                    {
                        trans.Properties.Add(new CustomProperty
                        {
                            Name = cCount + ". 20,000 VND",
                            Type = typeof(int),
                            Desc = "Cash counter of In/Out",
                            Cate = "5.Cash In / Out",
                            DefaultValue = trans.Value_20K
                        });
                        cCount += 1;
                    }

                    if (trans.Value_50K != 0)
                    {
                        trans.Properties.Add(new CustomProperty
                        {
                            Name = cCount + ". 50,000 VND",
                            Type = typeof(int),
                            Desc = "Cash counter of In/Out",
                            Cate = "5.Cash In / Out",
                            DefaultValue = trans.Value_50K
                        });
                        cCount += 1;
                    }
                    if (trans.Value_100K != 0)
                    {
                        trans.Properties.Add(new CustomProperty
                        {
                            Name = cCount + ". 100,000 VND",
                            Type = typeof(int),
                            Desc = "Cash counter of In/Out",
                            Cate = "5.Cash In / Out",
                            DefaultValue = trans.Value_100K
                        });
                        cCount += 1;
                    }
                    if (trans.Value_200K != 0)
                    {
                        trans.Properties.Add(new CustomProperty
                        {
                            Name = cCount + ". 200,000 VND",
                            Type = typeof(int),
                            Desc = "Cash counter of In/Out",
                            Cate = "5.Cash In / Out",
                            DefaultValue = trans.Value_200K
                        });
                        cCount += 1;
                    }
                    if (trans.Value_500K != 0)
                    {
                        trans.Properties.Add(new CustomProperty
                        {
                            Name = cCount + ". 500,000 VND",
                            Type = typeof(int),
                            Desc = "Cash counter of In/Out",
                            Cate = "5.Cash In / Out",
                            DefaultValue = trans.Value_500K
                        });
                        cCount += 1;
                    }
                    cCount = 1;
                    foreach (var req in (e.Node.Tag as Transaction).ListEvent.Values)
                    {
                        trans.Properties.Add(new CustomProperty
                        {
                            Name = req.TTime,
                            Type = typeof(string),
                            Desc = req.ToString(),
                            Cate = "6. Follow",
                            DefaultValue = req.ToString()
                        });
                        cCount++;
                    }
                    cCount = 1;
                    foreach (var req in (e.Node.Tag as Transaction).ListRequest.Values)
                    {
                        trans.Properties.Add(new CustomProperty
                        {
                            Name = string.Format("{0:HH:mm:ss}", req.DateBegin),
                            Type = typeof(string),
                            Desc = req.ToString(),
                            Cate = "4. Requests",
                            DefaultValue = req.ToString()
                        });
                        cCount++;
                    }
                    propertyGrid1.SelectedObject = trans;

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
                else if (e.Node != null && e.Node.Tag != null && e.Node.Tag is DateTime)
                {
                    DateTime dNode = (DateTime)e.Node.Tag;                    
                    foreach (KeyValuePair<DateTime, object> kTransaction in InitParametar.ReadTrans.ListTransaction[terminal].OrderBy(x => x.Key))
                        AddTransactionToNode(e.Node,kTransaction.Key, terminal, kTransaction.Value);
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
