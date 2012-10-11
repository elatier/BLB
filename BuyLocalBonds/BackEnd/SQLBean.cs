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
            conn = new SqlConnection("Server=.;Database=BLBData;Integrated Security=SSPI;");
        }
        public DataSet GetBonds(double low, double high)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Bonds WHERE Price between " + low + " and " + high, conn);
            da.Fill(ds, "Bonds");
            return ds;
        }
    }
}