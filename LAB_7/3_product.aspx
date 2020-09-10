<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_product.aspx.cs" Inherits="lab7_3._3_product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="3_allproduct.aspx">All Products</asp:HyperLink>
            &nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="3_home.aspx">Home</asp:HyperLink>
            <br />

            <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" DataKeyNames="pid" DataSourceID="LinqDataSource1" Height="172px" Width="410px">
                <Fields>
                    <asp:BoundField DataField="pid" HeaderText="pid" ReadOnly="True" SortExpression="pid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                    <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="lab7_3.DataClasses1DataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="products" Where="pid == @pid">
                <WhereParameters>
                    <asp:QueryStringParameter Name="pid" QueryStringField="pid" Type="Int32" />
                </WhereParameters>
            </asp:LinqDataSource>

        </div>
    </form>
</body>
</html>