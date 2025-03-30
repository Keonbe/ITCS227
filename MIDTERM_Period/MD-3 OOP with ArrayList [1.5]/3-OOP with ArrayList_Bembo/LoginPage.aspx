<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="_3_OOP_with_ArrayList_Bembo.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 428px;
        }
        .newStyle1 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style3 {
            width: 428px;
            text-align: right;
        }
    </style>
</head>
<body class="newStyle1">
    <form id="form1" runat="server">
        <div>
            Login Page<br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Username/Email address:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Valid1" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbUsername">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Valid2" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="tbPassword">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="Login" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            <asp:Label ID="lblPlaceholder" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>