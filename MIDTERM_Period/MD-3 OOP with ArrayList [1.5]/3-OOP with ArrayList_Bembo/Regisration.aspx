<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regisration.aspx.cs" Inherits="_3_OOP_with_ArrayList_Bembo.Regisration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 218px;
        }
    </style>
</head>
<body class="newStyle1">
    <form id="form1" runat="server">
        <fieldset>
        <div>
            Regisration<br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Valid1" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbFirstName">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tblastName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Valid2" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tblastName">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Email Address(as Username):"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Valid3" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbEmail">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Valid4" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbPassword">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="Confirm Password:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbConfirmPass" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Valid5" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbConfirmPass">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Customer Type:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlistCustomerType" runat="server" AutoPostBack="True">
                            <asp:ListItem Value="0.043">Silver</asp:ListItem>
                            <asp:ListItem Value="0.055">Gold</asp:ListItem>
                            <asp:ListItem Value="0.07">Platinum</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="Valid6" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="ddlistCustomerType">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <fieldset>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" OnClick="Button1_Click" Text="Save" />
                    </td>
                </tr>
            </table>
        </div>
            </fieldset>
        <asp:Label ID="lblPlaceholder" runat="server"></asp:Label>
    </form>
    </body>
</html>
