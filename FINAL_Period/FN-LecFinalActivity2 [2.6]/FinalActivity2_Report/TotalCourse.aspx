<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TotalCourse.aspx.cs" Inherits="FinalActivity2_Report.TotalCourse" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Students per Course</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Required for ReportViewer -->
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

        <!-- Navigation Menu -->
        <nav>
            <ul class="nav-links">
                    <li><asp:HyperLink runat="server" NavigateUrl="Average.aspx">Average Grade</asp:HyperLink></li>
                    <li><asp:HyperLink runat="server" NavigateUrl="TotalPassFail.aspx">Total "Passed" & "Failed"</asp:HyperLink></li>
                    <li><asp:HyperLink runat="server" NavigateUrl="TotalCourse.aspx">Total Each Course</asp:HyperLink></li>
            </ul>
        </nav>

        <!-- Report Viewer Control -->
        <div>
            <h2>Students per Course</h2>
            <rsweb:ReportViewer 
                ID="rvStudentsPerCourse" 
                runat="server" 
                Width="100%" 
                Height="700px" 
                ZoomMode="Percent">
                <LocalReport ReportPath="TotalPerCourse.rdlc"></LocalReport>
            </rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>