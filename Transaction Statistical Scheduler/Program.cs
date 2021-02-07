using System;
using System.Configuration.Install;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;

namespace Transaction_Statistical_Scheduler
{
    static class Program
    {
        public static ServiceBase[] ServicesToRun;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
         //   args = new string[] { "install" };
            // Initialize the service to start            
            ServicesToRun = new ServiceBase[] { new TransactionStatisticalScheduler() };
            
            // In interactive and debug mode ?
            if (Environment.UserInteractive)
            {
                // In debug mode ?
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    // Simulate the services execution
                    RunInteractiveServices(ServicesToRun);
                }
                else
                {
                    try
                    {
                        bool hasCommands = false;
                        // Having an install command ?
                        if (HasCommand(args, "install"))
                        {
                            //if (!WriteConfigReg())
                            //{
                            //    Console.WriteLine("Can't write registry !");
                            //    return;
                            //}
                            ManagedInstallerClass.InstallHelper(new String[] { typeof(Program).Assembly.Location });
                            hasCommands = true;
                        }
                        // Having an uninstall command ?
                        if (HasCommand(args, "uninstall"))
                        {
                            ManagedInstallerClass.InstallHelper(new String[] { "/u", typeof(Program).Assembly.Location });
                            hasCommands = true;
                        }
                        if (HasCommand(args, "debug"))
                        {
                            RunInteractiveServices(ServicesToRun);
                            hasCommands = true;
                        }
                        // If we don't have commands we print usage message
                        if (!hasCommands)
                        {
                            Console.WriteLine("Usage : {0} [command] [command ...]", Environment.GetCommandLineArgs());
                            Console.WriteLine("Commands : ");
                            Console.WriteLine(" - install : Install the services");
                            Console.WriteLine(" - uninstall : Uninstall the services");
                            Console.WriteLine(" - debug : Start debug");
                        }
                    }
                    catch (Exception ex)
                    {
                        var oldColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error : {0}", ex.GetBaseException().Message);
                        Console.ForegroundColor = oldColor;
                    }
                }
            }
            else
            {
                // Normal service execution
                ServiceBase.Run(ServicesToRun);
            }
        }
        /// <summary>
        /// Run services in interactive mode
        /// </summary>
        static void RunInteractiveServices(ServiceBase[] servicesToRun)
        {

            Console.WriteLine();
            Console.WriteLine("Start the services in interactive mode.");
            Console.WriteLine();

            // Get the method to invoke on each service to start it
            MethodInfo onStartMethod = typeof(ServiceBase).GetMethod("OnStart", BindingFlags.Instance | BindingFlags.NonPublic);

            // Start services loop
            foreach (ServiceBase service in servicesToRun)
            {
               // Console.Title = service.ServiceName;
                Console.Write("Starting {0} ... \n", service.ServiceName);
                onStartMethod.Invoke(service, new object[] { new string[] { } });
                Console.WriteLine("Started");
            }

         //   // Waiting the end
         //   Console.WriteLine();
         //   Console.WriteLine("Enter function or exit to stop services et finish process...");
         ////   DebugTest.ReadConmand();
         //   Console.WriteLine();

         //   // Get the method to invoke on each service to stop it
         //   MethodInfo onStopMethod = typeof(ServiceBase).GetMethod("OnStop", BindingFlags.Instance | BindingFlags.NonPublic);

         //   // Stop loop
         //   foreach (ServiceBase service in servicesToRun)
         //   {
         //    InitParametar.WriteLogApplication( "Stopping " + service.ServiceName + " ...", true, false);
         //       onStopMethod.Invoke(service, null);
         //       InitParametar.WriteLogApplication(service.ServiceName + " Stopped", false, false);
         //   }

         //   InitParametar.WriteLogApplication("\nAll services are stopped.", false, true);
         //   // Waiting a key press to not return to VS directly
         //   if (System.Diagnostics.Debugger.IsAttached)
         //   {
         //       Console.WriteLine();
         //       Console.Write("=== Press a key to quit ===");
         //       Console.ReadKey();
         //   }
        }
        /// <summary>
        /// Helper for check if we are a command in the command line arguments
        /// </summary>
        static bool HasCommand(String[] args, String command)
        {
            if (args == null || args.Length == 0 ) return false;
            return args.Any(a => String.Equals(a, command, StringComparison.OrdinalIgnoreCase));
        }
        static bool WriteConfigReg()
        {
            try
            {
                if (!RegistryCus.CreateSubKey(@"SOFTWARE", "Wincor Nixdorf")) return false;
                if (!RegistryCus.CreateSubKey(@"SOFTWARE\Wincor Nixdorf", "BSI")) return false;
                if (!RegistryCus.CreateSubKey(@"SOFTWARE\Wincor Nixdorf\BSI", "FDM_AGENT")) return false;
                if (string.IsNullOrEmpty(RegistryCus.GetValue(@"SOFTWARE\Wincor Nixdorf\BSI\FDM_AGENT", "TerminalID"))) RegistryCus.WriteValue(@"SOFTWARE\Wincor Nixdorf\BSI\FDM_AGENT", "TerminalID", "88888888");
                //string file = @"c:\windows\temp\fdm.reg";
                //Process regeditProcess = Process.Start("regedit.exe", "/s \"" + file + "\"");
                //regeditProcess.WaitForExit();
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
