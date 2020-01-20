using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

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
            try
            {
                MailMessage mail = editor.ToMailMessage();
                mail.Subject = InitParametar.STitle + "\\Feedback from " + txt_From.Text + " - " + txt_Title.Text;
                if (MailUtility.SendMail(mail))
                    MessageBox.Show("Send feedback successfuly.", "send feedback");
                else
                    MessageBox.Show("Send feedback fail.", "send feedback",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch
            { }
        }
    }
}
