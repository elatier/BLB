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
        bool BuyTran = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.BufferOutput = true;

            String cusip = Request.QueryString["CUSIP"];
            String clientId = Request.QueryString["CLIENTID"];
            if (!String.IsNullOrWhiteSpace(clientId))
            {
                BuyTran = false;
            }

            if (!String.IsNullOrWhiteSpace(cusip))
            {
                 
                bend = new BEnd();
               // try
               // {
                   DataSet ds = bend.SelectBond(cusip);
                
                   DataTable dt = ds.Tables[0];
                
                    CUSIP.Text = dt.Rows[0][0].ToString();
                    Name.Text = dt.Rows[0][1].ToString();
                    unitPrice = Util.Parse(0, dt.Rows[0][2].ToString());
                    Price.Text = (Convert.ToDouble(dt.Rows[0][2])).ToString("c");
                    ParValue.Text = (Convert.ToDouble(dt.Rows[0][3])).ToString("c");
                    MaturityDate.Text = dt.Rows[0][4].ToString();
                    YieldToMaturity.Text = dt.Rows[0][5].ToString();
                    CurrentYield.Text = dt.Rows[0][6].ToString();
                    Coupon.Text = dt.Rows[0][7].ToString();
                    Rating.Text = dt.Rows[0][8].ToString();
                    SettleTime.Text = dt.Rows[0][10].ToString();
                    String quantityAvail;
                    if (BuyTran)
                    {
                        quantityAvail = dt.Rows[0][9].ToString();
                    }
                    else
                    {
                        quantityAvail = bend.GetClientBondQuantity(clientId, dt.Rows[0][0].ToString());
                        ClientDropdown.Enabled = false;
                        ClientDropdown.SelectedValue = clientId;
                        HeaderLabel.Text = "Sell Bond";
                        Buy.Text = "Sell";
                    }

                    if (!String.IsNullOrWhiteSpace(quantityAvail))
                    {
                        QuantityAvailable.Text = quantityAvail;
                        QuantityRangeValidator.MaximumValue = quantityAvail;
                    }
                    else
                    {
                        Response.Redirect("~/Default.aspx", true);
                        Quantity.Enabled = false;
                        Quantity.Text = "0";
                        Buy.Visible = false;
                        QuantityAvailable.Text = "0";
                        QuantityRangeValidator.MaximumValue = "0";
                        QuantityRangeValidator.MinimumValue = "0";
                    
                    }

                //}
               // catch (Exception)
               // {
               //     Response.Redirect("~/Default.aspx", true);
               // }  


            }
            else
            {
                Response.Redirect("~/Default.aspx", true);
                //used for testing:
                //Response.Redirect("~/BuyBond.aspx?CUSIP=123456789", true);
            }
        }

        protected void Buy_Click(object sender, EventArgs e)
        {
            Buy.Visible = false;
            Cancel.Visible = true;
            Quantity.Enabled = false;
            ClientDropdown.Enabled = false;
            Confirm.Visible = true;
            TotalAmount.Text = (Convert.ToDouble(Quantity.Text) * unitPrice).ToString("c");
            TotalAmount.Visible = true;
            TotalAmountLabel.Visible = true;
            SettleTime.Visible = true;
            SettleTimeLabel.Visible = true;
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            String client_id = ClientDropdown.SelectedValue;
            if (BuyTran)
            {
                TransactionId.Text = bend.InsertBuyTransaction(client_id, CUSIP.Text, Quantity.Text)
                                    .Tables[0].Rows[0][0].ToString();
            }
            else
            {
                TransactionId.Text = bend.InsertSellTransaction(client_id, CUSIP.Text, Quantity.Text)
                    .Tables[0].Rows[0][0].ToString();
            }
            Cancel.Visible = false;
            Confirm.Visible = false;
            PortfolioButton.Visible = true;
            ConfirmationLabel.Visible = true;
            TransactionId.Visible = true;
            TransactionIDLabel.Visible = true;

          
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Cancel.Visible = false;
            Buy.Visible = true;
            Quantity.Enabled = true;
            Confirm.Visible = false;
            if (BuyTran) ClientDropdown.Enabled = true;
            TotalAmount.Text = "";
            TotalAmount.Visible = false;
            TotalAmountLabel.Visible = false;
            SettleTime.Visible = false;
            SettleTimeLabel.Visible = false;
        }

        protected void PortfolioButton_Click(object sender, EventArgs e)
        {
            String client_id = ClientDropdown.SelectedValue;
            Session["ClientID"] = client_id;
            Response.Redirect("~/ClientPortfolio.aspx?client_id=" + client_id, false);
        }

        protected void Back_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Search.aspx", true);
        }



    }
}
