using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical
{
    static class Program
    {
        public static bool isMinimize = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {            
          //    args = new string[] { "TanySmile", "weekly" };
            if (args.Length == 0)
            {
                InitParametar.CurrentUser = Environment.UserName;
                InitParametar.Init();              
                Application.EnableVisualStyles();
                InitGUI.Mode = InitGUI_Mode.Light;
                InitGUI.Init();
                InitGUI.frm_Main = new Frm_Main();
                Application.Run(InitGUI.frm_Main);
            }
            else
            {
                //Auto start - not GUI    
                InitParametar.AutoRunMode = true;
                InitParametar.CurrentUser = args[0];
                InitParametar.Init();
                if (args.Length == 2)
                    InitParametar.AutoStart(args[1]);
            }
        }
    }
}
