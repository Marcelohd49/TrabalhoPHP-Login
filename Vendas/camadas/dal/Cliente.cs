using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Vendas.camadas.dal;

namespace Vendas.camadas.dal
{
    public class Cliente
    {

        private string strCon = Conexao.getConexao();

        public void Insert(model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into CLIENTES values (@nome, @rg, @cidade, @endereco, ";
            sql += "@bairro, @telefone, @data_cadastro)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@rg", cliente.rg);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@data_cadastro", cliente.data);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir no banco...");

            }
            finally
            {
                conexao.Close();
            }

        }


        public List<model.Cliente> Select()
        {
            List<model.Cliente> lstCliente = new List<model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from CLIENTES";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    model.Cliente cliente = new model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"].ToString());
                    cliente.nome = reader["nome"].ToString();
                    cliente.rg = reader["rg"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.bairro = reader["bairro"].ToString();
                    cliente.telefone = reader["telefone"].ToString(); ;
                    cliente.data = reader["data_cadastro"].ToString();

                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao selecionar tabela no banco...");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }

        public void Update(camadas.model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "update CLIENTES set nome=@nome, rg=@rg, cidade=@cidade, endereco=@endereco, bairro=@bairro, telefone=@telefone, data=@data_cadastro";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@rg", cliente.rg);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);           
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@data_cadastro", cliente.data);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Clientes");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from CLIENTES where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao excluir  no banco...");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
