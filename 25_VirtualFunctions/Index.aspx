<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Make: <asp:TextBox ID="MakeBox" runat="server"></asp:TextBox><br />
        Wheel Number: <asp:TextBox ID="WheelBox" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button" runat="server" Text="Make Vehicle" OnClick="Button_Click" /><br />
        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>
