using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7_4
{
    public partial class _4_show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreRander(object sender, EventArgs e)
        {
            if(GridView1.SelectedRow != null)
            {
                DetailsView1.Visible = false;
            }
            else
            {
                DetailsView1.Visible = true;
            }
        }
    }
}