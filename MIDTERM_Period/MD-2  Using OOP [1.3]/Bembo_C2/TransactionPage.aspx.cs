using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ClassLibrary;

namespace Bembo_C2
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMemberID.Text = Session["MemberID"].ToString(); ///If import session, inverse of initial
            lblMemberName.Text = Session["MemberName"].ToString();
            lblMembership.Text = Session["Membership"].ToString();
            lblPrice.Text = ddlItems.SelectedValue;
            Panel2.Visible = false; //Hide panel
        }

        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrice.Text = ddlItems.SelectedValue;
            if(!string.IsNullOrEmpty(ddlItems.SelectedValue))
            {
                lblPrice.Text = ddlItems.SelectedValue;
            }
            else { lblPrice.Text = "0"; }

            if (!IsPostBack)
            {
                lblPrice.Text = ddlItems.SelectedValue;
            }
            else { lblPrice.Text = "0"; }
        }

        protected void btnAddtoCart_Click(object sender, EventArgs e) //if error CS0029, dont make it null
        {
            //Cannot error if no value added 
            ComputationClass Computation = new ComputationClass();
            double price = Convert.ToDouble(ddlItems.SelectedValue);
            lblPrice.Text = price.ToString("N2");
            if (ddlItems.SelectedIndex == 0)
            {
                lblPlaceholder.Text = "Error: Select an item.";
                return;
            }

            double quantity = Convert.ToDouble(tbQuantity.Text);
            if (quantity <= 0)
            {
                lblPlaceholder.Text = "Error: Quantity must be at least 1.";
                return;
            }

            // Retrieve previous values from ViewState, else 0
            double itemsCart = ViewState["itemsCart"] != null ? Convert.ToDouble(ViewState["itemsCart"]) : 0;
            double totalAmount = ViewState["totalAmount"] != null ? Convert.ToDouble(ViewState["totalAmount"]) : 0;

            itemsCart += quantity; // Update item count in cart
            ViewState["itemsCart"] = itemsCart; // Store updated value in ViewState
            lblItemCart.Text = itemsCart.ToString();

            double subtotal = quantity * price; 
            lblSubTotalPrice.Text = subtotal.ToString("N2");

            //Update total amount due
            //Computation.TotalAmountPurchased(subtotal, price, quantity, totalAmount); //Class No.1
            totalAmount = Computation.TotalAmountPurchased(subtotal, totalAmount);
            ViewState["totalAmount"] = totalAmount; // Store updated value in ViewState
            lblAmountPurchase.Text = totalAmount.ToString("N2");
        }



        protected void btnCheckout_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lblAmountPurchase.Text)) 
            {
                lblPlaceholder.Text = "Error: Cannot Checkout, No items in cart";
                return;
            }

            //Same2 as line 26
            double totalAmount = double.Parse(lblAmountPurchase.Text);
            double discount = 0;
            double itemcart = double.Parse(lblItemCart.Text);

            ComputationClass Computation = new ComputationClass();
            String membershipID = Session["Membership"].ToString();
            discount = ComputationClass.GetAppliedDiscount(membershipID, totalAmount,totalAmount); //Class No.1
            lblAppliedDiscount.Text = discount.ToString("N2"); //Display discount
            lblAmountDue.Text = Computation.GrandTotal(totalAmount, discount).ToString("N2"); //Class No.3 
        }




    }
}