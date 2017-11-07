<%@ Page Title="" Language="C#" MasterPageFile="~/PRINCIPAL.Master" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="Vendas.CadastroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 485px;
        }
    </style>
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
                <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtNome" runat="server" Width="314px" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtNome"></asp:RequiredFieldValidator>
            </td>

            <td>
                <asp:Label ID="Label2" runat="server" Text="Rg:"></asp:Label></td>
            <td>
                <asp:TextBox ID="TxtRg" runat="server" Width="160px" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredRg" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="TxtRg" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Telefone:"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtTelefone" runat="server" Width="159px" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredTelefone" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtTelefone" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Data de Nascimento:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDataNasc" runat="server" Width="113px" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredData" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtDataNasc" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularData" runat="server" ErrorMessage="Data Invalida" CssClass="btn btn-primary" ControlToValidate="txtDataNasc" ValidationExpression="^\d{2}/\d{2}/\d{4}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Endereco:"></asp:Label></td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEndereco" runat="server" Width="314px" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEndereco" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtEndereco"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Cidade:"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtCidade" runat="server" Width="174px" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredCidade" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtCidade"></asp:RequiredFieldValidator>
            </td>
            <td>Bairro</td>
            <td>
                <asp:TextBox ID="txtBairro" runat="server" Width="333px" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredBairro" runat="server" ErrorMessage="Preencher" CssClass="btn btn-primary" ControlToValidate="txtBairro"></asp:RequiredFieldValidator>
            </td>
            <link href="Content/bootstrap.css" rel="stylesheet" />
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
        <asp:GridView ID="gridCliente" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="gridCliente_PageIndexChanging" OnRowCommand="gridCliente_RowCommand" PageSize="5">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ClienteId" />
                <asp:BoundField DataField="nome" HeaderText="Nome" />
                <asp:BoundField DataField="rg" HeaderText="RG" />
                <asp:BoundField DataField="cidade" HeaderText="Cidade" />
                <asp:BoundField DataField="endereco" HeaderText="Endereco" />
                <asp:BoundField DataField="bairro" HeaderText="Bairro" />
                <asp:BoundField DataField="telefone" HeaderText="Telefone" />
                <asp:BoundField DataField="data" HeaderText="DataNasc" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Selecionar" ControlStyle-CssClass="btn btn-warning btn-sm" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
