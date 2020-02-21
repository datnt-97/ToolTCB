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
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Diagnostics;
using DifferenceEngine;
using System.Collections;

namespace Transaction_Statistical.UControl
{

    public partial class UC_Text : UserControl
    {
        UC_Explorer uc_Explorer;
        public string PathFile = string.Empty;
        public string PathFileSession = string.Empty;
        public string TabName = string.Empty;
        public UC_Text(string tabName, string _session, string _path)
        {
            Session = _session;
            PathFile = _path;
            TabName = tabName;
            InitUI();
        }
        public UC_Text()
        {
            Session = String.Format("{0:yyyyMMddHHmmssffff}", DateTime.Now);
            TabName = "New " + Session;
            InitUI();
        }
        private void InitUI()
        {
            InitializeComponent();
            pl_Menu.Location = new Point(this.Width, pl_Menu.Location.Y);

           
            inifile = new UtilityIniFile();
            pathFileTmp = inifile.GetEntryValue(Session, "PathFileTemp");

            ComboBoxItem cb_WN = new ComboBoxItem();
            cb_WN.Text = "Wincor Nixdorf";
            cb_WN.Value = "WN";
            cbo_MachineName.Items.Add(cb_WN);
            ComboBoxItem cb_DB = new ComboBoxItem();
            cb_DB.Text = "Diebold";
            cb_DB.Value = "DB";
            cbo_MachineName.Items.Add(cb_DB);
            ComboBoxItem cb_OKI = new ComboBoxItem();
            cb_OKI.Text = "OKI";
            cb_OKI.Value = "OKI";
            cbo_MachineName.Items.Add(cb_OKI);
            ComboBoxItem cb_NCR = new ComboBoxItem();
            cb_NCR.Text = "NCR";
            cb_NCR.Value = "NCR";
            cbo_MachineName.Items.Add(cb_NCR);
            ComboBoxItem cb_GRG = new ComboBoxItem();
            cb_GRG.Text = "GRG";
            cb_GRG.Value = "GRG";
            cbo_MachineName.Items.Add(cb_GRG);
            cbo_MachineName.SelectedIndex = 0;
            //color compare
            greenStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(100, Color.Lime)));
            redStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(100, Color.Red)));
            ///
            fctb1.AddStyle(sameWordsStyle);//same words style
            // add font
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                cbo_Font.Items.Add(font.Name);
            }
            cbo_Font.SelectedIndex = 1;
            nup_size.Value = 9;
            cbo_languageFormat.SelectedIndex = 1;
            LoadFile();
            new Thread(() => UpdateFilesOpened(Session, PathFile, "Text", false)).Start();

            toolTip1.SetToolTip(this.lb_Menu, "Show Menu");
            toolTip1.SetToolTip(this.lb_Explorer, "Show Explorer");
        }
        private void UpdateFilesOpened(string session, string path, string type, bool checkOpened)
        {
            try
            {
                PathFileSession = InitParametar.PathDirectoryTempUsr + "\\" + session;
                if (checkOpened) foreach (string s in inifile.GetSectionNames()) if (inifile.GetEntryValue(s, "PathFile") == path) inifile.DeleteSection(s);
                inifile.Write("FileName", System.IO.Path.GetFileName(path), session);
                inifile.Write("PathFileTemp", PathFileSession, session);
                inifile.Write("PathFile", path, session);
                inifile.Write("Type", type, session);
                inifile.Write("Status", "Opening", session);

                if (type.Equals("Text")) if (!string.IsNullOrEmpty(path))
                    {
                        DateTime dt = File.GetLastWriteTime(path);
                        inifile.Write("LastWriteTime", String.Format("{0:yyyyMMddHHmmssffff}", dt), session);
                        File.Copy(path, PathFileSession, true);
                    }

            }
            catch (Exception ex)
            { InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); }
        }
        private void LoadFile()
        {
            disabletxtchange = true;
            if (File.Exists(PathFile)) fctb1.OpenFile(PathFile);
            else
                if (File.Exists(pathFileTmp)) fctb1.OpenFile(pathFileTmp);
            disabletxtchange = false;
            Thread th_checkVerdor = new Thread(() => CheckLogMachine(PathFile, false));
            th_checkVerdor.Start();
        }
        public void ReLoadFile()
        {
            disabletxtchange = true;
            if (File.Exists(PathFile)) fctb1.OpenFile(PathFile);
            DateTime dt = File.GetLastWriteTime(PathFile);
            inifile.Write("LastWriteTime", String.Format("{0:yyyyMMddHHmmssffff}", dt), Session);
            disabletxtchange = false;
        }
        private void CheckLogMachine(string path, bool opened)
        {
            try
            {
                string itemSelect = "";
                UIHelper.UIThread(cbo_MachineName, delegate { itemSelect = cbo_MachineName.SelectedText; });
                if (!itemSelect.Equals("")) return;
                System.IO.StreamReader file;
                string pathcheck = path;
                if (opened) pathcheck = pathFileTmp;
                if (!File.Exists(pathcheck)) return;
                file = new System.IO.StreamReader(pathcheck);
                int n = 0;
                string line;
                string machineName = string.Empty;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith(@"> 11") || line.StartsWith(@"> 22") || line.StartsWith(@"> 12") || line.StartsWith(@"< 4") || line.StartsWith(@"< 3") || line.StartsWith(@"< 1"))
                    {
                        machineName = "WN";
                        break;
                    }
                    if (line.Contains(@"<convertSendCode>") || line.Contains(@"<convertSendCode>"))
                    {
                        machineName = "OKI";
                        break;
                    }
                    if (line.Contains(@"Device     Proc  Port  CU  DA Function Status Length"))
                    {
                        machineName = "DB";
                        break;
                    }
                    if (line.Contains(@"DATA = [") || line.Contains(@"TDATA: ["))
                    {
                        machineName = "NCR";
                        break;
                    }
                    n++;
                    if (n == 100) break;
                }
                for (int i = 0; i < cbo_MachineName.Items.Count; i++)
                {
                    ComboBoxItem cb = cbo_MachineName.Items[i] as ComboBoxItem;
                    if (cb.Value.ToString().Equals(machineName))
                    {
                        UIHelper.UIThread(cbo_MachineName, delegate { cbo_MachineName.SelectedIndex = i; });
                        break;
                    }
                }
            }
            catch (Exception ex)
            { InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); }
        }
        private void iconMenu_MouseHover(object sender, EventArgs e)
        {
            (sender as Mode_Label).Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void iconMenu_MouseLeave(object sender, EventArgs e)
        {
            (sender as Mode_Label).Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void iconMenu_Click(object sender, EventArgs e)
        {
            ShowMenu();
            if (this.lb_Menu.Text.Equals("«"))
            {
                this.lb_Menu.Text = "»";
                toolTip1.SetToolTip(this.lb_Menu, "Hide Menu");
            }
            else
            {

                this.lb_Menu.Text = "«";
                toolTip1.SetToolTip(this.lb_Menu, "Show Menu");
            }
        }


        bool showMenu;
        bool runningShowMenu;
        private void ShowMenu()
        {
            if (showMenu) showMenu = false; else showMenu = true;
            if (runningShowMenu) return;
            runningShowMenu = true;
            while (runningShowMenu)
            {
                if (showMenu)
                {
                    this.pl_Menu.Location = new Point(this.pl_Menu.Location.X - 3, this.pl_Menu.Location.Y);
                    if ((this.pl_Menu.Location.X + this.pl_Menu.Width) <= lb_Menu.Location.X) break;
                }
                else
                {
                    this.pl_Menu.Location = new Point(this.pl_Menu.Location.X + 3, this.pl_Menu.Location.Y);
                    if (this.pl_Menu.Location.X >= this.Width) break;
                }
                this.pl_Menu.Update();
            }
            runningShowMenu = false;
        }

        private void bt_Flip_Click(object sender, EventArgs e)
        {
            if (spl_Main.Orientation.Equals(Orientation.Horizontal))
                spl_Main.Orientation = Orientation.Vertical;
            else
                spl_Main.Orientation = Orientation.Horizontal;
        }

        private void bt_Switch_Click(object sender, EventArgs e)
        {
            if (spl_Main.Panel1Collapsed && !spl_Main.Panel2Collapsed)
            {
                spl_Main.Panel1Collapsed = false;
                spl_Main.Panel2Collapsed = false;
                bt_Flip.Enabled = true;
                toolTip1.SetToolTip(bt_Switch, "Hide Panel 2");

            }
            else if (!spl_Main.Panel1Collapsed && spl_Main.Panel2Collapsed)
            {
                spl_Main.Panel1Collapsed = true;
                spl_Main.Panel2Collapsed = false;
                toolTip1.SetToolTip(bt_Switch, "Show Panels");
                bt_Flip.Enabled = false;
            }
            else
            {
                spl_Main.Panel1Collapsed = false;
                spl_Main.Panel2Collapsed = true;
                toolTip1.SetToolTip(bt_Switch, "Hide Panel 1");
                bt_Flip.Enabled = false;
            }
        }

        private void cbo_languageFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set language
            string lang = cbo_languageFormat.SelectedItem.ToString();
            fctb1.ClearStylesBuffer();
            fctb1.Range.ClearStyle(StyleIndex.All);
            InitStylesPriority();
            fctb1.AutoIndentNeeded -= fastColoredTextBox1_AutoIndentNeeded;
            //
            switch (lang)
            {
                //For example, we will highlight the syntax of C# manually, although could use built-in highlighter
                case "CSharp (custom highlighter)":
                    fctb1.Language = Language.Custom;
                    fctb1.CommentPrefix = fctb2.CommentPrefix = "//";
                    fctb1.AutoIndentNeeded += fastColoredTextBox1_AutoIndentNeeded;
                    fctb2.AutoIndentNeeded += fastColoredTextBox1_AutoIndentNeeded;
                    //call OnTextChanged for refresh syntax highlighting

                    break;
                case "CSharp": fctb1.Language = Language.CSharp; break;
                case "VB": fctb1.Language = Language.VB; break;
                case "HTML": fctb1.Language = Language.HTML; break;
                case "XML": fctb1.Language = Language.XML; break;
                case "SQL": fctb1.Language = Language.SQL; break;
                case "PHP": fctb1.Language = Language.PHP; break;
                case "JS": fctb1.Language = Language.JS; break;
                case "Lua": fctb1.Language = Language.Lua; break;
                case "Text": fctb1.Language = Language.Text; break;
                case "ATMMsg": fctb1.Language = Language.ATMMsg; break;
            }
            fctb1.OnSyntaxHighlight(new TextChangedEventArgs(fctb1.Range));
            fctb2.Language = fctb1.Language;
            fctb1.OnTextChanged();
            //miChangeColors.Enabled = lang != "CSharp (custom highlighter)";
        }
        private void fastColoredTextBox1_AutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //label
            if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
                !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
            {
                args.Shift = -args.TabLength;
                return;
            }
            //some statements: case, default
            if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
            {
                args.Shift = -args.TabLength / 2;
                return;
            }
            //is unclosed operator in previous line ?
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))//operator is unclosed
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }
        string pathFileTmp;
        DateTime lastNavigatedDateTime = DateTime.Now;
        FastColoredTextBox textBoxSelected;
        public string Session = string.Empty;
        UtilityIniFile inifile;
        bool textselect = true;
        bool disabletxtchange = false;
        private Style sameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(100, Color.GreenYellow)));
        //compare
        int updating;
        Style greenStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(100, Color.Lime)));
        Style redStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(100, Color.Red)));

        //Shortcut style
        ShortcutStyle shortCutStyle = new ShortcutStyle(Pens.Maroon);
        //styles
        TextStyle ASCIIControl = new TextStyle(Brushes.White, Brushes.AliceBlue, FontStyle.Bold);
        TextStyle YellowStyle = new TextStyle(Brushes.Yellow, null, FontStyle.Regular);
        TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

        //styte compare
        TextStyle cpYellowStyle = new TextStyle(null, Brushes.Yellow, FontStyle.Regular);
        TextStyle cpRedStyle = new TextStyle(null, Brushes.Red, FontStyle.Regular);
        TextStyle cpCyanStyle = new TextStyle(null, Brushes.LightCyan, FontStyle.Regular);
        TextStyle cpGreenStyle = new TextStyle(null, Brushes.Green, FontStyle.Regular);
        private void EndUpdate()
        {
            updating--;
        }

        private void BeginUpdate()
        {
            updating++;
        }
        private void InitStylesPriority()
        {
            //add this style explicitly for drawing under other styles
            fctb1.AddStyle(SameWordsStyle);
        }
        private void ExpandedAllPanel()
        {
            //expandablePanel_Compare.Expanded = false;
            //expandablePanel_Converter.Expanded = false;
            //expandablePanel_Encoding.Expanded = false;
            //expandablePanel_Options.Expanded = false;
        }
        private void infotextbar(FastColoredTextBox _textbox)
        {
            textBoxSelected = _textbox;
            lb_Length.Text = "Length " + _textbox.Text.Length.ToString();
            lb_Lines.Text = "Lines " + _textbox.Lines.Count.ToString();
            lb_Sel.Text = "Select " + _textbox.SelectionLength.ToString() + "|" + _textbox.Selection.Text.Split('\n').Length.ToString();

            Place place = _textbox.Selection.End;
            //labelItem_col.Text = _textbox.SelectionStart.ToString();
            //labelItem_ln.Text = (_textbox.Selection.ToLine + 1).ToString();
            lb_Ln.Text = "Ln " + (place.iLine + 1).ToString();
            lb_Col.Text = "Col " + place.iChar.ToString();
            //  sliderItem_zoom.Value = _textbox.Zoom;
        }
        private void CSharpSyntaxHighlight(TextChangedEventArgs e)
        {
            fctb1.LeftBracket = '(';
            fctb1.RightBracket = ')';
            fctb1.LeftBracket2 = '\x0';
            fctb1.RightBracket2 = '\x0';
            //clear style of changed range
            e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle);

            //string highlighting
            e.ChangedRange.SetStyle(BrownStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");
            //comment highlighting
            e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            //number highlighting
            e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
            //attribute highlighting
            e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);
            //class name highlighting
            e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b");
            //keyword highlighting
            e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b");

            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();

            //set folding markers
            e.ChangedRange.SetFoldingMarkers("{", "}");//allow to collapse brackets block
            e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");//allow to collapse #region blocks
            e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");//allow to collapse comment block
        }

        private void fctb1_MouseHover(object sender, EventArgs e)
        {
            ExpandedAllPanel();
            //if (fctb1.Text != string.Empty)
            //    return; disabletxtchange = true;
            //string wc = "Welcome Anlyze :) ";

            //foreach (char c in wc)
            //{
            //    Thread.Sleep(50);
            //    fctb1.Text += c;//(c.ToString(),SameWordsStyle);               
            //}
            //disabletxtchange = false;
        }

        private void fctb1_PaintLine(object sender, PaintLineEventArgs e)
        {
            //draw current line marker
            if (e.LineIndex == fctb1.Selection.Start.iLine)
                using (var brush = new LinearGradientBrush(new Rectangle(0, e.LineRect.Top, 15, 15), Color.LightPink, Color.Red, 45))
                    e.Graphics.FillEllipse(brush, 0, e.LineRect.Top, 15, 15);
        }

        private void fctb1_SelectionChanged(object sender, EventArgs e)
        {
            //  tb_VisibleRangeChanged(sender, e);
            if (!textselect) return;
            if (disabletxtchange) return;
            infotextbar(fctb1);
        }

        private void fctb1_SelectionChangedDelayed(object sender, EventArgs e)
        {
            if (disabletxtchange) return;
            var tb = sender as FastColoredTextBox;
            //remember last visit time
            if (tb.Selection.IsEmpty && tb.Selection.Start.iLine < tb.LinesCount)
            {
                if (lastNavigatedDateTime != tb[tb.Selection.Start.iLine].LastVisit)
                {
                    tb[tb.Selection.Start.iLine].LastVisit = DateTime.Now;
                    lastNavigatedDateTime = tb[tb.Selection.Start.iLine].LastVisit;
                }
            }

            //highlight same words
            tb.VisibleRange.ClearStyle(sameWordsStyle);
            if (!tb.Selection.IsEmpty)
                return;//user selected diapason
            //get fragment around caret
            var fragment = tb.Selection.GetFragment(@"\w");
            string text = fragment.Text;
            if (text.Length == 0)
                return;
            //highlight same words
            Range[] ranges = tb.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();

            if (ranges.Length > 1)
                foreach (var r in ranges)
                    r.SetStyle(sameWordsStyle);
            ////////////////////////////////  maker bookmark
            //here we draw shortcut for selection area
            Range selection = fctb1.Selection;
            //clear previous shortcuts
            fctb1.VisibleRange.ClearStyle(shortCutStyle);
            //create shortcuts
            if (!selection.IsEmpty)//user selected one or more chars?
            {
                //find last char
                var r = selection.Clone();
                r.Normalize();
                r.Start = r.End;//go to last char
                r.GoLeft(true);//select last char
                //apply ShortCutStyle
                r.SetStyle(shortCutStyle);
            }
        }

        private void fctb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (disabletxtchange) return;
            try
            {
                string pathtemp = inifile.GetEntryValue(Session, "PathFileTemp");
                File.WriteAllText(pathtemp, fctb1.Text);
            }
            catch
            { }
        }

        private void fctb1_VisibleRangeChanged(object sender, EventArgs e)
        {
            if (disabletxtchange) return;
            try
            {
                if (updating > 0)
                    return;

                var vPos = (sender as FastColoredTextBox).VerticalScroll.Value;
                var curLine = (sender as FastColoredTextBox).Selection.Start.iLine;

                if (sender == fctb2)
                    UpdateScroll(fctb1, vPos, curLine);
                else
                    UpdateScroll(fctb2, vPos, curLine);

                fctb2.Refresh();
                fctb1.Refresh();
            }
            catch
            { }
        }
        void UpdateScroll(FastColoredTextBox tb, int vPos, int curLine)
        {
            if (updating > 0)
                return;
            //
            BeginUpdate();
            //
            if (vPos <= tb.VerticalScroll.Maximum)
            {
                tb.VerticalScroll.Value = vPos;
                tb.UpdateScrollbars();
            }

            if (curLine < tb.LinesCount)
                tb.Selection = new Range(tb, 0, curLine, 0, curLine);
            //
            EndUpdate();
        }
        private void fctb1_VisualMarkerClick(object sender, VisualMarkerEventArgs e)
        {
            //is it our style ?
            if (e.Style == shortCutStyle)
            {
                //show popup menu
                //   cmMark.Show(fastColoredTextBox1.PointToScreen(e.Location));
            }
        }

        private void fctb1_ZoomChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            fctb1.Font = new Font(cbo_Font.Text.ToString(), fctb1.Font.Size);
            fctb1.Update();
            fctb2.Font = new Font(cbo_Font.Text.ToString(), fctb2.Font.Size);
            fctb2.Update();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fctb2.Font = new Font(cbo_Font.Text.ToString(), (int)nup_size.Value);
            fctb1.Font = new Font(cbo_Font.Text.ToString(), (int)nup_size.Value);
        }

        private void btn_DDC_Click(object sender, EventArgs e)
        {
            try
            {
                string verdor = (cbo_MachineName.SelectedItem as ComboBoxItem).Text;
                switch (verdor)
                {
                    case "Wincor Nixdorf":
                        AnalyzeCCProtWN("DDC");
                        break;
                    case "Diebold":
                        AnalyzeCCProtDB("DDC");
                        break;
                    case "NCR":
                        AnalyzeCCProtNCR("DDC");
                        break;
                    case "OKI":
                        AnalyzeCCProtOKI("DDC");
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }

        private void bt_NDC_Click(object sender, EventArgs e)
        {
            try
            {
                string verdor = (cbo_MachineName.SelectedItem as ComboBoxItem).Text;
                switch (verdor)
                {
                    case "Wincor Nixdorf":
                        AnalyzeCCProtWN("NDC");
                        break;
                    case "Diebold":
                        AnalyzeCCProtDB("NDC");
                        break;
                    case "NCR":
                        AnalyzeCCProtNCR("NDC");
                        break;
                    case "OKI":
                        AnalyzeCCProtOKI("NDC");
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }
        private void AnalyzeCCProtOKI(string protocol)
        {
            try
            {
                string filetmp = FileTmpRandom();
                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(InitParametar.PathDirectoryTempUsr + "\\" + Session);
                System.IO.StreamWriter filenew = new System.IO.StreamWriter(filetmp);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(@"[ORG]"))
                    {
                        StringBuilder sb = new StringBuilder();
                        string lineHex;
                        string from = @"< ";
                        filenew.WriteLine(line.Substring(0, 22));
                        if (line.Contains(@"<convertSendCode>")) from = @"> ";
                        lineHex = line.Substring(line.IndexOf(@"[ORG]")).Replace(@"[ORG]", "");
                        for (int i = 0; i < lineHex.Length; i += 2)
                        {
                            string hs = lineHex.Substring(i, 2);
                            sb.Append(Convert.ToChar(Convert.ToUInt32(hs, 16)));
                        }
                        filenew.WriteLine(from + sb.ToString());
                    }
                }
                file.Close();
                filenew.Close();

                string pathout;
                if (AnalyzeWNFormat(filetmp, protocol, out pathout))
                {
                    fctb2.OpenFile(pathout);
                    spl_Main.Panel2Collapsed = false;
                }
                else
                    MessageBox.Show("Can't analyze log.\n", "Analyze Error", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }

        }
        private void AnalyzeCCProtWN(string protocol)
        {

            try
            {
                string pathout;
                if (AnalyzeWNFormat(InitParametar.PathDirectoryTempUsr + "\\" + Session, protocol, out pathout))
                {
                    fctb2.OpenFile(pathout);
                    spl_Main.Panel2Collapsed = false;
                }
                else
                    MessageBox.Show("Can't analyze log.\n", "Analyze Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Can't analyze log.");
            }
        }
        private void AnalyzeCCProtDB(string protocol)
        {

            try
            {
                string line;
                // Read the file and display it line by line.
                string pathnew = FileTmpRandom();
                System.IO.StreamReader file = new System.IO.StreamReader(InitParametar.PathDirectoryTempUsr + "\\" + Session);
                System.IO.StreamWriter filenew = new System.IO.StreamWriter(pathnew);
                string from = string.Empty;
                bool newline = true;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith("Device"))
                    {
                        newline = true;
                        filenew.WriteLine("");
                        filenew.WriteLine(line.Substring(line.Length - 16));
                    }
                    if (line.StartsWith(@"[") && line.Contains(@"]"))
                    {
                        StringBuilder sb = new StringBuilder();
                        string lineHex;
                        lineHex = line.Substring(1, line.IndexOf(@"]") - 1).Replace(" ", "");
                        for (int i = 0; i < lineHex.Length; i += 2)
                        {
                            string hs = lineHex.Substring(i, 2);
                            sb.Append(Convert.ToChar(Convert.ToUInt32(hs, 16)));
                        }
                        if (newline)
                        {
                            if (sb.ToString().StartsWith(@"1") || sb.ToString().StartsWith(@"3") || sb.ToString().StartsWith(@"4") || sb.ToString().StartsWith(@"5")) from = @"< ";
                            if (sb.ToString().StartsWith(@"11") || sb.ToString().StartsWith(@"12") || sb.ToString().StartsWith(@"22")) from = @"> ";
                            filenew.Write(from + sb.ToString());
                            newline = false;
                        }
                        else
                            filenew.Write(sb.ToString());

                    }
                }
                file.Close();
                filenew.Close();
                string pathout;
                if (AnalyzeWNFormat(pathnew, protocol, out pathout))
                {
                    fctb2.OpenFile(pathout);
                    spl_Main.Panel2Collapsed = false;
                }
                else
                    MessageBox.Show("Can't analyze log.\n", "Analyze Error", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void AnalyzeCCProtNCR(string protocol)
        {

            try
            {
                string line;
                // Read the file and display it line by line.
                string pathnew = FileTmpRandom();
                System.IO.StreamReader file = new System.IO.StreamReader(InitParametar.PathDirectoryTempUsr + "\\" + Session);
                System.IO.StreamWriter filenew = new System.IO.StreamWriter(pathnew);
                string from = string.Empty;
                bool newline = true;
                bool endline = true;
                while ((line = file.ReadLine()) != null)
                {
                    if (!endline)
                    {
                        if (line.EndsWith(@"]")) endline = true;
                        filenew.WriteLine(line.TrimEnd(']'));
                    }
                    if (line.StartsWith("RECV:"))
                    {
                        newline = true;
                        filenew.WriteLine("");
                        filenew.WriteLine(line.Replace(@"RECV:", "").Replace(@"TIME", "").Replace(@"=", "").Trim());
                        from = @"< ";
                    }
                    if (line.StartsWith("MSG_OUT:"))
                    {
                        newline = true;
                        filenew.WriteLine("");
                        filenew.WriteLine(line.Replace(@"MSG_OUT:", "").Replace(@"TIME", "").Replace(@"=", "").Trim());
                        from = @"> ";
                    }
                    if (line.Contains(@"DATA = [") || line.Contains(@"TDATA: ["))
                    {
                        string sb = string.Empty;
                        if (line.Contains(@"DATA = [")) sb = line.Substring(line.IndexOf(@"DATA = [") + 8);
                        if (line.Contains(@"TDATA: [")) sb = line.Substring(line.IndexOf(@"TDATA: [") + 8);
                        newline = false;
                        endline = false;
                        if (sb.EndsWith(@"]")) endline = true;
                        filenew.Write(from + sb.TrimEnd(']'));
                    }

                }
                file.Close();
                filenew.Close();
                string pathout;
                if (AnalyzeWNFormat(pathnew, protocol, out pathout))
                {
                    fctb2.OpenFile(pathout);
                    spl_Main.Panel2Collapsed = false;
                }
                else
                    MessageBox.Show("Can't analyze log.\n", "Analyze Error", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private bool AnalyzeWNFormat(string pathfileIn, string protocol, out string pathfileOut)
        {
            pathfileOut = InitParametar.PathDirectoryTempUsr + "\\" + FileTmpRandom();

            string pathExtractInfo = InitParametar.PathDirectoryTempUsr + @"\ExtractFileEx_" + Session + ".txt";
            string pathExtractRun = InitParametar.PathDirectoryTempUsr + @"\ExtracFile_" + Session + ".bat";


            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = pathExtractRun;
            if (protocol.Equals("NDC")) File.WriteAllText(pathExtractRun, "\"" + InitParametar.PathDirectoryUtilities + @"\Analyzelog.exe" + "\"" + " " + pathfileIn + " > " + "\"" + pathfileOut + "\"");
            //startInfo.Arguments = @"/c " + "\"" + InitParametar.PathDirectoryUtilities + @"\Analyzelog.exe" + "\"" + " " + pathfileIn + " > " + "\"" + pathfileOut + "\"";
            if (protocol.Equals("DDC")) File.WriteAllText(pathExtractRun, "\"" + InitParametar.PathDirectoryUtilities + @"\Analyzelog.exe" + "\"" + " -D " + pathfileIn + " > " + "\"" + pathfileOut + "\"");
            //startInfo.Arguments = @"/c " + "\"" + InitParametar.PathDirectoryUtilities + @"\Analyzelog.exe" + "\"" + " -D " + pathfileIn + " > " + "\"" + pathfileOut + "\"";
            File.AppendAllText(pathExtractRun, Environment.NewLine + @"DEL /q /s " + "\"" + "%~f0" + "\"");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
                if (!File.Exists(pathfileOut)) return false;
                FileInfo filesize = new FileInfo(pathfileOut);
                if (filesize.Length == 0) return false;
            }
            catch
            {
                MessageBox.Show("Error", "Can't analyze log.");

            }
            return true;
        }
        private string FileTmpRandom()
        {
            return String.Format("{0:yyyyMMddHHmmssffff}", DateTime.Now) + new Random().Next(int.MinValue, int.MaxValue).ToString() + ".tmp";
        }

        private void cbo_File1_Click(object sender, EventArgs e)
        {
            (sender as Mode_ComboBox).Items.Clear();
            Control tabcontrol = this.Parent;
            while (!(tabcontrol is AddOn.TabControlX) && tabcontrol.Parent != null)
            {
                tabcontrol = tabcontrol.Parent;
            }
            if (tabcontrol != null)
            {

                foreach (AddOn.TabPanelControl bt in (tabcontrol as AddOn.TabControlX).TabPanelCtrlList)
                {
                    if (bt.Controls[0] is UC_Text)
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Text = (bt.Controls[0] as UC_Text).TabName;
                        item.Value = (bt.Controls[0] as UC_Text).PathFileSession;
                        (sender as Mode_ComboBox).Items.Add(item);
                    }
                }
            }
        }

        private void bt_Compare_Click(object sender, EventArgs e)
        {
            textselect = false;

            try
            {
                if (cbo_File1.SelectedItem.ToString() == string.Empty || cbo_File2.SelectedItem.ToString() == string.Empty) return;

                disabletxtchange = true;
                string file1 = (string)(cbo_File1.SelectedItem as ComboBoxItem).Value;
                string file2 = (string)(cbo_File2.SelectedItem as ComboBoxItem).Value;

                Cursor = Cursors.WaitCursor;

                if (System.IO.Path.GetExtension(file1).ToLower() == ".cs")
                    fctb1.Language = fctb2.Language = Language.CSharp;
                else
                    fctb1.Language = fctb2.Language = Language.Custom;
                fctb1.Clear();
                fctb2.Clear();
                fctb1.Text = "";
                compare2files(file1, file2);

                ///show results
                Cursor = Cursors.Default;
                int width = spl_Main.ClientRectangle.Width;
                spl_Main.SplitterDistance = width / 2;
                spl_Main.Panel2Collapsed = false;
                spl_Main.Orientation = System.Windows.Forms.Orientation.Vertical;
                disabletxtchange = false;
                textselect = true;
                ExpandedAllPanel();
            }
            catch (Exception ex)
            { InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); }
        }
        public DifferenceEngine.DiffEngineLevel _level;
        private void compare2files(string sFile, string dFile)
        {

            if (rd_Fast.Checked)
            {
                _level = DiffEngineLevel.FastImperfect;
            }
            else
            {
                if (rd_Medium.Checked)
                {
                    _level = DiffEngineLevel.Medium;
                }
                else
                {
                    _level = DiffEngineLevel.SlowPerfect;
                }
            }
            TextDiff(sFile, dFile);

        }
        private void TextDiff(string sFile, string dFile)
        {
            this.Cursor = Cursors.WaitCursor;

            DiffList_TextFile sLF = null;
            DiffList_TextFile dLF = null;
            try
            {
                sLF = new DiffList_TextFile(sFile);
                dLF = new DiffList_TextFile(dFile);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                return;
            }

            try
            {
                double time = 0;
                DiffEngine de = new DiffEngine();
                time = de.ProcessDiff(sLF, dLF, _level);

                ArrayList rep = de.DiffReport();
                //Results dlg = new Results(sLF, dLF, rep, time);
                //dlg.Dock = DockStyle.Fill;
                //splitContainer_notepad.Panel1.Controls.Clear();
                //splitContainer_notepad.Panel1.Controls.Add(dlg);
                //fastColoredTextBox1.Visible = false;
                //dlg.Show();
                //  lvSource.Items.Clear();
                //   lvDestination.Items.Clear();
                //  Thread display = new Thread(() => DisplayCompareResults(splitContainer_notepad,fastColoredTextBox1, fastColoredTextBox2, progressBar, sLF, dLF, rep, time));
                //display.Start();
                DisplayCompareResults(spl_Main, fctb1, fctb2, textProgressBar1, sLF, dLF, rep, time);
                //  splitContainer_notepad.Visible = false;
                //  splitContainer_Compare.Visible = true;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                string tmp = string.Format("{0}{1}{1}***STACK***{1}{2}",
                    ex.Message,
                    Environment.NewLine,
                    ex.StackTrace);
                InitParametar.Send_Error(tmp + Environment.NewLine + ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                return;
            }
            this.Cursor = Cursors.Default;
        }
        public void DisplayCompareResults(SplitContainer split, FastColoredTextBox fcsource, FastColoredTextBox fcdescription, TextProgressBar progress, DiffList_TextFile source, DiffList_TextFile destination, ArrayList DiffLines, double seconds)
        {
            split.Visible = false;
            this.Text = string.Format("Results: {0} secs.", seconds.ToString("#0.00"));
            disabletxtchange = true;

            int i;
            int n = progress.Maximum = DiffLines.Count + 1;
            int m = 0;
            foreach (DiffResultSpan drs in DiffLines)
            {
                m++;
                progress.Value += 1;
                switch (drs.Status)
                {
                    case DiffResultSpanStatus.DeleteSource:
                        for (i = 0; i < drs.Length; i++)
                        {
                            fcsource.AppendText(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line + Environment.NewLine, cpYellowStyle);
                            fcdescription.AppendText("" + Environment.NewLine, BrownStyle);
                            progress.Text = m.ToString() + "/" + n.ToString();
                        }

                        break;
                    case DiffResultSpanStatus.NoChange:
                        for (i = 0; i < drs.Length; i++)
                        {
                            fcsource.AppendText(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line + Environment.NewLine);
                            fcdescription.AppendText(((TextLine)destination.GetByIndex(drs.DestIndex + i)).Line + Environment.NewLine);
                            progress.Text = m.ToString() + "/" + n.ToString();
                        }

                        break;
                    case DiffResultSpanStatus.AddDestination:
                        for (i = 0; i < drs.Length; i++)
                        {
                            fcsource.AppendText("" + Environment.NewLine, redStyle);
                            fcdescription.AppendText(((TextLine)destination.GetByIndex(drs.DestIndex + i)).Line + Environment.NewLine, cpYellowStyle);
                            progress.Text = m.ToString() + "/" + n.ToString();
                        }

                        break;
                    case DiffResultSpanStatus.Replace:
                        for (i = 0; i < drs.Length; i++)
                        {
                            fcsource.AppendText(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line + Environment.NewLine, cpRedStyle);
                            fcdescription.AppendText(((TextLine)destination.GetByIndex(drs.DestIndex + i)).Line + Environment.NewLine, cpRedStyle);
                            progress.Text = m.ToString() + "/" + n.ToString();
                        }
                        break;
                }

            }
            progress.Visible = false;
            split.Visible = true;
        }

        private void bt_Hex2ASCII_Click(object sender, EventArgs e)
        {

            string lineHex;
            if (fctb1.SelectedText.Length > 1) lineHex = fctb1.SelectedText;
            else lineHex = fctb1.Text;
            StringBuilder sb = new StringBuilder();
            int length = lineHex.Length;

            Dictionary<char, string> lSpecialDict = new Dictionary<char, string>()
            {
            { '\0',      "NUL" }, {(char)0x01, "SOH" }, {(char)0x02, "STX" },
            {(char)0x03, "ETX" }, {(char)0x04, "EOT" }, {(char)0x05, "ENQ" },
            {(char)0x06, "ACK" }, {(char)0x07, "BEL" }, {(char)0x08, "BS"  },
            {(char)0x09, "HT"  }, {(char)0x0A, "LF"  }, {(char)0x0B, "VT"  },
            {(char)0x0C, "FF"  }, {(char)0x0D, "CR"  }, {(char)0x0E, "SO"  },
            {(char)0x0F, "SI"  }, {(char)0x10, "DLE" }, {(char)0x11, "DC1" },
            {(char)0x12, "DC2" }, {(char)0x13, "DC3" }, {(char)0x14, "DC4" },
            {(char)0x15, "NAK" }, {(char)0x16, "SYN" }, {(char)0x17, "ETB" },
            {(char)0x18, "CAN" }, {(char)0x19, "EM"  }, {(char)0x1A, "SUB" },
            {(char)0x1B, "ESC" }, {(char)0x1C, "FS"  }, {(char)0x1D, "GS"  },
            {(char)0x1E, "RS"  }, {(char)0x1F, "US"  }, {(char)0x7F, "DEL" },
            };


            for (int i = 0; i < length; i += 2)
            {
                try
                {
                    while (lineHex.Substring(i, 2).StartsWith(" "))
                    {
                        i++;
                        if (i == length) break;
                    }
                    string hs = lineHex.Substring(i, 2);
                    try
                    {
                        sb.Append(Convert.ToChar(Convert.ToUInt32(hs, 16)));
                    }
                    catch (Exception)
                    {
                        sb.Append(hs);
                    }

                }
                catch (Exception)
                { }
            }
            if (fctb1.SelectedText.Length > 1)
            {
                fctb1.SelectedText = sb.ToString();
            }
            else
            {
                fctb2.Text = sb.ToString();
                char[] text = sb.ToString().ToCharArray();
                for (int i = 0; i < text.Length; i++)
                {
                    //is this a special ASCII character?
                    if (lSpecialDict.ContainsKey(text[i]))
                    {
                        string replacement;
                        //get the replacement
                        lSpecialDict.TryGetValue(text[i], out replacement);
                        if (replacement != null)
                            //Print it out with DarkGray as backcolor, Firebrick as font color.

                            fctb2.AppendText(replacement, ASCIIControl);
                    }
                    //just a normal character? Then append it.
                    else
                        fctb2.AppendText(text[i].ToString());
                }


                spl_Main.Panel2Collapsed = false;
            }
        }

        private void bt_ASCII2Hex_Click(object sender, EventArgs e)
        {
            string lineAscii;
            if (fctb1.SelectedText.Length >= 1) lineAscii = fctb1.SelectedText;
            else lineAscii = fctb1.Text;
            StringBuilder sb = new StringBuilder();
            int length = lineAscii.Length;

            byte[] inputBytes = Encoding.UTF8.GetBytes(lineAscii);

            foreach (byte b in inputBytes)
            {

                sb.Append(string.Format("{0:x2}", b));

            }

            if (fctb1.SelectedText.Length >= 1)
            {
                fctb1.SelectedText = sb.ToString();
            }
            else
            {
                fctb2.Text = sb.ToString();
                spl_Main.Panel2Collapsed = false;
            }
        }

        private void ckb_LineNumbers_CheckedChanged(object sender, EventArgs e)
        {
            fctb1.ShowFoldingLines = fctb1.ShowLineNumbers = ckb_LineNumbers.Checked;
            fctb2.ShowLineNumbers = ckb_LineNumbers.Checked;
        }

        private void lb_Explorer_Click(object sender, EventArgs e)
        {
            if (uc_Explorer == null) uc_Explorer = new UC_Explorer();
            uc_Explorer.ShowRight2LeftFromControl(this, sender as Control);
            if (this.lb_Explorer.Text.Equals("«"))
            {
                this.lb_Explorer.Text = "»";
                toolTip1.SetToolTip(this.lb_Explorer, "Hide Explorer");
            }
            else
            {
                this.lb_Explorer.Text = "«";
                toolTip1.SetToolTip(this.lb_Explorer, "Show Explorer");
            }
        }

       
    }
}
