using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
        protected void custom_PAN(object sender,ServerValidateEventArgs e)
        {
            String pan = e.Value;
            if(pan[0]=='A' || pan[0]=='B')
            {
                if(e.Value.Length == 10)
                {
                    e.IsValid = true;
                }
                else
                {
                    e.IsValid = false;
                }
            }
            else
                e.IsValid = false;  
        }
        protected void OnSelectedIndexChanged(object sender,EventArgs e)
        {
            city.Items.Clear();
            if(DropDownList1.SelectedValue == "Gujarat")
            {
                city.Items.Insert(0, "Ahemdabad");
                city.Items.Insert(1, "Vadodra");
            }
            else if(DropDownList1.SelectedValue == "Maharastra")
            {
                city.Items.Insert(0, "Mumbai");
                city.Items.Insert(1, "Pune");
            }
                
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Label2.Text = "Name: "+fname.Text;
                Label3.Text = "Age: "+age.Text;
                Label4.Text = "Password:"+pswd.Text;
                Label5.Text = "Gender: "+RadioButtonList2.Text;
                Label6.Text = "State: "+DropDownList1.Text;
                Label7.Text = "City: "+city.Text;
                Label8.Text = "PAN: "+pan.Text;
            }
        }
    }
}