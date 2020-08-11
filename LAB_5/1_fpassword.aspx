<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fpassword.aspx.cs" Inherits="lab5_1.fpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Fav Color:
            <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="163px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br/>

            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login Page" />

        </div>
    </form>
</body>
</html>
