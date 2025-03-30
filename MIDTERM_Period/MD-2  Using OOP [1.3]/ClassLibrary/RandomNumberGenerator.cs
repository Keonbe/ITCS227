using System;
using System.Collections.Generic;
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
    public class RandomNumberGenerator //1.B
    {
        private Random randomGenerator = new Random();

        public int GetRandomNumber()
        {
            int randomNumber = randomGenerator.Next(10);
            return randomNumber; 
        }
    }
}