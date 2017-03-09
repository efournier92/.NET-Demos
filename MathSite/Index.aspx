<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Name Spacing</title>
</head>
<body>
    <form id="form1" runat="server">
        Value 1:
        <asp:TextBox ID="Value1Box" runat="server"></asp:TextBox><br />
        Value 2:
        <asp:TextBox ID="Value2Box" runat="server"></asp:TextBox><br />
        <asp:Button ID="AddButton" runat="server" Text="Add" /><br />
        Principle:
        <asp:TextBox ID="PrincipleBox" runat="server"></asp:TextBox><br />
        Rate:
        <asp:TextBox ID="RateBox" runat="server"></asp:TextBox><br />
        <asp:Button ID="FindInterestButton" runat="server" Text="Find Interest" /><br />
        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>
