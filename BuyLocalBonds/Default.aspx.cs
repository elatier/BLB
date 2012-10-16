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

            //Regex numRegex = new Regex("/^\\d+\\.?\\d*$/");
            

            b.Name = Util.Filter(Name.Text);
            b.Cusip = Util.Filter(CUSIP.Text);
            b.Rating_low = RatingLow1.SelectedIndex + 1;
            b.Rating_high = RatingHigh1.SelectedIndex + 1;
            
            //
            b.Coupon_low = Util.Parse(b.Coupon_low, CouponLow.Text);
            b.Coupon_high = Util.Parse(b.Coupon_high, CouponHigh.Text);
            b.Current_yield_low = Util.Parse(b.Current_yield_low, CurrentYieldLow.Text);
            b.Current_yield_high = Util.Parse(b.Current_yield_high, CurrentYieldHigh.Text);
            b.Yield_to_maturity_low = Util.Parse(b.Yield_to_maturity_low, YieldToMaturityLow.Text);
            b.Yield_to_maturity_high = Util.Parse(b.Yield_to_maturity_high, YieldToMaturityHigh.Text);
            // maturity date
        
         

            DateTime TempDate = new DateTime(0001, 1, 1);

            b.Maturity_date_high = MaturityDateHigh.SelectedDate;
            if (DateTime.Compare(MaturityDateHigh.SelectedDate,TempDate) ==0)
                b.Maturity_date_high = new DateTime(9999, 12, 31);

            //
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
            }
            BondGrid.DataSource = ds.Tables[0];
            BondGrid.DataBind();
        }

        protected void BondGrid_RowCommand(Object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "SelectBond")
            {

                // Convert the row index stored in the CommandArgument
                // property to an Integer.
                int index = Convert.ToInt32(e.CommandArgument);

                // Get the last name of the selected author from the appropriate
                // cell in the GridView control.
                GridViewRow selectedRow = BondGrid.Rows[index];
                TableCell cusipCell = selectedRow.Cells[2];
                string cusip = cusipCell.Text;
                Response.Redirect("~/BuyBond.aspx?CUSIP="+cusip, false);
                //Name.Text = cusipCell.Text;
            }

        }

        protected void BuySelected_Click(object sender, EventArgs e)
        {
            string cusip = Request.Form["SelectBondRadio"];
            Name.Text = cusip;
            //Response.Redirect("~/BuyBond.aspx?CUSIP=" + cusip, false);
        }

    }
}
