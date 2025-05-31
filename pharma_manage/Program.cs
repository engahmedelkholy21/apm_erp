using System;
using System.Globalization;
using System.Windows.Forms;
using System.Timers;
using Microsoft.Win32;

namespace pharma_manage
{
    static class Program
    {
        private const string RegistryKeyPath = "HKEY_CURRENT_USER\\Software\\APM_ERP";
        private const string LastRunTimeValueName = "LastRunTime";
        private static readonly DateTime ExpirationDate = new DateTime(2025, 09, 15, 11, 55, 15);

        private static System.Timers.Timer timeCheckTimer;
        private static bool isAppExiting = false; // Prevent multiple exit calls

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DateTime now = DateTime.Now;
            //DateTime lastRunTime = GetLastRunTime();

            //if (now > ExpirationDate || (lastRunTime != DateTime.MinValue && now < lastRunTime))
            //{
            //    ForceExit();
            //}

            //SetLastRunTime(now);
            //SetupTimeCheckTimer();

            //// Handle exit event globally
            //Application.ApplicationExit += new EventHandler(OnApplicationExit);

            Application.Run(new login());
        }

        private static void SetupTimeCheckTimer()
        {
            timeCheckTimer = new System.Timers.Timer(60000); // Every 60 seconds
            timeCheckTimer.Elapsed += new ElapsedEventHandler(TimeCheckTimer_Elapsed);
            timeCheckTimer.Start();
        }

        private static void TimeCheckTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CheckTimeValidity();
        }

        private static void CheckTimeValidity()
        {
            DateTime currentTime = DateTime.Now;
            DateTime lastRecordedTime = GetLastRunTime();

            if (currentTime < lastRecordedTime || currentTime > ExpirationDate)
            {
                ForceExit();
            }
            else
            {
                SetLastRunTime(currentTime);
            }
        }

        private static DateTime GetLastRunTime()
        {
            try
            {
                object value = Registry.GetValue(RegistryKeyPath, LastRunTimeValueName, null);
                DateTime storedTime;

                if (value != null && DateTime.TryParse(value.ToString(), null, DateTimeStyles.RoundtripKind, out storedTime))
                {
                    return storedTime;
                }
            }
            catch { }

            return DateTime.MinValue;
        }
        public static void StopTimer()
        {
            if (timeCheckTimer != null)
            {
                timeCheckTimer.Stop();
                timeCheckTimer.Dispose();
                timeCheckTimer = null;
            }
        }


        private static void SetLastRunTime(DateTime time)
        {
            try
            {
                Registry.SetValue(RegistryKeyPath, LastRunTimeValueName, time.ToString("o"));
            }
            catch { }
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            StopAndDisposeTimer();
        }

        private static void StopAndDisposeTimer()
        {
            if (!isAppExiting) // Prevent multiple calls
            {
                isAppExiting = true;

                if (timeCheckTimer != null)
                {
                    timeCheckTimer.Stop();
                    timeCheckTimer.Dispose();
                    timeCheckTimer = null;
                }
            }
        }

        private static void ForceExit()
        {
            if (!isAppExiting)
            {
                isAppExiting = true;
                StopAndDisposeTimer();

                // Close all open forms
                foreach (Form form in Application.OpenForms)
                {
                    form.Invoke((MethodInvoker)delegate { form.Close(); });
                }

                // Give some time for forms to close properly
                System.Threading.Thread.Sleep(500);

                // Force exit
                Environment.Exit(0);
            }
        }
    }
}