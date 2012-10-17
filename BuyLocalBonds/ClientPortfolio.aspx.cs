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
            //ButtonGo_Click(this, new System.EventArgs());
        }

     
        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string client_id = DDLClientID.SelectedValue;

            dt = bend.CreatePortfolio(client_id);
            GV_portfolio.DataSource = dt;
            GV_portfolio.DataBind();
        
           Chart1.DataSource = dt;
           Chart1.Series["Series1"].XValueMember = "CUSIP";
           Chart1.Series["Series1"].YValueMembers = "Quantity owned";
           Chart1.DataBind();

        }

        protected void GV_portfolio_RowCommand(Object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "SelectBond")
            {

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow selectedRow = GV_portfolio.Rows[index];
                TableCell cusipCell = selectedRow.Cells[2];
                string cusip = cusipCell.Text;
                Session["CUSIP"] = cusip;
                Session["ClientID"] = DDLClientID.SelectedValue;
                Response.Redirect("~/BuySellBond.aspx", true);
            }

        }


    }
}