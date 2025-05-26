using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class ClassCode
    {
        //Connection String
        static string ConnectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\c#\appdev\FINALS\FinalActivity1\FinalActivity1\App_Data\DatabaseMain.mdf;Integrated Security=True";

        //Connection Object
        SqlConnection conn = new SqlConnection(ConnectString);


        //Saving data
        public void SaveData(string studentID, string studentName, double gradePrelim, double gradeMidterm, double gradeFinal)
        {
            conn.Open(); //Open Connection
            //string query = "INSERT INTO tblTest(Name, Email, Phone) VALUES('" + name + "', '" + email + "', '" + phone + "')";      //Query
            SqlCommand cmd = new SqlCommand("SaveStudentInfo", conn); //Command
            cmd.CommandType = CommandType.StoredProcedure; //Save
            cmd.Parameters.AddWithValue("@StudentID", SqlDbType.NVarChar).Value = studentID; //Supply values to parameters
            cmd.Parameters.AddWithValue("@StudentName", SqlDbType.NVarChar).Value = studentName;
            cmd.Parameters.AddWithValue("@GradePrelim", SqlDbType.Decimal).Value = gradePrelim;
            cmd.Parameters.AddWithValue("@GradeMidterm", SqlDbType.Decimal).Value = gradeMidterm;
            cmd.Parameters.AddWithValue("@GradeFinal", SqlDbType.Decimal).Value = gradeFinal;
            cmd.ExecuteNonQuery(); //Excetute
            conn.Close(); //Close Connection
        }

        public DataSet DisplayAllRecords()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("DisplayGradeDetails", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet mySet = new DataSet();
            adapter.Fill(mySet);
            return mySet; 
        }


    }
}
