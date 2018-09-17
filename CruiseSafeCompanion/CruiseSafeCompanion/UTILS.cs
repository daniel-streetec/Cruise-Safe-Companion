using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseSafeCompanion
{
    public static class UTILS
    {
        public static double ToDoubleSafe(this string s)
        {
            double dOut = 0;
            double.TryParse(s, out dOut);

            return dOut;
        }

        public static bool ToBoolSafe(this string s)
        {
            bool bOut = false;
            bool.TryParse(s, out bOut);

            return bOut;
        }
    }
}
