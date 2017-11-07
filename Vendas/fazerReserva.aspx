<%@ Page Title="" Language="C#" MasterPageFile="~/PRINCIPAL.Master" AutoEventWireup="true" CodeBehind="fazerReserva.aspx.cs" Inherits="Vendas.fazerReserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="tabelaT">
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Id: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtID" runat="server" Width="48px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Data Reserva: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtDataReserva" runat="server" Width="97px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Cliente: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtCliente" runat="server" Width="321px" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="produto: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:DropDownList ID="ddlInstrumento" runat="server" Width="245px" DataTextField="nome" DataValueField="nome" OnSelectedIndexChanged="ddlInstrumento_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Valor: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtValor" runat="server" Width="97px" Enabled="False"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Qtde: " CssClass="fonteLetras"></asp:Label>
                    <asp:TextBox ID="txtQtde" runat="server" Width="35px" Enabled="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>

            <td>
                <asp:Label ID="Label5" runat="server" Text="Data Entrega: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtDataEntrega" runat="server" Width="97px" palceholder="xx/xx/xxxx"></asp:TextBox>
                <asp:CompareValidator ID="CompareDataEntrega" runat="server" ErrorMessage="Data invalida" ControlToValidate="txtDataEntrega" Operator="DataTypeCheck" Type="Date" CssClass="btn btn-primary"></asp:CompareValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnReservar" runat="server" Text="Reservar" CssClass="btn btn-primary" Width="85px" OnClick="btnReservar_Click" /></td>

        </tr>
    </table>
</asp:Content>
