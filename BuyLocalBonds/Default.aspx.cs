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
            b.Price_low = Util.Parse(b.Price_low,PriceLow.Text);
            b.Price_high = Util.Parse(b.Price_high,PriceHigh.Text);

            DataSet ds = bend.SearchBonds(b);
            BondGrid.DataSource = ds.Tables[0];
            BondGrid.DataBind();
        }

    }
}
