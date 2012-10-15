using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BuyLocalBonds.BackEnd;

namespace BuyLocalBonds
{
    public partial class ClientPortfolio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     
        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            BEnd bend = new BEnd();
            Int64 client_id = new Int64();

            client_id = Convert.ToInt64(DDLClientID.SelectedValue);

            // Call the function which uses the client_id to get all the stocks. Returns a table with [stock, q]
            bend.CreatePortfolio(client_id);
        }
    }
}