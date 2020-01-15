using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical.Frm
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            Test1();
        }
        private void Test1()
        {
            string[] coloursArr = { "Red", "Green", "Black",
                                "White", "Orange", "Yellow",
                                "Blue", "Maroon", "Pink", "Purple" };

            for (int i = 0; i < coloursArr.Length; i++)
            {
                CCBoxItem item = new CCBoxItem(coloursArr[i], i);
                checkedComboBox3.Items.Add(item);
            }
        }

    }
}
