using System;
using System.Collections.Generic;

using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.ServiceProcess;

using System.Threading;

namespace Transaction_Statistical_Scheduler
{
    public partial class TransactionStatisticalScheduler : ServiceBase
    {
        Thread thread;
        bool Stop;
        List<SchedulerService> Tasks;
        string LastComnand = string.Empty;
        public TransactionStatisticalScheduler()
        {
            InitializeComponent();
            Stop = false;
            Tasks = new List<SchedulerService>();
        }


        protected override void OnStart(string[] args)
        {

            try
            {
                InitParametar.Init();
                if (thread != null)
                    ClearTimer();
                InitParametar.WriteLogApplication(string.Format("{0:HH:mm:ss fff}",DateTime.Now) + "  On Start Service.", true, false);

                thread = new Thread(() => Startup());
                thread.Start();
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void Startup()
        {
            try
            {
                WatchCommand();
                while (!Stop)
                {
                    LoadTask();
                    InitParametar.WriteLogApplication(" Init Service Finished.", false, true);
                    Thread.Sleep(TimeSpan.FromDays(1));
                    InitParametar.WriteLogApplication(string.Format("{0:HH:mm:ss fff}", DateTime.Now) + " Clear process to renew.", true, false);
                    ClearTimer();
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        protected override void OnStop()
        {
            try
            {
                Stop = true;
                InitParametar.WriteLogApplication(string.Format("{0:HH:mm:ss fff}", DateTime.Now) + " Stop service.", true, false);
                ClearTimer();
                thread.Abort();
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void ClearTimer()
        {
            try
            {
                while (InitParametar.RunningTask)
                    Thread.Sleep(TimeSpan.FromDays(1));
                foreach (SchedulerService sch in Tasks)
                    foreach (Timer tm in sch.timers)
                        tm.Dispose();
                Tasks.Clear();                
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void LoadTask()
        {
            SchedulerService task;
            InitParametar.WriteLogApplication(" Load Tasks.", false, false);
            foreach (string user in RegistryCus.GetSubkeys(InitParametar.SubkeyTask))
            {
                InitParametar.WriteLogApplication(" Load for user: " + user, false, false);
                foreach (string valueTask in RegistryCus.GetValues(InitParametar.SubkeyTask + @"\" + user))
                {
                    task = new SchedulerService();
                    task.Name = valueTask;
                    InitParametar.WriteLogApplication(" Task name: " + valueTask, false, false);
                    try
                    {
                        string[] field = RegistryCus.GetValue(InitParametar.SubkeyTask + @"\" + user, valueTask).Split('|');
                        if (field.Length == 6)
                        {
                            if (bool.Parse(field[5]))
                            {
                                task.User = user;
                                task.Time = field[0].Split(';')[0];
                                InitParametar.WriteLogApplication("     Task time: " + task.Time, false, false);
                                task.Type = (SchedulerService.TypeStart)Enum.Parse(typeof(SchedulerService.TypeStart), field[0].Split(';')[1], true);
                                InitParametar.WriteLogApplication("     Task type: " + task.Type + " => " + field[0].Split(';')[2], false, false);

                                if (task.Type.Equals(SchedulerService.TypeStart.WEEKLY))
                                    task.Week = field[0].Split(';')[2].Split(',');
                                else if (task.Type.Equals(SchedulerService.TypeStart.MONTHLY))
                                {
                                    task.Month = field[0].Split(';')[2].Split(',');
                                    task.day = int.Parse(field[0].Split(';')[3]);
                                }
                                task.Start();
                                Tasks.Add(task);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                    }
                }
            }
        }
        FileSystemWatcher watcher;
        private void WatchCommand()
        {
            try
            {
                CreateFileWatcher(Path.GetDirectoryName(InitParametar.PathFileApp), "command.txt");
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void CreateFileWatcher(string path, string filter)
        {
            try
            {
                // Create a new FileSystemWatcher and set its properties.
                 watcher = new FileSystemWatcher();
                watcher.Path = path;
                /* Watch for changes in LastAccess and LastWrite times, and 
                   the renaming of files or directories. */
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                   | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                // Only watch text files.
                watcher.Filter = filter;

                // Add event handlers.
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.Created += new FileSystemEventHandler(OnChanged);


                // Begin watching.
                watcher.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            try
            {
                Thread.Sleep(100);
                string[] line = File.ReadAllLines(e.FullPath);
                InitParametar.WriteLogApplication(string.Format("{0:HH:mm:ss fff}", DateTime.Now) + " Get command from tool.", true, false);
                if (line.Length != 0 && !line[line.Length - 1].Equals(LastComnand))
                {
                    LastComnand = line[line.Length - 1];
                    if (!LastComnand.Contains(@"[WFA]")) return;
                    InitParametar.WriteLogApplication(" Command: [" + LastComnand + "]", true, false);

                    if (LastComnand.EndsWith("Restart"))
                    {
                        OnStop();
                        OnStart(null);
                    }
                    else if (LastComnand.EndsWith("OnStop"))
                    {
                        OnStop();
                    }
                    else if (LastComnand.EndsWith("OnStart"))
                    {
                        OnStart(null);
                    }
                    else if (LastComnand.EndsWith("ReloadTask"))
                    {
                        ClearTimer();
                        LoadTask();
                    }
                    else if (LastComnand.Contains("RunTask"))
                    {
                        SchedulerService task = new SchedulerService();
                        task.User = LastComnand.Substring(LastComnand.IndexOf("RunTask")+8).Split('/')[0].Trim();
                        task.Name= LastComnand.Substring(LastComnand.IndexOf("RunTask")+8).Split('/')[1].Trim();
                        task.ProcessTask();
                        WriteCommand("Called task [" + task.Name + "] for user [" + task.User + "] successful.");
                    }
                    else
                        InitParametar.WriteLogApplication(" Command invalid.", false, true);
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        private void WriteCommand(string cmd)
        {
            try
            {
                watcher.EnableRaisingEvents = false;
                File.WriteAllText(InitParametar.PathCurrentApp + @"\command.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "[SRV] " + cmd);
               
             }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            watcher.EnableRaisingEvents = true;
        }
    }
    public class SchedulerService
    {
        private static SchedulerService _instance;
        public List<System.Threading.Timer> timers = new List<System.Threading.Timer>();

        public static SchedulerService Instance => _instance ?? (_instance = new SchedulerService());

        public string User;
        public string Name;
        public string Time;
        public int day;
        public TypeStart Type;
        public string[] Week;
        public string[] Month;
        public enum TypeStart { DAILY, ONCE, WEEKLY, MONTHLY };
        //  public enum Months { All, JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC };
        //  public enum Days { MON, TUE, WED, THU, FRI, SAT, SUN };


        public SchedulerService()
        {

        }
        public void Start()
        {
            try
            {
                if (Type.Equals(TypeStart.DAILY))
                {
                    ScheduleTaskDay(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(Time.Split(':')[0]), int.Parse(Time.Split(':')[0]), 0, 0), 12, () => ProcessTask());
                }
                else if (Type.Equals(TypeStart.MONTHLY))
                {

                    foreach (string month in Month)
                    {
                        int m = 0;
                        while (m < 12)
                        { if (DateTime.Now.AddMonths(m).ToString("MMM").ToUpper().Equals(month.Trim())) break; m++; }

                        ScheduleTaskMonth(new DateTime(DateTime.Now.Year, DateTime.Now.Month + m > 12 ? DateTime.Now.Month + m - 12 : DateTime.Now.Month + m, day, int.Parse(Time.Split(':')[0]), int.Parse(Time.Split(':')[1]), 0, 0), 0, () => ProcessTask());
                    }
                }
                else if (Type.Equals(TypeStart.ONCE))
                {
                    ScheduleTaskDay(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(Time.Split(':')[0]), int.Parse(Time.Split(':')[1]), 0, 0), 0, () => ProcessTask());
                }
                else if (Type.Equals(TypeStart.WEEKLY))
                {

                    foreach (string week in Week)
                    {
                        int d = 0;
                        while (d < 7)
                        { if (DateTime.Now.AddDays(d).ToString("ddd").ToUpper().Equals(week.Trim())) break; d++; }
                        ScheduleTaskDay(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + d > System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) ? DateTime.Now.Day + d - System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month): DateTime.Now.Day + d, int.Parse(Time.Split(':')[0]), int.Parse(Time.Split(':')[1]), 0, 0), 7, () => ProcessTask());
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        public void ScheduleTaskDay(DateTime firstRun, double intervalInHour, Action task)
        {
            try
            {

                DateTime now = DateTime.Now;
                //firstRun = new DateTime(now.Year, now.Month, now.Day, hour, min, 0, 0);
                while (now > firstRun)
                {
                    firstRun = firstRun.AddDays(1);
                }
                TimeSpan timeToGo = firstRun - now;
                if (timeToGo <= TimeSpan.Zero)
                {
                    timeToGo = TimeSpan.Zero;
                }
                var timer = new System.Threading.Timer(x =>
                {
                    task.Invoke();
                }, null, timeToGo, TimeSpan.FromHours(intervalInHour));
                timers.Add(timer);
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        public void ScheduleTaskMonth(DateTime firstRun, double intervalInHour, Action task)
        {
            try
            {
                DateTime now = DateTime.Now;
                //firstRun = new DateTime(now.Year, now.Month, now.Day, hour, min, 0, 0);
                if (now > firstRun) return;

                TimeSpan timeToGo = firstRun - now;
                if (timeToGo <= TimeSpan.Zero)
                {
                    timeToGo = TimeSpan.Zero;
                }
                if (timeToGo.Ticks >= (2 ^ 32 - 2))
                {
                    InitParametar.WriteLogApplication("     Mission temporarily delayed because timer's too big: " + string.Format("{0:yyyy-MM-dd HH:mm:ss}", firstRun), false, false);
                    return;
                }
                var timer = new System.Threading.Timer(x =>
                {
                    task.Invoke();
                }, null, timeToGo, TimeSpan.FromHours(intervalInHour));
                timers.Add(timer);
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
        public void ProcessTask()
        {
            try
            {
                InitParametar.WriteLogApplication(string.Format("{0:HH:mm:ss fff}", DateTime.Now) + " Start Task: "+ Name + " for user: "+ User, true, false);
                InitParametar.RunningTask = true;
                // File.WriteAllText(@"D:\export\test.txt", DateTime.Now.ToLongDateString());
                Process process = new Process();
                process.StartInfo.FileName = InitParametar.PathFileApp;
                process.StartInfo.Arguments = "\"" + User + "\" \"" + Name + "\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                InitParametar.WriteLogApplication(" StartInfo -> FileName -> " + process.StartInfo.FileName, true, false);
                InitParametar.WriteLogApplication(" StartInfo -> Arguments -> " + process.StartInfo.Arguments, true, false);
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string err = process.StandardError.ReadToEnd();
                InitParametar.RunningTask = false;
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            InitParametar.WriteLogApplication(string.Format("{0:HH:mm:ss fff}", DateTime.Now) + " End Task", true, false);
        }
    }
}
