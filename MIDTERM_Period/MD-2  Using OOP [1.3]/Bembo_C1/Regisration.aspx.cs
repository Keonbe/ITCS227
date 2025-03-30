using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bembo_C1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["studentID"] = tbStudentID.Text;
            Session["studentName"] = tbStudentName.Text;
            Session["CYS"] = tbCYS.Text;
            Session["Email"] = tbEmail.Text;
            Session["Password"] = tbPassword.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String VerifyPass = tbConfirmPass.Text;
            String pass = tbPassword.Text;
            bool boolBirth = false;
            bool boolPass = false;


            if (DateTime.TryParse(tbBirthday.Text, out DateTime Birthdate))
            { //verify birthday
                int age = DateTime.Now.Year - Birthdate.Year;
                if (age < 18)
{
                    lblPlaceholder.Text = ("Invalid age: User under 18");
                }
                else{
                    boolBirth = true;
                    //Response.Redirect("MyLogin.aspx");
                }
            }

            if (VerifyPass != pass){
                lblPlaceholder.Text = ("Security fault: Password not same");
            }
            else{
                boolPass = true;
                //Response.Redirect("MyLogin.aspx");
            }

            if (boolBirth && boolPass)
            {
                Response.Redirect("MyLogin.aspx");
            }

        }
    }
}