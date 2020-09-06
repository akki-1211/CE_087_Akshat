using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class _1_show : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            try
            {
                using (con)
                {
                    string query = "select * from student";
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    GridView1.DataSource = sdr;
                    GridView1.DataBind();
                    con.Close();
                }
            }
            catch(Exception err) { Label1.Text = err.Message; }
        }
    }
}