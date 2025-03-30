<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvertToBinary.aspx.cs" Inherits="_2___Implementing_OOP_in_Web_Application.ConvertToBinary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .newStyle2 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
    </style>
</head>
<body class="newStyle2">
    <form id="form1" runat="server">
        <div class="newStyle1">
            Decimal to Binary Converter<br />
            <fieldset>
            <br />
            
            <asp:Label ID="Label1" runat="server" Text="Enter Decimal Value:"></asp:Label>
            <asp:TextBox ID="tbDecimal" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="tbDecimal" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            <br />
        </div>
        <asp:Button ID="btn1" runat="server" Text="Convert" OnClick="Button1_Click" />
       
        <br />
        <br />
        <br />
        <br />
         
        <asp:Label ID="lblBinaryText" runat="server" Text="Binary Conversion:"></asp:Label>
         </fieldset>
        <asp:Label ID="lblBinaryValue" runat="server"></asp:Label>
    </form>
</body>
</html>
