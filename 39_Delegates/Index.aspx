<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delegates</title>
</head>
<body>
    <form id="form" runat="server">
        <asp:Button ID="UpdateLabelsButton" runat="server" Text="Update Labels" />
        <asp:Label ID="FirstLabel" runat="server"></asp:Label><br />
        <asp:Label ID="SecondLabel" runat="server"></asp:Label><br />
        <asp:Label ID="MainLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
