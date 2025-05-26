using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace WebApplication1
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DisplayRecords();
            }
        }

        public void DisplayRecords()
        {
            GridView1.DataSource = myData.DisplayAllRecords();
            GridView1.DataBind();
        }

        ClassMethod myData = new ClassMethod();

        protected void Button1_Click(object sender, EventArgs e)
        {
            myData.SaveNewRecord(tbStudentID.Text, tbStudentName.Text, tbCYS.Text, tbPassword.Text);
            DisplayRecords();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}