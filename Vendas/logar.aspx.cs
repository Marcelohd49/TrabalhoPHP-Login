using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vendas
{
    public partial class logar : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            camadas.dal.Usuario dalLogar = new camadas.dal.Usuario();
            camadas.model.Usuario usuario = new camadas.model.Usuario();

            var nomeUsuario = txtUsuario.Text;
            var senha = txtSenha.Text;

            try
            {
                usuario = dalLogar.LogarUsuario(nomeUsuario, senha);

                if (usuario.usuario == nomeUsuario && usuario.senha == senha)
                {
                    Response.Redirect("Conectado.aspx");
                }
                else
                {
                    labelStatus.Text = "Usuario não encontrado..";
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao consultar usuario");
            }
        }
    }
}