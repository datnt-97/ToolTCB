using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSHTML;
using System.Reflection;
using System.Globalization;
using System.Data.SQLite;

namespace Transaction_Statistical.UControl
{
    public partial class UC_ImportTransaction : UserControl
    {
        SQLiteHelper sqlite;
        public UC_ImportTransaction()
        {
            InitializeComponent();
            sqlite = new SQLiteHelper();
            LoadBank();
        }

        public UC_ImportTransaction(Mode_TreeView treeView)
        {
            InitializeComponent();
            sqlite = new SQLiteHelper();
            LoadBank();
            tre_LstTrans.CloneFrom(treeView);
            this.uc_Search = new UC_Search(treeView);
        }

        private void LoadBank()
        {
            string ParentID_Banks = InitParametar.GetParent_Bank();
            DataTable tb = sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", ParentID_Banks);
            cb_Bank.Items.Clear();
            cb_Bank.Items.Add("Auto");
            cb_Bank.SelectedIndex = 0;

            DataTable cfg_vendor = InitParametar.sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "60", "Parent_ID", "54");
            string subBank = string.Empty;
            foreach (DataRow R in cfg_vendor.Rows)
                if (R["Field"].ToString().EndsWith(@"(default)") && !string.IsNullOrEmpty(R["Data"].ToString()))
                    subBank = R["Data"].ToString();
            for (int n = 0; n < tb.Rows.Count; n++)
            {
                cb_Bank.Items.Add(tb.Rows[n]["Field"].ToString());
                if (subBank.Equals(tb.Rows[n]["Field"].ToString()))
                    cb_Bank.SelectedIndex = n + 1;
            }

        }

        private void cb_Bank_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_Terminal.Items.Clear();
            cb_Terminal.Items.Add("Auto");
            int n = 0;
            btn_Import.Enabled = false;
            if (cb_Bank.Text.Trim() != string.Empty)
            {
                btn_Import.Enabled = true;
                foreach (DataRow row in sqlite.GetTableDataWithColumnName("Terminal", "BankID", cb_Bank.Text).Rows)
                {
                    n++;
                    ComboBoxItem cb = new ComboBoxItem();
                    cb.Text = n + ". TID:" + row["TID"] + " - SN:" + row["Serial"];
                    cb.Value = row["ID"];
                    cb_Terminal.Items.Add(cb);
                }
            }
            cb_Terminal.SelectedIndex = 0;
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            try
            {
                prb_Process.Size = btn_Import.Size;
                prb_Process.Maximum = tre_LstTrans.Nodes.Count;
                prb_Process.Value = 0;


                string Bank = cb_Bank.Text.Equals("Auto") ? string.Empty : cb_Bank.Text;
                string Terminal = cb_Terminal.Text.Equals("Auto") ? string.Empty : cb_Terminal.Text;
                Custom_NodeTag nodeTag;
                Transaction trans;
                float percent = 0;
                foreach (TreeNode nodeTerminal in tre_LstTrans.Nodes)
                {

                    if (nodeTerminal.Tag == null) continue;
                    nodeTag = nodeTerminal.Tag as Custom_NodeTag;
                    Terminal = nodeTag.Terminal;
                    string id = sqlite.GetColumnDataWith2ColumnName("Terminal", "TID", Terminal, "BankID", Bank, "ID");

                    foreach (TreeNode nodeDate in nodeTerminal.Nodes)
                    {
                        nodeTag = nodeDate.Tag as Custom_NodeTag;
                        string dateTime = ((DateTime)nodeTag.Data).ToString("yyyyMMddHHmmssfff");
                        int stepTran = 0;
                        foreach (TreeNode nodeEvent in nodeDate.Nodes)
                        {

                            prb_Process.ValueF += ((float)1 / nodeTerminal.Nodes.Count) / nodeDate.Nodes.Count;
                            stepTran++;
                            prb_Process.CustomText = stepTran + "/" + nodeDate.Nodes.Count + " of " + nodeDate.Text + " Terminal [" + Terminal + "]";
                            prb_Process.Update();
                            if (!nodeEvent.Checked) continue;
                            nodeTag = nodeEvent.Tag as Custom_NodeTag;
                            if (nodeTag.Type is Custom_NodeTag.NodeTypes.Transaction)
                            {
                                trans = nodeTag.Data as Transaction;
                                ImportDB(trans);                               
                            }
                            else if (nodeTag.Type is Custom_NodeTag.NodeTypes.EventDevice)
                            {
                                //var evt = nodeTag.Data as TransactionEvent;
                                //EntryList entr = new EntryList();
                                //entr.ColumnName.Add("TerminalID");
                                //entr.Content.Add(id);

                                //entr.ColumnName.Add("TranType");
                                //entr.Content.Add(evt.Type.ToString());
                                //entr.ColumnName.Add("Amount");
                                //entr.Content.Add(evt.AmountCounter.ToString());

                                //entr.ColumnName.Add("K500");
                                //entr.Content.Add(evt.Value_500K.ToString());
                                //entr.ColumnName.Add("K200");
                                //entr.Content.Add(evt.Value_200K.ToString());
                                //entr.ColumnName.Add("K100");
                                //entr.Content.Add(evt.Value_100K.ToString());
                                //entr.ColumnName.Add("K50");
                                //entr.Content.Add(evt.Value_50K.ToString());
                                //entr.ColumnName.Add("K20");
                                //entr.Content.Add(evt.Value_20K.ToString());
                                //entr.ColumnName.Add("K10");
                                //entr.Content.Add(evt.Value_10K.ToString());

                                //entr.ColumnName.Add("DateTime");
                                //entr.Content.Add(evt.DateBegin.ToString("yyyyMMddHHmmssfff"));
                                //sqlite.CreateEntry("HistoryTransaction", entr);

                            }
                            else if (nodeTag.Type is Custom_NodeTag.NodeTypes.Cycles)
                            {
                                //var evt = nodeTag.Data as Cycle;
                                //EntryList entr = new EntryList();
                                //entr.ColumnName.Add("TerminalID");
                                //entr.Content.Add(id);

                                //entr.ColumnName.Add("TranType");
                                //entr.Content.Add(evt.);
                                //entr.ColumnName.Add("Amount");
                                //entr.Content.Add(evt.AmountCounter.ToString());

                                //entr.ColumnName.Add("500K");
                                //entr.Content.Add(evt.Value_500K.ToString());
                                //entr.ColumnName.Add("200K");
                                //entr.Content.Add(evt.Value_200K.ToString());
                                //entr.ColumnName.Add("100K");
                                //entr.Content.Add(evt.Value_100K.ToString());
                                //entr.ColumnName.Add("50K");
                                //entr.Content.Add(evt.Value_50K.ToString());
                                //entr.ColumnName.Add("20K");
                                //entr.Content.Add(evt.Value_20K.ToString());
                                //entr.ColumnName.Add("10K");
                                //entr.Content.Add(evt.Value_10K.ToString());

                                //entr.ColumnName.Add("DateTime");
                                //entr.Content.Add(evt.DateBegin.ToString("yyyyMMddHHmmssfff"));
                                //sqlite.CreateEntry("HistoryTransaction", entr);
                            }
                        }
                    }
                    prb_Process.PerformStep();
                }
            }
            catch (Exception ex)
            { }
            prb_Process.Size = new Size(0, 0);
        }
        private void ImportDB(Transaction trans)
        {
            try
            {
                Dictionary<DateTime, TransactionRequest> TransactionRequest = trans.ListRequest;

                if (TransactionRequest.Count > 0)
                {
                    foreach (var requestLast in TransactionRequest.Values)
                    {
                        var evts = trans.ListEvent.Where(x => (requestLast.DateBegin != null && requestLast.DateEnd != null) && (x.Value.DateBegin >= requestLast.DateBegin
                            && x.Value.DateBegin <= requestLast.DateEnd)).ToDictionary(x => x.Key, x => x.Value);
                        int countEvts = evts.Values.Where(x => x.isWarning).Count();

                        var evtCounter = evts.OrderBy(x => x.Key).Where(x => x.Value.hasCouter).ToList();

                        EntryList entr = new EntryList();
                        entr.ColumnName.Add("Bank");
                        entr.Content.Add(cb_Bank.Text);
                        entr.ColumnName.Add("TerminalID");
                        entr.Content.Add(trans.Terminal);
                        entr.ColumnName.Add("TranNumber");
                        entr.Content.Add(!string.IsNullOrEmpty(requestLast.TranNo) ? requestLast.TranNo : "-");
                        entr.ColumnName.Add("TranType");
                        entr.Content.Add(string.IsNullOrEmpty(requestLast.Request) ? "N/A" : requestLast.Request);


                        entr.ColumnName.Add("DateTime");
                        entr.Content.Add(trans.DateBegin.ToString("yyyyMMddHHmmssfff"));


                        if (countEvts > 0 && evts.Values.Where(x => x.isWarning).Count() > 0)
                        {

                            foreach (var e in evts.Where(x => x.Value.isWarning).ToDictionary(x => x.Key, x => x.Value))
                            {
                                entr.ColumnName.Add("Status");
                                entr.Content.Add((!string.IsNullOrEmpty(e.Value.Name) ? e.Value.Name : string.Empty) + (
                                    !string.IsNullOrEmpty(e.Value.Data) ? e.Value.Data : string.Empty));
                            }
                        }
                        else
                        {
                            entr.ColumnName.Add("Status");
                            entr.Content.Add(!string.IsNullOrEmpty(requestLast.Status.ToString()) ? requestLast.Status.ToString() : string.Empty);

                        }

                        entr.ColumnName.Add("CardType");
                        entr.Content.Add(trans.CardType.ToString());

                        entr.ColumnName.Add("CardNumber");
                        entr.Content.Add(trans.CardNumber);

                        entr.ColumnName.Add("DataInput");
                        entr.Content.Add(string.Join("\\n", trans.DataInput.ToArray()));


                        entr.ColumnName.Add("Amount");
                        entr.Content.Add((evtCounter.Sum(x => x.Value.AmountCounter) != 0 ? Math.Abs(evtCounter.Sum(x => x.Value.AmountCounter)) : Math.Abs(evtCounter.Sum(x => x.Value.AmountCounterRetracted))).ToString());


                        entr.ColumnName.Add("K500");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_500K)).ToString());

                        entr.ColumnName.Add("K500_Retract");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_500K_Retracted)).ToString());

                        entr.ColumnName.Add("K200");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_200K)).ToString());

                        entr.ColumnName.Add("K200_Retract");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_200K_Retracted)).ToString());

                        entr.ColumnName.Add("K100");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_100K)).ToString());

                        entr.ColumnName.Add("K100_Retract");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_100K_Retracted)).ToString());

                        entr.ColumnName.Add("K50");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_50K)).ToString());

                        entr.ColumnName.Add("K50_Retract");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_50K_Retracted)).ToString());

                        entr.ColumnName.Add("K20");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_20K)).ToString());

                        entr.ColumnName.Add("K20_Retract");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_20K_Retracted)).ToString());

                        entr.ColumnName.Add("K10");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_10K)).ToString());

                        entr.ColumnName.Add("K10_Retract");
                        entr.Content.Add(Math.Abs(evtCounter.Sum(x => x.Value.Value_10K_Retracted)).ToString());

                        entr.ColumnName.Add("WordFlow");
                        entr.Content.Add(trans.ListEvent.Values.Count > 0 ? string.Join("=>", trans.ListEvent.Values) : string.Empty);

                        entr.ColumnName.Add("Log");
                        entr.Content.Add(!string.IsNullOrEmpty(trans.TraceJournalFull) ? trans.TraceJournalFull : string.Empty);

                        sqlite.CreateEntry("HistoryTransaction", entr);
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        bool stopCheck;
        private void tre_LstTrans_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                UIHelper.UIThread(tre_LstTrans, delegate
                 {
                     if (e.Node.Nodes.Count != 0 && !stopCheck)
                         foreach (TreeNode node in e.Node.Nodes)
                         {
                             node.Checked = e.Node.Checked;
                         }

                     if (e.Node.Parent != null)
                     {
                         stopCheck = true;
                         e.Node.Parent.Checked = e.Node.Checked;
                         stopCheck = false;
                     }
                 });
            }
            catch (Exception ex)
            { }
        }

        private void tre_LstTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\u0006')
                {
                    uc_Search.Icon_Search_Click(null, null);
                }
            }

            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void bt_CloseInfo_Click(object sender, EventArgs e)
        {
            if (bt_CloseInfo.Text.Equals(@">>"))
            {
                bt_CloseInfo.Text = @"<<";
                bt_CloseInfo.Cursor = Cursors.PanWest;
                splitContainer1.SplitterDistance = 396;

            }
            else
            {
                bt_CloseInfo.Text = @">>";
                bt_CloseInfo.Cursor = Cursors.PanEast;
                splitContainer1.SplitterDistance = 25;

            }
        }

        private void tre_LstTrans_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        DataTable dataTable;
        DataSet ds;
        BindingSource bindingSource;
        SQLiteDataAdapter DA;
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string query = fc_Query.Text;
                if (fc_Query.SelectedText.Length > 5) query = fc_Query.SelectedText;
                query = query.Replace("500K", "K500").Replace("200K", "K200").Replace("100K", "K100").Replace("50K", "50").Replace("20K", "K20").Replace("10K", "K10");
                query = query.Replace("500K_Retract", "K500_Retract").Replace("200K_Retract", "K200_Retract").Replace("100K_Retract", "K100_Retract").Replace("50K_Retract", "50K_Retract").Replace("20K_Retract", "K20_Retract").Replace("10K_Retract", "K10_Retract");

                sqlite.SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand(query, sqlite.DataBaseConnnection);
                DA = new SQLiteDataAdapter(sqliteCommand);
                dataTable = new DataTable();
                DA.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                gridView.DataSource = bindingSource;
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
            Cursor = Cursors.Default;
        }
    
		private void bt_Delete_Click(object sender, EventArgs e)
		{
            try
            {
                //gridView.Rows.RemoveAt(gridView.CurrentRow.Index);
                //DA.Update(dataTable);

                UC_ExportOption uc_export = new UC_ExportOption();
                uc_export.Dock = DockStyle.Fill;
                Frm_TemplateDefault frm = new Frm_TemplateDefault(uc_export, "Export Options");
                frm.Show();

            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

		private void bt_WriteChange_Click(object sender, EventArgs e)
		{
            try
            {
                DA.Update(dataTable);
                MessageBox.Show("Update success.", "Write Changes");
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
           
		}
	}
}
