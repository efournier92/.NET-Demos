<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Polymorphism</title>
</head>
<body>
    <form runat="server">
        Book Title:
        <asp:TextBox ID="BookTitleBox" runat="server"></asp:TextBox><br />
        Book Price:
        <asp:TextBox ID="BookPriceBox" runat="server"></asp:TextBox><br /><br />
        Shoe Make:       
        <asp:TextBox ID="ShoeMakeBox" runat="server"></asp:TextBox><br />
        Shoe Price:       
        <asp:TextBox ID="ShoePriceBox" runat="server"></asp:TextBox><br /><br />
        <asp:Button runat="server" Text="Show Formatted" OnClick="FormatButton_Click" /><br />
        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>
