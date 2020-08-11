using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _2_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "admin" && TextBox2.Text == "admin")
            {
                Session["uname"] = TextBox1.Text;
                Session["password"] = TextBox2.Text;
                Response.Redirect("2_home.aspx");
            }
            else
            {
                Label1.Text = "<h1 forecolor=\"red\">Invalid Credentials</h1>";
            }
        }
    }
}