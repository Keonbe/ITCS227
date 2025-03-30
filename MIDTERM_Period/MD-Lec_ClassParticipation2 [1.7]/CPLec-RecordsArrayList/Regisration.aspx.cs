using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

namespace CPLec_RecordsArrayList
{
	public partial class Regisration : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                Session["EmailAddress"] = string.Empty;
                Session["Password"] = string.Empty;
                Session["FirstName"] = string.Empty;
                Session["LastName"] = string.Empty;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Clear previous messages
            lblPlaceholder.Text = "";
            lblPlaceholder.ForeColor = System.Drawing.Color.Red;

            // Validate input fields
            if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) ||
                string.IsNullOrEmpty(tbEmailAddress.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                lblPlaceholder.Text = "Error: Please fill in all fields.";
                return;
            }

            // Validate password length
            if (tbPassword.Text.Length < 8)
            {
                lblPlaceholder.Text = "Error: Password must be at least 8 characters long.";
                return;
            }

            // Validate password match
            if (tbPassword.Text != tbConfirmPass.Text)
            {
                lblPlaceholder.Text = "Error: Password and Confirm Password do not match.";
                return;
            }

            // Save data to dataClass
            dataClass myData = new dataClass();
            myData.SaveRecord(tbEmailAddress.Text, tbFirstName.Text, tbLastName.Text);

            // Set session variables
            Session["EmailAddress"] = tbEmailAddress.Text;
            Session["Password"] = tbPassword.Text;
            Session["FirstName"] = tbFirstName.Text;
            Session["LastName"] = tbLastName.Text;

            // Redirect to Login.aspx
            Response.Redirect("Login.aspx");
        }
    }
}

#region first code, doesnt work
/* this doesnt work
            if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) ||
                string.IsNullOrEmpty(tbEmailAddress.Text) || string.IsNullOrEmpty(tbPassword.Text)) //validation if empty
            {
                lblPlaceholder.Text = "Error: Please fill in all fields.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                return;
            }

            bool passwordSame = false;
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
                passwordSame = true;
                return;
            }

            if (!passwordSame) //if all validations pass, redirect
            {
                Session["EmailAddress"] = tbEmailAddress.Text;
                Session["Password"] = tbPassword.Text;
                Session["FirstName"] = tbFirstName.Text;
                Session["LastName"] = tbLastName.Text;
                Response.Redirect("Login.aspx");
            }

            dataClass myData = new dataClass();
            myData.SaveRecord(tbEmailAddress.Text, tbFirstName.Text, tbLastName.Text);

        }
        */
#endregion