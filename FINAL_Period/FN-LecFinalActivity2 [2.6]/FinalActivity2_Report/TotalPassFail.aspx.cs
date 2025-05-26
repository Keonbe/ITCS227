using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
using Microsoft.Identity.Client;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution;
using System.Data.SqlClient;

namespace FinalActivity2_Report
{
    public partial class TotalPassFail : System.Web.UI.Page
    {
        ClassLibrary objMethod = new ClassLibrary();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadReport();
            }
        }

        private void LoadReport()
        {
            rvPassFail.LocalReport.DataSources.Clear();
            DataTable dt = GetPassFailData();
            ReportDataSource rds = new ReportDataSource("PassFailDataSet", dt);
            rvPassFail.LocalReport.ReportPath = Server.MapPath("CountPassFail.rdlc");
            rvPassFail.LocalReport.DataSources.Add(rds);
            rvPassFail.LocalReport.Refresh();
        }

        private DataTable GetPassFailData()
        {
            DataTable dt = new DataTable();
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\c#\appdev\FINALS\FinalActivity2_Report\FinalActivity2_Report\App_Data\Database1.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("CountPassFail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    }
}