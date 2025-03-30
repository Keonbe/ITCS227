<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regisration.aspx.cs" Inherits="Bembo_C1.WebForm1" %>

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
            width: 160px;
        }
        .auto-style3 {
            width: 634px;
        }
        .auto-style4 {
            font-weight: normal;
        }
        .auto-style5 {
            width: 160px;
            height: 26px;
        }
        .auto-style6 {
            width: 634px;
            height: 26px;
        }
    </style>
<body>
    <form id="form1" runat="server">
        <h2 class="auto-style4">Welcome to my website</h2>
        <p class="auto-style4">
            Register here</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">StudentID</td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbStudentID" runat="server" Width="138px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Student Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbStudentName" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Course/Year/Section</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbCYS" runat="server" Width="138px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbEmail" runat="server" TextMode="Email" Width="279px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Birthday</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbBirthday" runat="server" TextMode="Date" Width="138px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" Width="283px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Confirm Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbConfirmPass" runat="server" TextMode="Password" Width="286px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                </td>
            </tr>
        </table>
        <asp:Label ID="lblPlaceholder" runat="server"></asp:Label>
    </form>
</body>
</html>
