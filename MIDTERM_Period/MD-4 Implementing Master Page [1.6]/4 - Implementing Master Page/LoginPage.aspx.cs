using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4___Implementing_Master_Page
{
	public partial class LoginPage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (Session["EmailAddress"] == null || Session["CustomerType"] == null || Session["Password"] == null) //login validation error
            {
                lblPlaceholder.Text = "Error: Session data missing. Please complete registration.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string email = Session["EmailAddress"].ToString();
            string password = Session["Password"].ToString();

            if (tbUsername.Text != email || tbPassword.Text != password) // input validation error
            {
                lblPlaceholder.Text = "Error: Incorrect Password or username.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                return;
            }

            bool isValidUser = false;
            if (tbUsername.Text == email && tbPassword.Text == password)
            {
                isValidUser = true;
            }

            if (isValidUser)
            {
                lblPlaceholder.Text = "Login successful!";
                lblPlaceholder.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("LoanCalculator.aspx");
            }
            else
            {
                lblPlaceholder.Text = "Error: Invalid email or password.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}