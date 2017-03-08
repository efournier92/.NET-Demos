<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enumerations</title>
</head>
<body>
    <form id="form" runat="server">
        <asp:DropDownList ID="DropDownList" runat="server" AutoPostBack="True">
            <asp:ListItem>Monday</asp:ListItem>
            <asp:ListItem>Tuesday</asp:ListItem>
            <asp:ListItem>Wednesday</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
