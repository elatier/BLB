using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace BuyLocalBonds.BackEnd
{
    public class SQLBean
    {
    SqlConnection conn;

        public SQLBean()
        {
            conn = new SqlConnection("Server=.;Database=BLBData;Integrated Security=SSPI;");             
        }
        public DataSet SearchBonds(string name, string cusip, double price_low, double price_high,
            double par_value_low, double par_value_high, string maturity_date_low, string maturity_date_high,
            double yield_to_maturity_low, double yield_to_maturity_high, double current_yield_low, double current_yield_high,
            double coupon_low, double coupon_high, double rating_low, double rating_high)
        {
            string sql = "SELECT [cusip]" +
                          ",[name]" +
                          ",[price]" +
                          ",[par_value]" +
                          ",[maturity_date]" +
                          ",[yield_to_maturity]" +
                          ",[current_yield]" +
                          ",[coupon]" +
                          ",[rating]" +
                          ",[country_code]" +
                      " FROM [BLBData].[dbo].[BONDS] WHERE 1=1" + //sanity check fail
                      ((name!=null) ? " AND name = @name" : "" )+
                      ((cusip!=null) ? " AND CUSIP = @cusip" : "")+
                      " AND price >= @price_low"+
                      " AND price <= @price_high" +
                      " AND par_value BETWEEN @par_value_low AND @par_value_high" +
                      " AND maturity_date BETWEEN @maturity_date_low AND @maturity_date_low_high" +
                      " AND yield_to_maturity BETWEEN @yield_to_maturity_low AND @yield_to_maturity_high" +
                      " AND current_yield BETWEEN @current_yield_low AND @current_yield_high" +
                      " AND coupon BETWEEN @coupon_low AND @coupon_high" +
                      " AND rating BETWEEN @rating_low AND @rating_high" +
                      " GO";

            SqlCommand cmdBond = new SqlCommand(sql, conn);

           // SqlParameter myParam = new SqlParameter(
            //    "@Param1", SqlDbType.VarChar, 11);

            cmdBond.Parameters.AddWithValue("@name", name);
            cmdBond.Parameters.AddWithValue("@cusip", cusip);
            cmdBond.Parameters.AddWithValue("@price_low", price_low);
            cmdBond.Parameters.AddWithValue("@price_high", price_high);
            cmdBond.Parameters.AddWithValue("@par_value_low", par_value_low);
            cmdBond.Parameters.AddWithValue("@par_value_high", par_value_high);
            cmdBond.Parameters.AddWithValue("@yield_to_maturity_low", yield_to_maturity_low);
            cmdBond.Parameters.AddWithValue("@yield_to_maturity_high", yield_to_maturity_high);
            cmdBond.Parameters.AddWithValue("@current_yield_low", current_yield_low);
            cmdBond.Parameters.AddWithValue("@current_yield_high", current_yield_high);
            cmdBond.Parameters.AddWithValue("@coupon_low", coupon_low);
            cmdBond.Parameters.AddWithValue("@coupon_high", coupon_high);
            cmdBond.Parameters.AddWithValue("@rating_low", rating_low);
            cmdBond.Parameters.AddWithValue("@rating_high", rating_high);

            SqlDataAdapter da = new SqlDataAdapter(cmdBond);

            DataSet ds = new DataSet();
            da.Fill(ds, "Bonds");
            conn.Close();
            return ds;
        }

        public DataSet GetBonds(string cusip, double low, double high)
        {
            conn = new SqlConnection("Server=.;Database=BLBData;Integrated Security=SSPI;");
            
            string sql = "SELECT * FROM Bonds WHERE ";
           // if (low != null && high != null) 
            sql += "Price between @low and @high";
            //if (cusip != null) 
            sql += " AND CUSIP = @cusip";
            SqlCommand cmdBond = new SqlCommand(sql, conn);

            cmdBond.Parameters.AddWithValue("@low", low);
            cmdBond.Parameters.AddWithValue("@high", high);
            cmdBond.Parameters.AddWithValue("@cusip", cusip);

            SqlDataAdapter da = new SqlDataAdapter(cmdBond);
            DataSet ds = new DataSet();
            da.Fill(ds, "Bonds");
            conn.Close();
            return ds;
        }
    }
}