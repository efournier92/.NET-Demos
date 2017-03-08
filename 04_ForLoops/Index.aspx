<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>For Loop</h2>
        <asp:Button ID="sampleButton" runat="server" Text="Fill Box" OnClick="sampleButton_Click" />
        <br>
        <asp:ListBox ID="sampleListBox" runat="server"></asp:ListBox>

        <h2>For Each Loop</h2>
        <asp:TextBox ID="forEachTextBox" runat="server" OnTextChanged="forEachTextBox_TextChanged"></asp:TextBox>
        <br>
        
        <br />
        <asp:Label ID="forEachLabel" runat="server"></asp:Label>
        
    </form>
    
</body>
</html>
