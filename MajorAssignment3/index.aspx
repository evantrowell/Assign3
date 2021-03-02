﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MajorAssignment3.index" %>

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
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" AutoGenerateEditButton="True" AutoGenerateDeleteButton="True">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                    <asp:BoundField DataField="Director" HeaderText="Director" SortExpression="Director" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
