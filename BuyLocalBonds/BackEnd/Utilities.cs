using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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