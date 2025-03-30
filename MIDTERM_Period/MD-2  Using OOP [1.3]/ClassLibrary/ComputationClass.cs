using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Create a Class Library for the following, Computation of.
1.A Applied Discount
2.A Total Amount Purchased per product
3.A Grand Total.
1.B Generation of Account Number
 */

namespace ClassLibrary
{
    public class ComputationClass
    {
        /*
        public double TotalAmountPurchased(double subtotal, double price, double quantity, double totalAmount) 
        {

            subtotal = quantity * price; //Get subtotal of chosen item
            totalAmount += subtotal; //Add subtotal to total amount/previous subtotal and its accumulated value, hard part '+='
            return totalAmount;
        }
        */

        public double TotalAmountPurchased(double subtotal, double totalAmount)
        {

            return totalAmount + subtotal;
        }

        public static double GetAppliedDiscount(string membershipType, double total, double itemCart)
        {
            double discountRate = 0;
            if (itemCart >= 3)
            {
                switch (membershipType.ToLower())
                {
                    case "silver":
                        discountRate = 0.12;
                        break;
                    case "gold":
                        discountRate = 0.15;
                        break;
                    case "platinum":
                        discountRate = 0.20;
                        break;
                }

                //return total * discountRate; //CS0161 error
            }
            return total * discountRate; //error fixed
        }

        public double GrandTotal(double totalAmount, double discount)
        {
            return (totalAmount - discount);
        }

    }
}
