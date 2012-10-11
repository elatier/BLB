using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace BuyLocalBonds
{
    public partial class SearchBonds : System.Web.UI.Page
    {
        SQLBean bean;
        protected void Page_Load(object sender, EventArgs e)
        {
           bean = new SQLBean();
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
                    ds = bean.GetBonds(Convert.ToDouble(PriceLow.Text), Convert.ToDouble(PriceHigh.Text));
                }
                else
                {
                    ds = bean.GetBonds(CUSIP.Text, Convert.ToDouble(PriceLow.Text), Convert.ToDouble(PriceHigh.Text));
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