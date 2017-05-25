<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delegates</title>
</head>
<body>
    <form runat="server">
        <asp:Button runat="server" Text="Update Labels" OnClick="UpdateLabelsButton_Click" /><br />
        <br />
        <asp:Label ID="FirstLabel" runat="server"></asp:Label><br />
        <asp:Label ID="SecondLabel" runat="server"></asp:Label><br />
        <asp:Label ID="MainLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
