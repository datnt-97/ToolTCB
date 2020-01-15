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
        Mode_TreeView TreeTransResult;
        Mode_TreeView TreeTransOrg;
        Mode_Label lb_Back;
        char FieldSplit = ';';
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
                //object obj = SearchText(txt_Search.Text.Trim());
                //if (obj != null)
                //    ShowResultSearch(obj, TreeTrans.Nodes);
                SearchTextInNode(txt_Search.Text.Trim());
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
        private void SearchTextInNode(string txt)
        {
            try
            {
                if (txt.Trim() == string.Empty)
                {
                    BackListOgrinal(null, null);
                }
                else
                {
                    if (TreeTransOrg == null || TreeTransOrg.Nodes.Count == 0)
                    {
                        TreeTransOrg = new Mode_TreeView();
                        TreeTransOrg.CloneFrom(TreeTrans);
                    }
                    if (TreeTransResult == null) TreeTransResult = new Mode_TreeView();
                    TreeTransResult.Nodes.Add(DateTime.Now.ToString("hh:MM:ss") + " Result search for [" + txt + "]: ");
                   SearchNodes(TreeTransOrg.Nodes, txt);
                    TreeTrans.Nodes.Clear();                   
                    if (TreeTransResult.Nodes.Count != 0)                  
                        TreeTransResult.Nodes[TreeTransResult.Nodes.Count - 1].Text += TreeTransResult.Nodes[TreeTransResult.Nodes.Count - 1].Nodes.Count + " items.";
                    else TreeTransResult.Nodes[TreeTransResult.Nodes.Count - 1].Text += "No found items.";
                    TreeTrans.CloneFrom(TreeTransResult);
                    TreeTrans.Nodes[TreeTrans.Nodes.Count - 1].Expand();
                    TreeTrans.Update();
                    ShowLabelBack();
                }
                //if (TreeTransResult.Nodes.Count != 0)
                //{ 
                //    TreeTrans.Nodes.Clear();
                //    foreach (TreeNode node in TreeTransResult.Nodes)
                //    { TreeTrans.Nodes.Add(node); }
                //    TreeTrans.Update();
                //}
            }
            catch(Exception ex)
            { 

            }
        }
        private void SearchNodes(TreeNodeCollection nodes,string txt)
        {
            try
            {               
                foreach (TreeNode node in nodes)
                {
                    if (node.Tag is Transaction)
                    {
                        if (txt.Split(FieldSplit).Where(x => (node.Tag as Transaction).TraceJournalFull.Contains(x)).ToList().Count != 0)
                            TreeTransResult.Nodes[TreeTransResult.Nodes.Count-1].Nodes.Add(node);
                    }
                    else if (node.Tag is TransactionEvent)
                    {
                        if ((node.Tag as TransactionEvent).TContent.Contains(txt))
                            TreeTransResult.Nodes[TreeTransResult.Nodes.Count - 1].Nodes.Add(node);
                    }
                    else if (node.Nodes.Count != 0)
                        SearchNodes(node.Nodes, txt);
                }
            }
            catch(Exception ex)
            { }         
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
   private void ShowLabelBack()
        {
            try
            {
                if (lb_Back == null)
                {
                    lb_Back = new Mode_Label();
                    lb_Back.Text = "<< Back";
                    lb_Back.BackColor = Color.Transparent;
                    lb_Back.AutoSize = false;
                    lb_Back.BackColor = System.Drawing.Color.Transparent;
                    lb_Back.Cursor = System.Windows.Forms.Cursors.Hand;
                    lb_Back.ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
                    lb_Back.Size = new System.Drawing.Size(50, 17);
                    lb_Back.Location = new Point(TreeTrans.Width - 69, 5);
                    lb_Back.MouseEnter += new System.EventHandler(ShowLabelBack_Enter);
                    lb_Back.MouseLeave += new System.EventHandler(ShowLabelBack_Leave);
                    lb_Back.MouseHover += new System.EventHandler(ShowLabelBack_Enter);
                    lb_Back.Click += new System.EventHandler(BackListOgrinal);
                    TreeTrans.Controls.Add(lb_Back);
                }
                else
                    lb_Back.Visible = true;
            }
            catch
            { }
        }
        private void ShowLabelBack_Leave(object sender, EventArgs e)
        {
                lb_Back.ForeColor= InitGUI.Custom.Menu_Text.DisplayColor;
        }
        private void ShowLabelBack_Enter(object sender, EventArgs e)
        {
                lb_Back.ForeColor = Color.Blue;
        }
        private void BackListOgrinal(object sender, EventArgs e)
        {
            if (TreeTransOrg.Nodes.Count != 0)
            {
                TreeTrans.CloneFrom(TreeTransOrg);
                TreeTransOrg.Nodes.Clear();
                lb_Back.Visible = false;
            }
        }
    }
    
}
