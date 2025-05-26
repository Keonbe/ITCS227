<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Average.aspx.cs" Inherits="FinalActivity2_Report.WebForm1" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- 1) Add this ScriptManager -->
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

                    <nav>
                <ul class="nav-links">
                    <li><asp:HyperLink runat="server" NavigateUrl="Average.aspx">Average Grade</asp:HyperLink></li>
                    <li><asp:HyperLink runat="server" NavigateUrl="TotalPassFail.aspx">Total "Passed" & "Failed"</asp:HyperLink></li>
                    <li><asp:HyperLink runat="server" NavigateUrl="TotalCourse.aspx">Total Each Course</asp:HyperLink></li>
                </ul>
            </nav>
        <div>
            
            <h2>Average Report</h2>

            <!-- 2) ReportViewer configured for LocalReport with code-behind data -->
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="600px">
                <LocalReport ReportPath="Average.rdlc" />
            </rsweb:ReportViewer>
        </div>
    </form>

    </form>
</body>
</html>
