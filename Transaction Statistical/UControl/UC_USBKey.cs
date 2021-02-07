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
    public partial class UC_USBKey : UserControl
    {
        public UC_USBKey()
        {
            InitializeComponent2();
            LoadUSB();
        }
        private void LoadUSB()
        {
                foreach (KeyValuePair<string, string> usb in USBDevice.GetListUSB())             
                    AddButtonUSB(usb.Key + usb.Value, USBDevice.IsUSBKey(usb.Key, usb.Value));
           
        }
        private void AddButtonUSB(string USB, bool isUSBKey)
        {
            //
            //btn_CreateUSBKey
            //
            Mode_Button btn_CreateUSBKey = new Mode_Button();
            btn_CreateUSBKey.AutoSize = false;
            btn_CreateUSBKey.BackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            btn_CreateUSBKey.Name = "btn_CreateUSBKey";
            btn_CreateUSBKey.Size = new System.Drawing.Size(this.mode_GroupBox1.Width - 8, 31);
            btn_CreateUSBKey.TabIndex = 17;
            btn_CreateUSBKey.Text = USB.Substring(0,2);
            btn_CreateUSBKey.TextAlign = ContentAlignment.MiddleLeft;
            btn_CreateUSBKey.Tag = USB;
            btn_CreateUSBKey.Click += new System.EventHandler(this.btn_CreateUSBKey_Click);
            this.mode_GroupBox1.AddControl = btn_CreateUSBKey;
            SetTextButton(btn_CreateUSBKey, btn_CreateUSBKey.Text, isUSBKey);

        }
        private void SetTextButton(Mode_Button btn,string usb, bool isUSBKey)
        {
            if (isUSBKey)
            {
                btn.BackColor = Color.Blue;
                btn.Text = usb + " USB key -> Disable USB Key";
            }
            else
            {
                btn.BackColor = Color.FromArgb(64, 64, 64);
                btn.Text = usb + " None USB Key -> Enable USB Key";
            }
        }
        private void btn_CreateUSBKey_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Mode_Button).BackColor == Color.Blue)
                {
                    File.Delete((sender as Mode_Button).Tag.ToString().Substring(0, 2) + USBDevice.path);
                    SetTextButton(sender as Mode_Button, (sender as Mode_Button).Tag.ToString().Substring(0, 2), false);
                }
                else
                {
                    if (!Directory.Exists((sender as Mode_Button).Tag.ToString().Substring(0, 2) + "\\BOOT")) CreateHiddenFolder( (sender as Mode_Button).Tag.ToString().Substring(0, 2) + "\\BOOT");
                    if (!Directory.Exists((sender as Mode_Button).Tag.ToString().Substring(0, 2) + "\\BOOT\\Support")) CreateHiddenFolder((sender as Mode_Button).Tag.ToString().Substring(0, 2) + "\\BOOT\\Support");
                 
                    File.WriteAllText((sender as Mode_Button).Tag.ToString().Substring(0, 2) + USBDevice.path, ManagedAes.Encrypt((sender as Mode_Button).Tag.ToString().Substring(2), InitParametar.prKey));
                    SetTextButton(sender as Mode_Button, (sender as Mode_Button).Tag.ToString().Substring(0, 2), true);
                }
            }
            catch(Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }


        private bool CreateHiddenFolder(string name)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(name);
                di.Create();
                di.Attributes |= FileAttributes.Hidden;
                return true;
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
         }


    }
}
