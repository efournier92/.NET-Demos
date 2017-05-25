 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Indexc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Var & Dynamic</title>
</head>
<body>
    <form runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" Text="Button" OnClick="Button_Click" />
        <br />
        <br />
        <asp:Label ID="Label" runat="server" Text="Label"></asp:Label><br />
    </form>
</body>
</html>
