using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace WebApplication1
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        ClassMethod myData = new ClassMethod();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(myData.CheckAccountValid(tbUsername.Text, tbPassword.Text))
            {
                Session["StudentID"] = myData.StudentID;
                Session["StudentName"] = myData.StudentName;
                Response.Redirect("UserPage.aspx");
            }
            else
            {
                lblPlaceholder.Text = "Invalid username or password.";
            }
        }
    }
}