<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_insert.aspx.cs" Inherits="lab7_4._4_insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="4_update.aspx">Update</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="4_show.aspx">Show_data</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="4_delete.aspx">Delete</asp:HyperLink>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Lime"></asp:Label>
            <br />
            <br />
            Sid : <asp:TextBox ID="TextBox1" runat="server" Width="194px" ForeColor="Green"></asp:TextBox>
            <br />
            <br />
            Name:
            <asp:TextBox ID="TextBox2" runat="server" Width="194px"></asp:TextBox>
            <br />
            <br />
            Sem:
            <asp:TextBox ID="TextBox3" runat="server" Width="194px"></asp:TextBox>
            <br />
            <br />
            Cpi:
            <asp:TextBox ID="TextBox4" runat="server" Width="194px"></asp:TextBox>
            <br />
            <br />
            Contact :
            <asp:TextBox ID="TextBox5" runat="server" Width="194px"></asp:TextBox>
            <br />
            <br />
            Email:
            <asp:TextBox ID="TextBox6" runat="server" Width="194px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        </div>
    </form>
</body>
</html>
