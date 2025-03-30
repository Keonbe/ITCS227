using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4___Implementing_Master_Page
{
	public partial class Regisration : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                Session["EmailAddress"] = string.Empty;
                Session["Password"] = string.Empty;
                Session["CustomerType"] = string.Empty;
                Session["FirstName"] = string.Empty;
                Session["LastName"] = string.Empty;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) ||
                string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                lblPlaceholder.Text = "Error: Please fill in all fields.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                return;
            }

            bool passwordGood = false;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPass.Text;
            if (password.Length < 8)     // Password length validation error
            {
                lblPlaceholder.Text = "Error: Password must be at least 8 characters long.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (password != confirmPassword) //Crosscheck if Passwords Match
            {
                lblPlaceholder.Text = "Error: Password and Confirm Password do not match.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                passwordGood = true;
                return;
            }


            // Store user information in session variables
            Session["FirstName"] = tbFirstName.Text;
            Session["LastName"] = tbLastName.Text;
            Session["EmailAddress"] = tbEmail.Text;
            Session["Password"] = tbPassword.Text;
            Session["CustomerType"] = ddlistCustomerType.SelectedItem.Text;
            Session["Discount"] = ddlistCustomerType.SelectedValue; //Discount rate


            lblPlaceholder.Text = "Registration successful! Redirecting to login page...";
            lblPlaceholder.ForeColor = System.Drawing.Color.Green;
            Response.Redirect("LoginPage.aspx");

        }
    }
}
