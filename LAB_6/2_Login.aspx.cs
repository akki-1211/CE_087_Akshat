using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab6_2
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            try
            {
                using (con)
                {
                    int c = 0;
                    string pswd = "";
                    string query = "select * from [user]" +
                        " where ID=" + TextBox1.Text /*+ "and password=" + TextBox2.Text*/;
                    cmd = new SqlCommand(query, con);
                    con.Open();                    
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read()) { pswd = sdr.GetString(1);
                        c += 1;
                    }
                    if(c == 1 & pswd.Equals(TextBox2.Text))
                    {
                        Session["userid"] = TextBox1.Text;
                        Session["passwrod"] = TextBox2.Text;
                        Response.Redirect("Product.aspx");
                    }
                    else { Label1.Text = "not found"; }
                    con.Close();
                }
            }
            catch (Exception err) { Label1.Text = err.Message; }
        }
    }
}