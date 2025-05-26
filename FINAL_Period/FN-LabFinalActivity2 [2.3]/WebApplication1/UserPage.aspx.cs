using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace WebApplication1
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["StudentID"] != null && Session["StudentName"] != null)
                {
                   lblStudentID.Text = Session["StudentID"].ToString();
                   lblStudentName.Text = Session["StudentName"].ToString();
                }
                else
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
        }

        ClassMethod myData = new ClassMethod();

        protected void Button1_Click(object sender, EventArgs e)
        {
         myData.UpdateUserPassword(lblStudentID.Text, tbOldPassword.Text, tbNewPassword.Text);
        }
    }
}