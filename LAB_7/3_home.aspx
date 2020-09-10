<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_home.aspx.cs" Inherits="lab7_3._3_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="3_allproduct.aspx">All Products</asp:HyperLink>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            ID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Fetch" OnClick="Button1_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
