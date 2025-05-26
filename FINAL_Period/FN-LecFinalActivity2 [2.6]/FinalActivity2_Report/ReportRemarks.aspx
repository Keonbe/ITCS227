<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportRemarks.aspx.cs" Inherits="FinalActivity2_Report.ReportRemarks" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<!--  
  a. Count the total number of  "Passed" and "Failed" students
  b. Count the total number of each course
  c. Display the Average of each students according to course
    -->

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Report REMARKS<br />
            <br />
            <rsweb:ReportViewer ID="ReportViewer1" runat="server">
            </rsweb:ReportViewer>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
