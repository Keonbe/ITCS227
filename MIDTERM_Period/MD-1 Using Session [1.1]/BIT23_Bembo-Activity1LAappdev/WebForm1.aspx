<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BIT23_Bembo_Activity1LAappdev.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to my website</title>
    <style type="text/css">
        .newStyle1 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .newStyle2 {
            font-family: Verdana;
        }
        .auto-style1 {
            font-size: x-large;
        }
        .newStyle3 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style3 {
            font-size: medium;
            width: 223px;
            text-align: right;
        }
        .auto-style5 {
            text-align: right;
            width: 219px;
            height: 31px;
        }
        .auto-style6 {
            text-align: right;
            width: 219px;
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
        }
        .newStyle4 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style8 {
            font-size: medium;
            width: 223px;
            text-align: right;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style10 {
            height: 31px;
        }
        .auto-style11 {
            width: 36%;
        }
        .auto-style12 {
            height: 23px;
            width: 221px;
        }
        .auto-style13 {
            width: 100%;
        }
        .newStyle5 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .newStyle6 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style15 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
            width: 406px;
            text-align: right;
        }
        .auto-style16 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
            width: 406px;
            text-align: right;
            height: 24px;
        }
        .auto-style17 {
            height: 24px;
        }
        .auto-style18 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
            width: 406px;
            text-align: right;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="newStyle3">Welcome to my Website</span></div>
    <div class="auto-style1"><strong>Registration</strong><table class="newStyle4">
        <tr>
            <td id="StudentID" class="auto-style8">Student ID</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td id="StudentName" class="auto-style3">Student Name</td>
            <td>
                <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td id="Course" class="auto-style3">Course</td>
            <td>
                <asp:DropDownList ID="drpCourse" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="85000.00">BIT</asp:ListItem>
                    <asp:ListItem Value="90000.00">BCS</asp:ListItem>
                    <asp:ListItem Value="88000.00">HUB</asp:ListItem>
                    <asp:ListItem Value="95000.00">MEB</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        </table>
        </div>
   
        <table class="newStyle4">
            <tr>
                <td id="lblTuitionfee" class="auto-style6">Tuition Fee</td>
                <td id="lblTuitiontxt" class="auto-style7">
                    <asp:Label ID="lblTuition" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td id="lblPayment" class="auto-style5">Downpayment</td>
                <td class="auto-style10">
                    <asp:RadioButtonList ID="downPaymentSelect" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="0.5">50%</asp:ListItem>
                        <asp:ListItem Value="0.4">40%</asp:ListItem>
                        <asp:ListItem Value="0.3">30%</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
        </table>

      
        <table class="auto-style11">
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style7">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
                </td>
            </tr>
        </table>
        <asp:Panel ID="Panel1" runat="server" Height="241px">
            <br />
            <span class="newStyle5">Student Tuition Details</span><br />
            <table align="right" class="auto-style13">
                <tr>
                    <td class="auto-style18">Student ID</td>
                    <td id="lblStudentID" class="auto-style7">
                        <asp:Label ID="lblStudentID" runat="server">stid</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">Student Name</td>
                    <td id="lblStudentName" class="auto-style17">
                        <asp:Label ID="lblStudentName" runat="server">stnm</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style18">Course</td>
                    <td id="lblCourse" class="auto-style7">
                        <asp:Label ID="lblCourse" runat="server">crse</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td id="lblDP" class="auto-style15">Downpayment</td>
                    <td id="lblDP">
                        <asp:Label ID="lblDP" runat="server">dp</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td id="lblDP" class="auto-style15">&nbsp;</td>
                    <td id="btnClear">
                    <%--<asp:Button ID="Clear" runat="server" OnClick="Clear_Click" Text="Clear" />--%>
                        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click1" Text="Clear" />
    </td>
</tr>
            </table>
        </asp:Panel>

      
    </form>
       


</body>
</html>
