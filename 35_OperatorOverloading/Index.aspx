﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Operator Overloading</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click"/><br />
        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>