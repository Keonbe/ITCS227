using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPLec_RecordsArrayList
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblPlaceholder.ForeColor = System.Drawing.Color.Red;

            //login validation error
            if (Session["EmailAddress"] == null || Session["Password"] == null) 
            {
                lblPlaceholder.Text = "Error: Session data missing. Please complete registration.";
                return;
            }

            string email = Session["EmailAddress"].ToString();
            string password = Session["Password"].ToString();
            // input validation error
            if (tbUsername.Text != email || tbPassword.Text != password)
            {
                lblPlaceholder.Text = "Error: Incorrect Password or username.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                return;
            }

            bool isValidUser = false;
            //if input matches session data(both)
            if (tbUsername.Text == email && tbPassword.Text == password) 
            {
                isValidUser = true;
            }

            if (isValidUser)
            {
                lblPlaceholder.Text = "Login successful!";
                lblPlaceholder.ForeColor = System.Drawing.Color.Green; 
            }

        }
    }
}