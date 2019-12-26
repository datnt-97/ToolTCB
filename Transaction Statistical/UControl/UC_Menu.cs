using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Menu : UserControl
    {
        UC_Menu_Overview ucOVerview;
        bool runningShowMenu = false;
        bool showMenu = false;
        public UC_Menu()
        {
            InitializeComponent2();
           addUserCfg();          
        }
        public UC_Menu(Control _Parent)
        {
            InitializeComponent2();
            addUserCfg();
            this.BackColor = System.Drawing.Color.Transparent;
            this.Location = new System.Drawing.Point(-10000, 100); 
          //  this.Location = new Point(-this.Width, this.Location.Y);
         
            _Parent.Controls.Add(this);           
            _Parent.Controls.SetChildIndex(this, 0);

            
        }
        public void SlideMenuShow()
        {
            if (showMenu) showMenu = false; else showMenu = true;
            if (runningShowMenu) return;
            runningShowMenu = true;
            while (runningShowMenu)
            {
                if (showMenu)
                {
                    this.Location = new Point(this.Location.X + 3, this.Location.Y);
                    if (this.Location.X >= 0) break;
                }
                else
                {
                    this.Location = new Point(this.Location.X - 3, this.Location.Y);
                    if (this.Location.X <= -this.Width) break;
                }
                this.Update();
            }
            runningShowMenu = false;
        }
       

        private void addUserCfg()
        {
            lv_Version.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\nCopyright © 2019, NPSS";
            ucOVerview = new UC_Menu_Overview();
            ucOVerview.Width = this.Width - 1 - pnl_Menu.Width;
            ucOVerview.Height = this.Height - 2;
            ucOVerview.Location = new Point(pnl_Menu.Width, 1);
            ucOVerview.TabIndex = btn_Overview.TabIndex;
            ucOVerview.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.Controls.Add(ucOVerview);

            UC_Menu_Dashboard ucDashboard = new UC_Menu_Dashboard();
            ucDashboard.Width = this.Width - 1 - pnl_Menu.Width;
            ucDashboard.Height = this.Height - 2;
            ucDashboard.Location = new Point(pnl_Menu.Width, 1);
            ucDashboard.TabIndex = btn_Dashboard.TabIndex;
            ucDashboard.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.Controls.Add(ucDashboard);

            UC_Menu_Startup ucStartup = new UC_Menu_Startup();
            ucStartup.Width = this.Width - 1 - pnl_Menu.Width;
            ucStartup.Height = this.Height - 2;
            ucStartup.Location = new Point(pnl_Menu.Width, 1);
            ucStartup.TabIndex = btn_Startup.TabIndex;
            ucStartup.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.Controls.Add(ucStartup);

            UC_Menu_History ucHistory = new UC_Menu_History();
            ucHistory.Width = this.Width - 1 - pnl_Menu.Width;
            ucHistory.Height = this.Height - 2;
            ucHistory.Location = new Point(pnl_Menu.Width, 1);
            ucHistory.TabIndex = btn_History.TabIndex;
            ucHistory.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.Controls.Add(ucHistory);

            UC_Menu_About ucAbout = new UC_Menu_About();
            ucAbout.Width = this.Width - 1 - pnl_Menu.Width;
            ucAbout.Height = this.Height - 2;
            ucAbout.Location = new Point(pnl_Menu.Width, 1);
            ucAbout.TabIndex = btn_About.TabIndex;
            ucAbout.BackColor = InitGUI.Custom.Menu_RightBckgd.DisplayColor;
            this.Controls.Add(ucAbout);
        }

        private void menu_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as AddOn.ButtonZ).BZBackColor = (sender as AddOn.ButtonZ).BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            foreach (Control ctr in pnl_Menu.Controls)
            {
                if (ctr.TabIndex != (sender as AddOn.ButtonZ).TabIndex && ctr is AddOn.ButtonZ)
                {
                    (ctr as AddOn.ButtonZ).BZBackColor = InitGUI.Custom.Menu_LeftBckgd.DisplayColor;
                    (ctr as AddOn.ButtonZ).Clicked = false;
                }
            }
            foreach(Control ctr in this.Controls)
            {
                if (ctr is UserControl)
                {
                    if (ctr.TabIndex == (sender as AddOn.ButtonZ).TabIndex)
                        ctr.Visible = true;
                    else
                        ctr.Visible = false;
                }
            }
        }

        private void buttonZ1_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as AddOn.ButtonZ).BZBackColor = Color.FromArgb(20, 120, 240);
        }
        private void mode_Label4_MouseHover(object sender, EventArgs e)
        {
            (sender as Mode_Label).ForeColor = Color.Blue;
        }

        private void mode_Label4_Leave(object sender, EventArgs e)
        {
            (sender as Mode_Label).ForeColor = InitGUI.Custom.Menu_Text.DisplayColor;
        }

        private void mode_Label8_MouseEnter(object sender, EventArgs e)
        {
            (sender as Mode_Label).ForeColor = Color.GreenYellow;
        }
    }
}
