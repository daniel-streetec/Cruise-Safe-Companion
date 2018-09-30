using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Deployment.Application;

namespace CruiseSafeCompanion
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args != null && args.Count() > 0)
            {
                System.IO.FileInfo FI = new System.IO.FileInfo(args[0]);
                if (FI.Exists)
                    Application.Run(new frmMain(args[0]));
                else
                    Application.Run(new frmMain());
            }
            else
                Application.Run(new frmMain());
        }

        public static string CurrentVersion
        {
            get
            {
                return System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
                //return ApplicationDeployment.IsNetworkDeployed
                //       ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                //       : Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
    }
}
