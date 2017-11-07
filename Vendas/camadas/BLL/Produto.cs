using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.camadas.BLL
{
    public class Produto:IntId
    {
        public string nome { get; set; }
        public string tamanho { get; set; }
        public string preco { get; set; }
        public string marca { get; set; }
        public string qtde { get; set; }
    }
}