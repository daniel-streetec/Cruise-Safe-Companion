using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseSafeCompanion
{
    public static class DBCommand
    {
        /// <summary>
        /// SQL to get the newest version no. for windows application
        /// </summary>
        public static string GetNewestWinVersionNo = "SELECT VERSION_NO FROM WIN_VERSIONS ORDER BY DATE_OF_RELEASE DESC LIMIT 1";

        /// <summary>
        /// SQL to get the newest version no. for devices firmware
        /// </summary>
        public static string GetNewestFirmVersionNo = "SELECT VERSION_NO FROM FIRM_VERSIONS ORDER BY DATE_OF_RELEASE DESC LIMIT 1";

        /// <summary>
        /// SQL to get the newest firmware
        /// </summary>
        public static string GetNewestFirmware(bool forPB) { return "SELECT * FROM FIRM_VERSIONS WHERE for_PB = " + (forPB ? "0" : "1") + " ORDER BY DATE_OF_RELEASE DESC LIMIT 1"; }

        /// <summary>
        /// SQL to get the newest software
        /// </summary>
        public static string GetNewestWinVersion = "SELECT * FROM WIN_VERSIONS ORDER BY DATE_OF_RELEASE DESC LIMIT 1";
    }
}
