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
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {

            BEnd bend = new BEnd();
            Bond b = new Bond();

            b.Name = Name.Text;
            b.Cusip = CUSIP.Text;
            if (PriceLow.Text!="") b.Price_low = Convert.ToDouble(PriceLow.Text);
            if (PriceHigh.Text!= "") b.Price_high = Convert.ToDouble(PriceHigh.Text); ;

            DataSet ds = bend.SearchBonds(b);
            BondGrid.DataSource = ds.Tables[0];
            BondGrid.DataBind();
        }

    }
}
