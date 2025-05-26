using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
using Microsoft.Identity.Client;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution;


namespace FinalActivity2_Report
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ClassLibrary objMethod = new ClassLibrary();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadReportAverage();
            }
        }

        public void loadReportAverage()
        {
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", objMethod.DisplayAverage().Tables["myTable"]);
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("Average.rdlc");
            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.Refresh();
        }
    }
}