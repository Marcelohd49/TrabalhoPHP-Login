using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.camadas.model
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int tamanho { get; set; }
        public decimal preco { get; set; }
        public string marca { get; set; }

        public int qtde { get; set; }

    }
}