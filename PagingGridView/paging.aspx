<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paging.aspx.cs" Inherits="PagingGridView.paging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:DropDownList ID="regionList" runat="server" OnSelectedIndexChanged="regionList_SelectedIndexChanged" AutoPostBack="true">
                </asp:DropDownList>
            </div>
            <div>
                <asp:DropDownList ID="corpList" runat="server" OnSelectedIndexChanged="corpList_SelectedIndexChanged" AutoPostBack="true">
                </asp:DropDownList>
            </div>
            <asp:Label ID="err" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:GridView ID="member" runat="server" EnableViewState="false" AllowPaging="true" pagesize="20" OnPageIndexChanging="member_PageIndexChanging">
                <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NumericFirstLast" />
            </asp:GridView>
            Page size:
            <asp:DropDownList ID="pagesize" runat="server" OnSelectedIndexChanged="pagesize_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="20" Value="20" Selected="True"></asp:ListItem>
                <asp:ListItem Text="40" Value="40" ></asp:ListItem>
                <asp:ListItem Text="100" Value="100" ></asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
