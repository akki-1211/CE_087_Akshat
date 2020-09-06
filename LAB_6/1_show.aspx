<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_show.aspx.cs" Inherits="WebApplication4._1_show" %>

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
    <a href="1_edit.aspx">Edit Values</a>&nbsp;&nbsp;<a href="1_insert.aspx">Insert Values</a>&nbsp; <a href="1_delete.aspx"> Delete Values </a>
            <br /><br /><br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
