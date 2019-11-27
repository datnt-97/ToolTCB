using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

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
        public static string pathDirectoryDocumentsUsrConfigData;// = "config";
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
                pathDirectoryDocumentsUsrConfigData = (PathDirectoryDocumentsUsr + "\\Config").Replace(@"\\", @"\"); if (!Directory.Exists(pathDirectoryDocumentsUsrConfigData)) Directory.CreateDirectory(pathDirectoryDocumentsUsrConfigData);
                configFileTraceDefault = PathDirectoryCurrentApp + @"\config\ConfigTraceFile.ini";
                configFileTrace = (pathDirectoryDocumentsUsrConfigData + "\\ConfigTraceFile.ini").Replace(@"\\", @"\"); if (!File.Exists(configFileTrace)) File.Copy(configFileTraceDefault, configFileTrace);
                PathFileRecordDeletetStartup = (PathDirectoryDocumentsUsr + "\\ListFileDeletetStartup.txt").Replace(@"\\", @"\"); if (!File.Exists(PathFileRecordDeletetStartup)) File.Create(PathFileRecordDeletetStartup);
              
                DatabaseFile = InitParametar.pathDirectoryDocumentsUsrConfigData + "\\DB.s3db";
                if (!File.Exists(DatabaseFile)) File.Copy(PathDirectoryCurrentAppConfigData + "\\DB.s3db", DatabaseFile, true);
                sqlite = new SQLiteHelper();
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
                
                //switch (r["Field"].ToString())
                //{
                //    case "DateFormat":
                //        string[] listtime = r["Data"].ToString().Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);                      
                //        foreach (string s in listtime)
                //        {
                //            string[] item = s.Split('|');
                //            listDateFormat[item[0]] = item[1];
                //        }
                //        break;
                //    case "FileNameFormat":
                //        transactionTemplate.FileNameFormat = r["Data"].ToString();
                //        break;
                //    case "TransactionStart":
                //        transactionTemplate.TransactionStart = r["Data"].ToString();
                //        break;
                //    case "AmountEnter":
                //        transactionTemplate.AmountEnter = r["Data"].ToString();
                //        break;          
                //    case "CardTaken":
                //        transactionTemplate.CardInserted = r["Data"].ToString();
                //        break;
                //    case "TransactionEnd":
                //        transactionTemplate.TransactionEnd = r["Data"].ToString();
                //        break;
                //    case "Track1":
                //        transactionTemplate.Track1 = r["Data"].ToString();
                //        break;
                //    case "Track2":
                //        transactionTemplate.Track2 = r["Data"].ToString();
                //        break;
                //    case "Track3":
                //        transactionTemplate.Track3 = r["Data"].ToString();
                //        break;
                //    case "OperationCode":
                //        transactionTemplate.OperationCode = r["Data"].ToString();
                //        break;                   
                //    case "NewFormatCounter":
                //        transactionTemplate.NewCounter = r["Data"].ToString();
                //        break;
                //    case "OldFormatCounter":
                //        transactionTemplate.OldCounter = r["Data"].ToString();
                //        break;
                //    case "SplitTransaction":
                //        transactionTemplate.SplitTransaction = r["Data"].ToString();
                //        break;
                //    case "PinEnter":
                //        transactionTemplate.PinEnter = r["Data"].ToString();
                //        break;
                //    default:
                //        break;
                //}
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
        //
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
        public List<TransactionEvent> CasebyCase;
        public int Result;
        string _datainput=string.Empty;
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
        public string TraceJournalTxt;
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
    
        public Events Name;
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
        public class RegesValue
    {
        public int index;
        public Dictionary<string, string> value = new Dictionary<string, string>();
        public string stringfind;
        public RegesValue()
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
                if (m.Count != 0)
                {
                    foreach (Match n in m)
                    {
                        RegesValue results = new RegesValue();
                        results.stringfind = n.ToString(); sString = sString.Replace(n.ToString(), string.Empty);
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
        public Dictionary<string, Cassette> ListCassette = new Dictionary<string, Cassette>();
        public string LogTxt;
        public string PathLog;
        public int IndexLog;
    }
    public class Cassette
    {
        public string Name;
        public string Description;
        public string Denomination;
        public decimal Value;
        public int Counter;
        public DateTime DateChange;
        public Cassette()
        {

        }
    }
}
