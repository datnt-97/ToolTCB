using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Threading;
using System.IO;

namespace Transaction_Statistical
{
    public partial class UC_Access : UserControl
    {
        public UC_Access()
        {
            InitializeComponent2();
            this.txt_PrKey.Select();
        }
          private void txt_PrKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_OK_Click(null, null);
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_PrKey.Text.Equals(InitParametar.prKey))
            {
                InitParametar.Admin_Key = true;
                this.ParentForm.Close();
            }
            txt_PrKey.BackColor = Color.OrangeRed;
        }
    }
}
