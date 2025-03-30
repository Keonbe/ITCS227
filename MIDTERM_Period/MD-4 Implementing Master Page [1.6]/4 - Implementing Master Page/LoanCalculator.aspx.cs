using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace _4___Implementing_Master_Page
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

            
            if (Session["FirstName"] == null || Session["LastName"] == null || 
                Session["CustomerType"] == null || Session["Discount"] == null) //login validation error
            {
                lblPlaceholder.Text = "Error: Session data missing. Please complete registration.";
                lblPlaceholder.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                string firstName = Session["FirstName"].ToString();
                string lastName = Session["LastName"].ToString();
                double discountValue = float.Parse(Session["Discount"].ToString());
                string customerType = Session["CustomerType"].ToString();


                double tcp = double.Parse(ddlistTypeCar.SelectedItem.Value);
                double percentage = double.Parse(rblDownPayment.SelectedItem.Value);
                double miscellaneous = Methods.miscellaneous();


                double downpayment = Methods.Downpayment(percentage, tcp); 
                double cashoutTotal = Methods.TotalCashout(downpayment, discountValue); 
                double monthlyAmor = Methods.MonthlyAmortization(tcp, years, cashoutTotal);
                double totalPrice = Methods.TotalPrice(tcp, miscellaneous);


                string downpaymentstr = downpayment.ToString("#,###.00");
                string cashoutTotalstr = cashoutTotal.ToString("#,###.00");
                string monthlyAmorstr = monthlyAmor.ToString("#,###.00");
                string totalPricestr = totalPrice.ToString("#,###.00");


                GetInfo getInfoInstance = new GetInfo();
                getInfoInstance.SetRecord(firstName, lastName, customerType, downpaymentstr, cashoutTotalstr, monthlyAmorstr, totalPricestr);

                loadData();
                Panel1.Visible = true;
            }
            catch (Exception ex)
            {
                lblPlaceholder.Text = $"Error: {ex.Message}";
            }
           
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