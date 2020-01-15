using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Search : UserControl
    {
        int indexSearch;

        Bitmap icon_select;
        Bitmap icon;
        int XShow;
        int XHide;
        bool showMenu;
        bool runningShowMenu;
        Mode_TreeView TreeTrans;
        public UC_Search(Mode_TreeView treeTrans)
        {
            icon_select = IconHelper.ImageUltility.ChangeColor(global::Transaction_Statistical.Properties.Resources.Next_Select, InitGUI.Custom.Menu_Button.DisplayColor);
            icon = IconHelper.ImageUltility.ChangeColor(global::Transaction_Statistical.Properties.Resources.next, InitGUI.Custom.Menu_Button.DisplayColor);
            InitializeComponent2();
            Icon_Search.BackgroundImage = icon;
            if (treeTrans != null)
            {
                TreeTrans = treeTrans;
                XShow = 2;
                XHide = -(treeTrans.Width - 69);
                this.Location = new System.Drawing.Point(XHide, treeTrans.Height - this.Height - 11);
                this.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
                this.BackColor = treeTrans.BackColor;
            }
        }
        public UC_Search()
        {
            icon_select = IconHelper.ImageUltility.ChangeColor(global::Transaction_Statistical.Properties.Resources.Next_Select, InitGUI.Custom.Menu_Button.DisplayColor);
            icon = IconHelper.ImageUltility.ChangeColor(global::Transaction_Statistical.Properties.Resources.next, InitGUI.Custom.Menu_Button.DisplayColor);
            InitializeComponent2();
        }
        private void ShowControl()
        {
            if (showMenu) showMenu = false; else showMenu = true;
            if (runningShowMenu) return;
            runningShowMenu = true;
            while (runningShowMenu)
            {
                if (showMenu)
                {
                    this.Location = new Point(this.Location.X + 3, this.Location.Y);
                    if (this.Location.X >= XShow) break;
                    txt_Search.Focus();
                }
                else
                {
                    this.Location = new Point(this.Location.X - 3, this.Location.Y);
                    if (this.Location.X <= -(this.Width - 25)) break;
                }
                this.Update();
            }
            runningShowMenu = false;
        }
        private void btn_MouseHover(object sender, EventArgs e)
        {
            this.Icon_Search.BackgroundImage = icon_select;
        }
        private void btn_MouseLeve(object sender, EventArgs e)
        {
            this.Icon_Search.BackgroundImage = icon;
        }
        private void Icon_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text.Trim())) ShowControl();
            else
            {
                object obj = SearchText(txt_Search.Text.Trim());
                if (obj != null)
                    ShowResultSearch(obj, TreeTrans.Nodes);
            }
        }
        private void txt_Search_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                object obj = SearchText(txt_Search.Text.Trim());
                if (obj != null)
                    ShowResultSearch(obj, TreeTrans.Nodes);
            }
            else
            {
                indexSearch = 0;
            }
        }

        private object SearchText(string txt)
        {
            int n = 0;
            if (InitParametar.ReadTrans.ListTransaction == null) return null;
            foreach (Dictionary<DateTime, object> terminal in InitParametar.ReadTrans.ListTransaction.Values)
            {
                foreach (object b in terminal.Values)
                {
                     n++; if (n <= indexSearch) continue;

                    if (b is Transaction && (b as Transaction).TraceJournalFull.Contains(txt))
                    {
                        indexSearch = n;
                        return b;
                    }
                    else if (b is TransactionEvent && (b as TransactionEvent).TContent.Contains(txt))
                    {
                        indexSearch = n;
                        return b;
                    }
                    else if (b is CycleEvent && (b as CycleEvent).Log.Contains(txt))
                    {
                        indexSearch = n;
                        return b;
                    }
                }
            }
            return null;
        }
    private void ShowResultSearch(object obj, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag.Equals(obj))
                {
                    TreeTrans.SelectedNode = node;
                    break;
                }
                else
                    ShowResultSearch(obj, node.Nodes);
            }
        }
    }
}
