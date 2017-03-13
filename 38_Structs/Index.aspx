<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Structs</title>
</head>
<body>
    <form runat="server">
        <asp:Button runat="server" Text="Make & Show Points" OnClick="MakePoints_Click" /><br />
        <asp:Label ID="PointsLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
