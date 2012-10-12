using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyLocalBonds.BackEnd
{
    public class Utilities
    {
        public static Double ToDouble(double currentValue, String text)
        {
            try
            {
                return Convert.ToDouble(text);
            }
            catch (FormatException)
            {

                return currentValue;
            }
            
        }

    }
}