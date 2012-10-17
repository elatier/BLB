using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BuyLocalBonds.BackEnd;
using System.Text.RegularExpressions;

namespace BuyLocalBonds
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            RatingLow1.SelectedIndex = 12;
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {

            BEnd bend = new BEnd();
            Bond b = new Bond();
           

            b.Name = Util.Filter(Name.Text);
            b.Cusip = Util.Filter(CUSIP.Text);
            b.Rating_low = RatingLow1.SelectedIndex + 1;
            b.Rating_high = RatingHigh1.SelectedIndex + 1;
            

            b.Coupon_low = Util.Parse(b.Coupon_low, CouponLow.Text);
            b.Coupon_high = Util.Parse(b.Coupon_high, CouponHigh.Text);
            b.Current_yield_low = Util.Parse(b.Current_yield_low, CurrentYieldLow.Text);
            b.Current_yield_high = Util.Parse(b.Current_yield_high, CurrentYieldHigh.Text);
            b.Yield_to_maturity_low = Util.Parse(b.Yield_to_maturity_low, YieldToMaturityLow.Text);
            b.Yield_to_maturity_high = Util.Parse(b.Yield_to_maturity_high, YieldToMaturityHigh.Text);
            b.Maturity_date_low = Util.ParseDate(b.Maturity_date_low, MaturityLow.Text);
            b.Maturity_date_high = Util.ParseDate(b.Maturity_date_high, MaturityHigh.Text);
            b.Price_low = Util.Parse(b.Price_low,PriceLow.Text);
            b.Price_high = Util.Parse(b.Price_high,PriceHigh.Text);
            b.Par_value_low = Util.Parse(b.Par_value_low, ParValueLow.Text);
            b.Par_value_high= Util.Parse(b.Par_value_high, ParValueHigh.Text);

            DataSet ds = bend.SearchBonds(b);
            if (ds.Tables[0].Rows.Count == 0)
            {
                NoResults.Visible = true;
            }
            else
            {
                NoResults.Visible = false;
                BondGrid.DataSource = ds.Tables[0];
                SearchTable.Visible = false;
                BondGrid.Visible = true;
                BackButton.Visible = true;
                BondGrid.DataBind();
            }
            
            
        }

        protected void BondGrid_RowCommand(Object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "SelectBond")
            {

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow selectedRow = BondGrid.Rows[index];
                TableCell cusipCell = selectedRow.Cells[1];
                string cusip = cusipCell.Text;
                Response.Redirect("~/BuyBond.aspx?CUSIP="+cusip, false);
            }

        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            SearchTable.Visible = true;
            BackButton.Visible = false;
            BondGrid.Visible = false;
        }

        protected void BondGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
