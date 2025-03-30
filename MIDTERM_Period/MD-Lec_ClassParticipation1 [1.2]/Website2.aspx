<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Website2.aspx.cs" Inherits="Activity1Lec.Website2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style3 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            width: 332px;
            text-align: right;
        }
        .auto-style4 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            width: 332px;
            text-align: right;
            height: 22px;
        }
        .auto-style5 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Student ID:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblStudentID" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Student Name:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblStudentName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Course: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblCourse" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Tuition Fee:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblTuitionFee" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Down Payment:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblDownpayment" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Text="Total Balance:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblTotalBalance" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
