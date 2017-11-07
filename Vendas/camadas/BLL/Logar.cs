using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.camadas.BLL
{
    public class Logar:IntId
    {
        public string nomeusuario { get; set; }
        public string senhausuario { get; set; }
        public string admin { get; set; }
    }
}