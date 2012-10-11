using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace BuyLocalBonds.BackEnd
{
    public class BEnd
    {
    SQLBean db;

        public BEnd()
        {
           db = new SQLBean();             
        }
        public DataSet SearchBonds(string cusip, double low, double high)
        {
            if (cusip == null)
                return db.GetBonds(null, low, high);
            else return db.GetBonds(cusip, low, high);
        }

        public DataSet SearchBonds(string name, string cusip, double price_low, double price_high,
            double par_value_low, double par_value_high, string maturity_date_low, string maturity_date_high,
            double yield_to_maturity_low, double yield_to_maturity_high, double current_yield_low, double current_yield_high,
            double coupon_low, double coupon_high, double rating_low, double rating_high)
        {
            return db.SearchBondsQuery(name, cusip, price_low, price_high,
            par_value_low, par_value_high, maturity_date_low, maturity_date_high,
            yield_to_maturity_low, yield_to_maturity_high, current_yield_low, current_yield_high,
            coupon_low, coupon_high, rating_low, rating_high);
        
        }

    }
}