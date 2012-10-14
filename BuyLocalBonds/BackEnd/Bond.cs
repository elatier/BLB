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
        public DateTime Maturity_date_low { get; set; }
        public DateTime Maturity_date_high { get; set; }
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
            Name = String.Empty;
            Cusip = String.Empty;
            Price_low = 0;
            Price_high = Double.MaxValue;
            Par_value_low = 0;
            Par_value_high = Double.MaxValue;
            Maturity_date_low =  new DateTime(1800,01,01);
            Maturity_date_high = new DateTime(3000,01,01);
            Yield_to_maturity_low = Double.MinValue;
            Yield_to_maturity_high = Double.MaxValue;
            Current_yield_low = Double.MinValue;
            Current_yield_high = Double.MaxValue;
            Coupon_low = Double.MinValue;
            Coupon_high = Double.MaxValue;
            Rating_low = double.MinValue;
            Rating_high = double.MaxValue;
        }

    }
}