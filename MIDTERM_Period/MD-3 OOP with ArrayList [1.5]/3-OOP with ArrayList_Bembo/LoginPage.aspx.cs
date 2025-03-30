using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_OOP_with_ArrayList_Bembo
{
	public partial class LoginPage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btn1_Click(object sender, EventArgs e)
        {
            string email = Session["EmailAddress"].ToString();
            string password = Session["Password"].ToString();

            if (tbUsername.Text != email || tbPassword.Text != password) // input validation error
            {
                lblPlaceholder.Text = "Error: Incorrect Password or username.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                return;
            }

            //if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            //{
            //    lblPlaceholder.Text = "Error: Please enter both email and password.";
            //    lblPlaceholder.ForeColor = System.Drawing.Color.Red;
            //    return;
            //}

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