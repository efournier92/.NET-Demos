<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Interfaces</title>
</head>
<body>
    <form id="form1" runat="server">
        Name:
        <asp:TextBox ID="NameBox" runat="server"></asp:TextBox><br />
        Text:
        <asp:TextBox ID="TextBox" runat="server"></asp:TextBox><br /><br />
         <asp:Button ID="PrintButton" runat="server" Text="Print" OnClick="PrintButton_Click" /><br /><br />
        <asp:Label ID="Label" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
