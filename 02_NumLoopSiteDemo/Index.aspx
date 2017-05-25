<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="numInput" runat="server" OnTextChanged="numInput_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="numOutput" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
