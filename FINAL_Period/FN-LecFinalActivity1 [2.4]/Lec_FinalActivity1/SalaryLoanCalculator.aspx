<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.Master" AutoEventWireup="true" CodeBehind="SalaryLoanCalculator.aspx.cs" Inherits="Lec_FinalActivity1.SalaryLoanCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 290px;
        }
        .auto-style3 {
            width: 260px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Welcome ::
    <asp:Label ID="lblClient" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Basic Monthly Salary</td>
            <td>
                <asp:Label ID="lblMonthlySalary" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Number of Months to Pay</td>
            <td>
                <asp:TextBox ID="tbMonthsToPay" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tbMonthsToPay" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="25" MinimumValue="1" Type="Integer">Number of months to pay must be between 1 and 25.</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnComputeLoan" runat="server" OnClick="Button1_Click" Text="Compute Loan" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
        <asp:Label ID="lblPlaceholder" runat="server"></asp:Label>
    </p>
    <div>

        <asp:Panel ID="pnlLoanResults" runat="server" Visible="False">
    <table>
        <tr>
            <td>Loan Amount:</td>
            <td class="auto-style3">
                <asp:Label ID="lblLoanAmount" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Interest:</td>
            <td class="auto-style3">
                <asp:Label ID="lblInterest" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Service Charge:</td>
            <td class="auto-style3">
                <asp:Label ID="lblServiceCharge" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Take Home Loan:</td>
            <td class="auto-style3">
                <asp:Label ID="lblTakeHomeLoan" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Monthly Amortization:</td>
            <td class="auto-style3">
                <asp:Label ID="lblMonthlyAmort" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

    <asp:Button ID="btnSubmitLoan" runat="server" Text="Submit Loan Application" OnClick="btnSubmitLoan_Click" />
</asp:Panel>


    </div>
    <p>
        &nbsp;
    </p>
    <p>
        <asp:Button ID="btnLogout" runat="server" OnClick="Button1_Click1" Text="Logout" />
    </p>
</asp:Content>

