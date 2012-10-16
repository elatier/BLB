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
        double unitPrice;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.BufferOutput = true;

            String cusip = Request.QueryString["CUSIP"];
            if (!String.IsNullOrWhiteSpace(cusip))
            {
                bend = new BEnd();
                    
                DataSet ds = bend.SelectBond(cusip);



                //DetailsView1.DataSource = ds.Tables[0];
                //DetailsView1.DataBind();

                DataTable dt = ds.Tables[0];
                
                //Todo also load values into textboxes
                CUSIP.Text = dt.Rows[0][0].ToString();
                Name.Text = dt.Rows[0][1].ToString();

                unitPrice = String.IsNullOrWhiteSpace(dt.Rows[0][2].ToString()) ? 0 : Convert.ToDouble(dt.Rows[0][2]);

                Price.Text = (Convert.ToDouble(dt.Rows[0][2])).ToString("c");
                ParValue.Text = (Convert.ToDouble(dt.Rows[0][3])).ToString("c");
                MaturityDate.Text = dt.Rows[0][4].ToString();
                YieldToMaturity.Text = dt.Rows[0][5].ToString();
                CurrentYield.Text = dt.Rows[0][6].ToString();
                Coupon.Text = dt.Rows[0][7].ToString();
                Rating.Text = dt.Rows[0][8].ToString();
                SettleTime.Text = dt.Rows[0][10].ToString();

                String quantityAvail = dt.Rows[0][9].ToString();
                

                if (!String.IsNullOrWhiteSpace(quantityAvail))
                {
                    QuantityAvailable.Text = quantityAvail;
                    QuantityRangeValidator.MaximumValue = quantityAvail;
                }
                else
                {
                    //Response.Redirect("~/Default.aspx", true);
                    Quantity.Enabled = false;
                    Quantity.Text = "0";
                    Buy.Visible = false;
                    QuantityAvailable.Text = "0";
                    QuantityRangeValidator.MaximumValue = "0";
                    QuantityRangeValidator.MinimumValue = "0";
                    
                }


            }
            else
            {
                //Response.Redirect("~/Default.aspx", true);
                Response.Redirect("~/BuyBond.aspx?CUSIP=123456789", true);
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Search.aspx", true);
        }

        protected void Buy_Click(object sender, EventArgs e)
        {
            Buy.Visible = false;
            Cancel.Visible = true;
            Quantity.Enabled = false;
            ClientDropdown.Enabled = false;
            Confirm.Visible = true;
            TotalAmount.Text = (Convert.ToDouble(Quantity.Text) * unitPrice).ToString("c");
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            String client_id = ClientDropdown.SelectedValue;
            DetailsView1.DataSource = bend.InsertBuyTransaction(client_id, CUSIP.Text, Quantity.Text).Tables[0];
            DetailsView1.DataBind();
            Cancel.Enabled = false;
            Confirm.Visible = false;
            PortfolioButton.Visible = true;
            ConfirmationLabel.Visible = true;
          
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Cancel.Visible = false;
            Buy.Visible = true;
            Quantity.Enabled = true;
            Confirm.Visible = false;
            ClientDropdown.Enabled = true;
            TotalAmount.Text = "";
        }

        protected void PortfolioButton_Click(object sender, EventArgs e)
        {
            String client_id = ClientDropdown.SelectedValue;
            Session["ClientID"] = client_id;
            Response.Redirect("~/ClientPortfolio.aspx?client_id=" + client_id, false);
        }

    }
}
