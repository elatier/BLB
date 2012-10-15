using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuyLocalBonds.BackEnd;
using System.Text.RegularExpressions;

namespace BuyLocalBonds
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void LoginButton_Click(object sender, EventArgs e)
        {
            BEnd bend = new BEnd();
            string UserName;
            string Password;

            UserName = UserName1.Text;
            Password = Password1.Text;

            if (String.IsNullOrEmpty(UserName) || String.IsNullOrEmpty(Password))
            {
                // check for user input
            }
            else
            {
                if (bend.LoginQuery(UserName, Password))
                {
                    InvalidInputBox.Text = "successful login";
                    Response.Redirect("Default.aspx");
                }
                else
                    InvalidInputBox.Text = "login fail";
            }
        }
    }
}
