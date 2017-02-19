<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Return Types</title>
</head>
<body>
    <form id="form1" runat="server">
        1st Title:
        <asp:TextBox ID="TitleBox1" runat="server"></asp:TextBox><br />
        2nd Title:
        <asp:TextBox ID="TitleBox2" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="SortButton" runat="server" Text="Sort" /><br /><br />

        <asp:Label ID="Label" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
