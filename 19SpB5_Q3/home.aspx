<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="_19SpB5_Q3.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Region:<asp:DropDownList ID="regionList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="regionList_SelectedIndexChanged"></asp:DropDownList><br />
            Corporation <asp:DropDownList ID="corpList" runat="server"></asp:DropDownList><br />
            FirstName <asp:TextBox ID="firstName" runat="server"></asp:TextBox><br />
            LastName <asp:TextBox ID="lastName" runat="server"></asp:TextBox><br />
            <asp:Button ID="add" runat="server" Text="Add member" OnClick="add_Click"/>
        </div>
    </form>
</body>
</html>
