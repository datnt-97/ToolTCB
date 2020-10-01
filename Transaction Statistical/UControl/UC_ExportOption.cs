using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADOX;


using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data.SQLite;
using OfficeOpenXml;
using System.Data.Entity;
using System.Reflection;
using System.IO;

namespace Transaction_Statistical.UControl
{
  
    public partial class UC_ExportOption : UserControl
    {  SQLiteHelper sqlite;
        public static string SelectedTable = string.Empty;
        public UC_ExportOption()
        {
            InitializeComponent();
            sqlite = new SQLiteHelper();
        }

        private void tb_loadFile_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.FileName = tb_loadFile.Text;
            fdlg.Filter = "Excel Sheet(*.xls;*.xlsx)|*.xls;*.xlsx|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                tb_loadFile.Text = fdlg.FileName;
                Import();
                //  Application.DoEvents();
            }
        }
        private void Import()
        {
            if (tb_loadFile.Text.Trim() != string.Empty)
            {
                try
                {
                    cb_Sheets.Items.Clear();
                    string[] strTables = GetTableExcel(tb_loadFile.Text);
                    cb_Sheets.Items.AddRange(strTables);
                    UControl.UC_ExportOptionSelect objSelectTable = new UControl.UC_ExportOptionSelect(strTables);
                    Frm_TemplateDefault frm = new Frm_TemplateDefault(objSelectTable, "Select Sheet");
                    frm.ShowDialog();
                    frm.Dispose();
                    if ((SelectedTable != string.Empty) && (SelectedTable != null))
                        cb_Sheets.Text = SelectedTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        public System.Data.DataTable GetDataTableExcel(string strFileName, string Table)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection(GetFormatExcel(strFileName));
            conn.Open();
            string strQuery = "SELECT * FROM [" + Table + "]";
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
            System.Data.DataSet ds = new System.Data.DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public string[] GetTableExcel(string strFileName)
        {
            List<string> strTables = new List<string>();
            Catalog oCatlog = new Catalog();
            ADOX.Table oTable = new ADOX.Table();
            ADODB.Connection oConn = new ADODB.Connection();

            oConn.Open(GetFormatExcel(strFileName), "", "", 0);
            oCatlog.ActiveConnection = oConn;

            foreach (ADOX.Table tab in oCatlog.Tables)
            {
                if (tab.Type == "TABLE")
                {
                    strTables.Add(tab.Name.Trim('$'));
                }
            }

            return strTables.ToArray(); ;
        }
         string GetFormatExcel(string file)
        {
            bool hasHeaders = true;
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (file.Substring(file.LastIndexOf('.')).ToLower() == ".xlsx")
            {
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=1\"";
                Nud_Colunms.Maximum = 16384;
                Nud_Rows.Maximum = 1048576;
            }
            else
            {
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=1\"";
                Nud_Colunms.Maximum = 256;
                Nud_Rows.Maximum = 65536;
            }
            return strConn;
        }

        private void cb_Sheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // ShowExcel(tb_loadFile.Text, cb_Sheets.Text);

                dataTable = GetDataTableExcel(tb_loadFile.Text, cb_Sheets.Text + "$");
                gridView.DataSource = null;
                Nud_Colunms.Value=gridView.ColumnCount = dataTable.Columns.Count;
                Nud_Rows.Value = gridView.RowCount = (int)Nud_Rows.Value;
                isSheet = true;               
                ShowData();
            }
            catch { }
        }
        string ColumnIndexToColumnLetter(int colIndex)
        {
            int div = colIndex;
            string colLetter = String.Empty;
            int mod = 0;

            while (div > 0)
            {
                mod = (div - 1) % 26;
                colLetter = (char)(65 + mod) + colLetter;
                div = (int)((div - mod) / 26);
            }
            return colLetter;
        }
        private void ShowExcel(string fname, string sheetName)
        {
            try
            {
                
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[sheetName.Trim('$')];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                // dt.Column = colCount;  
                Nud_Colunms.Value = colCount;
                Nud_Rows.Value = rowCount;


                for (int i = 1; i <= rowCount; i++)
                {


                    for (int j = 1; j <= colCount; j++)
                    {
                        //write the value to the Grid  


                        try
                        {
                            if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                            {
                                gridView.Rows[i - 1].Cells[j].Value = xlRange.Cells[i, j].Value2.ToString();

                            }
                        }
                        catch (Exception ex)
                        { }
                        // Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");  

                        //add useful things here!     
                    }
                }

                //cleanup  
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:  
                //  never use two dots, all COM objects must be referenced and released individually  
                //  ex: [somthing].[something].[something] is bad  

                //release com objects to fully kill excel process from running in the background  
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release  
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release  
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            catch (Exception ex)
            { }
        }

        private void Nud_Colunms_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridView.ColumnCount = (int)Nud_Colunms.Value;
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Alignment = DataGridViewContentAlignment.MiddleRight;
                style.BackColor = this.BackColor;
                style.ForeColor = this.ForeColor;
                DataGridViewCellStyle styleCell = new DataGridViewCellStyle();
                styleCell.BackColor = Color.DarkGray;
                styleCell.ForeColor = Color.WhiteSmoke;

                for (int i = 1; i <= Nud_Colunms.Value; i++)
                {
                    gridView.Columns[i - 1].Name = ColumnIndexToColumnLetter(i);

                    gridView.Columns[i - 1].HeaderCell.Style = style;

                }
                gridView.DefaultCellStyle = styleCell;
            }
            catch(Exception ex)
            { }
        }

        private void Nud_Rows_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridView.RowCount = (int)Nud_Rows.Value;
                gridView.RowHeadersWidth = 10;
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Alignment = DataGridViewContentAlignment.MiddleRight;
                style.BackColor = this.BackColor;
                style.ForeColor = this.ForeColor;
                for (int i = 1; i <= Nud_Rows.Value; i++)
                {

                    gridView.Rows[i - 1].HeaderCell.Value = i.ToString();
                    gridView.Rows[i - 1].HeaderCell.Style = style;
                    gridView.Rows[i - 1].Resizable = DataGridViewTriState.False;
                }
            }
            catch { }
        }

		private void cb_Wrap_CheckedChanged(object sender, EventArgs e)
		{
            fc_Query.WordWrap = cb_Wrap.Checked;
		}
		System.Data.DataTable dataTable;
        BindingSource bindingSource;
     //   SQLiteDataAdapter DA;
     //   DataSet ds;
        private void bt_Execute_Click(object sender, EventArgs e)
		{
            try
            {
                Cursor = Cursors.WaitCursor;
                string query = fc_Query.Text;
                if (fc_Query.SelectedText.Length > 5) query = fc_Query.SelectedText;
                query = query.Replace("500K", "K500").Replace("200K", "K200").Replace("100K", "K100").Replace("50K", "50").Replace("20K", "K20").Replace("10K", "K10");
                query = query.Replace("500K_Retract", "K500_Retract").Replace("200K_Retract", "K200_Retract").Replace("100K_Retract", "K100_Retract").Replace("50K_Retract", "50K_Retract").Replace("20K_Retract", "K20_Retract").Replace("10K_Retract", "K10_Retract");


                if (sqlite.GetTableDataSetFromQuery(query) != null)
                {
                    dataTable = sqlite.GetTableDataSetFromQuery(query).Tables[0];
                    isSheet = false;
                    rowShowIndex = 0;
                    lb_infoTable.Text = string.Format("Showing {0} to {1} of {2} entries", 0, 0, 0);
                    ShowData();
                }
                else
                    fc_Query.Text += Environment.NewLine + "-------- Not return---------";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Cursor = Cursors.Default;
        }
        int rowShowIndex = 0;
        bool isSheet = false;
        private void ShowData()
        {
            if (dataTable != null)
            {   gridView.DataSource = null;
                int rows = 0;int.TryParse(cb_ShowEntries.Text, out rows);if (rows == 0) rows = 100;

                if (isSheet)
                {
                    System.Data.DataTable tb = dataTable.Rows.Cast<DataRow>().Skip(rowShowIndex).Take(rows).CopyToDataTable();
                    for (int i = 1; i <= tb.Rows.Count; i++)
                    {
                        for (int j = 1; j <= tb.Columns.Count; j++)
                        {
                            try
                            {
                                gridView.Rows[i - 1].Cells[j].Value = tb.Rows[i][j];
                            }
                            catch (Exception ex)
                            { }
                        }
                    }
                }
                else
                {
                    gridView.Columns.Clear();
                    gridView.Rows.Clear();
                    gridView.ColumnCount = dataTable.Columns.Count;
                    gridView.RowCount = 2;
                    addSelectExport(dataTable.Columns.Count);                  
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        gridView.Columns[i].Name = dataTable.Columns[i].ColumnName;
                        gridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    foreach(DataRow row in (dataTable.Rows.Cast<DataRow>().Skip(rowShowIndex).Take(rows).CopyToDataTable().Rows))
                        gridView.Rows.Add(row.ItemArray);
                    Nud_Rows.Value = Nud_Rows.Value + 1;
                    // gridView.DataSource = dataTable.Rows.Cast<DataRow>().Skip(rowShowIndex).Take(rows).CopyToDataTable().Rows;
                }

                lb_infoTable.Text = string.Format("Showing {0} to {1} of {2} entries", rowShowIndex, rowShowIndex + rows, dataTable.Rows.Count);
                if (rowShowIndex > 0)
                    bt_PagePre.Visible = true;
                else
                    bt_PagePre.Visible = false;
                
                if ((rowShowIndex+rows) < dataTable.Rows.Count)
                    bt_PageNext.Visible = true;
                else
                    bt_PageNext.Visible = false;
                lb_Pages.Text = string.Format("{0} of {1} pages", (rowShowIndex + rows) / rows, dataTable.Rows.Count / rows);               
            }
        }
        private void addSelectExport(int count)
        {
            try
            {
                Nud_Colunms.Enabled = false;
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Alignment = DataGridViewContentAlignment.MiddleRight;
                style.BackColor = this.BackColor;
                style.ForeColor = this.ForeColor;
                DataGridViewCellStyle styleCell = new DataGridViewCellStyle();
                styleCell.BackColor = Color.DarkGray;
                styleCell.ForeColor = Color.WhiteSmoke;
                List<ComboBoxItem> lstCell = new List<ComboBoxItem>();
                
              //  ComboBoxItem cb = new ComboBoxItem();cb.Text = "None";lstCell.Add(cb);
                for (int c = 1; c < 30; c++)
                    for (int r = 1; r < 20; r++)
                    {
                        ComboBoxItem cb = new ComboBoxItem();
                        cb.Text = ColumnIndexToColumnLetter(c) + ":" + r;
                        cb.Value = new ExcelCellAddress(r, c);
                        lstCell.Add(cb);
                    }


               // DataGridViewComboBoxCell cbCell;

                for (int i = 0; i < count; i++)
                {
                    DataGridViewComboBoxCell cbCell = new DataGridViewComboBoxCell();
                    cbCell.DataSource = lstCell;
                    cbCell.ValueType = typeof(ComboBoxItem);
                    //    cbCell.Items.AddRange(lstCell.ToArray());
                    cbCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                    cbCell.Value = lstCell[i*19+4];                   
                    gridView.Rows[0].Cells[i] = cbCell;
                 
                }
                gridView.DefaultCellStyle = styleCell;
            }
            catch (Exception ex)
            { }
        }
		private void bt_PagePre_Click(object sender, EventArgs e)
		{
            try
            {
                int rows = 0; int.TryParse(cb_ShowEntries.Text, out rows);
                rowShowIndex -= rows;
            }
            catch { }
            ShowData();
        }

		private void bt_PageNext_Click(object sender, EventArgs e)
		{
            try
            {
                int rows = 0; int.TryParse(cb_ShowEntries.Text, out rows);
                rowShowIndex += rows;
            }
            catch { }
            ShowData();
        }

		private void gridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
            if (e.Exception is ArgumentException)
            {
                object value = gridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                // if (!((DataGridViewComboBoxColumn)gridView.Columns[e.ColumnIndex]).Items.Contains(value))
                //{
                //((DataGridViewComboBoxCell)gridView[e.ColumnIndex, e.RowIndex]).Value = value;
                    //((DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
               // }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private ExcelWorksheet DrawGDTC(ref ExcelWorksheet worksheet, System.Data.DataTable dt, Dictionary<string, ExcelCellAddress> mapColunm, bool isVertical)
        {
            try
            {
                //foreach (KeyValuePair<string, ExcelCellAddress> header in mapColunm)
                //{
                //    using (ExcelRange rng = worksheet.Cells[header.Value.Address])
                //    {
                //        rng.Merge = true;
                //        rng.Value = header.Key;
                //    }
                //}

                foreach (DataColumn column in dt.Columns)
                {
                    if (mapColunm.Keys.Contains(column.ColumnName))
                    {
                        for (int i=0;i< dt.Rows.Count;i++)
                        {
                            // ExcelAddress ad = new ExcelAddress(mapColunm[column.ColumnName].Row+i, mapColunm[column.ColumnName].Column + i, mapColunm[column.ColumnName].Row + i, mapColunm[column.ColumnName].Column + i);
                            ExcelCellAddress ad = new ExcelCellAddress(mapColunm[column.ColumnName].Row+i, mapColunm[column.ColumnName].Column);
                            worksheet.Cells[ad.Address].Value = dt.Rows[i][column.ColumnName];
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return worksheet;
        }

		private void bt_Export_Click(object sender, EventArgs e)
		{
            try
            {               
                Dictionary<string, ExcelCellAddress> mapCol = new Dictionary<string, ExcelCellAddress>();
                for (int i = 0; i < gridView.Rows[0].Cells.Count; i++)
                {
                    if (((ComboBoxItem)gridView.Rows[0].Cells[i].Value).Value != null)
                    {
                        mapCol[gridView.Columns[i].Name] = (ExcelCellAddress)((ComboBoxItem)gridView.Rows[0].Cells[i].Value).Value;
                    }
                }

                var file = new FileInfo(tb_loadFile.Text);
                using (var package = new ExcelPackage(file)) 
                {
                    ExcelWorksheet ws = package.Workbook.Worksheets[cb_Sheets.Text];
                    DrawGDTC(ref ws, dataTable, mapCol, true);
                    package.Save();
                }

                MessageBox.Show("Export success.");

            }
            catch (Exception ex)
            { MessageBox.Show("Export Fail. "+ex.Message,"Export fail",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }
	}
}
