<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormWeb.aspx.cs" Inherits="EmpresaCliente.FormWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="ObjectDataSource1" Height="50px" Width="304px">
            </asp:DetailsView>
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" DataSourceID = "ObjectDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCategorias" TypeName="EmpresaCliente.ServiceReference1.WSCategoriasSoapClient"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
