using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class ClassLibrary
    {

        static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\c#\appdev\FINALS\FinalActivity2_Report\FinalActivity2_Report\App_Data\Database1.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connStr);

        public DataSet DisplayAverage()
        {
            SqlDataAdapter da = new SqlDataAdapter("AveragePerStudentPerCourse", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }
    }
}
