<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virtual Functions</title>
</head>
<body>
    <form runat="server">
        Make: <asp:TextBox ID="MakeBox" runat="server"></asp:TextBox><br />
        # of Doors: <asp:TextBox ID="DoorBox" runat="server"></asp:TextBox><br /><br />
        <asp:Button runat="server" Text="Make Vehicle" OnClick="Button_Click"/><br /><br />
        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>
