<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_update.aspx.cs" Inherits="lab7_4._4_update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="4_insert.aspx">Insert</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="4_show.aspx">Show_data</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="4_delete.aspx">Delete</asp:HyperLink>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
            <br />
            <br />
            Sid : <asp:TextBox ID="TextBox1" runat="server" Width="194px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Fetch" />
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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
        </div>
    </form>
</body>
</html>
