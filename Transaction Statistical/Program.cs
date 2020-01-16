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
            InitParametar.Init();
            //  args = new string[] { "AutoStart" };
            if (args.Length == 0)
            {
              //  InitGUI.Init();
                Application.EnableVisualStyles();
             //   Application.SetCompatibleTextRenderingDefault(false);
                InitGUI.Mode = InitGUI_Mode.Light;
                InitGUI.Init();
                Application.Run(new Frm_Main());
            }
            else
            {
                //Auto start - not GUI               
                InitParametar.AutoStart(args[0]);
            }
        }
    }
}
