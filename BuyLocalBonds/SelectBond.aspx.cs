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
    public partial class SelectBond : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BEnd bend = new BEnd();
            Bond b = new Bond();

           // b.Price_low = Convert.ToDouble(PriceLow.Text);
            //b.Price_high = Convert.ToDouble(PriceHigh.Text); ;
            
            DataSet ds = bend.SearchBonds(b);
            BondGrid.DataSource = ds.Tables[0];
            BondGrid.DataBind();
        }

        protected void BondGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}