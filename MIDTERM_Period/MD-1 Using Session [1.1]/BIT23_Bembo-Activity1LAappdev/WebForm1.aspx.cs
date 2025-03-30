using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIT23_Bembo_Activity1LAappdev
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTuition.Text = drpCourse.SelectedItem.Value;
            Panel1.Visible = false;
        }

        protected void drpCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTuition.Text = drpCourse.SelectedItem.Value;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            lblStudentID.Text = txtStudentID.Text;
            lblStudentName.Text = txtStudentName.Text;
            lblCourse.Text = drpCourse.SelectedItem.Value;

            double dp;
            double tuition = Convert.ToDouble(lblTuition.Text);
            double payment = Convert.ToDouble(downPaymentSelect.SelectedItem.Value); //error in value, "0.5" instead of "50%"
            dp = tuition * payment;
            lblDP.Text = dp.ToString("#,000.00");
            
        }

        protected void btnClear_Click1(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            lblTuition.Text = "";
            drpCourse.SelectedItem.Value = "";
        }
    }
}