<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Creating Classes</title>
</head>
<body>
    <form runat="server">
        <asp:TextBox ID="TextBox" runat="server"></asp:TextBox><br/>
        <asp:Button runat="server" Text="Button" OnClick="Button_Click" />
        <br />
        <br/>
        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>
