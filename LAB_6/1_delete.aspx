<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_delete.aspx.cs" Inherits="WebApplication4._1_delete" %>

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
    <a href="1_edit.aspx">Edit Values</a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="1_insert.aspx">Insert Values</a>
    &nbsp;&nbsp;&nbsp;&nbsp;<a href="1_show.aspx">Show Values</a>
    <br/><br />
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            ID :&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
