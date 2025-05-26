using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LoanCalculations
    {
        /*
         * ABC company is in need to create a Salary Loan Calculator for their respective clients Formula :
            Loan Amount = Basic Monthly Salary * 2.5
            Interest = Loan Amount * number of months to pay * Interest rate
            Interest Table
            Number of Months to Pay Interest Rate
            1-5
            6-10
            11-15
            16-20
            21-25
            0.62%
            0.65%
            0.68%
            0.75%
            0.80%
            Take Home Loan Loan Amount - (Interest + Service Charge)
            Service Charge = 2% of Loan Amount
            Monthly Amortization Loan Amount I Number of months to pay
            Loan Details Output: Loan Amount / Interest / Take Home Loan / Service Charge / Monthly Amortization
         */


        //Computation Loan Calculator
        public double LoanAmountCalc(double basicMonthlySalary)
        {
            return basicMonthlySalary * 2.5;
        }

        public double InterestCalc(double loanAmount, int numberOfMonthsToPay, double interestRate)
        {
            return loanAmount * numberOfMonthsToPay * interestRate;
        }

        //InterestTable?Rate
        public double GetInterestRate(int MonthsToPay)
        {
            if (MonthsToPay >= 1 && MonthsToPay <= 5)
            {
                return 0.0062; // 0.62%
            }
            else if (MonthsToPay >= 6 && MonthsToPay <= 10)
            {
                return 0.0065; // 0.65%
            }
            else if (MonthsToPay >= 11 && MonthsToPay <= 15)
            {
                return 0.0068; // 0.68%
            }
            else if (MonthsToPay >= 16 && MonthsToPay <= 20)
            {
                return 0.0075; // 0.75%
            }
            else if (MonthsToPay >= 21 && MonthsToPay <= 25)
            {
                return 0.0080; // 0.80%
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(MonthsToPay), "Number of months to pay must be between 1 and 25.");
            }
        }


        public double TakeHomeLoanCalc(double loanAmount, double interest, double serviceCharge)
        {
            return loanAmount - (interest + serviceCharge);
        }

        public double ServiceChargeCalc(double loanAmount)
        {
            return loanAmount * 0.02;
        }

        public double MonthlyAmortizationCalc(double loanAmount, int numberOfMonthsToPay)
        {
            return loanAmount / numberOfMonthsToPay;
        }
    }
}
