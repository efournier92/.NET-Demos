<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Super Simple C# Webpage!
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="22px" OnTextChanged="TextBox1_TextChanged" Width="128px"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" checked="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
        </p>
        <p>
        </p>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="sampleLabel" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
