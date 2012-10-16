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


        ~BEnd()
        {
            db = null;
        }

        public DataSet SearchBonds(Bond b)
        {
            return db.SearchBondsQuery(b);
        
        }

        public DataTable CreatePortfolio(string clientID)
        {
            return db.GetPortfolio(clientID);

        }

        public Boolean LoginQuery(String UserName, String Password)
        {
            return db.LoginQuery(UserName, Password);

        }
        
        internal DataSet SelectBond(string cusip)
        {
            return db.SelectBondQuery(cusip);
        }

        internal DataSet InsertBuyTransaction(string client_id, string cusip, string quantity)
        {
            db.UpdateAvailableBonds(cusip, quantity);
            return db.InsertBuyTransactionQuery(client_id, cusip, quantity);
           
        }
    }
}