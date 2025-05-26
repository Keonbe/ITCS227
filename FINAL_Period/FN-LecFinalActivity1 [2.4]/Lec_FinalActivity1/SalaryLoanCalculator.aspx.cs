using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Lec_FinalActivity1
{
    public partial class SalaryLoanCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region codeOldSession
            /*
            if (!IsPostBack) //Session login
            {
                if (Session["EmailAddress"] != null)
                {
                    lblClient.Text = Session["EmailAddress"].ToString();
                }
                else
                {
                    lblClient.Text = "⚠️ Not logged in";
                }

                if (Session["BasicMonthlySalary"] != null)
                {
                    lblMonthlySalary.Text = Session["BasicMonthlySalary"].ToString();
                }
            */
            #endregion

            if (!IsPostBack) //Login
            {
                // Check if user is logged in by verifying session
                if (Session["EmailAddress"] != null)
                {
                    // User is logged in - enable buttons
                    tbMonthsToPay.Enabled = true;
                    btnComputeLoan.Enabled = true;
                    btnSubmitLoan.Enabled = true;

                    lblClient.Text = Session["EmailAddress"].ToString();

                    if (Session["BasicMonthlySalary"] != null)
                    {
                        lblMonthlySalary.Text = Session["BasicMonthlySalary"].ToString();
                    }
                }
                else //Not login
                {
                    tbMonthsToPay.Enabled = false;
                    btnComputeLoan.Enabled = false;
                    btnSubmitLoan.Enabled = false;
                    btnLogout.Enabled = false;

                    lblClient.Text = "⚠️ Not logged in";

                    lblMonthlySalary.Text = "";
                    lblLoanAmount.Text = "";
                    lblInterest.Text = "";
                    lblServiceCharge.Text = "";
                    lblTakeHomeLoan.Text = "";
                    lblMonthlyAmort.Text = "";
                }
            }
        }



        LoanCalculations loanCalculations = new LoanCalculations();
        protected void Button1_Click(object sender, EventArgs e) //compute loan
        {
            LoanCalculations loanCalculations = new LoanCalculations();
            try
            {
                double salary = double.Parse(lblMonthlySalary.Text);
                int monthsToPay = Convert.ToInt32(tbMonthsToPay.Text);
                double interestRate = loanCalculations.GetInterestRate(monthsToPay);

                // Sample values (replace with your actual formulas)
                double loanAmount =  loanCalculations.LoanAmountCalc(salary);
                double interest = loanCalculations.InterestCalc(loanAmount, monthsToPay, interestRate);
                double serviceCharge = loanCalculations.ServiceChargeCalc(loanAmount);
                double takeHome = loanCalculations.TakeHomeLoanCalc(loanAmount, interest, serviceCharge); //loanAmount - (interest + serviceCharge)
                double monthlyAmort = loanCalculations.MonthlyAmortizationCalc(loanAmount, monthsToPay);

                // Populate fields
                lblLoanAmount.Text = loanAmount.ToString("N2");
                lblInterest.Text = interest.ToString("N2");
                lblServiceCharge.Text = serviceCharge.ToString("N2");
                lblTakeHomeLoan.Text = takeHome.ToString("N2");
                lblMonthlyAmort.Text = monthlyAmort.ToString("N2");

                // Show panel
                pnlLoanResults.Visible = true;
            }
            catch (Exception ex)
            {
                lblPlaceholder.Text = "Error: " + ex.Message;
            }
        }

        protected void btnSubmitLoan_Click(object sender, EventArgs e) //submitloan
        {
            ClassMethods classMethods = new ClassMethods();

            decimal monthlySalary = decimal.Parse(lblMonthlySalary.Text);
            decimal loanAmount = decimal.Parse(lblLoanAmount.Text);
            decimal interest = decimal.Parse(lblInterest.Text);
            decimal serviceCharge = decimal.Parse(lblServiceCharge.Text);
            decimal takeHomeLoan = decimal.Parse(lblTakeHomeLoan.Text);
            decimal monthlyAmort = decimal.Parse(lblMonthlyAmort.Text);
            int monthsToPay = int.Parse(tbMonthsToPay.Text);
            string emailAddress = Session["EmailAddress"].ToString();

            classMethods.SaveLoanRecord(
                monthlySalary: monthlySalary,
                loanAmount: loanAmount,
                interest: interest,
                serviceCharge: serviceCharge,
                takeHomeLoan: takeHomeLoan,
                amortization: monthlyAmort,
                monthsToPay: monthsToPay,
                emailAddress: emailAddress
            );
        }

        protected void Button1_Click1(object sender, EventArgs e) //Logout
        {
            Session.Clear();        // Clear session data
            Session.Abandon();      // Ends session

            lblClient.Text = "⚠️ Not logged in"; //Reset labels displaying user info
            lblMonthlySalary.Text = "";

            lblLoanAmount.Text = ""; //Reset loan calculation output labels
            lblInterest.Text = "";
            lblServiceCharge.Text = "";
            lblTakeHomeLoan.Text = "";
            lblMonthlyAmort.Text = "";

            tbMonthsToPay.Text = ""; //clear input fields 
            Response.Redirect("LoginPage.aspx");
        }

    }
}