using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace BuyLocalBonds.BackEnd
{
    internal class SQLBean
    {
    SqlConnection conn;

        public SQLBean()
        {
            conn = new SqlConnection("Server=.;Database=BLBData;Integrated Security=SSPI;");             
        }
        public DataSet SearchBondsQuery(Bond b)
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
                      " FROM [BONDS] WHERE 1=1" + //sanity check fail
                      ((b.Name!=null) ? " AND name = @name" : "" )+
                      ((b.Cusip!=null) ? " AND CUSIP = @cusip" : "")+
                      ((b.Price_low!=Double.NaN) ? " AND price >= @price_low" : "")+
                      ((b.Price_high != Double.NaN) ? " AND price <= @price_high" : "")
                      //((par_value_low != Double.NaN) ? " AND par_value >= @par_value_low" : "") +
                      //((par_value_high != Double.NaN) ? " AND par_value <= @par_value_high" : "") +
                      //((maturity_date_low != null) ? " AND maturity_date <= @maturity_date_low" : "") +
                      //((maturity_date_high != null) ? " AND maturity_date >= @maturity_date_high" : "") +
                      //((yield_to_maturity_low != Double.NaN) ? " AND yield_to_maturity >= @yield_to_maturity_low" : "") +
                      //((yield_to_maturity_high != Double.NaN) ? " AND yield_to_maturity <= @yield_to_maturity_high" : "") +
                      //((current_yield_low != Double.NaN) ? " AND current_yield >= @current_yield_low" : "") +
                      //((current_yield_high != Double.NaN) ? " AND current_yield <= @current_yield_high" : "") +
                      //((coupon_low != Double.NaN) ? " AND coupon >= @coupon_low" : "") +
                      //((coupon_high != Double.NaN) ? " AND coupon <= @coupon_high" : "") +
                      //((rating_low != Double.NaN) ? " AND rating >= @rating_low" : "") +
                      //((rating_high != Double.NaN) ? " AND rating <= @rating_high" : "") 
                      ;


            SqlCommand cmdBond = new SqlCommand(sql, conn);

           // SqlParameter myParam = new SqlParameter(
            //    "@Param1", SqlDbType.VarChar, 11);

            if (b.Name != null) cmdBond.Parameters.AddWithValue("@name", b.Name);
            if (b.Cusip != null) cmdBond.Parameters.AddWithValue("@cusip", b.Cusip);
            if (b.Price_low != Double.NaN) cmdBond.Parameters.AddWithValue("@price_low", b.Price_low);
            if (b.Price_high != Double.NaN) cmdBond.Parameters.AddWithValue("@price_high", b.Price_high);
            //if (par_value_low != Double.NaN) cmdBond.Parameters.AddWithValue("@par_value_low", par_value_low);
            //if (par_value_high != Double.NaN) cmdBond.Parameters.AddWithValue("@par_value_high", par_value_high);
            //if (yield_to_maturity_low != Double.NaN) cmdBond.Parameters.AddWithValue("@yield_to_maturity_low", yield_to_maturity_low);
            //if (yield_to_maturity_high != Double.NaN) cmdBond.Parameters.AddWithValue("@yield_to_maturity_high", yield_to_maturity_high);
            //if (current_yield_low != Double.NaN) cmdBond.Parameters.AddWithValue("@current_yield_low", current_yield_low);
            //if (current_yield_high != Double.NaN) cmdBond.Parameters.AddWithValue("@current_yield_high", current_yield_high);
            //if (coupon_low != Double.NaN) cmdBond.Parameters.AddWithValue("@coupon_low", coupon_low);
            //if (coupon_high != Double.NaN) cmdBond.Parameters.AddWithValue("@coupon_high", coupon_high);
            //if (rating_low != Double.NaN) cmdBond.Parameters.AddWithValue("@rating_low", rating_low);
            //if (rating_high != Double.NaN) cmdBond.Parameters.AddWithValue("@rating_high", rating_high);

            SqlDataAdapter da = new SqlDataAdapter(cmdBond);

            DataSet ds = new DataSet();
            da.Fill(ds, "Bonds");
            //conn.Close();
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
            //conn.Close();
            return ds;
        }
    }
}