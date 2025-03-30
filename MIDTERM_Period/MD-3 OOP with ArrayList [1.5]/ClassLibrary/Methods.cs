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
            return dpPercentage/100 * tcp;
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

        /*
        public static double customertypeDiscount(string customerType)
        {
            double discountRate = 0;
            switch (customerType.ToLower())
            {
                case "platinum":
                    discountRate = 0.07; // 7%
                    break;
                case "gold":
                    discountRate = 0.055; // 5.5%
                    break;
                case "silver":
                    discountRate = 0.043; // 4.3%
                    break;
                default:
                    throw new ArgumentException("Invalid membership type");
            }
            return discountRate; // Return discount rate
        }
        */

        //---
        /*
        public static string GetCustomerTypeString(double discountValue)
        {
            switch (discountValue)
            {
                case 0.07: return CustomerType.Platinum.ToString();
                case 0.055: return CustomerType.Gold.ToString();
                case 0.043: return CustomerType.Silver.ToString();
                default: return "Unknown";
            }
        }

        public static string customertypeString(double customerTypeValue)
        {
            string customerType = "";
            switch (customerTypeValue)
            {
                case 0.007:
                    customerType = "Platinum"; // 7%
                    break;
                case 0.055:
                    customerType = "Gold"; // 5.5%
                    break;
                case 0.043:
                    customerType = "Silver"; // 4.3%
                    break;
                default:
                    throw new ArgumentException("Invalid membership type");
            }
            return customerType; 
        }
        <--->
         public static string customertypeString(string customerTypeValue)
        {
            switch (customerTypeValue)
            {
                case "0.07":
                    return "Platinum";
                case "0.055":
                    return "Gold";
                case "0.043":
                    return "Silver";
                default:
                    throw new ArgumentException("Invalid membership type");
            }
        }

         public static double customertypeDiscount(string customerTypeValue)
        {
            // Since we already have the discount rate, just parse it
            if (double.TryParse(customerTypeValue, out double discountRate))
                return discountRate;

            throw new ArgumentException("Invalid membership type");
        }

        */

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
