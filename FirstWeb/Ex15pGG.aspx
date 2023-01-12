<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex15pGG.aspx.cs" Inherits="FirstWeb.Ex15pGG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="list" runat="server" AutoPostBack="true" OnSelectedIndexChanged="list_SelectedIndexChanged" Height="201px" Width="137px">

            </asp:ListBox>
        </div>
        <div>
            <asp:GridView ID="view" runat="server">

            </asp:GridView>
        </div>
    </form>
</body>
</html>
