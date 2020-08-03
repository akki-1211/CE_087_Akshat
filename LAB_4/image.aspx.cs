using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class image : System.Web.UI.Page
    {
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if(Image1.Visible == false)
            {
                Image1.Visible = true;
            }
            else if(Image1.Visible == true)
            {
                Image1.Visible = false;
            }
        }
    }
}