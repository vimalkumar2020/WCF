<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MvcApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" id="calcMain">
            <div class="row">
                <div class="col-lg-2">
                    <asp:TextBox ID="Num1" runat="server"></asp:TextBox>
                </div>
                <div class="col-lg-2">
                    <asp:TextBox ID="Num2" runat="server"></asp:TextBox>
                </div>
                <div class="col-lg-2">
                    <asp:Button ID="btnAdd" Text="Add" runat="server"  OnClick="btnAdd_OnClick"/>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6" id="div1">
                    Add Result: <asp:Label ID="AddResult" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-2">
                    <asp:TextBox ID="Num3" runat="server"></asp:TextBox>
                </div>
                <div class="col-lg-2">
                    <asp:TextBox ID="Num4" runat="server"></asp:TextBox>
                </div>
                <div class="col-lg-2">
                    <asp:Button ID="btnSubtract" Text="Add" runat="server" OnClick="btnSubtract_OnClick"/>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                   Subtract Result: <asp:Label ID="SubResult" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
