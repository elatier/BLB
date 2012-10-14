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
    public partial class BuyBond : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.BufferOutput = true;

            String cusip = Request.QueryString["CUSIP"];
            if (!String.IsNullOrWhiteSpace(cusip))
            {
                BEnd bend = new BEnd();
                    
                DataSet ds = bend.SelectBond(cusip);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else
            {
                //Server.Transfer("Default.aspx", true);
                Response.Redirect("~/Default.aspx", true);
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx", true);
        }
    }
}
