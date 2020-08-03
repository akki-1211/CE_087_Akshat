using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(uname.Text == "admin" && pswd.Text == "admin")
            {

                Response.Redirect("home.aspx");
            }
            else
            {
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Text = "incorrect credentials";
            }
        }
    }
}