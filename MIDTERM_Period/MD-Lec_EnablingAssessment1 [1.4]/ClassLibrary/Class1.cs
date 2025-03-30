using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        /*
        public static string DecimalToBinaryConversion(int decimalNumber)
        {
            string binaryValue = string.Empty;
            int remainder;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                binaryValue = remainder.ToString() + binaryValue;
            }
            return binaryValue;
        }
         */

        public static string DecimalToBinaryConversion(int decimalNumber)
        {
            if (decimalNumber == 0){
                return "0";
            }

            string binary = "";

            // Step 3: Divide by 2 and record remainders
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2; 
                binary = remainder + binary; 
                decimalNumber = decimalNumber / 2; 
            }

            return binary;
        }
    }
}
