<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_edit.aspx.cs" Inherits="WebApplication4._1_edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        a{
            text-decoration:none
        }
        a:hover{
            color:aquamarine
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="1_insert.aspx"> Add Values </a>&nbsp;&nbsp;&nbsp;<a href="1_delete.aspx"> Delete Values </a>&nbsp;&nbsp;&nbsp;<a href="1_show.aspx"> Show Values </a>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            &nbsp;<br />
            ID :
            &nbsp;
            &nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Fetch" />
            <br />
            <br />
            <asp:Label ID="name" runat="server"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Sem" runat="server"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Height="16px" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="email" runat="server"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Height="16px" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="mobile" runat="server"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Height="16px" Visible="False"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>

        </div>
    </form>
</body>
</html>
