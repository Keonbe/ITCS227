using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Methods
    {
        public static double Downpayment(double dpPercentage, double tcp) //Down payment = % option * TCP 
        {
            return dpPercentage / 100 * tcp;
        }

        public static double TotalCashout(double dp, double discount) //Total Cash out = down payment – discount (if any) 
        {
            return dp - (dp * discount);
        }

        public static double MonthlyAmortization(double tcp, int years, double totalCashout) ////Monthly amortization = (TCP – total Cash out) / (number of year to pay * 12) 
        {

            return (tcp - totalCashout) / (years * 12);
        }

        public static double TotalPrice(double tcp, double miscellaneous) //Total Price = TCP + Miscellaneous 
        {
            return tcp + miscellaneous;
        }

        public static double miscellaneous() //Miscellaneous = Chattel Mortgage + Insurance with acts of God + LTO Registration for 3 years.  
        {
            return 35000 + 30000 + 8500;
            //double miscellaneous = years == 5 ? 0 : 35000 + 30000 + 8500; //'?' shorthand notation
        }

        public static string customertypeString(int customerTypeIndex)
        {
            switch (customerTypeIndex)
            {
                case 0: // Assuming Platinum is at index 0
                    return "Platinum";
                case 1: // Gold at index 1
                    return "Gold";
                case 2: // Silver at index 2
                    return "Silver";
                default:
                    throw new ArgumentException("Invalid membership type");
            }
        }

        public static double customertypeDiscount(double customerTypeID)
        {
            switch (customerTypeID)
            {
                case 0: // Platinum
                    return 0.07;
                case 1: // Gold
                    return 0.055;
                case 2: // Silver
                    return 0.043;
                default:
                    throw new ArgumentException("Invalid membership type");
            }
        }


    }
}
