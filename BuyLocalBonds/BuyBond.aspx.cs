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
        BEnd bend;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.BufferOutput = true;

            String cusip = Request.QueryString["CUSIP"];
            if (!String.IsNullOrWhiteSpace(cusip))
            {
                bend = new BEnd();
                    
                DataSet ds = bend.SelectBond(cusip);



                DetailsView1.DataSource = ds.Tables[0];
                DetailsView1.DataBind();

                DataTable dt = ds.Tables[0];
                
                //Todo also load values into textboxes
                CUSIP.Text = dt.Rows[0][0].ToString();
                Name.Text = dt.Rows[0][1].ToString();
                Price.Text = dt.Rows[0][2].ToString();
                ParValue.Text = dt.Rows[0][3].ToString();
                MaturityDate.Text = dt.Rows[0][4].ToString();
                YieldToMaturity.Text = dt.Rows[0][5].ToString();
                CurrentYield.Text = dt.Rows[0][6].ToString();
                Coupon.Text = dt.Rows[0][7].ToString();
                Rating.Text = dt.Rows[0][8].ToString();
                QuantityAvailable.Text = dt.Rows[0][10].ToString();

            }
            else
            {
                //Server.Transfer("Default.aspx", true);
                //Response.Redirect("~/Default.aspx", true);
                Response.Redirect("~/BuyBond.aspx?CUSIP=123456789", true);
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx", true);
        }

        protected void Buy_Click(object sender, EventArgs e)
        {
            
        }

    }
}
