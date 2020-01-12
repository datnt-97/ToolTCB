using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Licensing : UserControl
    {
        public UC_Licensing()
        {
            InitializeComponent2();
            LoadInfo();
        }
        private void LoadInfo()
        {
            foreach (KeyValuePair<License.Types, string> key in License.ListType)
            {
                Mode_RadioButton rd = new Mode_RadioButton();
                rd.Text = key.Key.ToString();  
                gs_Type.AddControl = rd;
            }
            foreach (string s in Enum.GetNames(typeof(License.Modules)))
            {
                Mode_CheckBox rd = new Mode_CheckBox();
                rd.Text = s;
                gs_Module.AddControl = rd;
            }
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "License request|*.req";
                file.Title = "Open request";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    fctb_PublicKey.Text = File.ReadAllText(file.FileName);
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void btn_CreateFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "License |*.lic";
            saveFileDialog1.Title = "Save an License";
            saveFileDialog1.FileName = "TransactionStatistical.lic";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                License_Create(saveFileDialog1.FileName);
                if (File.Exists(saveFileDialog1.FileName))
                    MessageBox.Show("Create license successfuly.", "Create license");
            }
        }
        private bool License_Create(string LicenseFile)
        {
            try
            {
                if (File.Exists(LicenseFile)) File.Delete(LicenseFile);
                string content = string.Empty;
                foreach (Mode_RadioButton ctr in gs_Type.ControlsGroup)
                    if (ctr.Checked)
                        content = ctr.Text + '' + txt_SID.Text + '';
                DateTime dt = DateTime.Now;
                if (cbb_Date.Text.Equals("Days"))
                    dt = DateTime.Now.AddDays((double)nup_Day.Value);
                else if(cbb_Date.Text.Equals("Months"))
                    dt = DateTime.Now.AddMonths((int)nup_Day.Value);
                else
                    dt = DateTime.Now.AddYears((int)nup_Day.Value);
                foreach (Mode_CheckBox chk in gs_Module.ControlsGroup)
                    if (chk.Checked)
                        content += DateTime.Now.ToString(License.FormatDate) + '' + dt.ToString(License.FormatDate) + '' + chk.Text + '';
                content = content.TrimEnd('') + '' + DateTime.Now.ToString(License.FormatDateAccess);

                using (StreamWriter sw = new StreamWriter(LicenseFile, true))
                {
                    sw.WriteLine(ManagedAes.Encrypt(content, InitParametar.prKey));
                    sw.Flush();
                    sw.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name); ;
            }
            return false;
        }
        private void btn_ReadInfo_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Company.Text = txt_Email.Text = txt_Name.Text = txt_Phone.Text = txt_SID.Text = string.Empty;
                string s = ManagedAes.Decrypt(fctb_PublicKey.Text, InitParametar.prKey);

                foreach (string file in s.Split('\n'))
                    switch (file.Substring(0,file.IndexOf(':')))
                    {
                        case "Type":
                            foreach (Mode_RadioButton ctr in gs_Type.ControlsGroup)
                                if (ctr.Text.Equals(file.Substring(file.IndexOf(':') + 1).Trim())) ctr.Checked = true;
                            break;
                        case "Modules":
                            foreach (Mode_CheckBox chk in gs_Module.ControlsGroup)
                                if (file.Substring(file.IndexOf(':')+1).Contains(chk.Text)) chk.Checked = true;
                            break;
                        case "Duration":
                            nup_Day.Value = decimal.Parse(file.Substring(file.IndexOf(':') + 1).Trim().Split(' ')[0].Trim());
                            cbb_Date.Text = file.Substring(file.IndexOf(':')+1).Trim().Split(' ')[1];
                            break;
                        case "Company":
                            txt_Company.Text = file.Substring(file.IndexOf(':')+1).Trim();
                            break;
                        case "Name":
                            txt_Name.Text = file.Substring(file.IndexOf(':')+1).Trim();
                            break;
                        case "Email":
                            txt_Email.Text = file.Substring(file.IndexOf(':')+1).Trim();
                            break;
                        case "Phone":
                            txt_Phone.Text = file.Substring(file.IndexOf(':')+1).Trim();
                            break;                        
                        case "SID":
                            txt_SID.Text = file.Substring(file.IndexOf(':')+1).Trim();
                            break;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption error.\n" + ex.Message, "Decryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
