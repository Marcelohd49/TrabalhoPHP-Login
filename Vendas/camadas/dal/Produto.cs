using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Vendas.camadas.dal
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public void Insert(model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into PRODUTO values (@nome, @tamanho, @preco, @marca, @qtde)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@tamanho", produto.tamanho);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("qtde", produto.qtde);

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

        public List<model.Produto> Select()
        {
            List<model.Produto> lstProduto = new List<model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from PRODUTO";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    model.Produto produto = new model.Produto();
                    produto.id = Convert.ToInt32(reader["id"].ToString());
                    produto.nome = reader["nome"].ToString();
                    produto.tamanho = Convert.ToInt32(reader["tamanho"].ToString());
                    produto.preco = Convert.ToDecimal(reader["preco"].ToString());
                    produto.marca = reader["marca"].ToString();
                    produto.qtde = Convert.ToInt32(reader["qtde"].ToString());
                  
                    lstProduto.Add(produto);
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
            return lstProduto;
        }

        public List<model.Produto> RecuperaProduto(int id)
        {
            List<model.Produto> lstProduto = new List<model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from PRODUTO where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    model.Produto produto = new model.Produto();
                   
                    produto.nome = reader["nome"].ToString();
                 

                    lstProduto.Add(produto);
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
            return lstProduto;
        }

        public void Update(camadas.model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "update PRODUTO set nome=@nome, tamanho=@tamanho, preco=@preco, marca=@marca, qtde=@qtde";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@tamanho", produto.tamanho);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@qtde", produto.qtde);
         
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

        public void Delete(model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from PRODUTO where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
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