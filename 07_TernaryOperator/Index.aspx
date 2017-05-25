<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ternary Operator</title>
</head>
<body>
    <form runat="server">
        <asp:TextBox ID="ternaryTextBox01" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="ternaryTextBox02" runat="server"></asp:TextBox><br />
        <asp:Button runat="server" Text="Find Sum" OnClick="ternaryButton_Click" /><br />
        <asp:Label ID="ternaryLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>

