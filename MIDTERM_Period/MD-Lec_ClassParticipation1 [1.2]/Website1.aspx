<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Website1.aspx.cs" Inherits="Activity1Lec.Website1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 288px;
            text-align: right;
        }
        .auto-style4 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-large;
        }
        .auto-style5 {
            width: 287px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Regisration<br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblID" runat="server" Text="Student ID:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbStudentID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblName" runat="server" Text="Student Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbStudentName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblCourse" runat="server" Text="Course Options:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="listCourse" runat="server" AutoPostBack="True">
                            <asp:ListItem Value="1500.00">BIT</asp:ListItem>
                            <asp:ListItem Value="1400.00">BCS</asp:ListItem>
                            <asp:ListItem Value="1250.00">HUB</asp:ListItem>
                            <asp:ListItem Value="1100.00">MEB</asp:ListItem>
                            <asp:ListItem Value="950.00">APM</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblUnits" runat="server" Text="Units Enrolled"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbUnits" runat="server" TextMode="Number">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblTuition" runat="server" Text="Tuition Downpayment"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblTuition" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                            <asp:ListItem Value="0.4">40%</asp:ListItem>
                            <asp:ListItem Value="0.5">50%</asp:ListItem>
                            <asp:ListItem Value="1">Full Payment</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Done!" Width="56px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <strong>
        <asp:Label ID="lblPlaceholder" runat="server" CssClass="auto-style4"></asp:Label>
        </strong>
    </form>
</body>
</html>
