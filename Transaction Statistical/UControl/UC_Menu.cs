using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Menu : UserControl
    {
        UC_Menu_Overview ucOVerview;
        bool runningShowMenu = false;
        bool showMenu = false;
        public UC_Menu()
        {
            InitializeComponent();
           addUserCfg();          
        }
        public UC_Menu(Control _Parent)
        {
            InitializeComponent();
            addUserCfg();
            this.BackColor = System.Drawing.Color.Transparent;
            this.Location = new System.Drawing.Point(-10000, 100); 
          //  this.Location = new Point(-this.Width, this.Location.Y);
            this.Size = new System.Drawing.Size(1066, 568);
            _Parent.Controls.Add(this);
            this.BringToFront();
            this.SendToBack();
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
            ucOVerview = new UC_Menu_Overview();
            ucOVerview.Width = this.Width - 1 - pnl_Menu.Width;
            ucOVerview.Height = this.Height - 2;
            ucOVerview.Location = new Point(pnl_Menu.Width, 1);
            ucOVerview.TabIndex = btn_Overview.TabIndex;
            this.Controls.Add(ucOVerview);

            UC_Menu_Dashboard ucDashboard = new UC_Menu_Dashboard();
            ucDashboard.Width = this.Width - 1 - pnl_Menu.Width;
            ucDashboard.Height = this.Height - 2;
            ucDashboard.Location = new Point(pnl_Menu.Width, 1);
            ucDashboard.TabIndex = btn_Dashboard.TabIndex;
            this.Controls.Add(ucDashboard);

            UC_Menu_Startup ucStartup = new UC_Menu_Startup();
            ucStartup.Width = this.Width - 1 - pnl_Menu.Width;
            ucStartup.Height = this.Height - 2;
            ucStartup.Location = new Point(pnl_Menu.Width, 1);
            ucStartup.TabIndex = btn_Startup.TabIndex;
            this.Controls.Add(ucStartup);
        }

        private void menu_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as AddOn.ButtonZ).BZBackColor = (sender as AddOn.ButtonZ).BackColor = Color.FromArgb(20, 120, 240);
            foreach (Control ctr in pnl_Menu.Controls)
            {
                if (ctr.TabIndex != (sender as AddOn.ButtonZ).TabIndex && ctr is AddOn.ButtonZ)
                {
                    (ctr as AddOn.ButtonZ).BZBackColor = Color.FromArgb(64, 64, 64);
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
    }
}
