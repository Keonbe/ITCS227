<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="_4___Implementing_Master_Page.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 211px; text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Username/Email Address:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbUsername" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 211px; height: 23px; text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            </td>
            <td style="height: 23px">
                <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPassword" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 211px; text-align: left">
                <asp:Label ID="lblPlaceholder" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="Login" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
