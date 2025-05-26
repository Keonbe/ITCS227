using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Lec_FinalActivity1
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        ClassMethods classMethods = new ClassMethods();
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Check if admin login
            if (tbUsername.Text == "admin" && tbPassword.Text == "admin")
            {
                Response.Redirect("AdminPage.aspx");
                return;
            }

            // Check normal user login
            if (classMethods.CheckLogin(tbUsername.Text, tbPassword.Text))
            {
                // Login successful - set session variables
                Session["EmailAddress"] = classMethods.EmailAddressClass;
                Session["BasicMonthlySalary"] = classMethods.BasicMontlySalaryClass;
                Session["Password"] = classMethods.PasswordClass;

                //Session["EmailAddress"] = tbUsername.Text;
                Session["Password"] = tbPassword.Text;

                // Redirect to salary loan calculator page
                Response.Redirect("SalaryLoanCalculator.aspx");
                return;
            }
            else
            {
                // Login failed - show error message
                lblPlaceholder.Text = "Invalid Username or Password";

                // Optionally, do not redirect immediately here, allow user to try again
                return;
            }

            // The following block should NOT run here because the method already returned above.
            // If you want to check for unregistered accounts, do it before login or in a different place.
            // Example: You can remove this block or move it to a different part of your application
            if (Session["EmailAddress"] == null && Session["BasicMonthlySalary"] == null)
            {
                lblPlaceholder.Text = "Account not Registered, Redirecting to Registration page";
                Response.AddHeader("REFRESH", "2;URL=Registration.aspx");
            }
        }
    }
}