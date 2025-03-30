using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GetInfo
    {
        static ArrayList firstName = new ArrayList();
        static ArrayList lastName = new ArrayList();
        static ArrayList customerType = new ArrayList();
        static ArrayList downPayment = new ArrayList();
        static ArrayList totalCashout = new ArrayList();
        static ArrayList monthlyAmortization = new ArrayList();
        static ArrayList totalPrice = new ArrayList();

        #region Properties
        public static ArrayList FirstName { get => firstName; set => firstName = value; }
        public static ArrayList LastName { get => lastName; set => lastName = value; }
        public static ArrayList CustomerType { get => customerType; set => customerType = value; }
        public static ArrayList DownPayment { get => downPayment; set => downPayment = value; }
        public static ArrayList TotalCashout { get => totalCashout; set => totalCashout = value; }
        public static ArrayList MonthlyAmortization { get => monthlyAmortization; set => monthlyAmortization = value; }
        public static ArrayList TotalPrice { get => totalPrice; set => totalPrice = value; }
        #endregion

        public void SetRecord(string firstName, string lastName, string customerType, string downPayment, string totalCashout, string monthlyAmortization, string totalPrice)
        {
            FirstName.Add(firstName);
            LastName.Add(lastName);
            CustomerType.Add(customerType);
            #region comment
            // ✅ Correct! Adds the actual customerType string
            //CustomerType.Add(CustomerType);  //❌Wrong! This adds the whole list inside itself
            #endregion
            DownPayment.Add(downPayment);
            TotalCashout.Add(totalCashout);
            MonthlyAmortization.Add(monthlyAmortization);
            TotalPrice.Add(totalPrice);

            System.Diagnostics.Debug.WriteLine($"Added to CustomerType: {customerType} (Type: {customerType.GetType()})");
        }


    }
}
