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
                      " AND price >= @price_low" +
                      " AND price <= @price_high" +
                      " AND par_value >= @par_value_low" +
                      " AND par_value <= @par_value_high" +
                      " AND maturity_date >= @maturity_date_low" +
                      " AND maturity_date <= @maturity_date_high" +
                      " AND yield_to_maturity >= @yield_to_maturity_low" +
                      " AND yield_to_maturity <= @yield_to_maturity_high" +
                      " AND current_yield >= @current_yield_low" +
                      " AND current_yield <= @current_yield_high" +
                      " AND coupon >= @coupon_low" +
                      " AND coupon <= @coupon_high" //+
                      //" AND rating >= @rating_low" +
                      //" AND rating <= @rating_high"
                      ;


            SqlCommand cmdBond = new SqlCommand(sql, conn);

           // SqlParameter myParam = new SqlParameter(
            //    "@Param1", SqlDbType.VarChar, 11);

            if (b.Name != null) cmdBond.Parameters.AddWithValue("@name", b.Name);
            if (b.Cusip != null) cmdBond.Parameters.AddWithValue("@cusip", b.Cusip);
            cmdBond.Parameters.AddWithValue("@price_low", b.Price_low);
            cmdBond.Parameters.AddWithValue("@price_high", b.Price_high);
            cmdBond.Parameters.AddWithValue("@par_value_low", b.Par_value_low);
            cmdBond.Parameters.AddWithValue("@par_value_high", b.Par_value_high);
            cmdBond.Parameters.AddWithValue("@maturity_date_low", b.Maturity_date_low);
            cmdBond.Parameters.AddWithValue("@maturity_date_high", b.Maturity_date_high);
            cmdBond.Parameters.AddWithValue("@yield_to_maturity_low", b.Yield_to_maturity_low);
            cmdBond.Parameters.AddWithValue("@yield_to_maturity_high", b.Yield_to_maturity_high);
            cmdBond.Parameters.AddWithValue("@current_yield_low", b.Current_yield_low);
            cmdBond.Parameters.AddWithValue("@current_yield_high", b.Current_yield_high);
            cmdBond.Parameters.AddWithValue("@coupon_low", b.Coupon_low);
            cmdBond.Parameters.AddWithValue("@coupon_high", b.Coupon_high);
            //cmdBond.Parameters.AddWithValue("@rating_low", b.Rating_low);
            //cmdBond.Parameters.AddWithValue("@rating_high", b.Rating_high);

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