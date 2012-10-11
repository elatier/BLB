using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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
                DataSet ds = bean.GetBonds(Convert.ToDouble(PriceLow.Text), Convert.ToDouble(PriceHigh.Text));
                GvBondResults.DataSource = ds.Tables[0];
                GvBondResults.DataBind();
            }
            catch (Exception)
            {


            }
        }



    }
}