using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["items"] != null)
            {
                Label1.Text = "Your Selected Items...";
                String item = Session["items"].ToString();
                String[] items = item.Split();
                foreach (String i in items)
                    Label2.Text += "<li>" + i + "</li>";
                Label3.Text = "Total Amount:" + Session["value"];
                Session["value"] = null;
                Session["items"] = null;

            }
            else
            {
                Label1.Text = "No Items Are selected";
            }
        }
    }
}