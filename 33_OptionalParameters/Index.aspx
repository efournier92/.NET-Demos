
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Optional Parameters</title>
</head>
<body>
    <form id="form1" runat="server">
        Search For: <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="SearchButton" runat="server" Text="Search" OnClick="SearchButton_Click" /><br /><br />
        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>
