using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Vendas.camadas.dal
{
    public class Reservar
    {
        private string strCon = Conexao.getConexao();

        public void Insert(model.Reserva reserva)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Reserva values (@ClienteId, @ProdutoId, @Qtde, @PrecoTotal, ";
            sql += "@DataReserva, @telefone, @data)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ClienteId", reserva.cliente);
            cmd.Parameters.AddWithValue("@ProdutoId", reserva.produto);
            cmd.Parameters.AddWithValue("@Qtde", reserva.qtde);
            cmd.Parameters.AddWithValue("@PrecoTotal", reserva.preco);
            cmd.Parameters.AddWithValue("@DataReserva", reserva.dataReserva);
          
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
    }
}