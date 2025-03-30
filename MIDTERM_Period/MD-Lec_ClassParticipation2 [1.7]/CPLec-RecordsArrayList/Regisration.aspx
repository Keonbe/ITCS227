<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Regisration.aspx.cs" Inherits="CPLec_RecordsArrayList.Regisration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
        width: 226px;
    }
        .auto-style3 {
            width: 226px;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        width: 181px;
    }
        .newStyle1 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
    .auto-style5 {
        width: 181px;
    }
    .auto-style6 {
        font-family: verdana, Geneva, Tahoma, sans-serif;
        width: 586px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="newStyle1">
        Regisration<br />
    </p>
    <table class="auto-style6">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbFirstName">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbLastName">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Email Address:"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="tbEmailAddress" runat="server" TextMode="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbEmailAddress">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbPassword">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label5" runat="server" Text="Confirm Password:"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="tbConfirmPass" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbConfirmPass">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbPassword" ControlToValidate="tbConfirmPass" ErrorMessage="CompareValidator" ForeColor="Red">Password incorrect</asp:CompareValidator>
            </td>
        </tr>
        <tr>
    <td class="auto-style2">&nbsp;</td>
    <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Text="Sign-in" OnClick="Button1_Click" />
    </td>
</tr>
    </table>
    <h2>
        <asp:Label ID="lblPlaceholder" runat="server"></asp:Label>
    </h2>
</asp:Content>
