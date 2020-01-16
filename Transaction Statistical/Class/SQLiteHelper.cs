using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Transaction_Statistical
{
    class SQLite
    {
    }
    public class EntryList
    {
        public EntryList()
        {
            ColumnName = new List<string>();
            DbType = new List<DbType>();
            Content = new List<string>();
            CompareCharacter = new List<string>();
        }
        public List<string> ColumnName { set; get; }
        public List<DbType> DbType { set; get; }
        public List<string> Content { set; get; }
        public List<string> CompareCharacter { set; get; }

    }
    public class EntryListCompare
    {

        public EntryListCompare()
        {
            EntryList EntryListData = new EntryList();
            EntryList EntryDataCompare = new EntryList();
        }
        public List<EntryList> EntryListData { set; get; }
        public List<EntryList> EntryDataCompare { set; get; }

    }
    public class ListWithName
    {
        public ListWithName()
        {
            SubItems = new List<string>();
        }
        public string Text { set; get; }
        public List<string> SubItems { set; get; }
    }
    public class ColumnProperties
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public string Content { get; set; }
        public bool AllowNull { get; set; }
    }
    public class Column : IEnumerable<ColumnProperties>
    {
        public Column()
        {
            cols = new List<ColumnProperties>();
        }
        private List<ColumnProperties> cols = new List<ColumnProperties>();
        public IEnumerator<ColumnProperties> GetEnumerator()
        {
            return this.cols.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(string Name)
        {
            ColumnProperties ml = new ColumnProperties();
            ml.Name = Name;
            ml.DataType = "VARCHAR";
            ml.AllowNull = true;
            cols.Add(ml);
        }
        public void Add(string Name, string DataType)
        {
            ColumnProperties ml = new ColumnProperties();
            ml.Name = Name;
            ml.DataType = DataType;
            ml.AllowNull = true;
            cols.Add(ml);
        }
        public void Add(string Name, string DataType, bool AllowNulls)
        {
            ColumnProperties ml = new ColumnProperties();
            ml.Name = Name;
            ml.DataType = DataType;
            ml.AllowNull = AllowNulls;
            cols.Add(ml);
        }
        public void Add(string Name, string DataType, bool AllowNulls, string ID)
        {
            ColumnProperties ml = new ColumnProperties();
            ml.Name = Name;
            ml.DataType = DataType;
            ml.ID = ID;
            ml.AllowNull = AllowNulls;
            cols.Add(ml);
        }
        public int Count
        {
            get { return cols.Count; }
        }

    }

    public class Table
    {
        public Table()
        {
            Columns = new Column();
        }
        public string Name { set; get; }
        public Column Columns { set; get; }

    }
    public class SQLiteHelper
    {
        SQLiteDataReader DataReader;
        public string DatabaseFile { set; get; }
        public string Password { set; get; }
        public SQLiteConnection DataBaseConnnection = new SQLiteConnection();

        public void SetConnection()
        {
            try
            {
                DatabaseFile = InitParametar.DatabaseFile;

                if (DataBaseConnnection.State == System.Data.ConnectionState.Open)
                {
                    return;
                }
                if (Password != null)
                {
                    DataBaseConnnection.ConnectionString = @"Data Source=" + DatabaseFile + "; Password=" + Password + ";";
                    DataBaseConnnection.Open();
                }
                if (Password == null)
                {
                    DataBaseConnnection.ConnectionString = @"Data Source=" + DatabaseFile + ";Version=3;UseUTF16Encoding=True;Synchronous=Normal;New=False";
                    DataBaseConnnection.Open();
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        public void DbDisconnect()
        {
            return;
            //while (true)
            //{
            //    if (DataBaseConnnection.State != System.Data.ConnectionState.Executing) break;
            //    Thread.Sleep(1);
            //}
            //DataBaseConnnection.Close();
        }
        public void CreateDatabase()
        {
            try
            {
                SetConnection();
                SQLiteConnection.CreateFile(DatabaseFile);
                if (Password != null)
                {
                    DataBaseConnnection.SetPassword(Password);
                }
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog("CreateDatabase", "CreateDatabase", ex.ToString());
            }
        }
        public bool CreateTable(Table Table)
        {
            try
            {
                SetConnection();
                string firstLine = "CREATE TABLE IF NOT EXISTS [" + Table.Name + "] ([ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ";
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append(firstLine);
                foreach (var item in Table.Columns)
                {
                    string nl = "";
                    if (item.AllowNull) nl = "NULL";
                    else nl = "NOT NULL";

                    queryBuilder.Append("[" + item.Name + "] " + item.DataType + " " + nl + ", ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2);
                queryBuilder.Append(")");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                DbDisconnect();
                // MessageBox.Show(queryBuilder.ToString());
            }
            catch (Exception ex)
            {
                DbDisconnect();
                SystemLog.WriteSQLLog("CreateDatabase", "CreateDatabase", ex.ToString());
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CreateTable", ex.ToString());
                // frmPassword fp = new frmPassword();
                //  if (fp.ShowDialog() == DialogResult.OK)
                //  {
                //      Password = fp.txtPass.Text;
                //     CreateTable(Table);
                //  }
            }
            return true;
        }
        public bool CreateTable(string TableName, string[] ColumnNames, bool[] AllowNulls, DbType[] DbTypes)
        {
            TableName = RemoveSpecialCharacters(TableName);
            try
            {
                SetConnection();
                string firstLine = "CREATE TABLE IF NOT EXISTS [" + TableName + "] ([ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ";
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append(firstLine);
                for (int i = 0; i < ColumnNames.Length; i++)
                {
                    string nl = "";
                    if (AllowNulls[i]) nl = "NULL";
                    else nl = "NOT NULL";

                    queryBuilder.Append("[" + ColumnNames[i] + "] " + DbTypes[i] + " " + nl + ", ");

                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2);
                queryBuilder.Append(")");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                DbDisconnect();
                // MessageBox.Show(queryBuilder.ToString());
            }
            catch (Exception ex)
            {
                DbDisconnect();
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                //  MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CreateTable", "Parameter1: " + TableName + "\n Parameter2: " + ColumnNames +"\n Parameter3: " + AllowNulls.ToString() + "\n Parameter4: " + DbTypes.ToString() +"\n" + ex.ToString());
                //  MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //  frmPassword fp = new frmPassword();
                //  if (fp.ShowDialog() == DialogResult.OK)
                //  {
                //      Password = fp.txtPass.Text;
                //      CreateTable(TableName, ColumnNames, AllowNulls, DbTypes);
                //  }
            }
            return true;

        }
        public bool DeleteTable(string TableName)
        {
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("DROP TABLE IF EXISTS " + TableName, DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                SQLiteCommand VacuumCommand = new SQLiteCommand("vacuum;", DataBaseConnnection);
                VacuumCommand.ExecuteNonQuery();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                return false;

            }
            return true;

        }
        public bool ClearTable(string TableName)
        {
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("delete from " + TableName, DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                SQLiteCommand VacuumCommand = new SQLiteCommand("vacuum;", DataBaseConnnection);
                VacuumCommand.ExecuteNonQuery();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                return false;
                // DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "DeleteTable","Parameter: " + TableName + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //   frmPassword fp = new frmPassword();
                // if (fp.ShowDialog() == DialogResult.OK)
                //  {
                //      Password = fp.txtPass.Text;
                //     DeleteTable(TableName);
                //  }
            }
            return true;

        }
        public bool CheckIdentTable(string TableName, int IdentReset)
        {
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("UPDATE SQLITE_SEQUENCE SET SEQ=" + IdentReset.ToString() + " WHERE NAME='" + TableName + "'", DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                SQLiteCommand VacuumCommand = new SQLiteCommand("vacuum;", DataBaseConnnection);
                VacuumCommand.ExecuteNonQuery();
                DbDisconnect();              
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                return false;
                // DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "DeleteTable","Parameter: " + TableName + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //   frmPassword fp = new frmPassword();
                // if (fp.ShowDialog() == DialogResult.OK)
                //  {
                //      Password = fp.txtPass.Text;
                //     DeleteTable(TableName);
                //  }
            }
            return true;

        }
        public bool CopyTableToTable(string TableSource, string TableDestination)
        {
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("INSERT INTO '" + TableDestination + "' SELECT * FROM '" + TableSource + "'", DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                SQLiteCommand VacuumCommand = new SQLiteCommand("vacuum;", DataBaseConnnection);
                VacuumCommand.ExecuteNonQuery();
                DbDisconnect();              
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                return false;
                //DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CopyTableToTable","Parameter1: " + TableSource + "\n Parameter2: " + TableDestination + "\n" + ex.ToString());
                // MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //   frmPassword fp = new frmPassword();
                // if (fp.ShowDialog() == DialogResult.OK)
                //  {
                //      Password = fp.txtPass.Text;
                //     DeleteTable(TableName);
                //  }
            }
            return true;

        }
        public bool CopyTableToNew(string TableSource, string TableNew, int Structure)
        {
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("CREATE TABLE '" + TableNew + "' AS SELECT * FROM '" + TableSource + "' WHERE " + Structure, DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                SQLiteCommand VacuumCommand = new SQLiteCommand("vacuum;", DataBaseConnnection);
                VacuumCommand.ExecuteNonQuery();
                DbDisconnect();               
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                return false;
               // DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CopyTableToNew", "Parameter1: " + TableSource + "\n Parameter2: " + TableNew + "\n Parameter3: " + Structure.ToString() + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //   frmPassword fp = new frmPassword();
                // if (fp.ShowDialog() == DialogResult.OK)
                //  {
                //      Password = fp.txtPass.Text;
                //     DeleteTable(TableName);
                //  }
            }
            return true;

        }
        public List<string> GetTableNames()
        {
            List<string> tables = new List<string>();
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT NAME FROM sqlite_master WHERE TYPE='table' ORDER BY NAME", DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    if (DataReader.HasRows)
                    {
                        tables.Add(DataReader[0].ToString());
                    }
                }
                DbDisconnect();

            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableNames", ex.ToString());
                // MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return tables;
        }
        public List<string> SearchTableName(string SearchKeyWord)
        {
            List<string> tables = new List<string>();
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT NAME FROM sqlite_master WHERE TYPE='table' and NAME like '" + SearchKeyWord + "' ORDER BY NAME", DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    if (DataReader.HasRows)
                    {
                        tables.Add(DataReader[0].ToString());
                    }
                }
                DbDisconnect();

            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "SearchTableName", "Parameter: " + SearchKeyWord + "\n" + ex.ToString());
                //  MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return tables;
        }
        public bool CheckExistTable(string TableName)
        {

            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("Select * from " + TableName, DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
                DbDisconnect();

            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                return false;
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CheckExistTable", "Parameter: " + TableName + "\n" + ex.ToString());

            }
            if (DataReader.HasRows) { DataReader.Close(); DbDisconnect(); return true; }
            else { DataReader.Close(); DbDisconnect(); return false; }
        }
        public Column GetColumnsFromTableName(string TableName)
        {
            TableName = RemoveSpecialCharacters(TableName);
            Column cols = new Column();
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("PRAGMA table_info('" + TableName + "');", DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    ColumnProperties ml = new ColumnProperties();
                    ml.ID = DataReader[0].ToString();
                    ml.Name = DataReader[1].ToString();
                    ml.DataType = DataReader[2].ToString();
                    bool nl = false;
                    if (DataReader[3].ToString() == "0") nl = true;
                    if (DataReader[3].ToString() == "1") nl = false;
                    ml.AllowNull = nl;
                    cols.Add(DataReader[1].ToString(), DataReader[2].ToString(), nl, DataReader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                //  MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetColumnFromTableName", "Parameter: " + TableName + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            DbDisconnect();
            return cols;

        }
        public bool CreateEntry(string TableName, EntryList EntryList)
        {
            TableName = RemoveSpecialCharacters(TableName);
            try
            {

                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("insert into " + TableName + " (");
                foreach (var item in EntryList.ColumnName)
                {
                    queryBuilder.Append(item + ", ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2);
                queryBuilder.Append(")");
                queryBuilder.Append(" values (");
                foreach (var item in EntryList.Content)
                {
                    queryBuilder.Append("'" + item + "', ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2);
                queryBuilder.Append(")");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);

                // for (int i = 0; i < EntryList.ColumnName.Count; i++)
                //  {
                //      sqliteCommand.Parameters.Add("@" + EntryList.ColumnName[i], EntryList.DbType[i]).Value = EntryList.Content[i];
                //  }
                SetConnection();
                sqliteCommand.ExecuteNonQuery();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CreateEntry", "Parameter1: " + TableName + "\n Parameter2: " + EntryList.ToString() + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }
        public bool UpdateListEntry(string TableName, List<EntryList> ColumnDataList, string ColumnName, string Equals)
        {
            TableName = RemoveSpecialCharacters(TableName);
            try
            {
                EntryList entryList;
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                for (int i = 0; i < ColumnDataList.Count; i++)
                {
                    entryList = new EntryList();
                    entryList = ColumnDataList[i];

                    queryBuilder.Append("update '" + TableName + "' set ");
                    for (int k = 0; k < entryList.ColumnName.Count; k++)
                    {
                        queryBuilder.Append(entryList.ColumnName[i] + "='" + entryList.Content[i] + "', ");
                    }
                    queryBuilder.Remove(queryBuilder.Length - 2, 2);
                    queryBuilder.Append(" ");
                    queryBuilder.Append(" WHERE " + ColumnName + "='" + Equals + "';");
                }
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CreateEntry", "Parameter1: " + TableName + "\n Parameter2: " + EntryList.ToString() + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }
        public bool CreateEntry(string TableName, object[] Content)
        {
            TableName = RemoveSpecialCharacters(TableName);
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("insert into " + TableName + " (");
                foreach (var item in GetColumnsFromTableName(TableName))
                {
                    queryBuilder.Append(item.Name + ", ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2);
                queryBuilder.Append(")");
                queryBuilder.Append(" values (");
                foreach (var item in GetColumnsFromTableName(TableName))
                {
                    queryBuilder.Append("@" + item.Name + ", ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2);
                queryBuilder.Append(")");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                List<string> colsNames = new List<string>();
                foreach (var item in GetColumnsFromTableName(TableName))
                {
                    colsNames.Add(item.Name);
                }

                for (int i = 0; i < GetColumnsFromTableName(TableName).Count; i++)
                {
                    sqliteCommand.Parameters.Add("@" + colsNames[i], DbType.Object).Value = Content[i];
                }
                sqliteCommand.ExecuteNonQuery();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CreateEntry", "Parameter1: " + TableName + "\n Parameter2: " + Content.ToString() + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }
        public bool DeleteEntry(string TableName, string ColumnName, string Equals)
        {
            TableName = RemoveSpecialCharacters(TableName);
            ColumnName = RemoveSpecialCharacters(ColumnName);
            Equals = RemoveSpecialCharacters(Equals);
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("DELETE FROM " + TableName + " WHERE " + ColumnName + "='" + Equals + "';", DataBaseConnnection);
                //  sqliteCommand.Parameters.Add("@" + ColumnName, DbType.Object).Value = Equals;
                sqliteCommand.ExecuteNonQuery();
                SQLiteCommand VacuumCommand = new SQLiteCommand("vacuum;", DataBaseConnnection);
                VacuumCommand.ExecuteNonQuery();
                DbDisconnect();
                return true;
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "DeleteEntry", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName + "\n Parameter3: " + Equals + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return false;
        }
        public bool UpdateEntry(string TableName, EntryList EntryList, string ColumnName, string Equals)
        {
            TableName = RemoveSpecialCharacters(TableName);
            ColumnName = RemoveSpecialCharacters(ColumnName);
            Equals = RemoveSpecialCharacters(Equals);

            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("update " + TableName + " set ");
                for (int i = 0; i < EntryList.ColumnName.Count; i++)
                {
                    queryBuilder.Append(EntryList.ColumnName[i] + "='" + EntryList.Content[i] + "', ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2);
                queryBuilder.Append(" ");
                queryBuilder.Append(" WHERE " + ColumnName + "='" + Equals + "'");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);


                sqliteCommand.ExecuteNonQuery();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                //  MsgInfo.MessageBoxError("Class SQLite", "SQLite", "UpdateEntry", "Parameter1: " + TableName + "\n Parameter2: " + EntryList.ToString() + "\n Parameter3: " + ColumnName + "\n Parameter4: " + Equals + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;

        }
        public DataTable GetTableIf(string TableName, EntryList EntryListCompare, string ColumnGet)
        {
            TableName = RemoveSpecialCharacters(TableName);
            DataTable DataTables = new DataTable();
            SQLiteDataReader dataReader;
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("select  " + ColumnGet + " from '" + TableName + "' where ");
                for (int i = 0; i < EntryListCompare.ColumnName.Count; i++)
                {
                    queryBuilder.Append(EntryListCompare.ColumnName[i] + EntryListCompare.CompareCharacter + "'" + EntryListCompare.Content[i] + "', ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2);
                queryBuilder.Append(" ");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                dataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(dataReader);
                sqliteCommand.Connection.Close();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
            }
            return DataTables;
        }
        public bool UpdateColumnEntrys(string TableName, string Entryname, string Entrydata)
        {
            TableName = RemoveSpecialCharacters(TableName);
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("update '" + TableName + "' set ");
                queryBuilder.Append(Entryname + "='" + Entrydata + "'");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                //  MsgInfo.MessageBoxError("Class SQLite", "SQLite", "UpdateEntry", "Parameter1: " + TableName + "\n Parameter2: " + EntryList.ToString() + "\n Parameter3: " + ColumnName + "\n Parameter4: " + Equals + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;

        }
        public bool Update1Entry(string TableName, string Entryname, string Entrydata, string ColumnName, string Equals)
        {
            TableName = RemoveSpecialCharacters(TableName);
            Entryname = RemoveSpecialCharacters(Entryname);
            ColumnName = RemoveSpecialCharacters(ColumnName);
            Equals = RemoveSpecialCharacters(Equals);

            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("update " + TableName + " set ");
                queryBuilder.Append(Entryname + "='" + Entrydata + "'");
                queryBuilder.Append(" WHERE " + ColumnName + "='" + Equals + "'");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                //MsgInfo.MessageBoxError("Class SQLite", "SQLite", "Update1Entry", "Parameter1: " + TableName + "\n Parameter2: " + Entryname + "\n Parameter3: " + Entrydata + "\n Parameter4: " + ColumnName + "\n Parameter5: " + Equals + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;

        }

        public List<ListWithName> GetEntries(string TableName)
        {
            TableName = RemoveSpecialCharacters(TableName);
            List<ListWithName> listLvi = new List<ListWithName>();
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("select * from " + TableName, DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    ListWithName lwn = new ListWithName();
                    lwn.Text = DataReader[0].ToString();
                    for (int i = 1; i < DataReader.FieldCount; i++)
                    {
                        lwn.SubItems.Add(DataReader[i].ToString());
                    }
                    listLvi.Add(lwn);
                }

            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetEntries", "Parameter1: " + TableName + "\n" + ex.ToString());
                //  MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            DbDisconnect();
            return listLvi;
        }
        public List<ListWithName> SearchDatabase(string ColumnName, string SearchKeyWord)
        {
            ColumnName = RemoveSpecialCharacters(ColumnName);
            SearchKeyWord = RemoveSpecialCharacters(SearchKeyWord);
            List<ListWithName> listLwn = new List<ListWithName>();
            try
            {
                foreach (var table in GetTableNames())
                {
                    if (table != "sqlite_sequence")
                    {
                        SetConnection();
                        SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT * FROM " + table + " WHERE " + ColumnName + " LIKE @searchKey", DataBaseConnnection);
                        sqliteCommand.Parameters.Add("@searchKey", DbType.String).Value = "%" + SearchKeyWord + "%";
                        DataReader = sqliteCommand.ExecuteReader();
                        if (DataReader.HasRows)
                        {
                            while (DataReader.Read())
                            {
                                ListWithName lwn = new ListWithName();
                                lwn.Text = DataReader[0].ToString();
                                for (int i = 1; i < DataReader.FieldCount; i++)
                                {
                                    lwn.SubItems.Add(DataReader[i].ToString());
                                }
                                listLwn.Add(lwn);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                //  MsgInfo.MessageBoxError("Class SQLite", "SQLite", "SearchDatabase", "Parameter1: " + ColumnName + "\n Parameter2: " + SearchKeyWord + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            DbDisconnect();
            return listLwn;
        }
        public List<ListWithName> SearchDatabase(string SearchKeyWord)
        {
            SearchKeyWord = RemoveSpecialCharacters(SearchKeyWord);
            List<ListWithName> listLwn = new List<ListWithName>();
            try
            {
                foreach (var table in GetTableNames())
                {
                    foreach (var col in GetColumnsFromTableName(table))
                    {
                        if (table != "sqlite_sequence")
                        {
                            SetConnection();
                            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT * FROM " + table + " WHERE " + col.Name + " LIKE @searchKey", DataBaseConnnection);
                            sqliteCommand.Parameters.Add("@searchKey", DbType.String).Value = "%" + SearchKeyWord + "%"; ;
                            DataReader = sqliteCommand.ExecuteReader();
                            if (DataReader.HasRows)
                            {
                                while (DataReader.Read())
                                {
                                    ListWithName lwn = new ListWithName();
                                    lwn.Text = DataReader[0].ToString();
                                    for (int i = 1; i < DataReader.FieldCount; i++)
                                    {
                                        lwn.SubItems.Add(DataReader[i].ToString());
                                    }
                                    listLwn.Add(lwn);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "SearchDatabase", "Parameter: " + SearchKeyWord + "\n" + ex.ToString());
                // MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return listLwn;
        }
        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public DataTable GetTableData(string TableName)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);
            SQLiteDataReader dataReader;
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                dataReader = sqliteCommand.ExecuteReader();

                DataTables.Load(dataReader);
                sqliteCommand.Connection.Close();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                // DataTables.GetErrors();
                // string a= DataTables.GetErrors()[0].RowError;
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableData", "Parameter: " + TableName + "\n" + ex.ToString());
                return DataTables;
            }
            return DataTables;
        }
        public DataSet GetTableDataSet(string TableName)
        {

            // TableName = RemoveSpecialCharacters(TableName);
            DataSet DS = new DataSet();
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                SQLiteDataAdapter DA = new SQLiteDataAdapter(sqliteCommand);
                DA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                DA.Fill(DS, TableName);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                //  MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataset", "Parameter: " + TableName + "\n" + ex.ToString());
                // MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
            return DS;
        }
        public DataSet SearchTableDataSet(string TableName, string ColumnName, string SearchKeyWord)
        {

            // TableName = RemoveSpecialCharacters(TableName);
            DataSet DS = new DataSet();
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("SELECT * FROM '" + TableName + "'" + " WHERE " + ColumnName + " LIKE '" + SearchKeyWord + "'");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                SQLiteDataAdapter DA = new SQLiteDataAdapter(sqliteCommand);
                DA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                DA.Fill(DS, TableName);
                DbDisconnect();
            }
            catch (Exception ex)
            {

                DbDisconnect();
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "SearchTableDataSet", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName + "\n Parameter3: " + SearchKeyWord + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
            return DS;
        }
        public bool UpdateTableDataSet(DataSet ds, string TableName)
        {

            // TableName = RemoveSpecialCharacters(TableName);
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'");
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                sqliteCommand.CommandType = CommandType.Text;
                SQLiteDataAdapter DA = new SQLiteDataAdapter(sqliteCommand);
                SQLiteCommandBuilder sqliteCommandb = new SQLiteCommandBuilder(DA);
                DA.Update(ds, TableName);
                DbDisconnect();
                return true;
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                // DbDisconnect();
                //  MsgInfo.MessageBoxError("Class SQLite", "SQLite", "UpdateTableDataSet", "Parameter1: " + ds.ToString() + "\n Parameter2: " + TableName + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }
        public DataTable GetTableDataWithColumnName(string TableName, string ColumnName, string Equals)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);

            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnName + " = '" + Equals + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(DataReader);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                //MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWithColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName + "\n Parameter3: " + Equals + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return DataTables;
        }
        public DataRow GetRowDataWithColumnName(string TableName, string ColumnName, string Equals)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);

            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnName + " = '" + Equals + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(DataReader);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                //MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWithColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName + "\n Parameter3: " + Equals + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return DataTables.Rows[0];
        }
        public string GetColumnDataWithColumnName(string TableName, string ColumnName, string Equals, string ColumnData)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataReader dataReader;
            TableName = RemoveSpecialCharacters(TableName);

            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnName + " = '" + Equals + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                dataReader = sqliteCommand.ExecuteReader();
                dataTable.Load(dataReader);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                return null;
                //MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWithColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName + "\n Parameter3: " + Equals + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            return dataTable.Rows[0][ColumnData].ToString();
        }
        public DataTable GetTableDataWith2ColumnName(string TableName, string ColumnName1, string Equals1, string ColumnName2, string Equals2)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);
            SQLiteDataReader dataReader;
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnName1 + " = '" + Equals1 + "' and " + ColumnName2 + " = '" + Equals2 + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                dataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(dataReader);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWith2ColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" +ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return DataTables;
        }

        public DataTable GetTableDataWith2ColumnNameComparison(string TableName, string ColumnName1, string Equals1, string ColumnComparison, string EqualsComparison, string Comparison)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);
            SQLiteDataReader dataReader;
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnName1 + " = '" + Equals1 + "' and " + ColumnComparison + Comparison + EqualsComparison);

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                dataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(dataReader);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWith2ColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" +ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return DataTables;
        }
        public DataTable GetTableDataWith3ColumnNameComparison(string TableName, string ColumnName1, string Equals1, string ColumnName2, string Equals2, string ColumnComparison, string EqualsComparison, string Comparison)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);
            SQLiteDataReader dataReader;
            try
            {

                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnName1 + " = '" + Equals1 + "' and " + ColumnName2 + " = '" + Equals2 + "' and " + ColumnComparison + Comparison + EqualsComparison);

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                SetConnection();
                dataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(dataReader);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWith2ColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" +ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return DataTables;
        }
        public DataTable GetTableDataWithColumnNameComparison(string TableName, string ColumnComparison, string EqualsComparison, string Comparison)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);

            try
            {

                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnComparison + Comparison + EqualsComparison);

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                SetConnection();
                DataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(DataReader);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWith2ColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" +ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return DataTables;
        }
        public DataRow GetRowDataWith2ColumnName(string TableName, string ColumnName1, string Equals1, string ColumnName2, string Equals2)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);

            try
            {

                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnName1 + " = '" + Equals1 + "' and " + ColumnName2 + " = '" + Equals2 + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                SetConnection();
                DataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(DataReader);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWith2ColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" +ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return DataTables.Rows[0];
        }
        public DataRow GetRowDataWith3ColumnName(string TableName, string ColumnName1, string Equals1, string ColumnName2, string Equals2, string ColumnName3, string Equals3)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);

            try
            {

                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnName1 + " = '" + Equals1 + "' and " + ColumnName2 + " = '" + Equals2 + "' and " + ColumnName3 + " = '" + Equals3 + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                SetConnection();
                DataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(DataReader);
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWith2ColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" +ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return DataTables.Rows[0];
        }
        public string GetColumnDataWith2ColumnName(string TableName, string ColumnName1, string Equals1, string ColumnName2, string Equals2, string ColumnData)
        {
            DataTable DataTables = new DataTable();
            TableName = RemoveSpecialCharacters(TableName);

            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where " + ColumnName1 + " = '" + Equals1 + "' and " + ColumnName2 + " = '" + Equals2 + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                SetConnection();
                DataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(DataReader);
                DbDisconnect();
                if (DataTables.Rows.Count != 0)
                    return DataTables.Rows[0][ColumnData].ToString();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
               
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "GetTableDataWith2ColumnName", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" +ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return null;
        }
        public bool CheckExistValue(string TableName, string ColumnName, string Equals)
        {
            SetConnection();
            try
            {
                SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT * FROM '" + TableName + "'" + " WHERE " + ColumnName + "='" + Equals + "'", DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                //  MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CheckExistValue", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName + "\n Parameter3: " + Equals + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (DataReader.HasRows) { DataReader.Close(); DbDisconnect(); return true; }
            else { DataReader.Close(); DbDisconnect(); return false; }

        }
        public bool CheckExist2Value(string TableName, string ColumnName1, string Equals1, string ColumnName2, string Equals2)
        {

            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("Select * from '" + TableName + "'" + " where " + ColumnName1 + " = '" + Equals1 + "' and " + ColumnName2 + " = '" + Equals2 + "'", DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CheckExist2Value", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (DataReader.HasRows) { DataReader.Close(); DbDisconnect(); return true; }
            else { DataReader.Close(); DbDisconnect(); return false; }
        }
        public bool CheckExist3Value(string TableName, string ColumnName1, string Equals1, string ColumnName2, string Equals2, string ColumnName3, string Equals3)
        {

            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand("Select * from '" + TableName + "'" + " where " + ColumnName1 + " = '" + Equals1 + "' and " + ColumnName2 + " = '" + Equals2 + "' and " + ColumnName3 + " = '" + Equals3 + "'", DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CheckExist2Value", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (DataReader.HasRows) { DataReader.Close(); DbDisconnect(); return true; }
            else { DataReader.Close(); DbDisconnect(); return false; }
        }
        public bool CheckExistEntry(string TableName, EntryList entr)
        {

            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("Select * from '" + TableName + "'" + " where ");

                for (int i = 0; i < entr.ColumnName.Count; i++)
                {
                    queryBuilder.Append(entr.ColumnName[i] + "='" + entr.Content[i] + "' and ");
                }
                queryBuilder.Remove(queryBuilder.Length - 5, 5);
                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "CheckExist2Value", "Parameter1: " + TableName + "\n Parameter2: " + ColumnName1 + "\n Parameter3: " + Equals1 + "\n Parameter4: " + ColumnName2 + "\n Parameter5: " + Equals2 + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (DataReader.HasRows) { DataReader.Close(); DbDisconnect(); return true; }
            else { DataReader.Close(); DbDisconnect(); return false; }
        }
        public string NoneQuery(string query)
        {


            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand(query, DataBaseConnnection);
                sqliteCommand.ExecuteNonQuery();
                DbDisconnect(); return null;
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "NoneQuery","Parameter: " + query + "\n" + ex.ToString());
                // DbDisconnect();
                return ex.Message.ToString();
            }
        }
        public object QueryReturn(string query)
        {

            object ob;
            try
            {
                SetConnection();
                SQLiteCommand sqliteCommand = new SQLiteCommand(query, DataBaseConnnection);
                ob = (object)sqliteCommand.ExecuteNonQuery();
                DbDisconnect();
              //  return null;
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "NoneQuery","Parameter: " + query + "\n" + ex.ToString());
                // DbDisconnect();
                return ex.Message.ToString();
            }
            return ob;
        }
        public string FindMaxColumn(string TableName, string ColumnMax)
        {


            DataTable DataTables = new DataTable();
            string max = string.Empty;
            // TableName = RemoveSpecialCharacters(TableName);
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("SELECT MAX(" + ColumnMax + ") FROM '" + TableName + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(DataReader);
                max = DataTables.Rows[0]["MAX(" + ColumnMax + ")"].ToString();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "FindMaxColunm", "Parameter1: " + TableName + "\n Parameter2: " + ColumnMax + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return max;
            }
            return max;
        }
        public string FindMaxColumnEqual(string TableName, string ColumnMax, string ColumnName, string Equals)
        {


            DataTable DataTables = new DataTable();
            string max = string.Empty;
            // TableName = RemoveSpecialCharacters(TableName);
            try
            {
                SetConnection();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("SELECT MAX(" + ColumnMax + ") FROM '" + TableName + "'" + " where " + ColumnName + "='" + Equals + "'");

                SQLiteCommand sqliteCommand = new SQLiteCommand(queryBuilder.ToString(), DataBaseConnnection);
                DataReader = sqliteCommand.ExecuteReader();
                DataTables.Load(DataReader);
                max = DataTables.Rows[0]["MAX(" + ColumnMax + ")"].ToString();
                DbDisconnect();
            }
            catch (Exception ex)
            {
                SystemLog.WriteSQLLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
                DbDisconnect();
                // MsgInfo.MessageBoxError("Class SQLite", "SQLite", "FinMaxColumnEqual", "Parameter1: " + TableName + "\n Parameter2: " + ColumnMax + "\n Parameter3: " + ColumnName + "\n Parameter4: " + Equals + "\n" + ex.ToString());
                //MessageBox.Show("Error: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return max;
            }
            return max;
        }

        internal bool CheckExistValue(string p1, EntryList entr, string p2, string p3)
        {
            throw new NotImplementedException();
        }
    }

    public static class SystemLog
    {
        public static void WriteSQLLog(string Class, string Method, string Msg)
        {
            try
            {
                string Pathlog = InitParametar.FolderSystemTrace + @"\" + string.Format("{0:yyyyMMdd}", DateTime.Now);
                string FileLog = Pathlog + @".log";
                if (!Directory.Exists(Pathlog))
                {
                    Directory.CreateDirectory(Pathlog);
                }
                StreamWriter sw = new StreamWriter(FileLog, true);
                sw.WriteLine("Class: " + Class);
                sw.WriteLine("Method: " + Method);
                sw.WriteLine("Message: " + Msg);
                sw.WriteLine("------------------------------------------------------------------------------------------------\n");
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {
                WriteSQLLog(Class, Method, Msg);
            }
        }
        public static void WriteTerminalLog(string TID, string Class, string Method, string Msg)
        {
            try
            {
                string Pathlog = InitParametar.FolderSystemTrace + @"\" + string.Format("{0:yyyyMMdd}", DateTime.Now);
                string FileLog = Pathlog + @"\" + TID + ".log";
                if (!Directory.Exists(Pathlog))
                {
                    Directory.CreateDirectory(Pathlog);
                }
                StreamWriter sw = new StreamWriter(FileLog, true);

                sw.WriteLine("Class: " + Class);
                sw.WriteLine("Method: " + Method);
                sw.WriteLine("Message: " + Msg);
                sw.Flush();
                sw.WriteLine("------------------------------------------------------------------------------------------------\n");
                sw.Close();
            }
            catch (Exception)
            {
                Thread.Sleep(100);
                WriteTerminalLog(TID, Class, Method, Msg);
            }
        }
    }
}
