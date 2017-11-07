using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Vendas.camadas.dal
{
    public class Usuario
    {
        private string strCon = Conexao.getConexao();

        public model.Usuario LogarUsuario(string usuario, string senha)
        {
            model.Usuario Usu = new model.Usuario();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Usuarios where usuario=@usuario and senha=@senha";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Usu.id = Convert.ToInt32(reader["id"].ToString());
                    Usu.usuario = reader["usuario"].ToString();
                    Usu.senha = reader["senha"].ToString();
                    Usu.admin = reader["admin"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Clientes");
            }
            finally
            {
                conexao.Close();
            }
            return Usu;
        }
    }
}