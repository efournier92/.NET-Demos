<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter Sedan Make & Model: <asp:TextBox ID="SedanTextBox" runat="server"></asp:TextBox><br />
        Enter Truck Make & Model: <asp:TextBox ID="TruckTextBox" runat="server"></asp:TextBox><br />
        <asp:Button ID="GetMakeButton" runat="server" Text="Get Make" OnClick="GetMakeButton_Click" />
    </form>
</body>
</html>
