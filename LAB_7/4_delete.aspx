<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_delete.aspx.cs" Inherits="lab7_4._4_delete" %>

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
&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="4_update.aspx">Update</asp:HyperLink>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
            <br />
            <br />
            Sid :
            <asp:TextBox ID="TextBox1" runat="server" Width="194px"></asp:TextBox>
&nbsp;
            <br />
            <br />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
