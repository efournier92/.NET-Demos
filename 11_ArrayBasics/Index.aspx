﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Button ID="SummarizeButton" runat="server" Text="Summarize" OnClick="SummarizeButton_Click" /><br />
        <asp:Label ID="Label" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>