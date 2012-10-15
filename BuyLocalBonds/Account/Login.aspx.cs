using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BuyLocalBonds.BackEnd;

namespace BuyLocalBonds.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

       // protected void LoginButton_Click(object sender, EventArgs e)
       // {
       //     
       // }

        private bool SiteSpecificAuthenticationMethod(string UserName, string Password)
        {
            // Insert code that implements a site-specific custom 
            // authentication method here.
            //
            // This example implementation always returns false.
            return false;
        }

        private void OnAuthenticate(object sender, AuthenticateEventArgs e)
        {
            bool Authenticated = false;
            Authenticated = SiteSpecificAuthenticationMethod(LoginUser.UserName, LoginUser.Password);

            e.Authenticated = Authenticated;
        }
    }
}
