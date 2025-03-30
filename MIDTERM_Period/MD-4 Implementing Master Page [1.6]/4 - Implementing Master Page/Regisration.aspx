<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Regisration.aspx.cs" Inherits="_4___Implementing_Master_Page.Regisration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="height: 23px; width: 220px; text-align: right">
                <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
            </td>
            <td style="height: 23px">
                <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbFirstName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 220px; text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbLastName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 220px; text-align: right">
                <asp:Label ID="Label3" runat="server" Text="Email Address:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbEmail" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 220px; text-align: right">
                <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbPassword" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 220px; text-align: right">
                <asp:Label ID="Label5" runat="server" Text="Confirm Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbConfirmPass" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbConfirmPass" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 220px; height: 23px; text-align: right">
                <asp:Label ID="Label6" runat="server" Text="Customer Type:"></asp:Label>
                <br />
            </td>
            <td style="height: 23px">
                <asp:DropDownList ID="ddlistCustomerType" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="0.043">Silver</asp:ListItem>
                    <asp:ListItem Value="0.055">Gold</asp:ListItem>
                    <asp:ListItem Value="0.07">Platinum</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
            </td>
        </tr>
        <tr>
            <td style="width: 220px">
                <asp:Label ID="lblPlaceholder" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
