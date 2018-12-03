<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IISTestWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" ID="btnGetJobs" OnClick="btnGetJobs_OnClick" Text="All Jobs" />
        <asp:Button runat="server" ID="btnGetJobsManager" OnClick="btnGetJobsManager_OnClick"  Text="Manager Jobs"/>
        <asp:Button runat="server" ID="btnGetJobsDeveloper" OnClick="btnGetJobsDeveloper_OnClick"  Text="Manager Jobs"/>
        <asp:Button runat="server" ID="btnGetJobsArchitect" OnClick="btnGetJobsArchitect_OnClick"  Text="Manager Jobs"/>
        <asp:GridView runat="server" ID="grd" />
    </div>

    </form>
</body>
</html>
