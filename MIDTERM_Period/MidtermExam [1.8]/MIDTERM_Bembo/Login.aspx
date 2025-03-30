<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MIDTERM_Bembo.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 92%;
    }
    .auto-style3 {
        width: 253px;
    }
    .auto-style4 {
        width: 341px;
    }
    .auto-style5 {
        width: 341px;
        font-size: large;
    }
        .auto-style6 {
            width: 253px;
            height: 32px;
        }
        .auto-style7 {
            width: 341px;
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Log In
    <table class="auto-style2">
    <tr>
        <td class="auto-style3">Username:</td>
        <td class="auto-style4">
            <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbUsername" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">Password:</td>
        <td class="auto-style7">
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPassword" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="lblPlaceholder" runat="server" CssClass="auto-style5"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </td>
    </tr>
</table>
</asp:Content>
