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

namespace Transaction_Statistical.UControl
{
    public partial class UC_Transaction : UserControl
    {
        SQLiteHelper sqlite;
        DateTime StartDate=DateTime.MinValue;
        DateTime EndDate=DateTime.MaxValue;
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
        Dictionary<string, TransactionType> listTransType;
        #endregion
        public UC_Transaction()
        {
            sqlite = new SQLiteHelper();
            InitializeComponent();
            Add_GUI();
            
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
            string[] extension = { "*.txt", "*.log"};
            DirectoryFileUtilities df = new DirectoryFileUtilities();
            FileInfo[] files = df.GetAllFilePath(tb_Path.Text,extension);
            JournalAnalyze(files);
            
        }
        private void JournalAnalyze(FileInfo[] File_Journal)
        {
            try
            {
                FileComparer comp = new FileComparer(FileComparer.CompareBy.Name);
                List<string> filesReadJournal = File_Journal.Select(f => f.FullName).ToList();
                filesReadJournal.Sort(comp);
                ReadAnalyzeJournal(filesReadJournal);
            }
            catch (Exception ex)
            {
                //InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); 
            }
        }
        private void ReadAnalyzeJournal(List<string> files)
        {
            try
            {
                string idTemplate = "65";
                DataTable cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "67", "Parent_ID", idTemplate);
                Dictionary<string, string> listDateFormat = new Dictionary<string, string>();
                //  ListCycle.Clear();
               /// ListCycleOld.Clear();
               /// ListCycleClear.Clear();
                #region Read template
                foreach (DataRow r in cfg_data.Rows)
                {
                    switch (r["Field"].ToString())
                    {
                        case "DateFormat":
                            string[] listtime = r["Data"].ToString().Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                            listDateFormat = new Dictionary<string, string>();
                            foreach (string s in listtime)
                            {
                                string[] item = s.Split('|');
                                listDateFormat[item[0]] = item[1];
                            }
                            break;
                        case "CycleReadFrom":
                            string cycleReadFrom = r["Data"].ToString();
                            Int32.TryParse(cycleReadFrom, out CodeCycleReadFrom);
                            break;
                        case "CycleBegin":
                            sCycleBegin = r["Data"].ToString();
                            break;
                        case "CycleEnd":
                            sCycleEnd = r["Data"].ToString();
                            break;
                        case "FORMATFILENAME":
                            sFileNameFormat = r["Data"].ToString();
                            break;
                        case "TRANSACTIONSTART":
                            sTRANSACTIONSTART = r["Data"].ToString();
                            break;
                        case "AMOUNTENTERED":
                            sAMOUNTENTERED = r["Data"].ToString();
                            break;
                        case "CASHREQUEST":
                            sCASHREQUEST = r["Data"].ToString();
                            break;
                        case "CASHDISPENSE":
                            sCASHDISPENSE = r["Data"].ToString();
                            break;
                        case "CASHPRESENTED":
                            sCASHPRESENTED = r["Data"].ToString();
                            break;
                        case "DEVICEERROR":
                            sDEVICEERROR = r["Data"].ToString();
                            break;
                        case "CASHTAKEN":
                            sCASHTAKEN = r["Data"].ToString();
                            break;
                        case "CASHRETRACT":
                            sCASHRETRACT = r["Data"].ToString();
                            break;
                        case "TRANSACTIONFAIL":
                            sTRANSACTIONFAIL = r["Data"].ToString();
                            break;
                        case "TRANSACTIONSUCCESSFUL":
                            sTRANSACTIONSUCCESSFUL = r["Data"].ToString();
                            break;
                        case "CARDTAKEN":
                            sCARDTAKEN = r["Data"].ToString();
                            break;
                        case "TRANSACTIONEND":
                            sTRANSACTIONEND = r["Data"].ToString();
                            break;
                        case "TRACK1":
                            sTRACK1 = r["Data"].ToString();
                            break;
                        case "TRACK2":
                            sTRACK2 = r["Data"].ToString();
                            break;
                        case "TRACK3":
                            sTRACK3 = r["Data"].ToString();
                            break;
                        case "TRANSACTIONREQUEST":
                            sTRANSACTIONREQUEST = r["Data"].ToString();
                            break;
                        case "TRANSACTIONREPLY":
                            sTRANSACTIONREPLY = r["Data"].ToString();
                            break;
                        case "NewFormatCounter":
                            sNewCounter = r["Data"].ToString();
                            break;
                        case "OldFormatCounter":
                            sOldCounter = r["Data"].ToString();
                            break;
                        case "SplitTransaction":
                            sSplitTransaction = r["Data"].ToString();
                            break;
                        default:
                            break;
                    }
                }



                ///
                DateTime dateBegin = DateTime.MinValue;
                DateTime dateEnd = DateTime.Now;
                DateTime currentDate = DateTime.MinValue;
                listTransType = new Dictionary<string, TransactionType>();
                DataTable tb_transtype = sqlite.GetTableDataWithColumnName("Transactions", "TemplateID", idTemplate);
                foreach (DataRow r in tb_transtype.Rows)
                {
                    TransactionType type = new TransactionType();
                    type.Name = r["Name"].ToString();
                    type.Identification = r["IdentificationTxt"].ToString();
                    type.Successful = r["SuccessfulTxt"].ToString();
                    type.Unsuccessful = r["UnsuccessfulTxt"].ToString();
                    listTransType[type.Name] = type;

                }
                #endregion
             
                //   List<string> listDataDay = new List<string>();

                Dictionary<string, Transaction> listDataDay = new Dictionary<string, Transaction>();
                foreach (string file in files)
                {
                    string contenFile = File.ReadAllText(file);
                    DateTime.TryParseExact(file.Substring(file.Length - 12, 8), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out currentDate);
                    if (CodeCycleReadFrom == 2 || CodeCycleReadFrom == 3) Journal_ReadCycleCash(contenFile, sCycleBegin, sCycleEnd, listDateFormat, currentDate);
                    SplitTransactionEJ(contenFile, sSplitTransaction, file.Substring(file.Length - 12, 8), listDataDay);
                  //  Journal_ReadCycleCash(contenFile, sNewCounter, currentDate);
                  //  Journal_ReadCycleCash(contenFile, sOldCounter, currentDate);
                }

                string start = StartDate.ToString("HH:mm:ss");
                string end = EndDate.ToString("HH:mm:ss");
                foreach (KeyValuePair<string, Transaction> KeyValue in listDataDay)
                {
                    Transaction trn = ReadAnalyzeJournal_TransactionInfo(KeyValue.Value);
                  
                    //    if (!(((trn.Day == StartDate.ToString(sFileNameFormat)) && String.Compare(trn.TTime, start) < 0) || ((trn.Day == EndDate.ToString(sFileNameFormat)) && String.Compare(trn.TTime, end) > 0)))
                    if (trn.DateEnd > StartDate && trn.DateBegin < EndDate)
                    {
                        if (trn.TransactionTypeList == string.Empty) trn.TransactionTypeList = "Unknow";
                        foreach (string s in trn.TransactionTypeList.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries))
                        {
                            if (!ListTransactionType.Keys.Contains(s))
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
                MessageBox.Show(ex.Message, "Error");
                //InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
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
               // InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        private void SplitTransactionEJ(string sString, string sReg, string DateDay, Dictionary<string, Transaction> listDataDay)
        {
            try
            {
                Dictionary<int, RegesValue> lst = new Dictionary<int, RegesValue>();
                if (Regexs.RunPatternRegular(sString, sReg, out lst))
                {
                    Transaction trans;
                    foreach (KeyValuePair<int, RegesValue> key in lst)
                    {
                        trans = new Transaction();
                        trans.TTimeBegin = key.Value.value["TimeBegin"];
                        trans.TTimeEnd = key.Value.value["TimeEnd"];
                        DateTime.TryParseExact(DateDay + trans.TTimeBegin, "yyyyMMddHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out trans.DateBegin);
                        DateTime.TryParseExact(DateDay + trans.TTimeEnd, "yyyyMMddHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out trans.DateEnd);
                        trans.Card = key.Value.value["Track2"];
                        trans.Name = key.Value.value["Track1"];
                        trans.TraceJournalTxt = key.Value.stringfind;
                        trans.TransactionTypeList = string.Empty;
                        trans.Day = DateDay;
                        listDataDay[DateDay + trans.TTimeBegin] = trans;

                    }
                }
            }
            catch (Exception ex)
            { 
                //InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); 
            }
        }
        private Transaction ReadAnalyzeJournal_TransactionInfo(Transaction trn)
        {
            try
            {
                Dictionary<int, RegesValue> tkeytmp;
                //Amount
                Dictionary<int, RegesValue> dc_amount = new Dictionary<int, RegesValue>();
                if (Regexs.RunPatternRegular(trn.TraceJournalTxt, sAMOUNTENTERED, out dc_amount))
                {
                    trn.Amount = dc_amount.FirstOrDefault().Value.value.FirstOrDefault().Value;
                }
               // MapTransactionsType(listTransType, trn.TraceJournalTxt, trn);
                if (Regexs.RunPatternRegular(trn.TraceJournalTxt, sCASHREQUEST, out tkeytmp))
                {
                    foreach (KeyValuePair<string, string> s in tkeytmp.Values.FirstOrDefault().value)
                    {
                        if (s.Key.Equals("Tc1")) trn.Cassette1 = s.Value;
                        if (s.Key.Equals("Tc2")) trn.Cassette2 = s.Value;
                        if (s.Key.Equals("Tc3")) trn.Cassette3 = s.Value;
                        if (s.Key.Equals("Tc4")) trn.Cassette4 = s.Value;
                        if (s.Key.Equals("Tc5")) trn.Cassette5 = s.Value;
                        if (s.Key.Equals("Tc6")) trn.Cassette6 = s.Value;
                        if (s.Key.Equals("Tc7")) trn.Cassette7 = s.Value;
                        if (s.Key.Equals("Tc8")) trn.Cassette8 = s.Value;
                    }
                }
                else
                {
                    if (Regexs.RunPatternRegular(trn.TraceJournalTxt, sCASHDISPENSE, out tkeytmp))
                    {
                        string cs = tkeytmp.Values.FirstOrDefault().value.FirstOrDefault().Value;
                        string[] dis = cs.Split(';');
                        string[] cassettes = new string[4];

                        for (int j = 0; j < cassettes.Length; j++) cassettes[j] = "0";

                        for (int j = 0; j < dis.Length - 1; j++)
                        {
                            string[] c = dis[j].Split(',');
                            cassettes[int.Parse(dis[j].Substring(0, 1)) - 1] = c[1];
                        }
                        trn.Cassette1 = cassettes[0];
                        trn.Cassette2 = cassettes[1];
                        trn.Cassette3 = cassettes[2];
                        trn.Cassette4 = cassettes[3];
                    }
                }
               
              

            }
            catch (Exception ex)
            { 
                //InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); 
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
    }
}
