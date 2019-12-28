using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical
{
    enum InitGUI_Mode
    {
        Dark,
        Light, 
        Custom
    }
    class InitGUI
    {
        public static InitGUI_Mode Mode = InitGUI_Mode.Light;
        public static UControl.GUI_Custom Custom = new UControl.GUI_Custom();
       
        public static void Init()
        {
            DataRow row = InitParametar.sqlite.GetRowDataWithColumnName("CfgData", "ID", "52");
            if (row["Field"].ToString().Equals(InitGUI_Mode.Light.ToString()))
            {
                Mode = InitGUI_Mode.Light;
                Custom.Frm_TopToolbar.DisplayColor = Color.FromArgb(20, 120, 240); //Color.FromArgb(240, 240, 240);
                Custom.Frm_Background.DisplayColor = Color.White;
                Custom.Frm_Border.DisplayColor = Color.Green;
                Custom.Frm_TextTilte.DisplayColor = Color.DimGray;
                Custom.Frm_ForeColor.DisplayColor = Color.Black;

                Custom.Editor_Background.DisplayColor = Color.FromArgb(240, 240, 240);
                Custom.Editor_ForeColor.DisplayColor = Color.Black;
                Custom.Editor_Border.DisplayColor = Color.Black;

                Custom.Menu_Border.DisplayColor = Color.YellowGreen;
                Custom.Menu_Button.DisplayColor = Color.YellowGreen;
                Custom.Menu_ButtonHover.DisplayColor = Color.LightGreen;
                Custom.Menu_ButtonDown.DisplayColor = Color.LimeGreen;
                Custom.Menu_LeftBckgd.DisplayColor = Color.BlanchedAlmond;
                Custom.Menu_RightBckgd.DisplayColor = Color.White;
                Custom.Menu_Text.DisplayColor = Color.Black;

                Custom.Trans_Background.DisplayColor = Color.White;
                Custom.Trans_Border.DisplayColor = Color.DarkGray;
                Custom.Trans_Terminal.DisplayColor = Color.Black;
                Custom.Trans_Day.DisplayColor = Color.Black;
                Custom.Trans_Transaction.DisplayColor = Color.Black;
                Custom.Trans_Event.DisplayColor = Color.Black;
                Custom.Trans_Cycle.DisplayColor = Color.Black;

                Custom.TranInfo_Background.DisplayColor =Color.FromArgb(240, 240, 240);
                Custom.TranInfo_Border.DisplayColor = Color.SkyBlue;
                Custom.TranInfo_Text.DisplayColor = Color.FromArgb(128, 128, 0);
                Custom.TranInfo_Tilte.DisplayColor = Color.FromArgb(0, 166, 166);

                Custom.Cycle_Background.DisplayColor = Color.FromArgb(240, 240, 240); 
                Custom.Cycle_Border.DisplayColor = Color.SkyBlue;
                Custom.Cycle_Text.DisplayColor = Color.Black;
                Custom.Cycle_Tilte.DisplayColor = Color.Black;

                Custom.Tab_sel_forecolor.DisplayColor = Color.FromArgb(0, 0, 0);
                Custom.Tab_Sel_Backcolor.DisplayColor = Color.YellowGreen;
                Custom.Tab_unsel_forecolor.DisplayColor = Color.DimGray;
                Custom.Tab_UnSel_Backcolor.DisplayColor = Color.FromArgb(0, 120, 240);
                Custom.Tab_MouseHvrColor.DisplayColor = Color.LightGreen;
                Custom.Tab_MouseClkColor.DisplayColor = Color.LimeGreen;
                Custom.Tab_Ribbon_Color.DisplayColor = Color.YellowGreen;
                Custom.Tab_CtrlPanel_Backcolor.DisplayColor = Color.FromArgb(40, 40, 40);
                Custom.Tab_CtrlButPanel_Backcolor.DisplayColor = Color.FromArgb(245, 245, 245);
            }
            else if (row["Field"].ToString().Equals(InitGUI_Mode.Dark.ToString()))
            {
                Mode = InitGUI_Mode.Dark;
                Custom.Frm_TopToolbar.DisplayColor = Color.FromArgb(37, 37, 38);
                Custom.Frm_Background.DisplayColor = Color.FromArgb(30, 30, 30);
                Custom.Frm_Border.DisplayColor = Color.Blue;
                Custom.Frm_TextTilte.DisplayColor = Color.White;
                Custom.Frm_ForeColor.DisplayColor = Color.White;

                Custom.Editor_Background.DisplayColor = Color.FromArgb(64, 64, 64);
                Custom.Editor_ForeColor.DisplayColor = Color.White;
                Custom.Editor_Border.DisplayColor = Color.Black;

                Custom.Menu_Border.DisplayColor = Color.Blue;
                Custom.Menu_Button.DisplayColor = Color.FromArgb(20, 120, 240);
                Custom.Menu_ButtonHover.DisplayColor = Color.DeepSkyBlue;
                Custom.Menu_ButtonDown.DisplayColor = Color.FromArgb(0, 98, 215);
                Custom.Menu_LeftBckgd.DisplayColor = Color.FromArgb(64, 64, 64);
                Custom.Menu_RightBckgd.DisplayColor = Color.FromArgb(37, 37, 38);
                Custom.Menu_Text.DisplayColor = Color.White;
                               
                Custom.Trans_Background.DisplayColor = Color.FromArgb(37, 37, 38);
                Custom.Trans_Border.DisplayColor = Color.DarkGray;               
                Custom.Trans_Terminal.DisplayColor = Color.White; 
                Custom.Trans_Day.DisplayColor = Color.White;
                Custom.Trans_Transaction.DisplayColor = Color.White;
                Custom.Trans_Event.DisplayColor = Color.White;
                Custom.Trans_Cycle.DisplayColor = Color.White;

                Custom.TranInfo_Background.DisplayColor = Color.FromArgb(64, 64, 64);
                Custom.TranInfo_Border.DisplayColor = Color.SkyBlue;
                Custom.TranInfo_Text.DisplayColor = Color.FromArgb(128, 128, 0);
                Custom.TranInfo_Tilte.DisplayColor = Color.FromArgb(0, 166, 166);

                Custom.Cycle_Background.DisplayColor = Color.FromArgb(64, 64, 64);
                Custom.Cycle_Border.DisplayColor = Color.SkyBlue;
                Custom.Cycle_Text.DisplayColor = Color.White;
                Custom.Cycle_Tilte.DisplayColor = Color.White;

                Custom.Tab_sel_forecolor.DisplayColor = Color.FromArgb(255, 255, 255);
                Custom.Tab_Sel_Backcolor.DisplayColor = Color.FromArgb(20, 120, 240);
                Custom.Tab_unsel_forecolor.DisplayColor = Color.FromArgb(196, 196, 196);
                Custom.Tab_UnSel_Backcolor.DisplayColor = Color.FromArgb(0, 120, 240);
                Custom.Tab_MouseHvrColor.DisplayColor = Color.FromArgb(20, 120, 240);
                Custom.Tab_MouseClkColor.DisplayColor = Color.FromArgb(20, 80, 200);
                Custom.Tab_Ribbon_Color.DisplayColor = Color.FromArgb(20, 120, 240);
                Custom.Tab_CtrlPanel_Backcolor.DisplayColor = Color.FromArgb(40, 40, 40);
                Custom.Tab_CtrlButPanel_Backcolor.DisplayColor = Color.FromArgb(30, 30, 30);
            }
            else
            {
                Mode = InitGUI_Mode.Custom;
                DataTable tb = InitParametar.sqlite.GetTableDataWithColumnName("CfgData", "Parent_ID", "52");

                foreach (DataRow r in tb.Rows)
                {
                    switch (r["Field"])
                    {
                        // Form
                        case "Frm_Background":
                            Custom.Frm_Background.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Frm_TopToolbar":
                            Custom.Frm_TopToolbar.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Frm_Border":
                            Custom.Frm_Border.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Frm_TextTilte":
                            Custom.Frm_TextTilte.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Frm_ForeColor":
                            Custom.Frm_ForeColor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                            //Editor
                        case "Editor_Background":
                            Custom.Editor_Background.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Editor_ForeColor":
                            Custom.Editor_ForeColor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Editor_Border":
                            Custom.Editor_Border.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                            //Menu 
                        case "Menu_Border":
                            Custom.Menu_Border.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Menu_Button":
                            Custom.Menu_Button.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Menu_ButtonHover":
                            Custom.Menu_ButtonHover.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Menu_ButtonDown":
                            Custom.Menu_ButtonDown.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Menu_LeftBckgd":
                            Custom.Menu_LeftBckgd.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Menu_RightBckgd":
                            Custom.Menu_RightBckgd.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Menu_Text":
                            Custom.Menu_Text.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        //Treeview
                        case "Trans_Background":
                            Custom.Trans_Background.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Trans_Border":
                            Custom.Trans_Border.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Trans_Terminal":
                            Custom.Trans_Terminal.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Trans_Day":
                            Custom.Trans_Day.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Trans_Transaction":
                            Custom.Trans_Transaction.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Trans_Event":
                            Custom.Trans_Event.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Trans_Cycle":
                            Custom.Trans_Cycle.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        //TransactionInfo
                        case "TranInfo_Background":
                            Custom.TranInfo_Background.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "TranInfo_Border":
                            Custom.TranInfo_Border.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "TranInfo_Text":
                            Custom.TranInfo_Text.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "TranInfo_Tilte":
                            Custom.TranInfo_Tilte.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;                            
                        //Cycle
                        case "Cycle_Background":
                            Custom.Cycle_Background.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Cycle_Border":
                            Custom.Cycle_Border.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Cycle_Text":
                            Custom.Cycle_Text.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Cycle_Tilte":
                            Custom.Cycle_Tilte.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        //Tab Control
                        case "Tab_sel_forecolor":
                            Custom.Tab_sel_forecolor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Tab_Sel_Backcolor":
                            Custom.Tab_Sel_Backcolor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Tab_unsel_forecolor":
                            Custom.Tab_unsel_forecolor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Tab_UnSel_Backcolor":
                            Custom.Tab_UnSel_Backcolor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Tab_MouseHvrColor":
                            Custom.Tab_MouseHvrColor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Tab_MouseClkColor":
                            Custom.Tab_MouseClkColor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Tab_Ribbon_Color":
                            Custom.Tab_Ribbon_Color.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Tab_CtrlPanel_Backcolor":
                            Custom.Tab_CtrlPanel_Backcolor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                        case "Tab_CtrlButPanel_Backcolor":
                            Custom.Tab_CtrlButPanel_Backcolor.DisplayColor = GetColorFromString(r["Data"].ToString());
                            break;
                    }
                }
            }
        }

        private static Color GetColorFromString(string input)
        {
            Color result = Color.FromArgb(0, 0, 0, 0);
            if (input.StartsWith("#"))
            {
                try
                {
                    int red = Convert.ToInt32(input.Substring(1, 2), 16);
                    int green = Convert.ToInt32(input.Substring(3, 2), 16);
                    int blue = Convert.ToInt32(input.Substring(5, 2), 16);
                    result = Color.FromArgb(red, green, blue);
                }
                catch
                {

                }
            }
            else if (input.StartsWith("ff"))
            {
                try
                {
                    int red = Convert.ToInt32(input.Substring(2, 2), 16);
                    int green = Convert.ToInt32(input.Substring(4, 2), 16);
                    int blue = Convert.ToInt32(input.Substring(6, 2), 16);
                    result = Color.FromArgb(red, green, blue);
                }
                catch
                {

                }
            }
            else
            {
                result = Color.FromName(input);
            }
            return result;
        }
    }
    public class Mode_Button : Button
    {
        private static Font _normalFont = new Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public Mode_Button() : base()
        {
            base.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            base.FlatAppearance.MouseDownBackColor = InitGUI.Custom.Menu_ButtonDown.DisplayColor;
            base.FlatAppearance.MouseOverBackColor = InitGUI.Custom.Menu_ButtonHover.DisplayColor;
            base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            base.UseVisualStyleBackColor = true;     
        }
    }
    public class Mode_RadioButton : RadioButton
    {
        public Mode_RadioButton() : base()
        {
            base.BackColor = Color.Transparent;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }
    }
    public class Mode_Label : Label
    {
        public Mode_Label() : base()
        {
            base.BackColor = Color.Transparent;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }
    }
    public class Mode_GroupBox : GroupBox
    {
        FlowLayoutPanel pn;
        public Mode_GroupBox() : base()
        {
            base.BackColor = Color.Transparent;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
            pn = new FlowLayoutPanel();
        }
      //  public Control AddControl
      //  {            
      //      set { pn.Controls.Add(value); }
      //  }
      //public ControlCollection Controls
      //  {
      //      get { return pn.Controls; }
      //  }
    }
    public class Mode_Panel : Panel
    {
        public Color BorderColor { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            //using (SolidBrush brush = new SolidBrush(BackColor))
            //    e.Graphics.FillRectangle(brush, ClientRectangle);
            if (BorderColor != null)
            {
                this.BorderStyle = BorderStyle.None;
                e.Graphics.DrawRectangle(new Pen(BorderColor, 1), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }
        }    
        public Mode_Panel() : base()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            base.BackColor = Color.Transparent;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }
    }
    public class Mode_TreeView : TreeView
    {
        public Mode_TreeView() : base()
        {
            base.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }       
    }
    public class Mode_ComboBox : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    // Uncomment this if you don't want the "highlight border".
                   
                    using (var p = new Pen(this.BorderColor, 1))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                    }
                    //using (var p = new Pen(this.BorderColor, 2))
                    //{
                    //    g.DrawRectangle(p, 2, 2, Width - buttonWidth - 4, Height - 4);
                    //}
                    
                }
            }
        }
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "DimGray")]
        public Color BorderColor { get; set; }
        public Mode_ComboBox() : base()
        {
            BorderColor = InitGUI.Custom.Menu_Border.DisplayColor;
            base.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }
    }
    public class Mode_DateTimePicker :  DateTimePicker
    {
        public Mode_DateTimePicker() : base()
        {
            base.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }
    }
    public class Mode_TextBox : TextBox
    {
        public Mode_TextBox() : base()
        {
            base.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }

        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);
        private const int WM_NCPAINT = 0x85;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT && this.Focused)
            {
                var dc = GetWindowDC(Handle);
                using (Graphics g = Graphics.FromHdc(dc))
                {
                    g.DrawRectangle(new Pen(SystemColors.Highlight,1), 0, 0, Width - 1, Height - 1);
                }
            }
        }
    }
    public class Mode_CheckBox : CheckBox
    {
        public Mode_CheckBox() : base()
        {
            base.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }
    }
    public class Mode_FastColoredTextBox : FastColoredTextBoxNS.FastColoredTextBox
    {
        public Mode_FastColoredTextBox() : base()
        {
            base.BackColor = InitGUI.Custom.Editor_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Editor_ForeColor.DisplayColor;
            base.IndentBackColor = Color.FromArgb(196, 196, 196);
            this.Margin = new Padding(10);
          //  if (BorderColor != null) SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
        public Color BorderColor { get; set; }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (BorderColor != null)
            {
                e.Graphics.DrawRectangle(new Pen(BorderColor, 1), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }
        }

    }
    public class Mode_CheckedListBox : CheckedListBox
    {
        public Mode_CheckedListBox() : base()
        {
            base.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }
    }
    public class Mode_ListView : ListView
    {
        public Mode_ListView() : base()
        {
            base.BackColor = InitGUI.Custom.Frm_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }
    }
    public class Mode_DataGridView : DataGridView
    {
        public Mode_DataGridView() : base()
        {
            base.BackgroundColor = InitGUI.Custom.Frm_Background.DisplayColor;
            base.ForeColor = InitGUI.Custom.Frm_ForeColor.DisplayColor;
        }
    }
}
