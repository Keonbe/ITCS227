using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MIDTERM_Bembo
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblPlaceholder.ForeColor = System.Drawing.Color.Red;
            string studentid = Convert.ToString(Session["StudentID"]);
            string password = Convert.ToString(Session["Password"]);


            if (string.IsNullOrEmpty(studentid) || string.IsNullOrEmpty(password)) //session empty error
            {
                lblPlaceholder.Text = "Error: Session data missing. Please complete registration.";
                return;
            }

            bool isValidUser = false;
            if (tbUsername.Text != studentid || tbPassword.Text != password) // input validation error
            {
                lblPlaceholder.Text = "Error: Incorrect Password or username.";
                return;
            }

            lblPlaceholder.Text = "Login successful!";
            lblPlaceholder.ForeColor = System.Drawing.Color.Green;
            Response.Redirect("ViewRecords.aspx");
        }
    }
}