using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Activity1Lec
{
    public partial class Website2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStudentID.Text = Session["studentID"].ToString();
            lblStudentName.Text = Session["studentName"].ToString();

            string courseValue = Session["studentCourse"]?.ToString(); //alternate way for Session -> lbl__.Text
            if (!string.IsNullOrEmpty(courseValue))
            {
                lblCourse.Text = CourseLabel(courseValue);
            }
            else
            {
                lblCourse.Text = "No Course Assigned"; //Fallback if error
            }

            lblTuitionFee.Text = Session["TuitionFee"].ToString();
            lblDownpayment.Text = Session["Downpayment"].ToString();
            lblTotalBalance.Text = Session["TotalBalance"].ToString();
        }

        /*
BIT	1500.00
BCS	1400.00
HUB	1250..00
MEB	1100.00
APM	950.00
 */
        private string CourseLabel(string courseValue)
        {
            switch (courseValue)
            {
                case "1500.00":
                    return "BIT";
                case "1400.00":
                    return "BCS";
                case "1250.00":
                    return "HUB";
                case "1100.00":
                    return "MEB";
                case "950.00":
                    return "APM";
                default:
                    return "Unknown Course"; 
            }
        }



    }

}
