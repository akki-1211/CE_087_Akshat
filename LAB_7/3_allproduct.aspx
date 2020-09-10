<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_allproduct.aspx.cs" Inherits="lab7_3._3_allproduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="3_home.aspx">Home</asp:HyperLink>
&nbsp;<br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="pid" DataSourceID="LinqDataSource1" >
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="pid" HeaderText="pid" ReadOnly="True" SortExpression="pid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                    <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                </Columns>
            </asp:GridView>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="lab7_3.DataClasses1DataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="products">
            </asp:LinqDataSource>
        </div>
    </form>
</body>
</html>
