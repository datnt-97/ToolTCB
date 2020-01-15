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
    public partial class UC_Feedback : UserControl
    {
        AddOn.EditorHTML editor;
        public UC_Feedback()
        {
            InitializeComponent();
            editor = new AddOn.EditorHTML();
            editor.Dock = DockStyle.Fill;
            this.cp_Editor.Controls.Add(editor);
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {

        }
    }
}
