using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _2_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["uname"] != null)
            {
                Label1.Text = "<h1>Welcome "+Session["uname"].ToString().ToUpper()+"</h1>";
            }
        }

        protected void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            Label3.Text = "Press Ctrl + Click any item for more than one items";
            if (RadioButton1.Checked == true)
            {
                ListBox1.Items.Clear(); 
                ListBox1.Items.Add(new ListItem("Smartphone", "15000"));
                ListBox1.Items.Add(new ListItem("Laptop", "50000"));
                ListBox1.Items.Add(new ListItem("Camera", "30000"));
            }
            else if(RadioButton2.Checked == true)
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add(new ListItem("Alchemist", "500"));
                ListBox1.Items.Add(new ListItem("The Breif History of time", "300"));
                ListBox1.Items.Add(new ListItem("Shiva Trilogy", "200"));
            }
            //ListBox1.Items.Clear();
            
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            var items = from ListItem li in ListBox1.Items
                        where li.Selected == true
                        select li;

            //Label1.Text = "you selected....<br />";
            //loop through selected items in listbox
            int sum = 0;
            foreach (ListItem li in items)
            {
                //selected item text and value.
                Session["items"] += li.Text + " ";
                sum += Int32.Parse(li.Value.ToString());
            }
            Session["value"] = sum;
            Response.Redirect("order.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = from ListItem li in ListBox1.Items
                        where li.Selected == true
                        select li;
            Label2.Text = "";
            foreach (ListItem li in items)
            {
                //selected item text and value.
                Label2.Text += li.Text + " Has Price INR:" + li.Value+"<br>";
            }

        }
    }
}