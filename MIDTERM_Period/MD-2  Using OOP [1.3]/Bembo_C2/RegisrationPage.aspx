<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisrationPage.aspx.cs" Inherits="Bembo_C2.RegisrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style1 {
            width: 53%;
        }
        .auto-style2 {
            width: 327px;
        }
        .auto-style3 {
            width: 327px;
            text-align: right;
        }
        .auto-style4 {
            margin-left: 18px;
        }
        .auto-style5 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Regisration Page</div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label4" runat="server" Text="Birthday"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbBirthday" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label3" runat="server" Text="Membership type"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropdownMembership" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="silver">Silver</asp:ListItem>
                    <asp:ListItem Value="gold">Gold</asp:ListItem>
                    <asp:ListItem Value="premium">Premium</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="167px" OnClick="Button1_Click" UseSubmitBehavior="False" />
                <asp:Button ID="lblTransfer" runat="server" CssClass="auto-style4" OnClick="Button2_Click" Text="Next Page" Width="85px" />
            </td>
        </tr>
    </table>
        <asp:Panel ID="Panel1" runat="server">
            <strong>
            <asp:Label ID="lblPlaceholder" runat="server" CssClass="auto-style5"></asp:Label>
            </strong>
        </asp:Panel>
        <p>
            <strong>
            <asp:Label ID="lblMemberID" runat="server"></asp:Label>
            </strong>
        </p>
    </form>
    </body>
</html>
