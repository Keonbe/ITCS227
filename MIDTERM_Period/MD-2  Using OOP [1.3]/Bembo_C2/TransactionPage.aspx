<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="Bembo_C2.TransactionPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            width: 358px;
            text-align: right;
        }
        .newStyle2 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style4 {
            width: 280px;
            text-align: right;
        }
        .auto-style5 {
            font-size: x-large;
        }
    </style>
</head>
<body class="newStyle2">
    <form id="form1" runat="server">
        <div class="newStyle1">
            ::<span class="auto-style2"><strong>Transaction Page</strong></span>::</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Member ID:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblMemberID" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Member Name:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblMemberName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Select Product:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="0.00">-Select Item-</asp:ListItem>
                        <asp:ListItem Value="35500.00">Laptop</asp:ListItem>
                        <asp:ListItem Value="27500.00">Desktop</asp:ListItem>
                        <asp:ListItem Value="5500.00">Printer (Dot Matrix)</asp:ListItem>
                        <asp:ListItem Value="4000.00">Printer (Ink Jet)</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Price:"></asp:Label>
                </td>
                <td>
                    <strong>
                    <asp:Label ID="lblPrice" runat="server"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Quantity"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="tbQuantity" runat="server" TextMode="Number" Width="90px"></asp:TextBox>
                    <strong>
                    <br />
                    </strong>
                    <asp:Label ID="lblSubTotalLabel" runat="server" Text="   Sub Total Price:"></asp:Label>
                    <strong>
                    <asp:Label ID="lblSubTotalPrice" runat="server"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Text="Item on cart:"></asp:Label>
                </td>
                <td>
                    <strong>
                    <asp:Label ID="lblItemCart" runat="server"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    
                    <asp:Button ID="btnAddtoCart" runat="server" OnClick="btnAddtoCart_Click" Text="Add to Cart" Width="178px" />
                    
                    <asp:Button ID="btnCheckout" runat="server" Text="Checkout" Width="152px" OnClick="btnCheckout_Click" />
                </td>
            </tr>
        </table>
        <asp:Panel ID="Panel1" runat="server" Height="180px">
            <strong><span class="auto-style2">Transaction Summary<br /> </span></strong>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Total Amount Purchase:</td>
                    <strong>
                    <td>
                        <strong>
                        <asp:Label ID="lblAmountPurchase" runat="server"></asp:Label>
                        </strong>
                    </td>
                    </strong>
                </tr>
                <tr>
                    <td class="auto-style4">Applied Discount:</td>
                    <td>
                        <strong>
                        <asp:Label ID="lblAppliedDiscount" runat="server"></asp:Label>
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Amount Due:</td>
                    <td>
                        <strong>
                        <asp:Label ID="lblAmountDue" runat="server"></asp:Label>
                        </strong>
                    </td>
                </tr>
            </table>
            </strong>
        </asp:Panel>
        <strong>
        <asp:Label ID="lblPlaceholder" runat="server" CssClass="auto-style5"></asp:Label>
        </strong>
        <p>
            &nbsp;</p>
        <asp:Panel ID="Panel2" runat="server" Visible="False">
            <asp:Label ID="lblMembership" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
