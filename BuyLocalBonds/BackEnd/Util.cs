using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace BuyLocalBonds.BackEnd
{
    public static class Util
    {
        public static Double Parse(Double currentValue, String input)
        {
            try
            {
                return Convert.ToDouble(Filter(input));
            }
            catch (FormatException)
            {
                //if not a number, return current value
                return currentValue;
            }
            
        }

        public static DateTime ParseDate(DateTime currentValue, String input)
        {

            DateTime parsed;
            if (DateTime.TryParseExact(input,"dd/MM/yyyy",
                CultureInfo.CurrentCulture, DateTimeStyles.None, out parsed))
            {
                return parsed;
            }
      
            return currentValue;
        }

        internal static string Filter(string p)
        {
            if (String.IsNullOrWhiteSpace(p))
            {
                return String.Empty;
            }
            else
            {
                return p;
            }
        }
    }
}