using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace CPLec_RecordsArrayList
{
	public partial class Admin_ViewAllRecords : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize the DataTable
                DataTable dt = new DataTable();

                // Add columns to the DataTable
                dt.Columns.Add("emailAddress");
                dt.Columns.Add("firstName");
                dt.Columns.Add("lastName");

                // Populate the DataTable with data
                for (int i = 0; i < dataClass.EmailAddress.Count; i++)
                {
                    dt.Rows.Add(dataClass.EmailAddress[i].ToString(),
                                dataClass.FirstName[i].ToString(),
                                dataClass.LastName[i].ToString());
                }

                // Bind the DataTable to the GridView
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}