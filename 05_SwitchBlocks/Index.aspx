<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="switchDropDown" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Apples</asp:ListItem>
            <asp:ListItem>Peaches</asp:ListItem>
            <asp:ListItem>Pears</asp:ListItem>
            <asp:ListItem>Plums</asp:ListItem>
        </asp:DropDownList>
        <br>
        <asp:Label ID="switchLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
