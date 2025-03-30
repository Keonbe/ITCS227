using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bembo_C1
{
    public partial class MyLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["StudentID"].ToString();
            //Session["Password"].ToString();
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            
            String VerifyUser = Session["StudentID"].ToString();
            String VerifyPass = Session["Password"].ToString();
            String user = tbUser.Text;
            String pass = tbPassW.Text;


            if (VerifyUser != user || VerifyPass != pass)
            {
                lblPlaceholder.Text = ("Security fault: Invalid username or password");
            }else{
                Response.Redirect("MyWebsite.aspx");
            }
        }
    }
}