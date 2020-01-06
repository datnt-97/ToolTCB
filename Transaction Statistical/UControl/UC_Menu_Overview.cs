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
using System.Management;
using System.IO;

namespace Transaction_Statistical.UControl
{
    public partial class UC_Menu_Overview : UserControl
    {
        Mode_Button bt_Custom;
        Frm_TemplateDefault frm_Access;
        public UC_Menu_Overview()
        {
            InitializeComponent2();
            LoadInfo();
            BackgroundWorker bgwDriveDetector = new BackgroundWorker();
            bgwDriveDetector.DoWork += bgwDriveDetector_DoWork;
            bgwDriveDetector.RunWorkerAsync();
            bgwDriveDetector.WorkerReportsProgress = true;
            bgwDriveDetector.WorkerSupportsCancellation = true;
            CheckUSBKey();
            SetControlAdmin();
        }
        public void LoadInfo()
        {
            try
            {
                bt_Custom.Visible = false;
                if (InitGUI.Mode == InitGUI_Mode.Dark) rd_Mode_Dark.Checked = true;
                else if (InitGUI.Mode == InitGUI_Mode.Light) rd_Mode_Ligh.Checked = true;
                else
                {
                    rd_Mode_Custom.Checked = true;
                    bt_Custom.Visible = true;
                }
                rd_Mode_Dark.CheckedChanged += new System.EventHandler(Style_Select);
                rd_Mode_Ligh.CheckedChanged += new System.EventHandler(Style_Select);
                rd_Mode_Custom.CheckedChanged += new System.EventHandler(Style_Select);

                cbo_LstTemplate.Items.Clear();
                DataTable cfg_vendor = InitParametar.sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "60", "Parent_ID", "54");
                foreach (DataRow R in cfg_vendor.Rows)
                {
                    ComboBoxItem cb = new ComboBoxItem();
                    cb.Text = R["Field"].ToString();
                    cb.Value = R["ID"].ToString();                    
                    cbo_LstTemplate.Items.Add(cb);
                    // if (cb.Value.Equals(InitParametar.TemplateTransactionID.ToString())) cbo_LstTemplate.SelectedItem = cb;
                    if (cb.Text.EndsWith(@"(default)"))
                    {
                        cbo_LstTemplate.SelectedItem = cb;                      
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void Style_Select(object sender, EventArgs e)
        {
            if (!(sender as Mode_RadioButton).Checked) return;
            if ((sender as Mode_RadioButton).Text.Equals(InitGUI_Mode.Custom.ToString()))
                bt_Custom.Visible = true;
            else
                bt_Custom.Visible = false;
            if (InitParametar.sqlite.Update1Entry("CfgData", "Field", (sender as Mode_RadioButton).Text, "ID", "52"))
                MessageBox.Show("Update successfuly.\n You need restart application.", "Update style");
            else
                MessageBox.Show("Update unsuccessfuly", "Update style", MessageBoxButtons.OK, MessageBoxIcon.Error);
            InitGUI.Init();
        }
        private void SetControlAdmin()
        {
            try
            {
                if (InitParametar.Admin_Key || InitParametar.Admin_USB)
                {
                    gr_Admin.Visible = true; gr_Admin.Update();
                    btn_LogAdmin.Visible = false; btn_LogAdmin.Update();
                    if (frm_Access != null) frm_Access.Close();                   
                }
                else
                {
                    gr_Admin.Visible = false;
                    btn_LogAdmin.Visible = true;
                }              
            }
            catch { }
        }
        public bool AccessAdmin()
        {
            if (InitParametar.Admin_Key || InitParametar.Admin_USB) return true;
            try
            {
                UC_Access uc = new UC_Access();
                 frm_Access = new Frm_TemplateDefault(uc, "Access");
                frm_Access.ShowDialog();
                SetControlAdmin();
                return InitParametar.Admin_Key;
            }
            catch
            { }
            return false;
        }
        private void CheckUSBKey()
        {
            try
            {
                InitParametar.Admin_USB = false;
                foreach (KeyValuePair<string, string> usb in USBDevice.GetListUSB())
                {
                    if (USBDevice.IsUSBKey(usb.Key, usb.Value))
                    {
                        InitParametar.Admin_USB = true;
                        break;
                    }
                }
            }
            catch
            { }
        }
        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
            CheckUSBKey();
            UIHelper.UIThread(this, delegate { SetControlAdmin(); });
        }

        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
            string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
            CheckUSBKey();
            UIHelper.UIThread(this, delegate { SetControlAdmin(); });
        }

        void bgwDriveDetector_DoWork(object sender, DoWorkEventArgs e)
        {
            var insertQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
            var insertWatcher = new ManagementEventWatcher(insertQuery);
            insertWatcher.EventArrived += DeviceInsertedEvent;
            insertWatcher.Start();

            var removeQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
            var removeWatcher = new ManagementEventWatcher(removeQuery);
            removeWatcher.EventArrived += DeviceRemovedEvent;
            removeWatcher.Start();
        }
    
        private void btn_LogAdmin_Click(object sender, EventArgs e)
        {            
                if (!AccessAdmin()) return;               
        }

        private void btn_Edit_Custom_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AccessAdmin()) return;
                if (InitGUI.Custom.IsDisposed) InitGUI.Custom = new GUI_Custom();
                Frm_TemplateDefault frm = new Frm_TemplateDefault(InitGUI.Custom, "Edit Custom Template");
                frm.titleCustom.Text = "Edit Custom Template";
                frm.Show();
                Control ctr = this.Parent;
                while (ctr != null)
                    if (ctr is UC_Menu) { (ctr as UC_Menu).SlideMenuShow(); break; }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AccessAdmin()) return;
                ComboBoxItem cb_tmp = cbo_LstTemplate.SelectedItem as ComboBoxItem;
                UC_CfgTemplate ucCfgTemplate = new UC_CfgTemplate(cb_tmp.Value.ToString());
                ucCfgTemplate.Dock = DockStyle.Fill;
                Frm_TemplateDefault frm = new Frm_TemplateDefault(ucCfgTemplate, "Modify template [" + cb_tmp.Text + "]");
                frm.Show();
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem cb_tmp = cbo_LstTemplate.SelectedItem as ComboBoxItem;
                InitParametar.ReadTrans.TemplateTransactionID = cb_tmp.Value.ToString();
                InitParametar.ReadTrans.LoadTemplateInfo();
                if (!cb_tmp.Text.EndsWith(@"(default)"))
                {
                    DataTable cfg_vendor = InitParametar.sqlite.GetTableDataWith2ColumnName("CfgData", "Type_ID", "60", "Parent_ID", "54");
                    foreach (DataRow R in cfg_vendor.Rows)
                    {
                        if (R["Field"].ToString().EndsWith(@"(default)"))
                            InitParametar.sqlite.Update1Entry("CfgData", "Field", R["Field"].ToString().Replace(@"(default)", string.Empty), "ID", R["ID"].ToString());
                    }
                    InitParametar.sqlite.Update1Entry("CfgData", "Field", cb_tmp.Text + @"(default)", "ID", cb_tmp.Value.ToString());
                    LoadInfo();
                }
                MessageBox.Show("Apply completed.", "Apply template config");
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                MessageBox.Show("Apply fail.\n" + ex.Message, "Apply template config", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            if (!AccessAdmin()) return;
            UC_NewTemplate ucNew = new UC_NewTemplate();
            ucNew.Dock = DockStyle.Fill;
            Frm_TemplateDefault frm = new Frm_TemplateDefault(ucNew, "New template");
            frm.ShowDialog();
            LoadInfo();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem cb_tmp = cbo_LstTemplate.SelectedItem as ComboBoxItem;
                if (MessageBox.Show("Do you want delete [" + cb_tmp.Text + "]", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    InitParametar.sqlite.DeleteEntry("CfgData", "ID", cb_tmp.Value.ToString());
                    InitParametar.sqlite.DeleteEntry("CfgData", "Parent_ID", cb_tmp.Value.ToString());
                    InitParametar.sqlite.DeleteEntry("Transactions", "TemplateID", cb_tmp.Value.ToString());
                    MessageBox.Show("Delete [" + cb_tmp.Text + "] complited.", "Delete template config");
                    LoadInfo();
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                MessageBox.Show("Delete fail.\n" + ex.Message, "Delete template config", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        private void btn_CreateLicensing_Click(object sender, EventArgs e)
        {
            UC_Licensing uc = new UC_Licensing();
            Frm_TemplateDefault frm = new Frm_TemplateDefault(uc, "Licensing");
            frm.Show();
        }
        private void btn_CreateUSBKey_Click(object sender, EventArgs e)
        {
            UC_USBKey uc = new UC_USBKey();
            Frm_TemplateDefault frm = new Frm_TemplateDefault(uc, "USB Key");
            frm.Show();
        }
    }
}
