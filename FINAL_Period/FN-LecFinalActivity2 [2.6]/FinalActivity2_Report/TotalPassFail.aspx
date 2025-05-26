<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TotalPassFail.aspx.cs" Inherits="FinalActivity2_Report.TotalPassFail" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pass/Fail Report</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

        <!-- Navigation -->
        <nav>
            <ul class="nav-links">
                    <li><asp:HyperLink runat="server" NavigateUrl="Average.aspx">Average Grade</asp:HyperLink></li>
                    <li><asp:HyperLink runat="server" NavigateUrl="TotalPassFail.aspx">Total "Passed" & "Failed"</asp:HyperLink></li>
                    <li><asp:HyperLink runat="server" NavigateUrl="TotalCourse.aspx">Total Each Course</asp:HyperLink></li>
            </ul>
        </nav>

        <!-- Report Viewer -->
        <div>
            <h2>Passed vs Failed Students</h2>
            <rsweb:ReportViewer 
                ID="rvPassFail" 
                runat="server" 
                Width="100%" 
                Height="700px">
                <LocalReport ReportPath="CountPassFail.rdlc"></LocalReport>
            </rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>

