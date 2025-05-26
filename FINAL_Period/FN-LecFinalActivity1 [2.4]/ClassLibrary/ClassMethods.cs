using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClassMethods
    {
        //Connection String
        static string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\c#\appdev\FINALS\Lec_FinalActivity1\Lec_FinalActivity1\App_Data\Database1.mdf;Integrated Security=True";

        //Conncetion Object
        SqlConnection sqlConn = new SqlConnection(ConnStr);

        //Stored Procedure Method
        public void SaveRecordRegisration(string firstName, string lastName, string basicMonthlySalary, string emailAddress, string passWord)
        {
            sqlConn.Open();
            SqlCommand saveRecord = new SqlCommand("SaveRecordsRegisration", sqlConn);
            saveRecord.CommandType = CommandType.StoredProcedure;

            //@FirstName, @LastName, @BasicMonthlySalary, @EmailAddress, @Password
            saveRecord.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName;
            saveRecord.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
            //saveRecord.Parameters.Add("@BasicMonthlySalary", SqlDbType.Decimal).Value = basicMonthlySalary;
            saveRecord.Parameters.Add("@BasicMonthlySalary", SqlDbType.Decimal).Value = Convert.ToDecimal(basicMonthlySalary);
            saveRecord.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = emailAddress;
            saveRecord.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passWord;
            saveRecord.ExecuteNonQuery();
            sqlConn.Close();
        }

        #region
        string EmailAddress, BasicMontlySalary, Password; //CTRL R + E
        public string EmailAddressClass { get => EmailAddress; set => EmailAddress = value; }
        public string BasicMontlySalaryClass { get => BasicMontlySalary; set => BasicMontlySalary = value; }
        public string PasswordClass { get => Password; set => Password = value; }
        #endregion

        public bool CheckLogin(string emailAddress, string passWord)
        {
            bool isValid = false;
            sqlConn.Open();
            SqlCommand checkLogin = new SqlCommand("LoginAccountCheck", sqlConn);
            checkLogin.CommandType = CommandType.StoredProcedure;
            //@EmailAddress, @Password
            checkLogin.Parameters.Add("@userName", SqlDbType.NVarChar).Value = emailAddress;
            checkLogin.Parameters.Add("@passWord", SqlDbType.NVarChar).Value = passWord;
            SqlDataReader reader = checkLogin.ExecuteReader();
            while (reader.Read())
            {
                EmailAddress = reader["EmailAddress"].ToString();
                BasicMontlySalary = reader["BasicMonthlySalary"].ToString();
                isValid = true;
                break;
            }
            sqlConn.Close();
            return isValid;
        }

        public void UpdateDatabaseRecord(string firstName, string lastName, string basicMonthlySalary, string emailAddress, string passWord, string newPassword)
        {
            sqlConn.Open();
            SqlCommand updateRecord = new SqlCommand("dbo.SPChangeUserInfo", sqlConn);

            updateRecord.CommandType = CommandType.StoredProcedure;
            //@FirstName, @LastName, @BasicMonthlySalary, @EmailAddress, @Password
            updateRecord.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName;
            updateRecord.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
            updateRecord.Parameters.Add("@BasicMonthlySalary", SqlDbType.Decimal).Value = basicMonthlySalary;
            updateRecord.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = emailAddress;
            updateRecord.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passWord;
            updateRecord.Parameters.Add("@NewPassword", SqlDbType.NVarChar).Value = newPassword;
            updateRecord.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void SaveLoanRecord(
    decimal monthlySalary,
    decimal loanAmount,
    decimal interest,
    decimal serviceCharge,
    decimal takeHomeLoan,
    decimal amortization,
    decimal monthsToPay,
    string emailAddress
)
        {
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("SaveLoanApplication", sqlConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MonthlySalary", monthlySalary);
            cmd.Parameters.AddWithValue("@LoanAmount", loanAmount);
            cmd.Parameters.AddWithValue("@Interest", interest);
            cmd.Parameters.AddWithValue("@ServiceCharge", serviceCharge);
            cmd.Parameters.AddWithValue("@TakeHomeLoan", takeHomeLoan);
            cmd.Parameters.AddWithValue("@Amortizaton", amortization);
            cmd.Parameters.AddWithValue("@MonthsToPay", monthsToPay);
            cmd.Parameters.AddWithValue("@EmailAddress", emailAddress);
            cmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
