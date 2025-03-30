using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace _2___Implementing_OOP_in_Web_Application
{
	public partial class ConvertToBinary : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            /*
             * ASP.NET WebForms requires jQuery for unobtrusive validation, but your project doesn't have a jQuery script reference.
             * >If you don’t need client-side validation, disable it in your Page_Load method:
             * |
             * v
             */
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbDecimal.Text, out int decimalNumber))
            {
                string binaryValue = Class1.DecimalToBinaryConversion(decimalNumber);
                lblBinaryValue.Text = binaryValue;

            }
            else
            {
                lblBinaryValue.Text = " *Invalid input: Please enter a valid decimal number.";
                lblBinaryValue.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}