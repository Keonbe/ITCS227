using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace MIDTERM_Bembo
{
	public partial class Regisration : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve session values
                string studentID = Session["StudentID"] as string;
                string password = Session["Password"] as string;

                // Print to lblPlaceholder
                lblPlaceholder.Text = $"Login Page: Session[StudentID]: {studentID} <br/> Login Page: Session[Password]: {password}";

                // Optional: Change text color for visibility
                lblPlaceholder.ForeColor = System.Drawing.Color.Blue;
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            lblPlaceholder.Text = "";  // Clear messages
            lblPlaceholder.ForeColor = System.Drawing.Color.Red;

            // Validate input fields
            if (string.IsNullOrEmpty(tbStudentID.Text) || string.IsNullOrEmpty(tbStudentName.Text) ||
                string.IsNullOrEmpty(tbCYS.Text) || string.IsNullOrEmpty(tbPassword.Text)) // Validate input fields
            {
                lblPlaceholder.Text = "Error: Please fill in all fields.";
                return;
            }

            if (tbPassword.Text != tbConfirmPassword.Text) // Validate password match
            {
                lblPlaceholder.Text = "Error: Password and Confirm Password do not match.";
                return;
            }

            Session["StudentID"] = tbStudentID.Text; // Set session variables
            Session["Password"] = tbPassword.Text;



            ClassMethod myData = new ClassMethod();
            myData.SaveRecord(tbStudentID.Text, tbStudentName.Text, tbCYS.Text, tbPassword.Text);

            Response.Redirect("Login.aspx");

        }
    }
}