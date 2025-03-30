<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWebsite.aspx.cs" Inherits="Bembo_C1.MyWebsite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
    body {
   font-family: Verdana, Geneva, Tahoma, sans-serif;
}
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 260px;
    }
</style>

<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome</h2>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Student ID</td>
                <td>
                    <asp:Label ID="lblStudentID" runat="server" Text="[lblStudentID]"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Student Name</td>
                <td>
                    <asp:Label ID="lblStudentName" runat="server" Text="[lblStudentName]"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Course/Year/Section</td>
                <td>
                    <asp:Label ID="lblCYS" runat="server" Text="[lblCYS]"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
