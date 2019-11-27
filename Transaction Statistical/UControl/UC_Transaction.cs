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

namespace Transaction_Statistical.UControl
{
    public partial class UC_Transaction : UserControl
    {
        SQLiteHelper sqlite;
        DateTime StartDate = DateTime.MinValue;
        DateTime EndDate = DateTime.MaxValue;
        Dictionary<string, int> ListTransactionType;
        List<Transaction> transactions = new List<Transaction>();
        Dictionary<DateTime, Cycle> ListCycle;
        Dictionary<DateTime, Cycle> ListCycleOld;
        Dictionary<DateTime, Cycle> ListCycleClear;

        #region Read parameter EJ


        int CodeCycleReadFrom = 1;
        string sCycleBegin = string.Empty;
        string sCycleEnd = string.Empty;

        string sSplitTransaction = string.Empty;
        string sFileNameFormat = string.Empty;
        string sTRANSACTIONSTART = string.Empty;
        string sAMOUNTENTERED = string.Empty;
        string sCASHREQUEST = string.Empty;
        string sCASHDISPENSE = string.Empty;
        string sCASHPRESENTED = string.Empty;
        string sDEVICEERROR = string.Empty;
        string sCASHTAKEN = string.Empty;
        string sCASHRETRACT = string.Empty;
        string sTRANSACTIONFAIL = string.Empty;
        string sTRANSACTIONSUCCESSFUL = string.Empty;
        string sCARDTAKEN = string.Empty;
        string sTRANSACTIONEND = string.Empty;
        string sTRACK1 = string.Empty;
        string sTRACK2 = string.Empty;
        string sTRACK3 = string.Empty;
        string sTRANSACTIONREQUEST = string.Empty;
        string sTRANSACTIONREPLY = string.Empty;
        string sNewCounter = string.Empty;
        string sOldCounter = string.Empty;

        #endregion
        public UC_Transaction()
        {
            sqlite = new SQLiteHelper();
            InitializeComponent();
            Add_GUI();
            uc_Menu.Location = new Point(-uc_Menu.Width, uc_Menu.Location.Y);
        }
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
                StartDate = DateTime.MinValue;
                EndDate = DateTime.MaxValue;
            }
            else
            {
                dateTimePicker_Start.Enabled = true;
                dateTimePicker_End.Enabled = true;
                StartDate = dateTimePicker_Start.Value;
                EndDate = dateTimePicker_End.Value;
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
                Reads(filesReadJournal);
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void Reads(List<string> files)
        {
            try
            {

                //   List<string> listDataDay = new List<string>();
                ///
                DateTime dateBegin = DateTime.MinValue;
                DateTime dateEnd = DateTime.Now;
                DateTime currentDate = DateTime.MinValue;

                Dictionary<string, Transaction> listDataDay = new Dictionary<string, Transaction>();
                foreach (string file in files)
                {
                    string day = file.Substring(file.Length - 12, 8);
                    string contenFile = File.ReadAllText(file);
                    DateTime.TryParseExact(file.Substring(file.Length - 12, 8), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out currentDate);
                    contenFile = SplitTransactionEJ(contenFile, InitParametar.transactionTemplate[TransactionEvent.Events.Transaction], listDataDay);
                   
                }

                string start = StartDate.ToString("HH:mm:ss");
                string end = EndDate.ToString("HH:mm:ss");
                ListTransactionType = new Dictionary<string, int>();
                foreach (KeyValuePair<string, Transaction> KeyValue in listDataDay)
                {
                    Transaction trn = Reads_TransInfo(KeyValue.Value);
                    //    if (!(((trn.Day == StartDate.ToString(sFileNameFormat)) && String.Compare(trn.TTime, start) < 0) || ((trn.Day == EndDate.ToString(sFileNameFormat)) && String.Compare(trn.TTime, end) > 0)))
                    if (trn.DateEnd > StartDate && trn.DateBegin < EndDate)
                    {
                        if (trn.TransactionTypeList == string.Empty) trn.TransactionTypeList = "Unknow";
                        foreach (string s in trn.TransactionTypeList.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries))
                        {
                            if (!InitParametar.listTransType.Keys.Contains(s))
                            {
                                ListTransactionType[s] = 1;
                                UIHelper.UIThread(pl_Actions, delegate
                                {
                                    CheckBox item = new CheckBox();
                                    item.Name = s;
                                    pl_Actions.Controls.Add(item);
                                    //     checkedComboBox_TransType1.Items.Add(s); checkedComboBox_TransType1.CheckBoxItems[s].Checked = true; 
                                });
                            }
                            else
                                ListTransactionType[s] = ListTransactionType[s] + 1;
                        }
                        transactions.Add(trn);
                    }

                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }

        }
        private bool Journal_ReadCycleCash(string line, string sCycleBegin, string sCycleEnd, Dictionary<string, string> listDateFormat, DateTime currentDate)
        {
            try
            {
                ///get cycle
                DateTime dateBegin;
                DateTime dateEnd;
                if (GetDateFromFormatLine(line, sCycleBegin, listDateFormat, out dateBegin))
                {
                    Cycle cl = new Cycle();
                    cl.DateBegin = currentDate;
                    ListCycle[dateBegin] = cl;
                }
                else if (GetDateFromFormatLine(line, sCycleEnd, listDateFormat, out dateEnd))
                {
                    dateEnd = DateTime.ParseExact(currentDate.ToString("yyyyMMdd") + dateEnd.ToString("HHmmss"), "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    if (ListCycle.Keys.Count == 0)
                    {
                        Cycle cl = new Cycle();
                        cl.DateBegin = DateTime.MinValue;
                        cl.DateEnd = dateEnd;
                        ListCycle[dateBegin] = cl;
                    }
                    else
                    {
                        Cycle cl = ListCycle.Values.LastOrDefault();
                        if (cl.DateEnd == null)
                        {
                            cl.DateEnd = dateEnd;
                            ListCycle[cl.DateBegin] = cl;
                        }
                        else
                        {
                            Cycle cln = new Cycle();
                            cln.DateBegin = cl.DateEnd;
                            cln.DateEnd = dateEnd;
                            ListCycle[cln.DateBegin] = cln;
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        private string SplitTransactionEJ(string sString, string sReg, Dictionary<string, Transaction> listDataDay)
        {
            string sAfter = sString;
            try
            {
                
                Dictionary<int, RegesValue> lst = new Dictionary<int, RegesValue>();
                if (Regexs.RunPatternRegular(sString, sReg, out lst))
                {
                    Transaction trans;
                    foreach (KeyValuePair<int, RegesValue> key in lst)
                    {
                        trans = new Transaction();                      
                        trans.TTimeBegin = key.Value.value["DateBegin"];
                        trans.TTimeEnd = key.Value.value["TimeEnd"];
                        DateTime.TryParseExact(trans.TTimeBegin, "MM-dd-yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out trans.DateBegin);
                        trans.DateEnd = trans.DateBegin;
                        DateTime.TryParseExact(trans.TTimeEnd, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out trans.DateEnd);
                        trans.Terminal = key.Value.value["TerminalID"];
                        trans.MachineNo = key.Value.value["MachineNo"];
                        trans.CardNumber = key.Value.value["CardNo"];
                        trans.DataInput = key.Value.value["DataInput"];
                        trans.TraceJournalTxt = key.Value.stringfind;
                        trans.TransactionTypeList = string.Empty;
                        trans.Day = String.Format("{0:yyyyMMdd}", trans.DateBegin);
                        listDataDay[key.Value.value["DateBegin"]] = trans;
                        sAfter = sAfter.Replace(key.Value.stringfind, null);
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return sAfter;
        }
        private Transaction Reads_TransInfo(Transaction trn)
        {
            try
            {
                using (StringReader reader = new StringReader(trn.TraceJournalTxt))
                {

                    trn = Read_TransSub(trn, reader);
                }

                Dictionary<int, RegesValue> tkeytmp;
                //Amount
                Dictionary<int, RegesValue> dc_amount = new Dictionary<int, RegesValue>();
                if (Regexs.RunPatternRegular(trn.TraceJournalTxt, sAMOUNTENTERED, out dc_amount))
                {
                    trn.Amount = dc_amount.FirstOrDefault().Value.value.FirstOrDefault().Value;
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return trn;
        }

        private Transaction Read_TransSub(Transaction trn, StringReader reader)
        {
            try
            {
                TransactionEvent ev;
                string line = reader.ReadLine();
                if (trn.CasebyCase == null)
                {
                    trn.CasebyCase = new List<TransactionEvent>();
                     ev = new TransactionEvent();
                    ev.Name = TransactionEvent.Events.TransactionStart;
                    ev.TTime = trn.TTime;
                    ev.Status = TransactionEvent.StatusS.Succeeded;
                    trn.CasebyCase.Add(ev);
                   
                }
                while (!string.IsNullOrEmpty(line))
                {
                    Dictionary<int, RegesValue> tkeytmp = new Dictionary<int, RegesValue>();
                    foreach(KeyValuePair<TransactionEvent.Events,string> tmp in InitParametar.transactionTemplate)
                    {
                        if (Regexs.RunPatternRegular(line, tmp.Value, out tkeytmp))
                        {
                            ev = new TransactionEvent();
                            ev.Name = tmp.Key;
                            ev.TTime = tkeytmp.FirstOrDefault().Value.value["Time"] ?? string.Empty;
                            ev.TContent = tkeytmp.FirstOrDefault().Value.stringfind;
                            ev.Status = TransactionEvent.StatusS.Succeeded;
                            trn.CasebyCase.Add(ev);
                            break;
                        }
                    }
                    line = reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return trn;
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
    }
}
