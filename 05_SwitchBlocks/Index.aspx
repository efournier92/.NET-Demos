<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="switchDropDown" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem>Apple</asp:ListItem>
            <asp:ListItem Value="Peach">Peach</asp:ListItem>
            <asp:ListItem>Pear</asp:ListItem>
            <asp:ListItem>Plum</asp:ListItem>
        </asp:DropDownList>
        <br>
        <asp:Label ID="switchLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
