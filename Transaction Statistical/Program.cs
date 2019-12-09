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
            if (args.Length == 0)
            {               
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
              //  Application.Run(new Frm_LoadingApp());
                Application.Run(new Frm_Main());
            }
            else
            {
                //Auto start - not GUI

            }
        }
    }
}
