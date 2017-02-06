<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Male" /><br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Under 45" /><br />
        <asp:Button ID="Button" runat="server" Text="Button" OnClick="Button_Click" /><br />
        <asp:Label ID="Label" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
