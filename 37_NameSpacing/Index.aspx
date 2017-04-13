<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Name Spacing</title>
</head>
<body>
    <form runat="server">
        Value 1:
        <asp:TextBox ID="Value1Box" runat="server"></asp:TextBox><br />
        Value 2:
        <asp:TextBox ID="Value2Box" runat="server"></asp:TextBox><br />
        <asp:Button runat="server" Text="Add" OnClick="AddButton_Click" /><br />
        <asp:Label ID="SumLabel" runat="server"></asp:Label><br />
        <br />
        Principle:
        <asp:TextBox ID="PricipleBox" runat="server"></asp:TextBox><br />
        Rate:
        <asp:TextBox ID="RateBox" runat="server"></asp:TextBox><br />
        <asp:Button runat="server" Text="Button" OnClick="FindInterestButton_Click" /><br />
        <asp:Label ID="InterestLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
