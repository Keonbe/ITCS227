using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace _4___Implementing_Master_Page
{
	public partial class ViewRecords : System.Web.UI.Page
	{
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                dt.Columns.Add("First Name", typeof(string));
                dt.Columns.Add("Last Name", typeof(string));
                dt.Columns.Add("Customer Type", typeof(string));
                for (int i = 0; i <= GetInfo.FirstName.Count - 1; i++)
                {
                    dt.Rows.Add(GetInfo.FirstName[i].ToString(),
                                GetInfo.LastName[i].ToString(),
                                GetInfo.CustomerType[i].ToString());
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
	}
}