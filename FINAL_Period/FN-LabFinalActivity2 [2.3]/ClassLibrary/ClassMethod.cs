using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class ClassMethod
    {

        /* <<Define your connection string>> by 
         CLicking the mdf file in this case "Masterfile.mdf"
         and then click on the properties window
        and copy the connection string and paste it here
         */
        static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\Masterfile.mdf;
                          Integrated Security=True;
                          Connect Timeout=30"; //This is where your DB is located
          /*@"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=C:\Users\user\source\repos\ClassLibrary\ClassLibrary\App_Data\Masterfile.mdf;
          Integrated Security=True"; */


        /*<<Define connection object>> by
        using System.Data;
        using System.Data.SqlClient;
        */
        SqlConnection myConn = new SqlConnection(connStr);

        public void SaveNewRecord(string studentID, string studentName, string course, string passWord) //Method for saving record
        {
            myConn.Open(); //Open state of our table
            SqlCommand saveCmd = new SqlCommand("SaveNewRecord", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure; //Defines the command type Storedprocedure
            saveCmd.Parameters.Add("@StudentID", SqlDbType.NVarChar).Value = studentID;
            saveCmd.Parameters.Add("@StudentName", SqlDbType.NVarChar).Value = studentName;
            saveCmd.Parameters.Add("@Course", SqlDbType.NVarChar).Value = course;
            saveCmd.Parameters.Add("Password", SqlDbType.NVarChar).Value = passWord;
            saveCmd.ExecuteNonQuery(); //Executes the command
            myConn.Close(); //Close the connection
        }

        public DataSet DisplayAllRecords()         //Method for displaying record
        {
            SqlDataAdapter myAdapter = new SqlDataAdapter("DisplayAllRecords", myConn);
            myAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet mySet = new DataSet(); // Column/Table Constructor
            myAdapter.Fill(mySet); //Fill the dataset with the data from the database ||ERROR
            return mySet; //Return the dataset
        }

        #region classes
        string studentID, studentName, course;
        //Shortcut Ctrl + R + E
        public string StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string Course { get => course; set => course = value; }
        #endregion

        public bool CheckAccountValid(string userName, string passWord) //Method for checking if the account is valid, or in db
        { //If is in database, true else false
            bool isFound = false;
            myConn.Open();
            SqlCommand Cmd = new SqlCommand("CheckUserAccount", myConn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName;
            Cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passWord;
            SqlDataReader dataReader = Cmd.ExecuteReader();
            while (dataReader.Read())
            {
                isFound = true;
                StudentID = dataReader.GetString(0);
                StudentName = dataReader.GetString(1);
                Course = dataReader.GetString(2);
                break;
            }
            myConn.Close();
            return isFound;
        }


        public void UpdateUserPassword(string userName, string passWord, string newPassWord) //UserPage password update method
        {
            myConn.Open();
            SqlCommand updateCmd = new SqlCommand("UpdatePassword", myConn);
            updateCmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName;
            updateCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passWord;
            updateCmd.Parameters.Add("@NewPassword", SqlDbType.NVarChar).Value = newPassWord;
            updateCmd.CommandType = CommandType.StoredProcedure;
            myConn.Close();
        }
       
    }
}
