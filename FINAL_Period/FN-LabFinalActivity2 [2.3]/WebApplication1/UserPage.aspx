<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="WebApplication1.UserPage" %>

<!DOCTYPE html>
<!-- displays data who login -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 349px;
        }
    </style>
</head>
<body style="font-family:Verdana, Geneva, Tahoma, sans-serif; background-color:beige">
    <form id="form1" runat="server">
        Welcome::<asp:Label ID="lblStudentID" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblStudentName" runat="server"></asp:Label>
    <div>

        Change Password<br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Old Password</td>
                <td>
                    <asp:TextBox ID="tbOldPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">New Password</td>
                <td>
                    <asp:TextBox ID="tbNewPassword" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
                </td>
            </tr>
        </table>

    </div>
    </form>
    </body>
</html>
