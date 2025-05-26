using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

namespace FinalActivity1
{
    public partial class WebGradesCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayRecords();
            }
        }

        ClassCode cc = new ClassCode(); //Parameter
        protected void Button1_Click(object sender, EventArgs e)
        {
            cc.SaveData(tbStudentID.Text, tbStudentName.Text, Convert.ToDouble(tbGradePrelim.Text), Convert.ToDouble(tbGradeMidterm.Text), Convert.ToDouble(tbGradeFinal.Text));
        
        
        }

        public void DisplayRecords()
        {
            GridView1.DataSource = cc.DisplayAllRecords();
            GridView1.DataBind();
        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }
    }
}