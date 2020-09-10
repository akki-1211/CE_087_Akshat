using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7_3
{
    public partial class _3_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dbc = new DataClasses1DataContext();
            GridView1.DataSource = dbc.products;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            string url = "3_product.aspx?";
            using (DataClasses1DataContext dtContext = new DataClasses1DataContext())
            {
                product p = dtContext.products.SingleOrDefault(x => x.pid == id);
                url += "pid=" + Convert.ToString(p.pid) + "&" + "name=" + p.name + "&" + "category=" + p.category + "&" +
                    "description=" + p.description + "&" + "price=" + p.price;
                Response.Redirect(url);
            }

        }
    }
}