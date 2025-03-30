using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Activity1Lec
{
    public partial class Website1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["studentID"] = tbStudentID.Text;
            Session["studentName"] = tbStudentName.Text;
            Session["studentCourse"] = listCourse.SelectedValue; //dont use ddl as varName
            Session["studentUnits"] = tbUnits.Text;
            Session["studentID"] = tbStudentID.Text;
            Session["studentPayment"] = rblTuition.SelectedValue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbStudentID.Text) || string.IsNullOrEmpty(tbStudentName.Text))
            {
                lblPlaceholder.Text = "Error: Empty Student information";
                return;
            }

            //double noOfUnits = Convert.ToDouble(tbUnits.Text);
            if (Convert.ToDouble(tbUnits.Text) <= 0 && Convert.ToDouble(tbUnits.Text) <= 24) //error unresolved, if empty
            {
                lblPlaceholder.Text = "Error: Units Enrolled must be at least 1 or in between 24(Max units)";
                return;
            }

            if (Convert.ToDouble(tbUnits.Text) > 24)
                {
                    lblPlaceholder.Text = "Error: Units Enrolled exceeded, Select minumum amount of units to maximum amount of units";
                    return;
                }

            if (string.IsNullOrEmpty(rblTuition.SelectedValue))
            {
                lblPlaceholder.Text = "Error: No payment method selected";
                return;
            }

            double ratePerUnit = Convert.ToDouble(listCourse.SelectedValue);
            double payment = Convert.ToDouble(rblTuition.SelectedValue);
            double noOfUnits = Convert.ToDouble(tbUnits.Text);
            double tuitionFee = ratePerUnit * noOfUnits;
            double downPayment = tuitionFee * payment;
            double totalBalance = tuitionFee - downPayment;

            Session["TuitionFee"] = tuitionFee;
            Session["DownPayment"] = downPayment;
            Session["TotalBalance"] = totalBalance;

            Response.Redirect("Website2.aspx");
        }
    }
}