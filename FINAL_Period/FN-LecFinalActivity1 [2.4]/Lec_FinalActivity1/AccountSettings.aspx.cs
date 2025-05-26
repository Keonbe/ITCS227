using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Lec_FinalActivity1
{
    public partial class AccountSettings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["EmailAddress"] != null) //login
                {
                    // User is logged in - enable buttons
                    tbFirstName.Enabled = true;
                    tbLastName.Enabled = true;
                    tbBasicMonthlySalary.Enabled = true;
                    tbPassword.Enabled = true;
                    btnSave.Enabled = true;

                    lblClient.Text = Session["EmailAddress"].ToString();
                }
                else //Not login
                {
                    tbFirstName.Enabled = false;
                    tbLastName.Enabled = false;
                    tbBasicMonthlySalary.Enabled = false;
                    tbPassword.Enabled = false;
                    btnSave.Enabled = false;

                    lblClient.Text = "⚠️ Not logged in";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassMethods classMethods = new ClassMethods();
            string emailAddress = Session["EmailAddress"].ToString();
            string passWord = Session["Password"].ToString();

            classMethods.UpdateDatabaseRecord(tbFirstName.Text, tbLastName.Text, tbBasicMonthlySalary.Text, emailAddress, passWord, tbPassword.Text);
        }
    }
}