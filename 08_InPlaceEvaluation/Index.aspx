<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>In Place Evaluation</title>
</head>
<body>
    <form runat="server">
        <asp:Button runat="server" Text="CLICK ME" OnClick="Button_Click" />
        <br /><br />
        <asp:Label ID="Label" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
