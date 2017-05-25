<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Class Inheritance</title>
</head>
<body>
    <form runat="server">
        Enter Sedan Make & Model: <asp:TextBox ID="SedanTextBox" runat="server"></asp:TextBox><br />
        Enter Truck Make & Model: <asp:TextBox ID="TruckTextBox" runat="server"></asp:TextBox><br /><br />
        <asp:Button runat="server" Text="Get Make" OnClick="GetMakeButton_Click" /><br /><br />
        <asp:Label ID="SedanLabel" runat="server"></asp:Label><br />
        <asp:Label ID="TruckLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
