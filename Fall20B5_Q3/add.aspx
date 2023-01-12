<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="Fall20B5_Q3.add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ProductName <asp:TextBox ID="pname" runat="server"></asp:TextBox><asp:Label ForeColor="Red" ID="nameerr" runat="server"></asp:Label><br />
            Supplier <asp:DropDownList ID="sup" runat="server"></asp:DropDownList><br />
            Category <asp:DropDownList ID="cate" runat="server"></asp:DropDownList><br />
            Quantity per Unit <asp:TextBox ID="quan" runat="server"></asp:TextBox><asp:Label ForeColor="Red" ID="quanerr" runat="server"></asp:Label>
            <br />
            UnitPrice <asp:TextBox ID="price" runat="server"></asp:TextBox><asp:Label ForeColor="Red" ID="priceerr" runat="server"></asp:Label>
            <asp:RangeValidator ID="rangeValid" runat="server" ControlToValidate="price" Type="Integer" MinimumValue="10" MaximumValue="100" ErrorMessage="The UnitPrice must be a integer number between 10 and 100"></asp:RangeValidator> <br />
            UnitInStock <asp:TextBox ID="unit" runat="server"></asp:TextBox><asp:Label ForeColor="Red" ID="stockerr" runat="server"></asp:Label>
            <asp:RangeValidator ID="rangeValid2" runat="server" Type="Integer" MinimumValue="0" MaximumValue="1000" ControlToValidate="unit" ErrorMessage="The UnitInStock must be a positive integer number"></asp:RangeValidator> <br />
            <asp:CheckBox ID="dis" runat="server" />Discontinued<br />
            <asp:Button ID="addproduct" runat="server" Text="Add Product" OnClick="addproduct_Click"/>
        </div>
    </form>
</body>
</html>
