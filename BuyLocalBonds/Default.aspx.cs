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

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {

            BEnd bend = new BEnd();
            Bond b = new Bond();

            //Regex numRegex = new Regex("/^\\d+\\.?\\d*$/");

            b.Name = Util.Filter(Name.Text);
            b.Cusip = Util.Filter(CUSIP.Text);
            // rating
            //
            b.Coupon_low = Util.Parse(b.Coupon_low, CouponLow.Text);
            b.Coupon_high = Util.Parse(b.Coupon_high, CouponHigh.Text);
            b.Current_yield_low = Util.Parse(b.Current_yield_low, CurrentYieldLow.Text);
            b.Current_yield_high = Util.Parse(b.Current_yield_high, CurrentYieldHigh.Text);
            b.Yield_to_maturity_low = Util.Parse(b.Yield_to_maturity_low, YieldToMaturityLow.Text);
            b.Yield_to_maturity_high = Util.Parse(b.Yield_to_maturity_high, YieldToMaturityHigh.Text);
            // maturity date
            //
            b.Price_low = Util.Parse(b.Price_low,PriceLow.Text);
            b.Price_high = Util.Parse(b.Price_high,PriceHigh.Text);
            b.Par_value_low = Util.Parse(b.Par_value_low, ParValueLow.Text);
            b.Par_value_high= Util.Parse(b.Par_value_high, ParValueHigh.Text);

            DataSet ds = bend.SearchBonds(b);
            BondGrid.DataSource = ds.Tables[0];
            BondGrid.DataBind();
        }

    }
}
