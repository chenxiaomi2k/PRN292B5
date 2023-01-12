<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="FirstWeb.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="type" runat="server" OnSelectedIndexChanged="type_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Account" Value="acc" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Employee" Value="empl"></asp:ListItem>
                <asp:ListItem Text="Customer" Value="cus"></asp:ListItem>
            </asp:DropDownList>
            <asp:GridView ID="view" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
