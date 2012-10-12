using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyLocalBonds.BackEnd
{
    public class Bond
    {
        public string Name { get; set; }
        public string Cusip { get; set; }
        public double Price_low { get; set; }
        public double Price_high { get; set; }
        public double Par_value_low { get; set; }
        public double Par_value_high { get; set; }
        public string Maturity_date_low { get; set; }
        public string Maturity_date_high { get; set; }
        public double Yield_to_maturity_low { get; set; }
        public double Yield_to_maturity_high { get; set; }
        public double Current_yield_low { get; set; }
        public double Current_yield_high { get; set; }
        public double Coupon_low { get; set; }
        public double Coupon_high { get; set; }
        public double Rating_low { get; set; }
        public double Rating_high { get; set; }

        public Bond()
        {
            Name = null;
            Cusip = null;
            Price_low = Double.NaN;
            Price_high = Double.NaN;
            Par_value_low = Double.NaN;
            Par_value_high = Double.NaN;
            Maturity_date_low = null;
            Maturity_date_high = null;
            Yield_to_maturity_low = Double.NaN;
            Yield_to_maturity_high = Double.NaN;
            Current_yield_low = Double.NaN;
            Current_yield_high = Double.NaN;
            Coupon_low = Double.NaN;
            Coupon_high = Double.NaN;
            Rating_low = Double.NaN;
            Rating_high = Double.NaN;
        }

    }
}