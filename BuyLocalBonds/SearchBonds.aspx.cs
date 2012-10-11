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

            try
            {
                DataSet ds;
                string pattern = "[0-9]{3}[a-zA-Z0-9]{6}";
                Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                if (!rgx.IsMatch(CUSIP.Text)) {
                    CUSIP.Text="";
                    ds = bend.GetBonds(Convert.ToDouble(PriceLow.Text), Convert.ToDouble(PriceHigh.Text));
                }
                else
                {
                    ds = bend.GetBonds(CUSIP.Text, Convert.ToDouble(PriceLow.Text), Convert.ToDouble(PriceHigh.Text));
                }
                GvBondResults.DataSource = ds.Tables[0];
                GvBondResults.DataBind();
            }
            catch (Exception)
            {


            }
        }



    }
}