using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace MIDTERM_Bembo
{
	public partial class ViewRecords : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

            if (!IsPostBack)
            {
                DataTable dt = new DataTable();

                // Add COLUMN to the DataTable
                dt.Columns.Add("StudentID");
                dt.Columns.Add("StudentName");
                dt.Columns.Add("CourseYearSection");
                dt.Columns.Add("Password");

                // Populate the DataTable with data
                for (int i = 0; i < ClassMethod.StudentID.Count; i++)
                {
                    dt.Rows.Add(ClassMethod.StudentID[i].ToString(),
                                ClassMethod.StudentName[i].ToString(),
                                ClassMethod.CourseYearSection[i].ToString(),
                                ClassMethod.Password[i].ToString());
                }


                dt.Rows.Add("2025-1-12345", "Jose Rizal", "BIT21", "Jprizal12345");  // Sample data source, ROWS/HORIZONTAL
                dt.Rows.Add("2025-1-12346", "Andres Bonifacio", "BIT22", "ABonifacio12345");
                dt.Rows.Add("2025-1-12347", "Elmer Bertudez", "BIT23", "EBertudez12345");
                dt.Rows.Add("2025-1-12348", "Jose Filio", "BIT24", "Jfilio12345");
                dt.Rows.Add("2025-1-12349", "Amiel Del Rosario", "BIT25", "Adelrosario12345");

                // Bind the DataTable to the GridView
                GridView1.DataSource = dt; //Anything ".add" id above this", because bind
                GridView1.DataBind();
                }


        }
    }
}