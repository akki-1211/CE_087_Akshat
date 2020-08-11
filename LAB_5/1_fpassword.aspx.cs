using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5_1
{
    public partial class fpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["password"];
            if(cookie != null)
            {
                String color = TextBox1.Text.ToLower();
                if(cookie["color"] == color)
                {
                    Label1.Text = "Your Password is: " + cookie["password"];
                }
                else
                {
                    Label1.Text = "Your Password is not define. or incorrect color";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["password"].Expires = DateTime.Now.AddYears(-1);
            Response.Redirect("login.aspx?c=1");
        }
    }
}