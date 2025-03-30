using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class dataClass
    {
        static ArrayList firstName = new ArrayList();
        static ArrayList lastName = new ArrayList();
        static ArrayList emailAddress = new ArrayList();

        #region Properties //getters and setters
        public static ArrayList FirstName { get => firstName; set => firstName = value; }
        public static ArrayList LastName { get => lastName; set => lastName = value; }
        public static ArrayList EmailAddress { get => emailAddress; set => emailAddress = value; }
        #endregion


        public void SaveRecord(string emailAddress, string firstName, string lastName) //ERROR: use "public void" not "public static void"
        {
            EmailAddress.Add(emailAddress);
            FirstName.Add(firstName);
            LastName.Add(lastName);
        }

    }
}
