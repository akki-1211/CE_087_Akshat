using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class _1_insert : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            try
            {
                using (con)
                {
                    int count = 0;
                    string cmd = "select * from Student";
                    SqlCommand c = new SqlCommand(cmd,con);
                    con.Open();
                    SqlDataReader sdr = c.ExecuteReader();
                    while (sdr.Read()) { count++; }
                    TextBox1.Text = Convert.ToString(count+100+1) ;
                }
            }
            catch(Exception err)
            {
                Label1.Text = err.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            try
            {
                using (con)
                {
                    con.Open();
                    string query = "insert into student (name,email,mobile_no,sem) values (@name,@email,@mobile,@sem)";
                    cmd = new SqlCommand(query,con);
                    cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@email", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@sem", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@mobile", TextBox3.Text);
                    cmd.ExecuteNonQuery();
                    Label1.Text = "Added Successfully";
                    con.Close();
                    TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = "";

                }
            }
            catch(Exception err)
            {
                Label1.Text = err.Message;
            }
            Page_Load(sender, e);
        }
    }
}