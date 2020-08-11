<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_login.aspx.cs" Inherits="WebApplication3._2_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <div>
            <asp:Label ID="Label1" runat="server" ForeColor="red"></asp:Label>
            </div>
            <br />
            <br />
            Name:
            <asp:TextBox ID="TextBox1" runat="server" Width="167px"></asp:TextBox>
            <br />
            <br />
            Password :
            <asp:TextBox ID="TextBox2" runat="server" Width="161px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
