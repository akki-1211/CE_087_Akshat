<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_show.aspx.cs" Inherits="lab7_4._4_show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="4_insert.aspx">Insert</asp:HyperLink>
&nbsp;&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="4_delete.aspx">Delete</asp:HyperLink>
&nbsp;&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="4_update.aspx">Update</asp:HyperLink>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="sid" DataSourceID="LinqDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="sid" HeaderText="sid" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                </Columns>
            </asp:GridView>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="lab7_4.DataClasses1DataContext" EntityTypeName="" TableName="students">
            </asp:LinqDataSource>
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="sid" DataSourceID="LinqDataSource2" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="sid" HeaderText="sid" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
                    <asp:BoundField DataField="cpi" HeaderText="cpi" SortExpression="cpi" />
                    <asp:BoundField DataField="contact_no" HeaderText="contact_no" SortExpression="contact_no" />
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                </Fields>
            </asp:DetailsView>
            <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="lab7_4.DataClasses1DataContext" EntityTypeName="" TableName="students" Where="sid == @sid">
                <WhereParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="sid" PropertyName="SelectedValue" Type="Int32" DefaultValue="0" /> 
                </WhereParameters>
            </asp:LinqDataSource>
        </div>
    </form>
</body>
</html>
