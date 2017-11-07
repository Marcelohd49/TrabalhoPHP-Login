using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.camadas.model
{
    public class Reserva
    {
        public int id { get; set; }
        public int  cliente { get; set; }
        public int produto { get; set; }
        public int qtde { get; set; }
        public decimal preco  { get; set; }
        public string dataReserva { get; set; }
    }
}