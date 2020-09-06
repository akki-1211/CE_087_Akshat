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
    public partial class _1_edit : System.Web.UI.Page
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
                    //DropDownList1.Items.Add(new ListItem("Select Id", "-1"));
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
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            
            try
            {
                using (con)
                {
                    string query = "select * from student where ID=" + TextBox6.Text;
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {                        
                        TextBox2.Visible = true;
                        TextBox3.Visible = true;
                        TextBox4.Visible = true;
                        TextBox5.Visible = true;
                        while (sdr.Read())
                        {
                            name.Text = "Name:";
                            Sem.Text = "Sem:";
                            email.Text = "Email:";
                            mobile.Text = "Mobile_no:";
                            TextBox2.Text = sdr.GetString(1);
                            TextBox3.Text = Convert.ToString(sdr.GetInt16(3));
                            TextBox4.Text = sdr.GetString(4);
                            TextBox5.Text = sdr.GetString(2);

                        }
                        con.Close();

                        
                    }
                    else { Label1.Text = "Id not Found :("; }

                }
            }
            catch (Exception er) { Label1.Text = er.Message; }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            try
            {
                using (con)
                {
                    string query = "update student set name='" + TextBox2.Text + "',sem='" + TextBox3.Text + "',mobile_no='" + TextBox5.Text + "',email='" + TextBox4.Text + "'where ID=" + TextBox6.Text;
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Label1.Text = "Updated successfully";
                    con.Close();
                    Page_Load(sender, e);
                }
            }
            catch (Exception er) { Label1.Text = er.Message; }
        }
    }
}