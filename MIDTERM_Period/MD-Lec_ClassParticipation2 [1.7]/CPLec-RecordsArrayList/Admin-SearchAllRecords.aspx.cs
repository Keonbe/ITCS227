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
	public partial class Admin_SearchAllRecords : System.Web.UI.Page
	{
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitializeData(); // Load predefined data from dataClass
                BindGridView(); // Display all records
            }
        }

        private void InitializeData()
        {
            // Create DataTable if it doesn't exist
            dt.Columns.Add("emailAddress");
            dt.Columns.Add("firstName");
            dt.Columns.Add("lastName");

            // Add initial records from dataClass
            for (int i = 0; i < dataClass.EmailAddress.Count; i++)
            {
                dt.Rows.Add(dataClass.EmailAddress[i], dataClass.FirstName[i], dataClass.LastName[i]);
            }

            // Sample data source
            dt.Rows.Add("john@dlsud.edu.ph", "John", "Baptist");
            dt.Rows.Add("alice@dlsud.edu.ph", "Alice", "Smith");
            dt.Rows.Add("michael@dlsud.edu.ph", "Michael", "Johnson");
            dt.Rows.Add("emma@dlsud.edu.ph", "Emma", "Brown");

            // Store the data in ViewState so it doesn't disappear on postback / Save data to ViewState so we can update it later
            ViewState["Records"] = dt;
        }

        private void BindGridView(string searchTerm = "")
        {
            DataTable originalData = (DataTable)ViewState["Records"];
            DataTable filteredData = originalData.Clone(); // Create an empty table with the same structure

            foreach (DataRow row in originalData.Rows)
            {
                string email = row["emailAddress"].ToString().ToLower();
                string firstName = row["firstName"].ToString().ToLower();
                string lastName = row["lastName"].ToString().ToLower();
                string searchLower = searchTerm.ToLower();

                // Check if the search term appears in any field
                if (string.IsNullOrEmpty(searchTerm) ||
                    email.Contains(searchLower) ||
                    firstName.Contains(searchLower) ||
                    lastName.Contains(searchLower))
                {
                    filteredData.Rows.Add(row.ItemArray); // Copy the row to the new table
                }
            }

            // Bind the filtered data to GridView
            GridView1.DataSource = filteredData;
            GridView1.DataBind();

            // Show a message if no records are found
            lblPlaceholder.Text = (filteredData.Rows.Count == 0) ? "No records found." : "";
            lblPlaceholder.ForeColor = System.Drawing.Color.Red;
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text.Trim();
            BindGridView(searchTerm);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            BindGridView(); // Show all records
        }

    }
}