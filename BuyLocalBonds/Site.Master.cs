using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyLocalBonds
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                if ("/default.aspx" == Request.Path.ToLower())
                {
                    NavigationMenu.Visible = false;
                }
                else
                {
                    //send to login screen, comment out for bypassing login check
                    Response.Redirect("~/", true);
                }
            }
        }


        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (e.Item.Text == "Log Out")
            {
                Session.Clear();
                Response.Redirect("~/", true);
            }
        }

        
    }
}
