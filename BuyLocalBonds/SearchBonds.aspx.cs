using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using BuyLocalBonds.BackEnd;

namespace BuyLocalBonds
{
    public partial class SearchBonds : System.Web.UI.Page
    {
        BEnd bend;
        protected void Page_Load(object sender, EventArgs e)
        {
           bend = new BEnd();
        }

        protected void Search_Click(object sender, EventArgs e)
        {

            //try
            //{
                DataSet ds;
                Bond b = new Bond();
                b.Price_low = Convert.ToDouble(PriceLow.Text);
                b.Price_high = Convert.ToDouble(PriceHigh.Text);;
                ds = bend.SearchBonds(b);
                GvBondResults.DataSource = ds.Tables[0];
                GvBondResults.DataBind();
            //}
            //catch (Exception Ex)
            //{
                //throw;

            //}
        }



    }
}