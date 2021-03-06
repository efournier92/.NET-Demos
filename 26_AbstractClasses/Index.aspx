﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Abstract Classes</title>
</head>
<body>
    <form runat="server">
        Sphere Radius: <asp:TextBox ID="SphereRadiusBox" runat="server" AutoPostBack="True" OnTextChanged="SphereRadiusBox_TextChanged"></asp:TextBox><br />
        <asp:Label ID="SphereLabel" runat="server"></asp:Label><br /><br />

        Cube Edge Length: <asp:TextBox runat="server" AutoPostBack="True" OnTextChanged="CubeEdgeBox_TextChanged"></asp:TextBox><br />
        <asp:Label ID="CubeLabel" runat="server"></asp:Label><br />
    </form>
</body>
</html>
