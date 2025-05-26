<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Lec_FinalActivity1.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .newStyle1 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .newStyle2 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style1 {
            width: 156px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="newStyle2">
        Login Page</p>
    <table class="newStyle2">
        <tr>
            <td class="auto-style1">Email Address</td>
            <td>
                <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbUsername" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Password</td>
            <td>
                <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPassword" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="Login" />
            </td>
        </tr>

        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="lblPlaceholder" runat="server" ForeColor="Red"></asp:Label>
            </td>
    </table>
</asp:Content>
