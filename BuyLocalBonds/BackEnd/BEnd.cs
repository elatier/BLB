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

        public DataSet SearchBonds(Bond b)
        {
            return db.SearchBondsQuery(b);
        
        }

    }
}