using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Lec_FinalActivity1
{
    public partial class Regisration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassMethods classMethods = new ClassMethods();
            classMethods.SaveRecordRegisration(tbFirstName.Text, tbLastName.Text, tbMonthlySalary.Text, tbEmailAddress.Text, tbPassword.Text);

        }
    }
}