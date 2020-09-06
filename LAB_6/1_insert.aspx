<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_insert.aspx.cs" Inherits="WebApplication4._1_insert" %>

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
            <a href="1_edit.aspx">Edit Values</a>&nbsp;&nbsp;&nbsp;<a href="1_delete.aspx">Delete Values</a>
            &nbsp;&nbsp;&nbsp;<a href="1_show.aspx">Show Values</a>
            <br />
        </div>
        <div>

            <br />

            ID :
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Height="16px" Width="132px"></asp:TextBox>
            <br />
            <br />
            Name: <asp:TextBox ID="TextBox2" runat="server" Height="18px" Width="195px"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" Text ="Name is Required" ControlToValidate="TextBox2" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <br />
            Mobile No:
            <asp:TextBox ID="TextBox3" runat="server" Height="17px" Width="179px"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" Text ="Number is Required" ControlToValidate="TextBox3" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <br />
            Semester:
            <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="199px"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server"  Text="Semester is Required" ControlToValidate="TextBox5" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <br />
            Email :
            <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="204px"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" Text ="mail is required" ControlToValidate="TextBox4" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
