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
        public DataSet GetBonds(string cusip, double low, double high)
        {
            return db.GetBonds(low, high);
        }

        public DataSet GetBonds(double low, double high)
        {
            return db.GetBonds(low, high);
        }
    }
}