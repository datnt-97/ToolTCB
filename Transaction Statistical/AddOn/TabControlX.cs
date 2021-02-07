using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical.AddOn
{
    public partial class TabControlX : UserControl
    {
        public TabControlX()
        {
            InitializeComponent();
        }
        public bool ShowButtonNewTab = true;
        ButtonX btAddNew;
        int selected_index = -1;
        private List<ButtonX> buttonlist = new List<ButtonX> { };
        public List<TabPanelControl> TabPanelCtrlList = new List<TabPanelControl> { };

        private Size tab_size = new Size(110, 25);
        private Color sel_tab_forecolor = InitGUI.Custom.Tab_sel_forecolor.DisplayColor;
        private Color unsel_tab_forecolor = InitGUI.Custom.Tab_unsel_forecolor.DisplayColor;
        private Color sel_tab_backcolor = InitGUI.Custom.Tab_Sel_Backcolor.DisplayColor;
        private Color un_sel_tab_backcolor = InitGUI.Custom.Tab_UnSel_Backcolor.DisplayColor;
        private Color tab_mouseHvrColor = InitGUI.Custom.Tab_MouseHvrColor.DisplayColor;
        private Color tab_mouseClkColor = InitGUI.Custom.Tab_MouseClkColor.DisplayColor;
        private int txt_x_loc = 10, txt_y_loc = 5;
        private Color ribbon_Color = InitGUI.Custom.Tab_Ribbon_Color.DisplayColor;
        private Color tabCtrlPanel_backcolor = InitGUI.Custom.Tab_CtrlPanel_Backcolor.DisplayColor;
        private Color tabCtrlButPanel_backcolor = InitGUI.Custom.Tab_CtrlButPanel_Backcolor.DisplayColor;

        void setHeight()
        {
            if (!buttonlist.Any())
            {
                BackTopPanel.Height = tab_size.Height;
                TabButtonPanel.Height = tab_size.Height;
                RibbonPanel.Height = 2;
            }
            else
            {
                BackTopPanel.Height = buttonlist[0].Height;
                TabButtonPanel.Height = buttonlist[0].Height;
                RibbonPanel.Height = 2;
            }
        }

        public List<ButtonX> TabsList
        {
            get { return buttonlist; }
        }

        public Size TabSize
        {
            get { return tab_size; }
            set { tab_size = value; setHeight(); Invalidate(); }
        }

        public Color SelTabForeColor
        {
            get { return sel_tab_forecolor; }
            set { sel_tab_forecolor = value; Invalidate(); }
        }

        public Color UnSelTabForeColor
        {
            get { return unsel_tab_forecolor; }
            set { unsel_tab_forecolor = value; Invalidate(); }
        }

        public Color SelTabBackColor
        {
            get { return sel_tab_backcolor; }
            set { sel_tab_backcolor = value; Invalidate(); }
        }

        public Color UnSelTabBackColor
        {
            get { return un_sel_tab_backcolor; }
            set { un_sel_tab_backcolor = value; Invalidate(); }
        }

        public Color MouseHrTabColor
        {
            get { return tab_mouseHvrColor; }
            set { tab_mouseHvrColor = value; Invalidate(); }
        }

        public Color MouseClkTabColor
        {
            get { return tab_mouseClkColor; }
            set { tab_mouseClkColor = value; Invalidate(); }
        }

        public int X_TextLoc
        {
            get { return txt_x_loc; }
            set { txt_x_loc = value; Invalidate(); }
        }

        public int Y_TextLoc
        {
            get { return txt_y_loc; }
            set { txt_y_loc = value; Invalidate(); }
        }

        public Color RibbonColor
        {
            get { return ribbon_Color; }
            set { RibbonPanel.BackColor = value; ribbon_Color = value ;Invalidate(); }
        }

        public Color CtrlPanelColor
        {
            get { return tabCtrlPanel_backcolor; }
            set { TabPanel.BackColor = value; tabCtrlPanel_backcolor = value;Invalidate(); }
        }

        public Color TabPanelColor
        {
            get { return tabCtrlButPanel_backcolor; }
            set { BackTopPanel.BackColor = value; TabButtonPanel.BackColor = value;
                tabCtrlButPanel_backcolor = value; Invalidate();
            }
        }

        public int SelectedTabIndex()
        {
            return selected_index;
        }

        public int TabCount()
        {
            return buttonlist.Count;
        }


        public void ChangeTabText(string newtext, int index)
        {
            ButtonX but = buttonlist[index];
            but.Text = newtext;
        }


        void createAndAddButton(string tabtext,string tooltip, TabPanelControl tpcontrol, Point loc, bool showCloseButton)
        {            
            ButtonX bx = new ButtonX();
            bx.DisplayText = tabtext;
            bx.Text = tabtext;
            toolTip1.SetToolTip(bx, tooltip);
            //  bx.Size = tab_size;  
            int width = TextRenderer.MeasureText(tabtext, this.Font).Width + 20;
            if (width < tab_size.Width) width = tab_size.Width;
            bx.Size = new Size(width, tab_size.Height);
            
            bx.Location = loc;
            bx.ForeColor = sel_tab_forecolor;
            bx.BXBackColor = sel_tab_backcolor;
            bx.MouseHoverColor = sel_tab_backcolor;
            bx.MouseClickColor1 = sel_tab_backcolor;
            bx.ChangeColorMouseHC = false;
            bx.TextLocation_X = txt_x_loc;
            bx.TextLocation_Y = txt_y_loc;
            bx.Font = this.Font;
            bx.Click += button_Click;
            bx.ShowCloseButton = showCloseButton;
            bx.OnClickCloseHandler += Close_Button;
            TabButtonPanel.Controls.Add(bx);
            bx.TabIndex = buttonlist.Count;
            tpcontrol.TabIndex = buttonlist.Count;
            buttonlist.Add(bx);
            selected_index = bx.TabIndex;

            TabPanelCtrlList.Add(tpcontrol);
            TabPanel.Controls.Clear();
            TabPanel.Controls.Add(tpcontrol);
            if(showCloseButton)          
                bx.ContextMenuStrip = cMS_Tab;
            UpdateButtons();
        }
        void createButtonNew( Point loc)
        {
             btAddNew = new ButtonX();
            btAddNew.DisplayText = "New";
            btAddNew.Text = "New";
            toolTip1.SetToolTip(btAddNew, "Create new");
            //  bx.Size = tab_size;  
            int width = TextRenderer.MeasureText(btAddNew.Text, this.Font).Width;
            btAddNew.Size = new Size(width, tab_size.Height-5);

            btAddNew.Location = loc;
            btAddNew.ForeColor = unsel_tab_forecolor;
            btAddNew.BXBackColor = un_sel_tab_backcolor;
            btAddNew.MouseHoverColor = sel_tab_backcolor;
            btAddNew.MouseClickColor1 = un_sel_tab_backcolor;
            btAddNew.ChangeColorMouseHC = true;
            btAddNew.TextLocation_X = 2;
            btAddNew.TextLocation_Y = 2;
            btAddNew.Font = this.Font;
            btAddNew.Click += button_AddTab;
            btAddNew.ShowCloseButton = false;
            btAddNew.TabIndex = 100;
            TabButtonPanel.Controls.Add(btAddNew);
            UpdateButtons();
        }
        private void Close_Button(object sender, EventArgs e)
        {
            RemoveTab((sender as ButtonX).TabIndex);
        }
        void button_Click(object sender, EventArgs e)
        {

            //  string btext = ((ButtonX)sender).Text;
            //int index = 0, i;
            //for (i = 0; i < buttonlist.Count; i++)
            //{
            //    if (buttonlist[i] == (sender as ButtonX))
            //    {
            //        index = i;
            //    }
            //}
            //if (selected_index != index)
            //{
            //    TabPanel.Controls.Clear();
            //    TabPanel.Controls.Add(TabPanelCtrlList[index]);
            //    selected_index = ((ButtonX)sender).TabIndex;
            //    UpdateButtons();
            //}
            selected_index = (sender as ButtonX).TabIndex;
            foreach (TabPanelControl tpc in TabPanelCtrlList)
            {
                if(tpc.TabIndex== selected_index)
                {
                    TabPanel.Controls.Clear();
                    TabPanel.Controls.Add(tpc);
                    UpdateButtons();
                }
            }
        }
        void button_AddTab(object sender, EventArgs e)
        {
            btAddNew.BXBackColor = un_sel_tab_backcolor;
            TabPanelControl tpc = new TabPanelControl();
            tpc.Dock = DockStyle.Fill;
            UControl.UC_Text uc_Text = new UControl.UC_Text();
            uc_Text.Dock = DockStyle.Fill;  
            tpc.Controls.Add(uc_Text);
            AddTab(uc_Text.TabName, uc_Text.TabName, tpc, true);
        }
        public TabPanelControl GetTabPanel(int indexTab)
        {
            return TabPanelCtrlList[indexTab];           
        }
        public TabPanelControl GetTabPanel(string nameTab)
        {
            int index = 0, i;
            for (i = 0; i < buttonlist.Count; i++)
            {
                if (buttonlist[i].Text == nameTab)
                {
                    index = i;
                }
            }
            return TabPanelCtrlList[index];
        }

        public void AddTab(string tabtext,string tooltip, TabPanelControl tpcontrol, bool showClose)
        {
            Point pt = new Point(0, 0);
            if (buttonlist.Any())          
                pt = new Point(buttonlist[buttonlist.Count - 1].Size.Width + buttonlist[buttonlist.Count - 1].Location.X, 0);
            createAndAddButton(tabtext, tooltip, tpcontrol, pt, showClose);
            if (ShowButtonNewTab)
            {
                pt = new Point(buttonlist[buttonlist.Count - 1].Size.Width + buttonlist[buttonlist.Count - 1].Location.X, 5);
                if (btAddNew == null)
                    createButtonNew(pt);
                else
                {
                    btAddNew.Location = pt;                 
                }
            }
        }


        void UpdateButtons()
        {
            if (buttonlist.Count > 0)
            {
                for (int i = 0; i < buttonlist.Count; i++)
                {
                    if (i == selected_index)
                    {
                        buttonlist[i].ChangeColorMouseHC = false;
                        buttonlist[i].BXBackColor = buttonlist[i].BackColor = sel_tab_backcolor;
                        buttonlist[i].ForeColor = sel_tab_forecolor;
                        buttonlist[i].MouseHoverColor = sel_tab_backcolor;
                        buttonlist[i].MouseClickColor1 = sel_tab_backcolor;
                    }
                    else
                    {
                        buttonlist[i].ChangeColorMouseHC = true;
                        buttonlist[i].ForeColor = unsel_tab_forecolor;
                        buttonlist[i].MouseHoverColor = tab_mouseHvrColor;
                        buttonlist[i].BXBackColor = buttonlist[i].BackColor= un_sel_tab_backcolor;
                        buttonlist[i].MouseClickColor1 = tab_mouseClkColor;
                    }
                }

            }
            cMS_Tab.BackColor = tabCtrlPanel_backcolor;
            
            cMS_Tab.ForeColor = sel_tab_forecolor;
        }

        private void toolStripButton1_DropDownOpening(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems.Clear();
            int mergeindex = 0;
            for (int i = 0; i < buttonlist.Count; i++)
            {
                ToolStripMenuItem tbr = new ToolStripMenuItem();
                tbr.Text = buttonlist[i].Text;
                tbr.MergeIndex = mergeindex;
                if (selected_index == i)
                {
                    tbr.Checked = true;
                }
                tbr.Click += tbr_Click;
                toolStripDropDownButton1.DropDownItems.Add(tbr);
                mergeindex++;
            }
        }



        List<string> btstrlist = new List<string> { };
        void BackToFront_SelButton()
        {
            int x=0;
            int n = 0;
            //   TabButtonPanel.Controls.Clear();
            foreach (ButtonX bt in buttonlist.OrderBy(b => b.TabIndex).ToList())
            {
                foreach (Control ctr in TabButtonPanel.Controls)
                {
                    if (ctr.Equals(bt))
                    {
                        bt.Location = new Point(x, bt.Location.Y);
                        x += bt.Width;
                        //  TabButtonPanel.Controls.Add(bt);
                        bt.TabIndex = n; 
                        ctr.Location = bt.Location;
                        ctr.TabIndex = n;n++;
                        continue;
                    }
                }
            }
            if (ShowButtonNewTab)
            {
                Point pt = new Point(x, 5);
                if (btAddNew == null)
                    createButtonNew(pt);
                else
                { 
                    btAddNew.Location = pt;
                  
                    if (!TabButtonPanel.Controls.Contains(btAddNew))
                        TabButtonPanel.Controls.Add(btAddNew);
                }
            }           
        }

        void tbr_Click(object sender, EventArgs e)
        {
            int i;
            for (int k = 0; k < ((ToolStripMenuItem)sender).MergeIndex; k++)
            {
                int j = 0;
                for (i = ((ToolStripMenuItem)sender).MergeIndex; i >= 0; i--)
                {
                    ButtonX but = buttonlist[i];
                    ButtonX temp = buttonlist[j];
                    buttonlist[i] = temp;
                    buttonlist[j] = but;

                    TabPanelControl uct1 = TabPanelCtrlList[i];
                    TabPanelControl tempusr = TabPanelCtrlList[j];
                    TabPanelCtrlList[i] = tempusr;
                    TabPanelCtrlList[j] = uct1;
                }
            }

            string btext = ((ToolStripMenuItem)sender).Text;
            BackToFront_SelButton();
            selected_index = 0;
            TabPanel.Controls.Clear();
            TabPanel.Controls.Add(TabPanelCtrlList[buttonlist[0].TabIndex]);
            UpdateButtons();
        }


        public void RemoveTab(int index)
        {
            if (index >= 0 && buttonlist.Count > 0 && index < buttonlist.Count)
            {
                TabButtonPanel.Controls.Remove(buttonlist[index]);
                buttonlist.RemoveAt(index);
                TabPanelCtrlList.RemoveAt(index);
                BackToFront_SelButton();
                
                if (buttonlist.Count > 1)
                {
                    if (index - 1 >= 0)
                    {
                        TabPanel.Controls.Clear();
                        TabPanel.Controls.Add(TabPanelCtrlList[index - 1]);
                    }
                    else
                    {
                        TabPanel.Controls.Clear();
                        TabPanel.Controls.Add(TabPanelCtrlList[(index - 1) + 1]);
                        selected_index = (index - 1) + 1;
                    }
                }
                selected_index = index - 1;

                if (buttonlist.Count == 1)
                {
                    TabPanel.Controls.Clear();
                    TabPanel.Controls.Add(TabPanelCtrlList[0]);
                    selected_index = 0;
                }
            }
            UpdateButtons();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTab(cMS_Tab.SourceControl.TabIndex);
        }

        private void closeAllButThisToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<int> lst = buttonlist.Select(x=>x.TabIndex).ToList();
            foreach (int bt in lst)
            {
                if (bt != 0 && bt != 100 && bt != cMS_Tab.SourceControl.TabIndex)
                    RemoveTab(bt);
            }
        }

        private void closeAllToTheLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> lst = buttonlist.Select(x => x.TabIndex).ToList();
            foreach (int bt in lst)
            {
                if (bt == cMS_Tab.SourceControl.TabIndex) break;
                if (bt != 0 && bt != 100 )
                    RemoveTab(bt);                
            }
        }

        private void closeAllToTheRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> lst = buttonlist.Select(x => x.TabIndex).ToList();
            bool enable = false;
            foreach (int bt in lst)
            {
                if (bt == cMS_Tab.SourceControl.TabIndex) enable =true;
                if (bt != 0 && bt != 100 && enable)
                    RemoveTab(bt);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(TabPanelControl tpc in TabPanelCtrlList)
            {
                if(tpc.TabIndex== cMS_Tab.SourceControl.TabIndex && tpc.Controls[0] is UControl.UC_Text)
                {
                    (tpc.Controls[0] as UControl.UC_Text).bt_Save_Click(null, null);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPanelControl tpc in TabPanelCtrlList)
            {
                if (tpc.TabIndex == cMS_Tab.SourceControl.TabIndex && tpc.Controls[0] is UControl.UC_Text)
                {
                    (tpc.Controls[0] as UControl.UC_Text).bt_SaveAs_Click(null, null);
                }
            }
        }

        private void openConteningToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void UpdateTilte(int tabIndex, string tilte, string tooltip)
        {
            try
            {
              buttonlist.Clear();
                foreach (ButtonX bt in TabButtonPanel.Controls)
                {
                    if(bt.TabIndex!=100)
                    buttonlist.Add(bt);
                    if (bt.TabIndex == tabIndex)
                    {
                        bt.Text = tilte;
                        toolTip1.SetToolTip(bt, tooltip);                       
                    }
                }
            }
            catch { }
        }
    }
}
