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
using System.Threading;
using System.IO;

namespace Transaction_Statistical.UControl
{
    public partial class UC_ExportCus : UserControl
    {
        UC_Explorer uc_Explorer;
        public UC_ExportCus()
        {
            InitializeComponent2();
            LoadTemplate();
            LoadPathTemp(true);
        }
        private void LoadPathTemp(bool isLoad)
        {
            try
            {
                UtilityIniFile fini = new UtilityIniFile(InitParametar.PathDirectoryCurrentUserConfigData + "\\AppConfig.dat");
                if (isLoad)
                {
                    txt_Destination.Text = fini.GetEntryValue("Directory", "FolderTempExport");
                    if (Directory.Exists(txt_Destination.Text) || File.Exists(txt_Destination.Text)) return;
                    txt_Destination.Text = "D:\\";
                }
                else
                {
                    fini.Write("FolderTempExport", txt_Destination.Text, "Directory");
                }
            }
            catch { }
        }
        private void InitializeComponent2()
        {
            this.label7 = new Transaction_Statistical.Mode_Label();
            this.ckbl_Forms = new Transaction_Statistical.Mode_CheckedListBox();
            this.label3 = new Transaction_Statistical.Mode_Label();
            this.txt_Destination = new Transaction_Statistical.Mode_TextBox();
            this.chb_Open = new Transaction_Statistical.Mode_CheckBox();
            this.btn_Read = new Transaction_Statistical.AddOn.ButtonZ();
            this.prb_Process = new Transaction_Statistical.TextProgressBar();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Forms select";
            // 
            // ckbl_Forms
            // 
            this.ckbl_Forms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ckbl_Forms.CheckOnClick = true;
            this.ckbl_Forms.FormattingEnabled = true;
            this.ckbl_Forms.Location = new System.Drawing.Point(156, 39);
            this.ckbl_Forms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbl_Forms.Name = "ckbl_Forms";
            this.ckbl_Forms.Size = new System.Drawing.Size(559, 87);
            this.ckbl_Forms.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Export destination";
            // 
            // txt_Destination
            // 
            this.txt_Destination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Destination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_Destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Destination.Location = new System.Drawing.Point(156, 12);
            this.txt_Destination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(559, 22);
            this.txt_Destination.TabIndex = 28;
            this.txt_Destination.Text = @"D:\";
            this.txt_Destination.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Path_MouseEnter);
            // 
            // chb_Open
            // 
            this.chb_Open.AutoSize = true;
            this.chb_Open.Checked = true;
            this.chb_Open.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_Open.Location = new System.Drawing.Point(579, 193);
            this.chb_Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_Open.Name = "chb_Open";
            this.chb_Open.Size = new System.Drawing.Size(135, 21);
            this.chb_Open.TabIndex = 34;
            this.chb_Open.Text = "Open after finish";
            this.chb_Open.UseVisualStyleBackColor = true;
            // 
            // btn_Read
            // 
            this.btn_Read.BorderLeft = false;
            this.btn_Read.BZBackColor = InitGUI.Custom.Menu_Button.DisplayColor;
            this.btn_Read.DisplayText = "Export";
            this.btn_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Read.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = System.Drawing.Color.White;
            this.btn_Read.Location = new System.Drawing.Point(156, 148);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Read.MouseClickColor1 = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            this.btn_Read.MouseHoverColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.NotchangeAfterMouseUP = false;
            this.btn_Read.Size = new System.Drawing.Size(560, 28);
            this.btn_Read.TabIndex = 36;
            this.btn_Read.Text = "Export";
            this.btn_Read.TextLocation_X = 180;
            this.btn_Read.TextLocation_Y = -3;
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // prb_Process
            // 
            this.prb_Process.CustomText = "Export start..";
            this.prb_Process.Location = new System.Drawing.Point(3, 212);
            this.prb_Process.Maximum = 1000;
            this.prb_Process.Name = "prb_Process";
            this.prb_Process.ProgressColor = this.btn_Read.BZBackColor;
            this.prb_Process.Size = new System.Drawing.Size(0, 0);
            this.prb_Process.Step = 1;
            this.prb_Process.TabIndex = 0;
            this.prb_Process.TextColor = System.Drawing.Color.White;
            this.prb_Process.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.prb_Process.VisualMode = Transaction_Statistical.ProgressBarDisplayMode.TextAndPercentage;
            // 
            // UC_ExportCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            this.Controls.Add(this.prb_Process);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.chb_Open);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ckbl_Forms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Destination);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_ExportCus";
            this.Size = new System.Drawing.Size(751, 249);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void LoadTemplate(bool isLoad)
        {
            try
            {
                prb_Process.Location = btn_Read.Location;
                prb_Process.ProgressColor = btn_Read.BZBackColor;
                uc_Explorer = new UC_Explorer();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = UC_Menu_Startup.Template;
                ckbl_Forms.DataSource = bindingSource;
                ckbl_Forms.DisplayMember = "Value";
                UC_Menu_Startup.Template.ToList().ForEach(x => { ckbl_Forms.SetItemChecked(x.Key, true); });

            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }

        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                prb_Process.Size = btn_Read.Size;

                Dictionary<int, string> TemplateChoosen = new Dictionary<int, string>();
                foreach (var item in ckbl_Forms.CheckedItems)
                {
                    var row = (KeyValuePair<int, string>)(item);
                    TemplateChoosen.Add(row.Key, row.Value);
                }
                if (!Directory.Exists(txt_Destination.Text))
                {
                    MessageBox.Show("Folder not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                prb_Process.Maximum = TemplateChoosen.Count();
                prb_Process.Value = 0;
                prb_Process.Step = 1;
                var w = System.Diagnostics.Stopwatch.StartNew();
                w.Start();
                if (InitParametar.ReadTrans.Export(txt_Destination.Text, TemplateChoosen, prb_Process))
                {
                    w.Stop();
                    MessageBox.Show("Export successfully. (Execute : " + (w.ElapsedMilliseconds).ToString() + " ms)", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (chb_Open.Checked)
                        new Thread(() => UC_Explorer.OpenFile(InitParametar.ReadTrans.FileExport, false)).Start();
                    //(this.Parent as Form).Close();
                }
            }
            catch (Exception ex ){ 
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            prb_Process.Size = new Size(0, 0);
            LoadPathTemp(false);
        }

        private void chb_Open_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_Path_MouseEnter(object sender, MouseEventArgs e)
        {
            uc_Explorer.ShowFromControl(this, sender as Control);
        }
    }
}
