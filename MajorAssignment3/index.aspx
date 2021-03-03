<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MajorAssignment3.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="MovieApp.MovieUtils.MovieUtilities" UpdateMethod="UpdateMovie" DeleteMethod="DeleteMovie">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <UpdateParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                    <asp:Parameter Name="title" Type="String" />
                    <asp:Parameter Name="director" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                    <asp:BoundField DataField="Director" HeaderText="Director" SortExpression="Director" />
                </Columns>
            </asp:GridView>

        </div>
        <asp:Panel ID="pnlAddMovie" runat="server" GroupingText="Add New Movie">
            <asp:Label ID="lblTitle" runat="server" Text="Title: "></asp:Label><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblDirector" runat="server" Text="Director: "></asp:Label><asp:TextBox ID="txtDirector" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSave" runat="server" Text="Submit" />
        </asp:Panel>
        
    </form>
</body>
</html>
