using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseSafeCompanion
{
    public class ApplicationUpdater
    {
        public delegate void UpdateCompleteHandler(UpdateCompleteEventArgs e);
        public event UpdateCompleteHandler UpdateComplete;

        /// <summary>
        /// Check for newer versions of the windows application on the server
        /// </summary>
        /// <returns>if there is a newer version</returns>
        public static bool CheckForNewerVersion()
        {
            DataTable dtVersions = DBConnect.GetQueryResult(DBCommand.GetNewestWinVersionNo);
            if (dtVersions != null)
                return !((string)dtVersions.Rows[0]["VERSION_NO"] == Program.DB_VERSION_NO);
            else
                return false;
        }

        public void UpdateSoftware()
        {
            Thread T = new Thread(new ThreadStart(T_WORK));
            T.SetApartmentState(ApartmentState.STA);
            T.Name = "CruiseSafe Updater";
            T.Priority = ThreadPriority.BelowNormal;
            T.Start();
        }

        private void T_WORK()
        {
            try
            {
                DataTable dtResult = DBConnect.GetQueryResult(DBCommand.GetNewestWinVersion);
                if (dtResult != null)
                {
                    byte[] DATA = (byte[])dtResult.Rows[0]["PAYLOAD"];
                    string VERSION = (string)dtResult.Rows[0]["VERSION_NO"];
                    string CHANGELOG = (string)dtResult.Rows[0]["CHANGELOG"];
                    DateTime RELEASE_DATE = (DateTime)dtResult.Rows[0]["DATE_OF_RELEASE"];

                    string tmpFileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".zip";

                    System.IO.File.WriteAllBytes(tmpFileName, DATA);

                    System.Diagnostics.Process.Start(tmpFileName);

                    UpdateComplete?.Invoke(new UpdateCompleteEventArgs(CHANGELOG, VERSION, true));
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
                UpdateComplete?.Invoke(new UpdateCompleteEventArgs("", "", false));
            }
        }

        public class UpdateCompleteEventArgs : EventArgs
        {
            private string _changelog;
            private string _version;
            private bool _success;

            public string Changelog { get => _changelog; }
            public string Version { get => _version; }
            public bool Success { get => _success; }

            public UpdateCompleteEventArgs(string changelog, string version, bool success)
            {
                _version = version;
                _changelog = changelog;
                _success = success;
            }
        }
    }
}
