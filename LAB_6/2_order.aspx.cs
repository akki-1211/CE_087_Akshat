using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Lab6_2
{
    public partial class order : System.Web.UI.Page
    {
        //SqlConnection con;
        //SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["items"] != null)
            {
                Label1.Text = "Your Selected Items...";
                String item = Session["items"].ToString();
                String[] items = item.Split();
                foreach (String i in items)
                    Label1.Text += "<li>" + i + "</li>";
                Label2.Text = "Total Amount:" + Session["total"];

            }
            else
            {
                Label1.Text = "No Items Are selected";
            }
        }
    }
}