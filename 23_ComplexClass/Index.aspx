 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Truck Name:<asp:TextBox ID="TextBox" runat="server"></asp:TextBox><br />
        
        <div style="text-align: center;">
            <asp:Label runat="server"></asp:Label>
        </div><br />

        <asp:Label ID="Label" runat="server"></asp:Label>
    </form>
</body>
</html>
