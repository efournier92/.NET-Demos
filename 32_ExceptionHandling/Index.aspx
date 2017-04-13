<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exception Handling</title>
</head>
<body>
    <form runat="server">
        Value 1: <asp:TextBox ID="ValueBox1" runat="server"></asp:TextBox><br />
        Value 2: <asp:TextBox ID="ValueBox2" runat="server"></asp:TextBox><br /><br />
        <asp:Button runat="server" Text="Divide" OnClick="DivideButton_Click" /><br /><br />
        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>
