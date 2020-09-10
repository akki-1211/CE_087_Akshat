using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7_4
{
    public partial class _4_update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            DataClasses1DataContext dbc = new DataClasses1DataContext();
            GridView1.DataSource = from student in dbc.students select student;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != null)
            {
                int id = Convert.ToInt32(TextBox1.Text);
                using (DataClasses1DataContext dbc = new DataClasses1DataContext())
                {
                    student s = dbc.students.SingleOrDefault(x => x.sid == id);
                    TextBox2.Text = s.name;
                    TextBox3.Text = Convert.ToString(s.sem);
                    TextBox4.Text = Convert.ToString(s.cpi);
                    TextBox5.Text = s.contact_no;
                    TextBox6.Text = s.email;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != null)
            {
                int id = Convert.ToInt32(TextBox1.Text);
                using (DataClasses1DataContext dbc = new DataClasses1DataContext())
                {
                    student s = dbc.students.SingleOrDefault(x => x.sid == id);
                    s.name = TextBox2.Text;
                    s.sem = Convert.ToInt16(TextBox3.Text);
                    s.cpi = Convert.ToDouble(TextBox4.Text);
                    s.contact_no = TextBox5.Text;
                    s.email = TextBox6.Text;
                    dbc.SubmitChanges();
                    Label1.Text = "Updated Successfully";
                    TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
                    TextBox4.Text = TextBox5.Text = TextBox6.Text = "";
                }
            }
        }
    }
}