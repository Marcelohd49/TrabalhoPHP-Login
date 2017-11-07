using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vendas
{
    public partial class fazerReserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cache["OP"] = "I";

                txtDataReserva.Text = DateTime.Now.ToShortDateString();
             
                txtID.Text = Convert.ToString(int.Parse(Request.QueryString["id"]));
                //BuscarCliente();
                //buscarInstrumento();
            }
        }

        protected void btnReservar_Click(object sender, EventArgs e)
        {

        }

        protected void ddlInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            camadas.dal.Produto dalProduto  = new camadas.dal.Produto();
            camadas.model.Produto produto = new camadas.model.Produto();

            //instrumento = daoInstrumento.RecuperaPrecoInstrumento(ddlInstrumento.SelectedItem.Value);
            //txtValor.Text = Convert.ToString(instrumento.preco);
        }
    }
}