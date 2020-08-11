<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="lab5_1.reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Email:
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="202px"></asp:TextBox>
            <br />
            <br />
            password:
            <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="188px"></asp:TextBox>
            <br />
            <br />
            in case you forgot your password<br />
            <br />
            select fav color(stored in cookie)&nbsp; :<asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="175px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
