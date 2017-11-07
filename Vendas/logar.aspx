<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logar.aspx.cs" Inherits="Vendas.logar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div id="form-Login" align="center">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="usuario: " style="color: #FF0000; font-weight: 700;"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelSenha" runat="server" Text="senha: " style="color: #FF0000; font-weight: 700;"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnLogar" runat="server" Text="Logar" CssClass="btn btn-danger btn-small" Width="55px" OnClick="btnLogar_Click" />
                </td>
                <td>
                    <asp:Label ID="labelStatus" runat="server" Text="status" style="font-weight: 700"></asp:Label>
                </td>
            </tr>
        </table>
       
    </div>
    </form>
</body>
</html>
