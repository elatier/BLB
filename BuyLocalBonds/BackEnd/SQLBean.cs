using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace BuyLocalBonds
{
    public class SQLBean
    {
    SqlConnection conn;

        public SQLBean()
        {
                        
        }
        public DataSet GetBonds(double low, double high)
        {
            conn = new SqlConnection("Server=.;Database=BLBData;Integrated Security=SSPI;");

            string sql = "SELECT * FROM Bonds WHERE ";
            sql += "Price between @low and @high";
            SqlCommand cmdBond = new SqlCommand(sql, conn);

            cmdBond.Parameters.AddWithValue("@low", low);
            cmdBond.Parameters.AddWithValue("@high", high);

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