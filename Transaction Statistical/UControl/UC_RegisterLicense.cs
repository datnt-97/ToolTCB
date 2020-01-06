using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Reflection;
using System.Net.Mail;

namespace Transaction_Statistical.UControl
{
    public partial class UC_RegisterLicense : UserControl
    {
        public UC_RegisterLicense()
        {
            InitializeComponent();
            LoadInfo();
        }
        private void LoadInfo()
        {
            foreach (KeyValuePair<License.Types, string> key in License.ListType)
            {
                Mode_RadioButton rd = new Mode_RadioButton();
                rd.Text = key.Key.ToString();
                gs_Type.AddControl = rd;
                rd.Checked = true;
            }
            foreach (string s in Enum.GetNames(typeof(License.Modules)))
            {
                Mode_CheckBox rd = new Mode_CheckBox();
                rd.Text = s;
                rd.Checked = true;
                gs_Module.AddControl = rd;
            }
            cbb_Date.Items.AddRange(License.Duration.Values.ToArray());
            cbb_Date.SelectedIndex = 0;
        }
        private bool CheckInfo()
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                txt_Name.BackColor = Color.OrangeRed;
                return false;
            }
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                txt_Email.BackColor = Color.OrangeRed;
                return false;
            }

            foreach (Control cb in gs_Module.ControlsGroup)
                if (cb is Mode_CheckBox && (cb as Mode_CheckBox).Checked) return true;
            gs_Module.BackColor= Color.OrangeRed; 
            return false;
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("Please, input information.", "Input info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string s = "Name: " + InitParametar.STitle;
                s += Environment.NewLine + "Version: " + InitParametar.Version;
                s += Environment.NewLine + "Type:";
                foreach (Control cb in gs_Type.ControlsGroup)
                    if (cb is Mode_RadioButton && (cb as Mode_RadioButton).Checked) s +=cb.Text;
                s += Environment.NewLine + "Modules: ";
                foreach (Control cb in gs_Module.ControlsGroup)
                    if (cb is Mode_CheckBox && (cb as Mode_CheckBox).Checked) s += cb.Text + ",";
                s = s.TrimEnd(',');
                s += Environment.NewLine + "Duration: " + cbb_Date.Text;
                s += Environment.NewLine + "Company: " + txt_Company.Text;
                s += Environment.NewLine + "Name: " + txt_Name.Text;
                s += Environment.NewLine + "Email: " + txt_Email.Text;
                s += Environment.NewLine + "Phone: " + txt_Phone.Text;
                string content = s;
                s += Environment.NewLine + "MAC: " + InitParametar.GetMacAddress();
                s += Environment.NewLine + "SID: " + InitParametar.GetComputerSid();
                s = ManagedAes.Encrypt(s, InitParametar.prKey);
                content += Environment.NewLine + "PublicKey: " + s;

                if (sender.Equals(btn_Send))
                {
                    DataRow tmpLic = InitParametar.sqlite.GetRowDataWithColumnName("CfgData", "ID", "877");
                    MailMessage mail = new MailMessage();                
                    mail.Body = content;
                    mail.Subject = tmpLic["Field"].ToString();
                    foreach (string add in tmpLic["Data"].ToString().Trim().Replace(',', ';').TrimEnd(';').TrimStart(';').Split(';'))
                        mail.To.Add(new MailAddress(add));
                    if (MailUtility.SendMail(mail))
                        MessageBox.Show("Send request license successfuly.", "Create request");
                }
                else
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "License request|*.req";
                    saveFileDialog1.Title = "Save an License request";
                    saveFileDialog1.FileName = "TransactionStatistical.req";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, s);
                        if (File.Exists(saveFileDialog1.FileName))
                            MessageBox.Show("Create request license successfuly.", "Create request");
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_Email.Text))
                {
                    foreach (string add in txt_Email.Text.Trim().TrimEnd(';').TrimEnd(',').TrimStart(';').TrimStart(',').Replace(',', ';').Split(';'))
                    { var eMailValidator = new System.Net.Mail.MailAddress(add); }
                }
                txt_Email.BackColor = this.BackColor;
            }
            catch
            {
                txt_Email.BackColor = Color.OrangeRed;
                txt_Email.Text = string.Empty;
            }
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            txt_Name.BackColor = this.BackColor;
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
