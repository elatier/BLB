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

         ~SQLBean()
        {
            conn.Close();
        }

        public Boolean LoginQuery(String UserName, String Password)
        {
            string sql = "SELECT trader_id FROM TRADER WHERE trader_username = @UserName AND trader_password = @Password";
            SqlCommand cmdBond = new SqlCommand(sql, conn);
            cmdBond.Parameters.AddWithValue("@UserName", UserName);
            cmdBond.Parameters.AddWithValue("@Password", Password);

            SqlDataAdapter da = new SqlDataAdapter(cmdBond);
            DataSet ds = new DataSet();
            da.Fill(ds, "Trader");
            if (ds.Tables[0].Rows.Count == 1)
                return true;

            return false;
        }

        public DataTable GetPortfolio(string client_id)
        {

            string sql = "SELECT BONDS.name as 'Bond Name', TRANSACTIONS.cusip as 'CUSIP',SUM(TRANSACTIONS.quantity) as 'Quantity Owned' FROM BONDS JOIN TRANSACTIONS  ON (BONDS.cusip = TRANSACTIONS.cusip) WHERE TRANSACTIONS.client_id = @client_id GROUP BY TRANSACTIONS.cusip, BONDS.name";
            
            SqlCommand cmdBond = new SqlCommand(sql, conn);
            cmdBond.Parameters.AddWithValue("@client_id", client_id);

            SqlDataAdapter da = new SqlDataAdapter(cmdBond);
            DataSet ds = new DataSet();
            da.Fill(ds, "Transactions");
            DataTable dt = ds.Tables[0];

            //conn.Close();
            return dt;


            
        }


        public DataSet SearchBondsQuery(Bond b)
        {

            string sql = "SELECT [cusip] AS 'CUSIP'" +
                          ",[name] AS 'Bond Name'" +
                          ",CONVERT(varchar(12),maturity_date, 13) AS 'Maturity Date'" +
                          ",[yield_to_maturity] AS 'Yield To Maturity (%)'" +
                          ",[current_yield] AS 'Current Yield (%)'" +
                          ",[coupon] AS 'Coupon (%)'" +
                          ",[rating_sp] AS 'S&P Rating'" +
                          //",[country_code]" +
                          ",'$'+CONVERT(varchar(12), price, 1) AS 'Price'" +
                          ",'$'+CONVERT(varchar(12), par_value, 1) AS 'Par Value'" +
                      " FROM BondQuantity WHERE 1=1" + //sanity check fail
                      " AND quantity_available > 0 "+
                ((!String.IsNullOrWhiteSpace(b.Name)) ? " AND name LIKE @name" : "") +
                ((!String.IsNullOrWhiteSpace(b.Cusip)) ? " AND CUSIP = @cusip" : "") +
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
                      " AND coupon <= @coupon_high" +
                      " AND rating <= @rating_low" +
                      " AND rating >= @rating_high"
                      ;


            SqlCommand cmdBond = new SqlCommand(sql, conn);

            if (!String.IsNullOrWhiteSpace(b.Name))
                cmdBond.Parameters.AddWithValue("@name", "%" + b.Name + "%");
            if (!String.IsNullOrWhiteSpace(b.Cusip))
                cmdBond.Parameters.AddWithValue("@cusip", b.Cusip);
            cmdBond.Parameters.AddWithValue("@price_low", b.Price_low);
            cmdBond.Parameters.AddWithValue("@price_high", b.Price_high);
            cmdBond.Parameters.AddWithValue("@par_value_low", b.Par_value_low);
            cmdBond.Parameters.AddWithValue("@par_value_high", b.Par_value_high);
            //cmdBond.Parameters.AddWithValue("@maturity_date_low", b.Maturity_date_low);
            //cmdBond.Parameters.AddWithValue("@maturity_date_high", b.Maturity_date_high);
            cmdBond.Parameters.Add("@maturity_date_low", SqlDbType.Date).Value = b.Maturity_date_low;
            cmdBond.Parameters.Add("@maturity_date_high", SqlDbType.Date).Value = b.Maturity_date_high;
            cmdBond.Parameters.AddWithValue("@yield_to_maturity_low", b.Yield_to_maturity_low);
            cmdBond.Parameters.AddWithValue("@yield_to_maturity_high", b.Yield_to_maturity_high);
            cmdBond.Parameters.AddWithValue("@current_yield_low", b.Current_yield_low);
            cmdBond.Parameters.AddWithValue("@current_yield_high", b.Current_yield_high);
            cmdBond.Parameters.AddWithValue("@coupon_low", b.Coupon_low);
            cmdBond.Parameters.AddWithValue("@coupon_high", b.Coupon_high);
            cmdBond.Parameters.AddWithValue("@rating_low", b.Rating_low);
            cmdBond.Parameters.AddWithValue("@rating_high", b.Rating_high);

            SqlDataAdapter da = new SqlDataAdapter(cmdBond);
            DataSet ds = new DataSet();
            da.Fill(ds, "Bonds");
            //conn.Close();
            return ds;
        }

        internal DataSet SelectBondQuery(string cusip)
        {
            string sql = "SELECT [cusip]" +
                          ",[name]" +
                          ",[price]" +
                          ",[par_value]" +
                          ",CONVERT(varchar(12),maturity_date, 13) AS 'maturity_date'" +
                          ",[yield_to_maturity]" +
                          ",[current_yield]" +
                          ",[coupon]" +
                          ",[rating_sp]" +
                          ",[quantity_available]"+
                          ",[settlement_time]"+
                          ",ci.country_code"+
                      " FROM BondQuantity b JOIN COUNTRY_INFO ci ON ci.country_code= b.country_code " +
                        " WHERE CUSIP = @cusip";

            SqlCommand cmdBond = new SqlCommand(sql, conn);

            cmdBond.Parameters.AddWithValue("@cusip", cusip);

            SqlDataAdapter da = new SqlDataAdapter(cmdBond);
            DataSet ds = new DataSet();
            da.Fill(ds, "Bonds");
            return ds;
        }

        internal DataSet InsertBuyTransactionQuery(string client_id, string cusip, string quantity) 
        {
            string sql = "INSERT INTO [TRANSACTIONS] ([client_id],[cusip],[quantity])VALUES (@clientId, @cusip ,@quantity) SELECT SCOPE_IDENTITY() AS 'Transaction ID';";

            SqlCommand cmdBond = new SqlCommand(sql, conn);
            cmdBond.Parameters.AddWithValue("@clientId", client_id);
            cmdBond.Parameters.AddWithValue("@cusip", cusip);
            cmdBond.Parameters.AddWithValue("@quantity", quantity);

            SqlDataAdapter da = new SqlDataAdapter(cmdBond);
            DataSet ds = new DataSet();
            da.Fill(ds, "Bonds");
            return ds;
        }

        internal DataSet UpdateAvailableBonds(string cusip, string quantity)
        {
            string sql = "UPDATE [AVAILABLE_BONDS] SET [quantity_available] = [quantity_available] - ( @quantity ) WHERE cusip = @cusip;";

            SqlCommand cmdBond = new SqlCommand(sql, conn);
            cmdBond.Parameters.AddWithValue("@cusip", cusip);
            cmdBond.Parameters.AddWithValue("@quantity", quantity);

            SqlDataAdapter da = new SqlDataAdapter(cmdBond);
            DataSet ds = new DataSet();
            da.Fill(ds, "Bonds");
            return ds;
        }
    }
}