using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using OfficeOpenXml;
using Transaction_Statistical.Class;

namespace Transaction_Statistical
{
    public class InitParametar
    {
        public static SQLiteHelper sqlite;
        public static string PathDirectoryCurrentApp;//=Path.GetDirectoryName(Application.ExecutablePath);
        public static string PathDirectoryCurrentAppConfigData;//=Path.GetDirectoryName(Application.ExecutablePath);
        public static string PathDirectoryUtilities;// = PathDirectoryCurrentApp + "Utilities";
        public static string PathDirectoryTempUsr;//= Path.GetTempPath() + "Analyze";
        public static string PathDirectoryDocumentsUsr;
        public static string FolderSystemLog;
        public static string DatabaseFile;
        public static string listFileOpened;// = pathTempUsr + "\\ListFileOpened.ini";
        public static string configFileTrace;// = pathConfig + "\\ConfigTraceFile.ini";
        public static string configFileTraceDefault;
        public static List<string> ListFileDeleteStartup;
        public static string PathFileRecordDeletetStartup;

        //form enu
        public static bool ActiveFormMain;
        public static bool ExitApp = false;
        public static string UsrSupport;
        public static string PwdSupport;
        public static string IpSupport;
        public static string PathUpdateSupport;
        public static string PathUpdateSupportError;


        /// Transaction Template
        public static string TemplateTransactionID = "65";
        public static Dictionary<TransactionEvent.Events, string> transactionTemplate;
        public static Dictionary<string, TransactionType> listTransType;
        public static Dictionary<string, string> listDateFormat;
        public static Dictionary<string, Dictionary<DateTime, Transaction>> listTransaction;
        public static void Init()
        {
            try
            {
                // ftp Support
                UsrSupport = "UsrUpdate";
                PwdSupport = "@UsrUpdate@";
                IpSupport = "ftp://bsi.vn";
                PathUpdateSupport = "/UsrUpdate/Analyze";
                PathUpdateSupportError = "/UsrUpdate/Analyze/Error";
                //version

                //VersionAnalyze.Date = DateTime.ParseExact("2013-04-07 16:40:52", "yyyy-MM-dd HH:mm:ss",System.Globalization.CultureInfo.InvariantCulture);

                //USB

                ///

                //Init directory and file config
                PathDirectoryCurrentApp = Path.GetDirectoryName(Application.ExecutablePath);
                PathDirectoryUtilities = (PathDirectoryCurrentApp + "\\Utilities").Replace(@"\\", @"\");
                PathDirectoryCurrentAppConfigData = PathDirectoryCurrentApp + @"\Config";
                PathDirectoryTempUsr = (Path.GetTempPath() + "\\Analyze").Replace(@"\\", @"\");
                PathDirectoryDocumentsUsr = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Analyze").Replace(@"\\", @"\");
                if (!Directory.Exists(PathDirectoryUtilities)) Directory.CreateDirectory(PathDirectoryUtilities);
                if (!Directory.Exists(PathDirectoryTempUsr)) Directory.CreateDirectory(PathDirectoryTempUsr);
                if (!Directory.Exists(PathDirectoryDocumentsUsr)) Directory.CreateDirectory(PathDirectoryDocumentsUsr);
                if (!Directory.Exists(PathDirectoryCurrentApp) || !Directory.Exists(PathDirectoryUtilities) || !Directory.Exists(PathDirectoryTempUsr)) MessageBox.Show("Directory Application or directory temp profile user error.", "Error Directory.");
                listFileOpened = (PathDirectoryDocumentsUsr + "\\ListFileOpened.ini").Replace(@"\\", @"\"); if (!File.Exists(listFileOpened)) File.Create(listFileOpened);

                configFileTraceDefault = PathDirectoryCurrentApp + @"\config\ConfigTraceFile.ini";

                PathFileRecordDeletetStartup = (PathDirectoryDocumentsUsr + "\\ListFileDeletetStartup.txt").Replace(@"\\", @"\"); if (!File.Exists(PathFileRecordDeletetStartup)) File.Create(PathFileRecordDeletetStartup);

                DatabaseFile = PathDirectoryCurrentAppConfigData + "\\DB.s3db";
                sqlite = new SQLiteHelper();
                listTransaction = new Dictionary<string, Dictionary<DateTime, Transaction>>();
                // Chesk file cfg
                LoadTemplateInfo();
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); ;
            }
        }

        public static void LoadTemplateInfo()
        {
            if (transactionTemplate == null) transactionTemplate = new Dictionary<TransactionEvent.Events, string>();
            if (listTransType == null) listTransType = new Dictionary<string, TransactionType>(); else listTransType.Clear();
            DataTable cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "67", "Parent_ID", InitParametar.TemplateTransactionID);
            if (listDateFormat == null) listDateFormat = new Dictionary<string, string>(); else listDateFormat.Clear();

            #region Read template
            foreach (DataRow r in cfg_data.Rows)
            {
                foreach (TransactionEvent.Events name in (TransactionEvent.Events[])Enum.GetValues(typeof(TransactionEvent.Events)))
                {
                    if (r["Field"].Equals(name.ToString())) transactionTemplate[name] = r["Data"].ToString();
                }

            }
            listTransType = new Dictionary<string, TransactionType>();
            DataTable tb_transtype = sqlite.GetTableDataWithColumnName("Transactions", "TemplateID", InitParametar.TemplateTransactionID);
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
        }

        public static void Send_Error(string MsgError, string ClassName, string MethodName)
        {
            try
            {

                UC_Info msg = new UC_Info();

                msg.TextCustom.ReadOnly = false;
                msg.TextCustom.Text = "Host name: " + Environment.MachineName;
                msg.TextCustom.AppendText(Environment.NewLine + "Class: " + ClassName);
                msg.TextCustom.AppendText(Environment.NewLine + "Method: " + MethodName);
                msg.TextCustom.AppendText(Environment.NewLine + "Date: " + String.Format("{0:yyyy/MM/dd-HH:mm:ss ffff}", DateTime.Now));
                //  msg.TextCustom.Select( );
                msg.TextCustom.Font = new System.Drawing.Font("Times New Roman", 13, FontStyle.Bold);
                msg.TextCustom.SelectionColor = Color.Green;

                Frm_TemplateDefault frm = new Frm_TemplateDefault(msg);
                frm.titleCustom.Text = "Error Message";
                frm.Height = 300;
                frm.Show();

                msg.TextCustom.AppendText(Environment.NewLine + "Error Message:");
                //  int indexline = msg.Messager.TextLength;
                //   msg.TextCustom.Select(indexline, (Environment.NewLine + "Error Message:").Length);
                msg.TextCustom.Font = new System.Drawing.Font("Times New Roman", 12, FontStyle.Italic);
                msg.TextCustom.SelectionColor = Color.Black;

                msg.TextCustom.AppendText(Environment.NewLine + MsgError);
                msg.TextCustom.Update();
                msg.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
    }
    public class TransactionType
    {
        public string Name;
        public string Identification;
        public string Successful;
        public string Unsuccessful;
    }

    public class ReadTransaction
    {
        SQLiteHelper sqlite;
        /// Transaction
        public string FormatTime = "HH:mm:ss";
        public string FormatDate = "yyyyMMdd";
        public string FormatDateTime = "MM - dd - yyyy HH:mm:ss";
        public string FormatDateTime_2 = "MM-dd-yyyy HH:mm:ss";
        public string TemplateTransactionID = "65";
        public Dictionary<TransactionEvent.Events, string> transactionTemplate;

        public Dictionary<string, Dictionary<DateTime, Transaction>> ListTransaction;
        public DateTime StartDate = DateTime.MinValue;
        public DateTime EndDate = DateTime.MaxValue;
        public Dictionary<string, string> Template_EventTransaction;
        public Dictionary<string, string> Template_EventDevice;
        public Dictionary<string, string> Template_EventRequest;
        public Dictionary<string, string> Template_EventReceive;
        public Dictionary<string, string> Template_SplitTransactions;
        public Dictionary<string, string> Template_EventCounterChanged;
        public Dictionary<string, TransactionType> Template_TransType;

        //DAT : 2/12/2019
        public Dictionary<string, string> Template_SplitSupervisorMode;
        public Dictionary<DateTime, Cycle> ListCycle = null;

        public ReadTransaction()
        {
            sqlite = new SQLiteHelper();
            LoadTemplateInfo();
        }
        public void LoadTemplateInfo()
        {
            if (Template_EventTransaction == null) Template_EventTransaction = new Dictionary<string, string>();
            if (Template_EventDevice == null) Template_EventDevice = new Dictionary<string, string>();
            if (Template_EventRequest == null) Template_EventRequest = new Dictionary<string, string>();
            if (Template_EventReceive == null) Template_EventReceive = new Dictionary<string, string>();
            if (Template_SplitTransactions == null) Template_SplitTransactions = new Dictionary<string, string>();
            if (Template_EventCounterChanged == null) Template_EventCounterChanged = new Dictionary<string, string>();
            if (Template_SplitSupervisorMode == null) Template_SplitSupervisorMode = new Dictionary<string, string>();

            if (Template_TransType == null) Template_TransType = new Dictionary<string, TransactionType>(); else Template_TransType.Clear();


            #region Read template
            DataTable cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "456", "Parent_ID", InitParametar.TemplateTransactionID);
            foreach (DataRow r in cfg_data.Rows)
                Template_EventTransaction[r["Field"].ToString()] = r["Data"].ToString();

            cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "457", "Parent_ID", InitParametar.TemplateTransactionID);
            foreach (DataRow r in cfg_data.Rows)
                Template_EventDevice[r["Field"].ToString()] = r["Data"].ToString();

            cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "471", "Parent_ID", InitParametar.TemplateTransactionID);
            foreach (DataRow r in cfg_data.Rows)
                Template_EventRequest[r["Field"].ToString()] = r["Data"].ToString();

            cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "472", "Parent_ID", InitParametar.TemplateTransactionID);
            foreach (DataRow r in cfg_data.Rows)
                Template_EventReceive[r["Field"].ToString()] = r["Data"].ToString();

            cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "458", "Parent_ID", InitParametar.TemplateTransactionID);
            foreach (DataRow r in cfg_data.Rows)
                Template_SplitTransactions[r["Field"].ToString()] = r["Data"].ToString();

            cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "459", "Parent_ID", InitParametar.TemplateTransactionID);
            foreach (DataRow r in cfg_data.Rows)
                Template_EventCounterChanged[r["Field"].ToString()] = r["Data"].ToString();

            cfg_data = sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "460", "Parent_ID", InitParametar.TemplateTransactionID);
            foreach (DataRow r in cfg_data.Rows)
                Template_SplitSupervisorMode[r["Field"].ToString()] = r["Data"].ToString();
            //{
            //    //foreach (TransactionEvent.Events name in (TransactionEvent.Events[])Enum.GetValues(typeof(TransactionEvent.Events)))
            //    //{
            //        if (r["Field"].Equals(name.ToString())) transactionTemplate[name] = r["Data"].ToString();
            //  //  }

            //}
            Template_TransType = new Dictionary<string, TransactionType>();
            DataTable tb_transtype = sqlite.GetTableDataWithColumnName("Transactions", "TemplateID", InitParametar.TemplateTransactionID);
            foreach (DataRow r in tb_transtype.Rows)
            {
                TransactionType type = new TransactionType();
                type.Name = r["Name"].ToString();
                type.Identification = r["IdentificationTxt"].ToString();
                type.Successful = r["SuccessfulTxt"].ToString();
                type.Unsuccessful = r["UnsuccessfulTxt"].ToString();
                Template_TransType[type.Name] = type;
            }
            #endregion
        }
        public bool Reads(List<string> files)
        {

            try
            {
                DateTime dateBegin = DateTime.MinValue;
                DateTime dateEnd = DateTime.Now;
                DateTime currentDate = DateTime.MinValue;

                ListTransaction = new Dictionary<string, Dictionary<DateTime, Transaction>>();
                ListCycle = new Dictionary<DateTime, Cycle>();

                foreach (string file in files)
                {
                    string day = file.Substring(file.Length - 12, 8);
                    string contenFile = File.ReadAllText(file);
                    DateTime.TryParseExact(day, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out currentDate);
                    SplitTransactionEJ(ref contenFile);
                    //SplitLogged(ref contenFile);

                    FindCounterChanged(ref contenFile, ref ListCycle);


                }
                int i = ListTransaction.Values.LastOrDefault().Keys.Count;
                Stream stream = null;
                using (var excelPackage = new ExcelPackage(stream ?? new MemoryStream()))
                {
                    TemplateHelper template = new TemplateHelper("Dat", "Report", "Test", excelPackage);
                    // Tạo buffer memory stream để hứng file excel
                    template.CanQuyTheoCouterTrenMay("cân quỹ theo counter trên máy", OfficeOpenXml.Table.TableStyles.Custom, ListCycle);
                    //template.BaoCaoGiaoDichBatThuong("test_2", OfficeOpenXml.Table.TableStyles.Custom);
                    //template.BaoCaoGiaoDichKhongThanhCong("test_3", OfficeOpenXml.Table.TableStyles.Custom, dBTemp);
                    stream = template.getStream();
                    var buffer = stream as MemoryStream;
                    File.WriteAllBytes(@"E:\text.xlsx", buffer.ToArray());
                }
                MessageBox.Show(ListCycle.Count() + ":  Cycle " + i.ToString() + " transaction : " + (DateTime.Now - dateEnd).TotalSeconds.ToString() + " s =>" + ((DateTime.Now - dateEnd).TotalSeconds / i).ToString(), "Total");

                return true;
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        public bool Export(List<string> files)
        {
            try
            {
                DateTime dateBegin = DateTime.MinValue;
                DateTime dateEnd = DateTime.Now;
                DateTime currentDate = DateTime.MinValue;

                ListTransaction = new Dictionary<string, Dictionary<DateTime, Transaction>>();
                ListCycle = new Dictionary<DateTime, Cycle>();

                foreach (string file in files)
                {
                    string day = file.Substring(file.Length - 12, 8);
                    string contenFile = File.ReadAllText(file);
                    DateTime.TryParseExact(day, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out currentDate);
                    SplitTransactionEJ(ref contenFile);
                    //SplitLogged(ref contenFile);

                    FindCounterChanged(ref contenFile, ref ListCycle);

                }
                int i = ListTransaction.Values.LastOrDefault().Keys.Count;

                Stream stream = null;
                using (var excelPackage = new ExcelPackage(stream ?? new MemoryStream()))
                {
                    TemplateHelper template = new TemplateHelper("dat", "ok", "", excelPackage);
                    // Tạo buffer memory strean để hứng file excel
                    template.CanQuyTheoCouterTrenMay("test", OfficeOpenXml.Table.TableStyles.Custom, ListCycle);
                    //template.BaoCaoGiaoDichBatThuong("test_2", OfficeOpenXml.Table.TableStyles.Custom);
                    //template.BaoCaoGiaoDichKhongThanhCong("test_3", OfficeOpenXml.Table.TableStyles.Custom, dBTemp);
                    stream = template.getStream();
                    var buffer = stream as MemoryStream;
                    //// Đây là content Type dành cho file excel, còn rất nhiều content-type khác nhưng cái này mình thấy okay nhất
                    File.WriteAllBytes(@"E:\text.xlsx", buffer.ToArray());
                }
                MessageBox.Show(ListCycle.Count() + ":  Cycle " + i.ToString() + " transaction : " + (DateTime.Now - dateEnd).TotalSeconds.ToString() + " s =>" + ((DateTime.Now - dateEnd).TotalSeconds / i).ToString(), "Total");

                return true;

            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }

            return false;
        }
        private bool SplitTransactionEJ(ref string sString)
        {
            try
            {
                Dictionary<int, RegesValue> lst = new Dictionary<int, RegesValue>();
                foreach (string reg in Template_SplitTransactions.Values)
                {
                    if (Regexs.RunPatternRegular(sString, reg, out lst))
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
                            //trans.CardNumber = key.Value.value["CardNo"];
                            //trans.DataInput = key.Value.value["DataInput"];
                            trans.TraceJournalFull = trans.TraceJournal_Remaining = key.Value.stringfind;
                            trans.TransactionTypeList = string.Empty;
                            trans.Day = String.Format("{0:yyyyMMdd}", trans.DateBegin);

                            trans.TraceJournal_Remaining = trans.TraceJournal_Remaining.Replace(key.Value.value["SStart"], null);
                            trans.TraceJournal_Remaining = trans.TraceJournal_Remaining.Replace(key.Value.value["SEnd"], null);

                            FindEventTransaction(ref trans.TraceJournal_Remaining, trans.DateBegin, ref trans.ListEvent);
                            FindEventRequest(ref trans.TraceJournal_Remaining, trans.DateBegin, ref trans.ListEvent);
                            FindEventReceive(ref trans.TraceJournal_Remaining, trans.DateBegin, ref trans.ListEvent);


                            if (ListTransaction.ContainsKey(trans.Terminal))
                            {
                                if (ListTransaction[trans.Terminal].ContainsKey(trans.DateBegin))
                                    trans.DateBegin.AddMilliseconds(1);
                                ListTransaction[trans.Terminal][trans.DateBegin] = trans;
                            }
                            else
                                ListTransaction[trans.Terminal] = new Dictionary<DateTime, Transaction>() { { trans.DateBegin, trans } };
                            sString = sString.Replace(trans.TraceJournalFull, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        private bool FindCounterChanged(ref string sString, ref Dictionary<DateTime, Cycle> Cycles)
        {
            try
            {
                Cycle cycleItem = null;
                Dictionary<int, RegesValueWithPatternOfGroup> lst = new Dictionary<int, RegesValueWithPatternOfGroup>();

                CycleEvent evt;
                foreach (KeyValuePair<string, string> reg in Template_EventCounterChanged)
                {
                    if (Regexs.RunPatternRegular(sString, reg.Value, out lst))
                    {
                        foreach (KeyValuePair<int, RegesValueWithPatternOfGroup> key in lst)
                        {
                            evt = new CycleEvent();
                            evt.Name = reg.Value;
                            evt.Log = key.Value.stringfind;

                            if (key.Value.value.ContainsKey("Settlement"))
                            {
                                cycleItem = new Cycle();
                                cycleItem.LogTxt = key.Value.stringfind;
                                cycleItem.IndexLog = key.Value.index;
                                var date = key.Value.value["StartDateTime"].FirstOrDefault().Value;
                                evt.TDate = date;
                                var settlementPeriodDateBegin = key.Value.value["Start"].FirstOrDefault().Value;
                                var settlementPeriodDateEnd = key.Value.value["End"].FirstOrDefault().Value;
                                var startSettlement = DateTime.ParseExact(date, FormatDateTime_2, CultureInfo.InvariantCulture);
                                var periodDateBegin = DateTime.ParseExact(settlementPeriodDateBegin, FormatDateTime_2, CultureInfo.InvariantCulture);
                                var periodDateEnd = DateTime.ParseExact(settlementPeriodDateEnd, FormatDateTime_2, CultureInfo.InvariantCulture);
                                cycleItem.SettlementPeriodDateBegin = periodDateBegin;
                                cycleItem.SettlementPeriodDateEnd = periodDateEnd;
                                cycleItem.DateBegin = startSettlement;
                                cycleItem.TerminalID = key.Value.value["TerminalNo"].FirstOrDefault().Value;
                                cycleItem.SerialNo = key.Value.value["SerialNo"].FirstOrDefault().Value;

                                //GET CASH COUNT OUT 
                                if (key.Value.value.ContainsKey("CashCount") && key.Value.value.ContainsKey("ListCassette"))
                                {
                                    var dateCashCountValue = key.Value.value["TimeCashCount"].FirstOrDefault().Value;
                                    var dateCashCount = DateTime.ParseExact(
                                        string.Format("{0} {1}",
                                        date.Split(' ')[0],
                                        dateCashCountValue),
                                        FormatDateTime_2,
                                        CultureInfo.InvariantCulture);
                                    var NameCassette = key.Value.value["NameCassette"].ToArray();
                                    var TypeCassette = key.Value.value["Type"].ToArray();
                                    var DenomiCassette = key.Value.value["Denomi"].ToArray();
                                    var InitialCassette = key.Value.value["InitialCassette"].ToArray();
                                    var CurrentCassette = key.Value.value["Current"].ToArray();
                                    var StatusCassette = key.Value.value["Status"].ToArray();
                                    for (int i = 0; i < NameCassette.Count(); i++)
                                    {
                                        Cassette cassette = new Cassette();
                                        cassette.Name = NameCassette[i].Value.Trim();
                                        cassette.Type = TypeCassette[i].Value.Trim();
                                        cassette.Denomi = DenomiCassette[i].Value.Trim();
                                        cassette.Initial = InitialCassette[i].Value.Trim();
                                        cassette.Current = CurrentCassette[i].Value.Trim();
                                        cassette.Status = StatusCassette[i].Value.Trim();
                                        cycleItem.Cashcount_Out.Add(NameCassette[i].Value, cassette);

                                    }

                                }
                                //GET DENOMINATION COUNT 
                                if (key.Value.value.ContainsKey("DenomiationCount")
                                    && key.Value.value.ContainsKey("ListDeno") && key.Value.value.ContainsKey("DenoListRetract"))
                                {
                                    var dateDenominationCountValue = key.Value.value["TimeCashCount"].FirstOrDefault().Value;
                                    var dateDenominationCount = DateTime.ParseExact(
                                        string.Format("{0} {1}",
                                        date.Split(' ')[0],
                                        dateDenominationCountValue),
                                        FormatDateTime_2,
                                        CultureInfo.InvariantCulture);
                                    var NameDenomi = key.Value.value["Name"].ToArray();
                                    var DispensedDenomi = key.Value.value["Dispensed"].ToArray();
                                    var DepositedDenomi = key.Value.value["Deposited"].ToArray();
                                    var RemainingDenomi = key.Value.value["Remaining"].ToArray();
                                    var InitialDenomi = key.Value.value["Initial"].ToArray();
                                    var NameDenoRetract = key.Value.value["NameDenoRetract"].ToArray();
                                    var CountDenoRetract = key.Value.value["CountDenoRetract"].ToArray();
                                    for (int i = 0; i < NameDenomi.Count(); i++)
                                    {
                                        Deno deno = new Deno();
                                        deno.Name = NameDenomi[i].Value;
                                        deno.Dispensed = DispensedDenomi[i].Value.Trim();
                                        deno.Deposited = DepositedDenomi[i].Value.Trim();
                                        deno.Initial = InitialDenomi[i].Value.Trim();
                                        deno.Remaining = RemainingDenomi[i].Value.Trim();
                                        cycleItem.DenominationCount.Add(NameDenomi[i].Value, deno);
                                    }
                                    for (int i = 0; i < NameDenoRetract.Count(); i++)
                                    {
                                        if (!cycleItem.DenominationCount.ContainsKey(NameDenoRetract[i].Value.Trim()))
                                        {
                                            Deno deno = new Deno();
                                            deno.Name = NameDenoRetract[i].Value.Trim();
                                            deno.Retracted = CountDenoRetract[i].Value.Trim();
                                            cycleItem.DenominationCount.Add(NameDenoRetract[i].Value.Trim(), deno);
                                        }
                                        else
                                        {
                                            cycleItem
                                                .DenominationCount
                                                .FirstOrDefault(x => x.Key == NameDenoRetract[i].Value.Trim())
                                                .Value
                                                .Retracted = CountDenoRetract[i].Value.Trim();

                                        }
                                    }

                                }
                                if (!Cycles.ContainsKey(startSettlement))
                                {
                                    Cycles.Add(startSettlement, cycleItem);
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        private bool FindEventDevice(DateTime DateCurrent, ref string sString, ref Dictionary<DateTime, TransactionEvent> eventList)
        {
            try
            {
                Dictionary<int, RegesValue> lst = new Dictionary<int, RegesValue>();
                TransactionEvent evt;

                foreach (KeyValuePair<string, string> tmp in Template_EventDevice)
                {
                    if (Regexs.RunPatternRegular(sString, tmp.Value, out lst))
                    {
                        foreach (RegesValue regx in lst.Values)
                        {
                            evt = new TransactionEvent();
                            evt.Name = tmp.Key;
                            evt.Status = TransactionEvent.StatusS.Succeeded;
                            evt.TContent = regx.stringfind;
                            evt.TTime = regx.value.ContainsKey("Time") ? regx.value["Time"] : string.Empty;
                            DateTime.TryParseExact(evt.TTime, FormatTime, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateCurrent);
                            evt.TDate = string.Format("{0:" + FormatDate + "}", DateCurrent);
                            if (eventList.ContainsKey(DateCurrent)) eventList[DateCurrent.AddMilliseconds(1)] = evt;
                            else eventList[DateCurrent] = evt;
                            sString = sString.Replace(regx.stringfind, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        private bool FindEventTransaction(ref string sString, DateTime DateCurrent, ref Dictionary<DateTime, TransactionEvent> eventList)
        {
            try
            {
                Dictionary<int, RegesValue> lst = new Dictionary<int, RegesValue>();
                TransactionEvent evt;

                foreach (KeyValuePair<string, string> tmp in Template_EventTransaction)
                {
                    if (Regexs.RunPatternRegular(sString, tmp.Value, out lst))
                    {
                        foreach (RegesValue regx in lst.Values)
                        {
                            evt = new TransactionEvent();
                            evt.Name = tmp.Key;
                            evt.Status = TransactionEvent.StatusS.Succeeded;
                            evt.TContent = regx.stringfind;
                            if (regx.value.ContainsKey("Time"))
                            {
                                evt.TTime = regx.value["Time"];
                                DateTime.TryParseExact(String.Format("{0:" + FormatDate + "}", DateCurrent) + evt.TTime, FormatDate + FormatTime, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateCurrent);
                            }
                            evt.TDate = string.Format("{0:" + FormatDate + "}", DateCurrent);
                            if (eventList.ContainsKey(DateCurrent)) eventList[DateCurrent.AddMilliseconds(1)] = evt;
                            else eventList[DateCurrent] = evt;
                            sString = sString.Replace(regx.stringfind, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        private bool FindEventRequest(ref string sString, DateTime DateCurrent, ref Dictionary<DateTime, TransactionEvent> eventList)
        {
            try
            {
                Dictionary<int, RegesValue> lst = new Dictionary<int, RegesValue>();
                TransactionEvent evt;

                foreach (KeyValuePair<string, string> tmp in Template_EventRequest)
                {
                    if (Regexs.RunPatternRegular(sString, tmp.Value, out lst))
                    {
                        foreach (RegesValue regx in lst.Values)
                        {
                            evt = new TransactionEvent();
                            evt.Name = tmp.Key;
                            evt.Status = TransactionEvent.StatusS.Succeeded;
                            evt.TContent = regx.stringfind;
                            evt.TTime = regx.value.ContainsKey("Time") ? regx.value["Time"] : string.Empty;
                            DateTime.TryParseExact(evt.TTime, FormatTime, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateCurrent);
                            evt.TDate = string.Format("{0:" + FormatDate + "}", DateCurrent);
                            if (eventList.ContainsKey(DateCurrent)) eventList[DateCurrent.AddMilliseconds(1)] = evt;
                            else eventList[DateCurrent] = evt;
                            sString = sString.Replace(regx.stringfind, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        private bool FindEventReceive(ref string sString, DateTime DateCurrent, ref Dictionary<DateTime, TransactionEvent> eventList)
        {
            try
            {
                Dictionary<int, RegesValue> lst = new Dictionary<int, RegesValue>();
                TransactionEvent evt;

                foreach (KeyValuePair<string, string> tmp in Template_EventReceive)
                {
                    if (Regexs.RunPatternRegular(sString, tmp.Value, out lst))
                    {
                        foreach (RegesValue regx in lst.Values)
                        {
                            evt = new TransactionEvent();
                            evt.Name = tmp.Key;
                            evt.Status = TransactionEvent.StatusS.Succeeded;
                            evt.TContent = regx.stringfind;
                            evt.TTime = regx.value.ContainsKey("Time") ? regx.value["Time"] : string.Empty;
                            DateTime.TryParseExact(evt.TTime, FormatTime, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateCurrent);
                            evt.TDate = string.Format("{0:" + FormatDate + "}", DateCurrent);
                            if (eventList.ContainsKey(DateCurrent)) eventList[DateCurrent.AddMilliseconds(1)] = evt;
                            else eventList[DateCurrent] = evt;
                            sString = sString.Replace(regx.stringfind, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }

        //DAT : 3/12/2019
        private bool SplitLogged(ref string sString)
        {
            try
            {
                Dictionary<int, RegesValue> lst = new Dictionary<int, RegesValue>();
                string reg = @"(?<Logged>(?<LoggedStart>(\d+:\d+:\d+))\sLogged into Supervisor Mode[\s\S]*?\s+(?<LoggedEnd>(\d+:\d+:\d+))\s+Logged out from Supervisor Mode)";
                if (Regexs.RunPatternRegular(sString, reg, out lst))
                {
                    Cycle cycle;
                    foreach (KeyValuePair<int, RegesValue> key in lst)
                    {
                        cycle = new Cycle();
                        cycle.LogTxt = key.Value.stringfind;
                        string LogTxts = key.Value.stringfind;
                        FindCounterChanged(ref LogTxts, ref ListCycle);

                        //if (cycle.DateBegin != DateTime.MinValue)
                        //{

                        //    ListCycle.Add(cycle.DateBegin.ToString(), cycle);
                        //}

                        sString = sString.Replace(key.Value.value["Logged"], null);
                    }
                }

            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
    }

    public class Transaction
    {
        public enum TransactionType
        {
            Alls,
            Withdrawal,
            Deposit,
            BalanceInquiry,
            MiniStatement,
            ChangePin
        }
        public Dictionary<DateTime, TransactionEvent> ListEvent = new Dictionary<DateTime, TransactionEvent>();
        public int Result;
        string _datainput = string.Empty;
        [CategoryAttribute("Customer"), DescriptionAttribute("Data input")]
        public string DataInput
        {
            get { return _datainput; }
            set { _datainput = value; }
        }
        string _card = "";
        [CategoryAttribute("Customer"), DescriptionAttribute("Card number")]
        public string CardNumber
        {
            get { return _card; }
            set { _card = value; }
        }
        string _name = "";
        [CategoryAttribute("Customer"), DescriptionAttribute("Name of the customer")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string TraceJournalFull;
        public string TraceJournal_Remaining;
        public string TraceDeviceTxt;
        public string TraceTransMsgTxt;
        public string TraceApplicationTrcTxt;
        public string Day;
        TransactionType _type = TransactionType.Withdrawal;
        [CategoryAttribute("Transaction"), DescriptionAttribute("Type the transaction")]
        public TransactionType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        [CategoryAttribute("Transaction"), DescriptionAttribute("Type the transaction list")]
        public string TransactionTypeList { get; set; }
        string _tdate = "";
        [CategoryAttribute("Transaction"), DescriptionAttribute("Date of the transaction")]
        public string TDate
        {
            get { return _tdate; }
            set { _tdate = value; }
        }
        public DateTime DateBegin;
        public DateTime DateEnd;
        public string TTimeBegin;
        public string TTimeEnd;
        string _ttime = "";
        [CategoryAttribute("Transaction"), DescriptionAttribute("Time of the transaction")]
        public string TTime
        {
            get { return _ttime; }
            set { _ttime = value; }
        }

        string _amount = "0";
        [CategoryAttribute("Transaction"), DescriptionAttribute("Amount")]
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 1")]
        public string Terminal;
        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 1")]
        public string MachineNo;

        string _cassette1 = string.Empty;
        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 1")]
        public string Cassette1
        {
            get { return _cassette1; }
            set { _cassette1 = value; }
        }

        string _cassette2 = string.Empty;
        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 2")]
        public string Cassette2
        {
            get { return _cassette2; }
            set { _cassette2 = value; }
        }

        string _cassette3 = string.Empty;
        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 3")]
        public string Cassette3
        {
            get { return _cassette3; }
            set { _cassette3 = value; }
        }

        string _cassette4 = string.Empty;
        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 4")]
        public string Cassette4
        {
            get { return _cassette4; }
            set { _cassette4 = value; }
        }

        string _cassette5 = string.Empty;
        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 5")]
        public string Cassette5
        {
            get { return _cassette5; }
            set { _cassette5 = value; }
        }

        string _cassette6 = string.Empty;
        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 6")]
        public string Cassette6
        {
            get { return _cassette6; }
            set { _cassette6 = value; }
        }

        string _cassette7 = string.Empty;
        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 7")]
        public string Cassette7
        {
            get { return _cassette7; }
            set { _cassette7 = value; }
        }

        string _cassette8 = string.Empty;
        [CategoryAttribute("CRM"), DescriptionAttribute("Cassette 8")]
        public string Cassette8
        {
            get { return _cassette8; }
            set { _cassette8 = value; }
        }

        string _status = "";
        [CategoryAttribute("CRM"), DescriptionAttribute("Status")]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        //List<Withdrawal> _withdraw = new List<Withdrawal>();
        //[CategoryAttribute("Transaction"), DescriptionAttribute("Withdrawals")]
        //public List<Withdrawal> Withdraws
        //{
        //    get { return _withdraw; }
        //    set { _withdraw = value; }
        //}


        public Transaction()
        {

        }

        public override string ToString()
        {
            if (Type == TransactionType.Withdrawal)
                return Day + "," + TTime + "," + Name + "," + CardNumber + "," + Cassette1.ToString() + "," + Cassette2.ToString() + "," + Cassette3.ToString() + "," + Cassette4.ToString();
            return "";
        }
    }
    public class TransactionEvent
    {
        public enum Events
        {
            TransactionStart,
            CardInserted,
            Track1,
            Track2,
            Track3,
            PINEntered,
            AmountEnter,
            TransactionReqSend,
            TransactionResReceive,
            NotesInserted,
            ShutterOpen,
            NotesRemoved,
            AddMoreDeposit,
            TransactionEnd,
            Transaction
        }

        public string Name;
        public enum StatusS
        {
            Succeeded,
            UnSucceeded,
            Warning,
            Error
        }
        public StatusS Status;
        [CategoryAttribute("Transaction"), DescriptionAttribute("Date of the transaction")]
        public string TDate;

        [CategoryAttribute("Transaction"), DescriptionAttribute("Time of the transaction")]
        public string TTime;
        [CategoryAttribute("Transaction"), DescriptionAttribute("Content of the transaction")]
        public string TContent;
    }

    public class CycleEvent
    {
        public enum Events
        {
            SettlementPeriod,
            CashCount,
            DenominationCount,
            CardCapture,
            ForgottenBanknote,
            Replenishment
        }

        public string Name;
        public string Log;

        [CategoryAttribute("Cycle"), DescriptionAttribute("Date of the cycle")]
        public string TDate;

    }


    public class RegesValue
    {
        public int index;
        public Dictionary<string, string> value = new Dictionary<string, string>();
        public string stringfind;
        public RegesValue()
        { }

    }
    public class RegesValueWithPatternOfGroup
    {
        public int index;
        public Dictionary<string, Dictionary<int, string>> value = new Dictionary<string, Dictionary<int, string>>();
        public string stringfind;
        public RegesValueWithPatternOfGroup()
        { }

    }
    public class Regexs
    {
        //public static Dictionary<int, RegesValue> RunPatternRegular(string sString, string sReg, bool ShowMessage)
        //{

        //    Dictionary<int, RegesValue> listResult = new Dictionary<int, RegesValue>();

        //    try
        //    {

        //        Regex myRegex = new Regex(sReg);
        //        MatchCollection m = myRegex.Matches(sString);
        //        if (m.Count != 0)
        //        {
        //            // m.Groups[""].Captures.

        //            List<string> listVar = new List<string>();
        //            bool var1 = false;
        //            bool var2 = false;
        //            string var = string.Empty;
        //            foreach (char c in sReg)
        //            {
        //                if (c == '?')
        //                {
        //                    var1 = true;
        //                }
        //                else if (c == '<') var2 = true;
        //                else if (c == '>') { var1 = var2 = false; listVar.Add(var); var = string.Empty; }
        //                else if (var1 && var2)
        //                {
        //                    var += c;
        //                }
        //            }
        //            int k = 0;
        //            string result = string.Empty;
        //            foreach (Match n in m)
        //            {
        //                RegesValue results = new RegesValue();
        //                results.stringfind = n.ToString();
        //                results.index = n.Index;

        //                k++;
        //                string value = string.Empty;
        //                foreach (string group in listVar)
        //                {

        //                    value += Environment.NewLine + group + " : " + n.Groups[group];
        //                    results.value[group] = n.Groups[group].ToString();
        //                }
        //                result = "Found map: " + k.ToString() + "/" + m.Count.ToString() + Environment.NewLine + "-----------Map string-----------" + Environment.NewLine + n.Value + Environment.NewLine + "-----------Group map-----------" + value + Environment.NewLine;
        //                listResult[n.Index] = results;
        //            }
        //            if (ShowMessage)
        //            {
        //                Message_Form frm = new Message_Form("Run Test Result", result);
        //              frm.Show();
        //            }

        //        }
        //        else
        //        {
        //            if (ShowMessage) MessageBox.Show("Not math :(", "Test fail", MessageBoxButtons.OK);
        //        }
        //    }
        //    catch (Exception ex)
        //    { InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); }
        //    return listResult;
        //}
        //public static bool RunPatternRegular(string sString, string sReg, bool ShowMessage, out Dictionary<int, RegesValue> listResult)
        //{

        //    listResult = new Dictionary<int, RegesValue>();
        //    try
        //    {

        //        Regex myRegex = new Regex(sReg);
        //        MatchCollection m = myRegex.Matches(sString);
        //        if (m.Count != 0)
        //        {
        //            // m.Groups[""].Captures.

        //            List<string> listVar = new List<string>();
        //            bool var1 = false;
        //            bool var2 = false;
        //            string var = string.Empty;
        //            foreach (char c in sReg)
        //            {
        //                if (c == '?')
        //                {
        //                    var1 = true;
        //                }
        //                else if (c == '<') var2 = true;
        //                else if (c == '>') { var1 = var2 = false; listVar.Add(var); var = string.Empty; }
        //                else if (var1 && var2)
        //                {
        //                    var += c;
        //                }
        //            }
        //            int k = 0;
        //            string result = string.Empty;
        //            foreach (Match n in m)
        //            {
        //                RegesValue results = new RegesValue();
        //                results.stringfind = n.ToString();
        //                results.index = n.Index;

        //                k++;
        //                string value = string.Empty;
        //                foreach (string group in listVar)
        //                {

        //                    value += Environment.NewLine + group + " : " + n.Groups[group];
        //                    results.value[group] = n.Groups[group].ToString();
        //                }
        //                result = "Found map: " + k.ToString() + "/" + m.Count.ToString() + Environment.NewLine + "-----------Map string-----------" + Environment.NewLine + n.Value + Environment.NewLine + "-----------Group map-----------" + value + Environment.NewLine;
        //                listResult[n.Index] = results;
        //            }
        //            if (ShowMessage)
        //            {
        //                Message_Form frm = new Message_Form("Run Test Result", result);
        //                frm.Show();
        //            }
        //            return true;
        //        }
        //        else
        //        {
        //            if (ShowMessage) MessageBox.Show("Not math :(", "Test fail", MessageBoxButtons.OK);
        //            else return false;

        //        }
        //    }
        //    catch (Exception ex)
        //    { InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); }
        //    return false;
        //}
        public static bool RunPatternRegular(string sString, string sReg, out Dictionary<int, RegesValue> listResult)
        {
            listResult = new Dictionary<int, RegesValue>();
            try
            {
                Regex myRegex = new Regex(sReg, RegexOptions.ExplicitCapture, TimeSpan.FromSeconds(5));
                MatchCollection m = myRegex.Matches(sString);
                Match ma = myRegex.Match(sString);
                if (m.Count != 0)
                {
                    foreach (Match n in m)
                    {
                        RegesValue results = new RegesValue();
                        results.stringfind = n.ToString();
                        results.index = n.Index;
                        foreach (string groupName in myRegex.GetGroupNames())
                        {
                            if (groupName.Equals("0")) continue;
                            results.value[groupName] = n.Groups[groupName].ToString();
                        }
                        listResult[n.Index] = results;
                    }
                    return true;
                }
            }

            catch (TimeoutException)
            { }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        public static bool RunPatternRegular(string sString, string sReg, out Dictionary<int, RegesValueWithPatternOfGroup> listResult)
        {

            listResult = new Dictionary<int, RegesValueWithPatternOfGroup>();
            try
            {
                Regex myRegex = new Regex(sReg, RegexOptions.ExplicitCapture, TimeSpan.FromSeconds(5));
                MatchCollection m = myRegex.Matches(sString);
                Match ma = myRegex.Match(sString);
                if (m.Count != 0)
                {
                    foreach (Match n in m)
                    {
                        RegesValueWithPatternOfGroup results = new RegesValueWithPatternOfGroup();
                        results.stringfind = n.ToString(); sString = sString.Replace(n.ToString(), string.Empty);
                        results.index = n.Index;
                        foreach (string groupName in myRegex.GetGroupNames())
                        {
                            if (groupName.Equals("0")) continue;
                            CaptureCollection captureCollection = n.Groups[groupName].Captures;
                            Dictionary<int, string> keyValues = new Dictionary<int, string>();
                            foreach (Capture capture in captureCollection)
                            {

                                keyValues.Add(capture.Index, capture.Value);
                            }
                            results.value[groupName] = keyValues;
                        }
                        listResult[n.Index] = results;
                    }
                    return true;
                }
            }

            catch (TimeoutException)
            { }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }


    }
    public class UIHelper
    {
        static public void UIThread(Control control, MethodInvoker code)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    control.BeginInvoke(code);
                    return;
                }
                control.Invoke(code);
            }
            catch
            {
                //  MsgInfo.MessageBoxError("Core", "UIHelper", "UIThread", "Parameter1: " + control.ToString() + "\nParameter2: " + code.ToString() + "\n" + ex.Message.ToString());
            }
        }
        internal static void UIThread(ListViewItem it, MethodInvoker methodInvoker)
        {
            throw new NotImplementedException();
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    public class Cycle
    {

        public DateTime DateBegin;
        public DateTime DateEnd;
        public DateTime SettlementPeriodDateBegin;
        public DateTime SettlementPeriodDateEnd;
        public Dictionary<string, CycleEvent> ListEvent = new Dictionary<string, CycleEvent>();
        public Dictionary<int, Cassette> Cashcount_In = null;
        public Dictionary<string, Cassette> Cashcount_Out = new Dictionary<string, Cassette>();
        public Dictionary<string, Deno> DenominationCount = new Dictionary<string, Deno>();
        public string LogTxt;
        public string PathLog;
        public int IndexLog;
        public string TerminalID;
        public string SerialNo;
    }
    public class Deno
    {
        public string Name = string.Empty;
        public string Dispensed = "0";
        public string Deposited = "0";
        public string Remaining = "0";
        public string Retracted = "0";
        public string Initial = "0";
        public string currency = string.Empty;
        public string log = string.Empty;
    }
    public class CapturedCard
    {
        public DateTime DateTime;
        public int Count;
        public string CardNumber;
        public string RetractedTitle;
        public string Status;
    }
    public class ForgottenBanknote
    {
        public DateTime DateTime;
        public string No;
        public string CardNumber;
        public string Retract;
        public string Position;
    }
    public class Cassette
    {
        public string Name;
        public string Type;
        public string Denomi;
        public string Initial;
        public string Current;
        public string Status;
        public string Log;

        public Cassette()
        {

        }
    }
}
