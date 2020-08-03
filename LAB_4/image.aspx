<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="image.aspx.cs" Inherits="WebApplication2.image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Width="278px" ImageUrl="abc.png" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" />
        </div>
    </form>
</body>
</html>
