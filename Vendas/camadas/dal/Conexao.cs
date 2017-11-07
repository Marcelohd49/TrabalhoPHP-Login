using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.camadas.dal
{
    public class Conexao
    {
        public static string getConexao()
        {
            return @"Data Source=.\SQLEXPRESS2;Initial Catalog=DADOS_VENDAS;Integrated Security=True";
        }
    }
}