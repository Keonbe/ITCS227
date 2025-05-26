<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebGradesCalculator.aspx.cs" Inherits="FinalActivity1.WebGradesCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 308px;
        }
        .auto-style3 {
            width: 308px;
            height: 33px;
        }
        .auto-style4 {
            height: 33px;
        }
    </style>
</head>
<body style="font-family:Verdana, Geneva, Tahoma, sans-serif">
    <form id="form1" runat="server">
        <div>
            Web Grades Calculator</div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Student ID</td>
                    <td>
                        <asp:TextBox ID="tbStudentID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbStudentID" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Name</td>
                    <td>
                        <asp:TextBox ID="tbStudentName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbStudentName" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Grade Details in % (Prelim)</td>
                    <td>
                        <asp:TextBox ID="tbGradePrelim" runat="server" TextMode="Number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbGradePrelim" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tbGradePrelim" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Double">0-100 Range only*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Grade Details in % (Midterm)</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbGradeMidterm" runat="server" TextMode="Number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbGradeMidterm" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="tbGradeMidterm" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Double">0-100 Range only*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Grade Details in % (Final)</td>
                    <td>
                        <asp:TextBox ID="tbGradeFinal" runat="server" TextMode="Number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbGradeFinal" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="tbGradeFinal" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Double">0-100 Range only*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
                        <asp:Button ID="btnLoadData" runat="server" OnClick="btnLoadData_Click" Text="Load Data" />
                    </td>
                </tr>
            </table>
        </div>
    <div>
        <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        </div>
    </form>
    </body>
</html>
