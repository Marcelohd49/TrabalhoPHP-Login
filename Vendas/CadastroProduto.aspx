<%@ Page Title="" Language="C#" MasterPageFile="~/PRINCIPAL.Master" AutoEventWireup="true" CodeBehind="CadastroProduto.aspx.cs" Inherits="Vendas.CadastroProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">

        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Codigo:"></asp:Label></td>
            <td class="auto-style3">
                <asp:TextBox ID="txtCodigo" runat="server" Width="38px" Enabled="False"></asp:TextBox></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Produto:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtNome" runat="server" Width="314px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtNome"></asp:RequiredFieldValidator>
            </td>

            <td>
                <asp:Label ID="Label2" runat="server" Text="Tamanho:"></asp:Label></td>
            <td>
                <asp:TextBox ID="TxtTamanho" runat="server" Width="28px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredTamanho" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="TxtTamanho"></asp:RequiredFieldValidator>
            </td>
            </tr> 
        <tr>     
            <td>
                <asp:Label ID="Label3" runat="server" Text="Preço:"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPreco" runat="server" Width="94px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredPreco" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtPreco"></asp:RequiredFieldValidator>
                 &nbsp;&nbsp;
                 <asp:Label ID="Label4" runat="server" Text="Qtde:"></asp:Label>
                  <asp:TextBox ID="txtQtde" runat="server" Width="35px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4Qtde" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtQtde"></asp:RequiredFieldValidator>         
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Marca:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMarca" runat="server" Width="199px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredMarca" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtMarca"></asp:RequiredFieldValidator>
            </td>
           </tr>
        <tr>
            <td>
                <asp:Button ID="btnSalvarNoBanco" runat="server" Text="Salvar no Banco" CssClass="btn btn-primary btn-small" Width="131px" OnClick="btnSalvarNoBanco_Click" Visible="False" /></td>
            <td class="auto-style3">
                <asp:Button ID="btnInserir" runat="server" Text="Inserir" CssClass="btn btn-primary btn-small" Width="69px" OnClick="btnInserir_Click" />
                <asp:Button ID="btnRemover" runat="server" Text="Remover" CssClass="btn btn-primary btn-small" Width="85px" OnClick="btnRemover_Click" Visible="False" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary btn-small" Width="84px" OnClick="btnCancelar_Click" Visible="False" />
                                <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-primary btn-small" Width="71px" OnClick="btnEditar_Click" Visible="False" />
            
            </td>
        </tr>
    </table>
     <div style="width: 100%; overflow: auto;">
        <asp:GridView ID="gridProduto" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="gridCliente_PageIndexChanging" OnRowCommand="gridCliente_RowCommand" PageSize="5" OnSelectedIndexChanged="gridProduto_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" />
                <asp:BoundField DataField="nome" HeaderText="nome" />
                <asp:BoundField DataField="tamanho" HeaderText="tamanho" />
                <asp:BoundField DataField="preco" HeaderText="preco" />
                <asp:BoundField DataField="marca" HeaderText="marca" />     
                <asp:BoundField DataField="qtde" HeaderText="qtde" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Selecionar" ControlStyle-CssClass="btn btn-warning btn-sm" >
<ControlStyle CssClass="btn btn-warning btn-sm"></ControlStyle>
                </asp:ButtonField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
