<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_home.aspx.cs" Inherits="WebApplication3._2_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" ForeColor="#333333"></asp:Label>
            Select Anyone Category:<br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="category" OnCheckedChanged="RadioButton_CheckedChanged" Text="Electronics" AutoPostBack="true" />
&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="category" Text="Books" OnCheckedChanged="RadioButton_CheckedChanged" AutoPostBack="true" />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <asp:ListBox ID="ListBox1" SelectionMode="multiple" runat="server" Height="91px" Visible="False" Width="191px" style="margin-top: 0px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>

            &nbsp;&nbsp;&nbsp;&nbsp;

            <br />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Place Order" OnClick="Button1_Click"/>

        </div>
    </form>
</body>
</html>
