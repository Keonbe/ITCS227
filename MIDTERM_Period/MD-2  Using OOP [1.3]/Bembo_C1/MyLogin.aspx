<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyLogin.aspx.cs" Inherits="Bembo_C1.MyLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
           font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 370px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Username</td>
                    <td>
                        <asp:TextBox ID="tbUser" runat="server" Width="201px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="tbPassW" runat="server" TextMode="Password" Width="199px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" Text="Login" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblPlaceholder" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
