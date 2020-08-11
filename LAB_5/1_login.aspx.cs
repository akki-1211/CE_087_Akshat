using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5_1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Label1.Text = "";
            if (Request.QueryString["c"] != null)
            {
                int c = Int32.Parse(Request.QueryString["c"]);
                if (c == 1)
                {
                    Label1.Text = "Cookie deleted";
                }
            }
        }
    }
}