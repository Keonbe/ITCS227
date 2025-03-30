using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

namespace _3_OOP_with_ArrayList_Bembo

    #region comment
    /*
     * List of mistakes:
     * Incorrect values from ddl and rbl but values != code so most of the time "Input string was not in a correct format."
     * Variable Names: My names vs. Auto-name by copilot(Membertype & CustomerType)
     * Not wrapping my head around. Instructions vague and I didnt think enough of the problem at hand
     * If error(below) then REBUILD, CLEAN, and BUILD the entire solution, not the project itself or alone. Doing the 3 alone in a project only will result in this error below:
    Server Error in '/' Application.
    Configuration Error
    Description: An error occurred during the processing of a configuration file required to service this request. Please review the specific error details below and modify your configuration file appropriately.

    Parser Error Message: The CodeDom provider type "Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" could not be located.

    Source Error:
    Line 14:   <system.codedom>
    Line 15:     <compilers>
    Line 16:       <compiler language="c#;cs;csharp" extension=".cs" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:default /nowarn:1659;1699;1701" />
    Line 17:       <compiler language="vb;vbs;visualbasic;vbscript" extension=".vb" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.VBCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:default /nowarn:41008 /define:_MYTYPE=\&quot;Web\&quot; /optionInfer+" />
    Line 18:     </compilers>

    Source File: C:\Users\admin\Documents\c#\appdev\3-OOP with ArrayList_Bembo\3-OOP with ArrayList_Bembo\web.config    Line: 16
    Version Information: Microsoft .NET Framework Version:4.0.30319; ASP.NET Version:4.8.9282.0

    ---

     /*GetInfo.SetRecord(firstName, lastName, customerType, downpaymentstr,cashoutTotalstr, monthlyAmorstr, totalPricestr);
                Error CS0120: This error suggests that GetInfo is being treated as a static class or that SetRecord is a static method. 
                If SetRecord is an instance method, you need to create an instance of GetInfo to call it. If SetRecord is static, you should call it using the class name.        
     */
    #endregion 

{
    public partial class LoanCalculator : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                loadData();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbNumYears.Text, out int years) || years < 1 || years > 5)
            {
                lblPlaceholder.Text = "Error: Number of years must be between 1 and 5.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                //Methods LoanCalculator = new Methods();
               //double miscellaneous = years == 5 ? 0 : 35000 + 30000 + 8500;

                string firstName = Session["FirstName"].ToString();
                string lastName = Session["LastName"].ToString();
                /*
                //string customerTypeSession = Session["CustomerType"].ToString(); //solves numerical representation of customer type in column/gridview
                //string customerTypeValue = Session["CustomerType"].ToString(); //value of the discount itself'
                //string customerType = Methods.customertypeString(double.Parse(customerTypeSession));
                //double discount = Methods.customertypeDiscount(customerTypeValue);
                //float discount = float.Parse(Session["Discount"].ToString()); //??
                //string customerType = Session["CustomerType"].ToString();

                string customerType = Methods.customertypeString(Session["CustomerType"].ToString());
                double discount = Methods.customertypeDiscount(Session["CustomerType"].ToString());
                
                 //string customerTypeValue = Session["CustomerType"].ToString(); // Raw discount value (e.g., "0.07")
                //string customerType = Methods.customertypeString(customerTypeValue); // Convert to string (e.g., "Platinum")
                //string customerTypeValue = Session["CustomerType"].ToString(); // Raw discount value (e.g., "0.07")
                //string customerType = Methods.customertypeString(customerTypeValue); // Convert to string (e.g., "Platinum")
                 
                //string customerType = Session["CustomerTypePrint"].ToString(); // Directly get the customer type (e.g., "Platinum")
                //double selectedCustomerTypeID = Convert.ToDouble(Session["CustomerTypePrint"].ToString());

                -> // double discount = Methods.customertypeDiscount(discountValue);
                 */ //Instead of creating methods, Directly from the source(regisration.aspx) use the ddl itself than make a method
                double discountValue = float.Parse(Session["Discount"].ToString());
                string customerType = Session["CustomerType"].ToString();


                double tcp = double.Parse(ddlistTypeCar.SelectedItem.Value);
                double percentage = double.Parse(rblDownPayment.SelectedItem.Value);
                double miscellaneous = Methods.miscellaneous();


                double downpayment = Methods.Downpayment(percentage, tcp); //error CS0176 fixed by calling the class itself instead of instance(at line 42)
                double cashoutTotal = Methods.TotalCashout(downpayment, discountValue); // Perform calculations
                double monthlyAmor = Methods.MonthlyAmortization(tcp, years, cashoutTotal);
                double totalPrice = Methods.TotalPrice(tcp, miscellaneous);


                string downpaymentstr = downpayment.ToString("#,###.00");
                string cashoutTotalstr = cashoutTotal.ToString("#,###.00");
                string monthlyAmorstr = monthlyAmor.ToString("#,###.00");
                string totalPricestr = totalPrice.ToString("#,###.00");


                GetInfo getInfoInstance = new GetInfo();
                getInfoInstance.SetRecord(firstName, lastName, customerType, downpaymentstr, cashoutTotalstr, monthlyAmorstr, totalPricestr);
               
                loadData(); //refresh gridview
                Panel1.Visible = true;
            }
            catch (Exception ex)
            {
                lblPlaceholder.Text = $"Error: {ex.Message}";
            }
           //lblPlaceholder.Text = GetInfo.CustomerType[i].GetType().ToString(); //debug
        }


        protected void loadData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("No.");
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("CustomerType", typeof(string));
            dt.Columns.Add("Downpayment", typeof(string));
            dt.Columns.Add("Total Cashout", typeof(string));
            dt.Columns.Add("Monthly Amortization", typeof(string));
            dt.Columns.Add("Total Price", typeof(string));

            for (int i = 0; i < GetInfo.FirstName.Count; i++)
            {
                dt.Rows.Add(
                    $"{i + 1}.",
                    GetInfo.FirstName[i],
                    GetInfo.LastName[i],
                    GetInfo.CustomerType[i].ToString(),
                    $"${GetInfo.DownPayment[i]}",
                    $"${GetInfo.TotalCashout[i]}",
                    $"${GetInfo.MonthlyAmortization[i]}",
                    $"${GetInfo.TotalPrice[i]}"
                );
            }

            gvData.DataSource = dt;
            gvData.DataBind();
        }

    }
}