<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="tryParseTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="tryParseButton" runat="server" Text="Calculate 110%" OnClick="tryParseButton_Click1" /><br>
        <asp:Label ID="tryParseLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
