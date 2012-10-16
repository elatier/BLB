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
        BEnd bend; 
        protected void Page_Load(object sender, EventArgs e)
        {
            bend = new BEnd();
            //ButtonGo_Click(null, null);
        }

     
        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string client_id = DDLClientID.SelectedValue;

            // Call the function which uses the client_id to get all the stocks. Returns a table with [stock, q]
            dt = bend.CreatePortfolio(client_id);
            GV_portfolio.DataSource = dt;
           GV_portfolio.DataBind();
        
           Chart1.DataSource = dt;
           Chart1.Series["Series1"].XValueMember = "CUSIP";
           Chart1.Series["Series1"].YValueMembers = "Quantity owned";
           Chart1.DataBind();

        }
    }
}