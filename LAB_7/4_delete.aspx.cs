using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7_4
{
    public partial class _4_delete : System.Web.UI.Page
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
            if (TextBox1.Text != null)
            {
                int id = Convert.ToInt32(TextBox1.Text);
                using (DataClasses1DataContext dbc = new DataClasses1DataContext())
                {
                    student s = dbc.students.SingleOrDefault(x => x.sid == id);
                    dbc.students.DeleteOnSubmit(s);
                    dbc.SubmitChanges();
                    Label1.Text = "Deleted Successfully";
                    TextBox1.Text = "";
                }
            }
        }
    }
}