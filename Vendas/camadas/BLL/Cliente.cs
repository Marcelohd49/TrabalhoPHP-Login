using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.camadas.BLL
{
    public class Cliente:IntId
    {
        public string nome { get; set; }
        public string rg { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set; }
        public string data_cadasrtro { get; set; }
    }
}