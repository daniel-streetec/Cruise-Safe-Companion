using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseSafeCompanion
{
    public static class ApplicationUpdater
    {
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
    }
}
