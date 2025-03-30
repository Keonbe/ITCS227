using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

namespace Bembo_C2 //Tip: Build or Rebuild frequently if issues persist
{
    public partial class RegisrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)  // Prevent session overwriting every page load
            {
                Session["MemberName"] = string.Empty;
                Session["Membership"] = string.Empty;
                Session["MemberID"] = string.Empty;
            }

        }

        protected void Button1_Click(object sender, EventArgs e) //Need birthdate or age 18+ validation
        {
            bool boolName = false;
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)) //if empoty name
            {
                lblPlaceholder.Text = "Invalid Input: First Name or Last Name is empty.";
                return;
            } else {
                boolName = true;
            }

            if (string.IsNullOrWhiteSpace(tbBirthday.Text)) //if empty birthday
            {
                lblPlaceholder.Text = "Invalid birthday: Please enter your birthday.";
                return;
            } 

            bool boolBirth = false;
            if (DateTime.TryParse(tbBirthday.Text, out DateTime Birthdate)) //verify birthday
            { 
                int age = DateTime.Now.Year - Birthdate.Year;
                if (age < 18)
                {
                    lblPlaceholder.Text = ("Invalid birthday: User under 18");
                }
                else if (age > 18)
                {
                    boolBirth = true;
                    //Response.Redirect("MyLogin.aspx");
                }
            }

            String Fname = tbFirstName.Text;
            String Lname = tbLastName.Text;
            String initialFn = "", initialLn = "", generatedNumber = "";

            /*
            if (string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(Lname))
            {
                lblPlaceholder.Text = "Invalid Input: First Name or Last Name is empty";
                return;
            } else
            {
                boolName = true;
            }
            */
            generatedNumber = GenerateRandomNumber(5);
            initialFn = Fname.Remove(1, Fname.Length - 1);
            initialLn = Lname.Remove(1, Lname.Length - 1);
            string generatedName = initialFn + initialLn + generatedNumber;

            if (boolBirth && boolName)
            {
                lblMemberID.Text = generatedName;
                lblPlaceholder.Text = "Regisration Done";
            }

            /*
            if(string.IsNullOrEmpty(initialFn) || string.IsNullOrEmpty(initialLn))
            {
                lblPlaceholder.Text = ("Error:Empty name");
            }   else {
            generatedName = initialFn + initialLn + generatedName;
                }
            */

            Session["MemberName"] = tbFirstName.Text + " " + tbLastName.Text; //Store session after input process, not b4 input or pageload
            Session["Membership"] = DropdownMembership.SelectedValue; 
            Session["MemberID"] = lblMemberID.Text;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lblMemberID.Text))
            {
                lblPlaceholder.Text = "Error: Member not registered to proceed to next page";
                return;
            } else
            {
                Panel1.Visible = false;
                Response.Redirect("TransactionPage.aspx");
            }
        }

        private string GenerateRandomNumber(int length)
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();
            string randomNumber = "";
            for (int i = 0; i < length; i++)
            {
                randomNumber += generator.GetRandomNumber().ToString();
            }
            return randomNumber;
        }
    }
}