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
    public partial class _1_delete : System.Web.UI.Page
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
                    if (sdr.HasRows)
                    {
                        GridView1.DataSource = sdr;
                        GridView1.DataBind();
                    }
                    else { Label1.Text = "Id not Found :("; }
                    con.Close();
                }
            }
            catch (Exception er) { Label1.Text = er.Message; }
            /*DropDownList1.Items.Clear();
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
                    DropDownList1.Items.Add(new ListItem("Select Id", "-1"));
                    while (sdr.Read())
                    {
                        DropDownList1.Items.Add(new ListItem(Convert.ToString(sdr.GetInt32(0)), Convert.ToString(sdr.GetInt32(0))));
                    }
                    con.Close();
                }
            }
            catch (Exception err) { Label1.Text = err.Message; }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i;
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            
            try
            {
                using (con)
                {
                    string query = "delete from student where id="+ TextBox1.Text;
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Label1.Text = "Deleted SuccessFully";
                    }
                    else
                    { Label1.Text = "Id not Found :("; }
                    con.Close();
                    Page_Load(sender, e);
                }
            }
            catch (Exception err) { Label1.Text = err.Message; }
        }
    }
}