using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyLocalBonds.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

        protected void OnAuthenticate(object sender, AuthenticateEventArgs e)
        {
            bool Authenticated = false;
            Authenticated = SiteSpecificAuthenticationMethod(LoginUser.UserName, LoginUser.Password);

            e.Authenticated = Authenticated;
        }

        private bool SiteSpecificAuthenticationMethod(string UserName, string Password)
        {
            BackEnd.BEnd bend = new BackEnd.BEnd();
            return bend.LoginQuery(UserName, Password);

        }
 


    }
}
