﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Passing Arrays To Methods</title>
</head>
<body>
    <form runat="server">
        <asp:Button runat="server" Text="Sum" OnClick="Button_Click"/><br />
        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>
