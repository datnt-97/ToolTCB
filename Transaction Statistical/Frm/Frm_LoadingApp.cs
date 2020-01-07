using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical
{

    public partial class Frm_LoadingApp : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Frm_LoadingApp()
        {
            InitializeComponent();
            SetAndStartTimer();
        }

        Timer timer = new Timer();
        private void SetAndStartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        static int count = 0;
        void timer_Tick(object sender, EventArgs e)
        {
            count += 2;
            UIHelper.UIThread(this, delegate { label1.Text = "Processing... (" + count + "%)"; });
            if(count==100)
            {
                timer.Stop();
                this.Close();
            }
        }
        private void bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Program.isMinimize = true;
        }

        private void Frm_LoadingApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true; 
                dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            }
            else
                dragging = false;

           
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Frm_LoadingApp_Activated(object sender, EventArgs e)
        {
            if(Program.isMinimize)
            {
                Program.isMinimize = false;
            }
        }
    }
}
