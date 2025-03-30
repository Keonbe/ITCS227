<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="LoanCalculator.aspx.cs" Inherits="_4___Implementing_Master_Page.LoanCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="auto-style1">
        Loan Calculator<br />
        <br />
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Type of car to be loan:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlistTypeCar" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="1500000.00">SUV</asp:ListItem>
                        <asp:ListItem Value="890000.00">Van</asp:ListItem>
                        <asp:ListItem Value="680000.00">Sedan</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Down payment:"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblDownPayment" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                        <asp:ListItem Value="0.2">20%</asp:ListItem>
                        <asp:ListItem Value="0.25">25%</asp:ListItem>
                        <asp:ListItem Value="0.30">30%</asp:ListItem>
                        <asp:ListItem Value="0.35">35%</asp:ListItem>
                        <asp:ListItem Value="0.4">40%</asp:ListItem>
                        <asp:ListItem Value="0.45">45%</asp:ListItem>
                        <asp:ListItem Value="0.5">50%</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="Valid1" runat="server" ControlToValidate="rblDownPayment" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Please choose a downpayment option</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Number of years to pay (1-5 years only):"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbNumYears" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Valid2" runat="server" ControlToValidate="tbNumYears" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btn1" runat="server" OnClick="Button1_Click" Text="Save" />
                </td>
            </tr>
        </table>
        <br />
    </div>
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <p>
        <asp:Label ID="lblPlaceholder" runat="server"></asp:Label>
    </p>
    <div>
        <asp:Panel ID="Panel2" runat="server">
            <asp:GridView ID="gvData" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </asp:Panel>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
