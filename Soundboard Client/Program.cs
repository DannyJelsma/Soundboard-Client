using AutoUpdaterDotNET;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Soundboard_Client {
    static class Program {
        private static Server server;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            AutoUpdater.Synchronous = true;
            AutoUpdater.RunUpdateAsAdmin = false;
            AutoUpdater.Start("https://dannyjelsma.nl/soundboard-update.xml");

            System.Timers.Timer timer = new System.Timers.Timer {
                Interval = 60000,
            };
            timer.Elapsed += delegate
            {
                AutoUpdater.Synchronous = false;
                AutoUpdater.UpdateMode = Mode.Forced;
                AutoUpdater.Start("https://dannyjelsma.nl/soundboard-update.xml");
            };
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            server = new Server();

            if (Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SoundboardClient") == null
                || Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SoundboardClient").GetValue("APIKey").Equals("")) {

                if (Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SoundboardClient") == null) {
                    Registry.CurrentUser.CreateSubKey(@"SOFTWARE\SoundboardClient", true).SetValue("APIKey", "");
                }

                Application.Run(new APIKeyWindow());
            } else {
                server.Authenticate();
                Application.Run(new SoundboardForm());
            }
        }

        public static Server GetServer() {
            return server;
        }
    }
}
