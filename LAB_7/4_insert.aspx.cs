using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7_4
{
    public partial class _4_insert : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbc = new DataClasses1DataContext())
            {
                student s = new student()
                {
                    sid = Convert.ToInt32(TextBox1.Text),
                    name = TextBox2.Text,
                    sem = Convert.ToInt16(TextBox3.Text),
                    cpi = Convert.ToDouble(TextBox4.Text),
                    contact_no = TextBox5.Text,
                    email = TextBox6.Text
                };
                dbc.students.InsertOnSubmit(s);
                dbc.SubmitChanges();
                Label1.Text = "Inserted Successfully";
                TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
                TextBox4.Text = TextBox5.Text = TextBox6.Text = "";
            }
        }
    }
}