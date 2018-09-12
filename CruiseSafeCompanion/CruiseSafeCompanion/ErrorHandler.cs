using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseSafeCompanion
{
    public static class ErrorHandler
    {
        /// <summary>
        /// Handle an exception
        /// </summary>
        /// <param name="ex"></param>
        public static void Handle(Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
        }
    }
}
