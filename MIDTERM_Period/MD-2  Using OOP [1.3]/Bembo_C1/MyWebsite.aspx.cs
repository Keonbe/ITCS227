using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bembo_C1
{
    public partial class MyWebsite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStudentID.Text = Session["studentID"].ToString();
            lblStudentName.Text = Session["studentName"].ToString();
            lblCYS.Text = Session["CYS"].ToString();
        }
    }
}