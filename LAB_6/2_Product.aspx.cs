using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Lab6_2
{
    public partial class Product : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        int c = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //ListBox1.Items.Clear();
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            try
            {
                using (con)
                {
                    string query = "select * from product";
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    GridView1.DataSource = sdr;
                    GridView1.DataBind();
                    sdr.Close();
                    sdr = cmd.ExecuteReader();
                    //if (c == 0)
                    //{
                        while (sdr.Read())
                        {
                            ListBox1.Items.Add(new ListItem(sdr.GetString(1), Convert.ToString(sdr.GetInt32(0))));
                        }
                        //c += 1;
                    //}
                    con.Close();
                }
            }
            catch (Exception err) { Label1.Text = err.Message; }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["items"] = "";
            var items = from ListItem li in ListBox1.Items
                        where li.Selected == true
                        select li;
            //Label2.Text = Session["userid"] + Convert.ToString(Session["password"]);
            foreach (ListItem li in items)
            {
                Session["items"] += li.Text + " ";
            }

            //Session["items"] = items;
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            Double sum = 0;
            try
            {
                using (con)
                {
                    SqlDataReader sdr = null ;
                    con.Open();
                    foreach (ListItem li in items)
                    {
                        string query = "select * from product where pid=" + Convert.ToString(li.Value);
                        //Label1.Text += li.Value;
                        cmd = new SqlCommand(query, con);
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            sum += (sdr.GetDouble(3));
                        }
                        
                    }
                    sdr.Close();
                    con.Close();
                    Session["total"] = (sum);
                    con.Open();
                    foreach (ListItem li in items)
                    {
                        string query = "insert into Order_tbl values (@uid,@pid)";
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        
                        //cmd1.Parameters.AddWithValue("@oid", 100);
                        cmd1.Parameters.AddWithValue("@uid",Convert.ToInt32(Session["userid"]));
                        cmd1.Parameters.AddWithValue("@pid",Convert.ToInt32(li.Value));
                        cmd1.ExecuteNonQuery();

                    }
                    Response.Redirect("order.aspx");
                    //ListBox1.Items.Clear();
                }
            }
            catch (Exception err)
            {
                Label1.Text = err.Message; }
        }
    }
}