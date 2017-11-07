using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Vendas
{
    public partial class CadastroProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtCodigo.Text = "-1";
                Cache["OP"] = "Gravar";
                camadas.dal.Produto dalProduto = new camadas.dal.Produto();
                gridProduto.DataSource = dalProduto.Select();
                gridProduto.DataBind();
                btnSalvarNoBanco.Visible = true;
                btnInserir.Visible = false;

            }
        }

            
        protected void btnSalvarNoBanco_Click(object sender, EventArgs e)
        {
            camadas.model.Produto produto = new camadas.model.Produto();
            camadas.dal.Produto dalProduto = new camadas.dal.Produto();

            produto.id = Convert.ToInt32(txtCodigo.Text.Trim());
            produto.nome = txtNome.Text.Trim();
            produto.tamanho = Convert.ToInt32(TxtTamanho.Text.Trim());
            produto.preco = Convert.ToDecimal(txtPreco.Text.Trim());
            produto.marca = txtMarca.Text.Trim();
            produto.qtde = Convert.ToInt32(txtQtde.Text.Trim());


            if (Cache["OP"].ToString() == "Gravar")
            {
                dalProduto.Insert(produto);
                System.Windows.Forms.MessageBox.Show("Produto " + produto.nome + " foi gravado no banco");
            }
            else
            {
                if (Cache["OP"].ToString() == "Editar")
                {
                    dalProduto.Update(produto);
                    MessageBox.Show("Produto " + produto.nome + " foi alterado no banco");
                }
            }

            gridProduto.DataSource = dalProduto.Select();
            gridProduto.DataBind();

            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            TxtTamanho.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtQtde.Text = string.Empty;

            habilitaCampos(true);

            btnSalvarNoBanco.Visible = true;
            btnCancelar.Visible = false;
            btnInserir.Visible = false;
            btnRemover.Visible = false;
            btnEditar.Visible = false;

        }

        protected void gridCliente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                btnRemover.Visible = true;
                btnSalvarNoBanco.Visible = false;
                btnInserir.Visible = false;
                btnCancelar.Visible = true;
                btnEditar.Visible = true;
                

                Cache["OP"] = "Editar";

                GridViewRow linha = gridProduto.Rows[Convert.ToInt32(e.CommandArgument)];
                txtCodigo.Text = linha.Cells[0].Text;
                txtNome.Text = linha.Cells[1].Text;
                TxtTamanho.Text = linha.Cells[2].Text;
                txtPreco.Text = linha.Cells[3].Text;
                txtMarca.Text = linha.Cells[4].Text;
                txtQtde.Text = linha.Cells[5].Text;

                habilitaCampos(false);
            }
        }

        protected void gridCliente_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            camadas.dal.Produto daoProduto = new camadas.dal.Produto();
            gridProduto.DataSource = daoProduto.Select();
            gridProduto.PageIndex = e.NewPageIndex;
            gridProduto.DataBind();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "-1";
            btnSalvarNoBanco.Visible = true;
            btnCancelar.Visible = true;
            btnInserir.Visible = false;           
            Cache["OP"] = "Gravar";
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCodigo.Text) > 0)
            {
                camadas.dal.Produto dalProduto = new camadas.dal.Produto();
                camadas.model.Produto produto = new camadas.model.Produto();

                produto.id = Convert.ToInt32(txtCodigo.Text);
                dalProduto.Delete(produto);

                btnSalvarNoBanco.Visible = true;
                btnInserir.Visible = false;
                btnRemover.Visible = false;
                btnCancelar.Visible = false;
                btnEditar.Visible = false;
                habilitaCampos(true);

                limparCampos();
                gridProduto.DataSource = dalProduto.Select();
                gridProduto.DataBind();

            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Cache["OP"] = "Limpar";

            txtCodigo.Text = "-1";
            btnSalvarNoBanco.Visible = true;
            btnInserir.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = false;
            btnRemover.Visible = false;
          
            limparCampos();
            habilitaCampos(true);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            btnSalvarNoBanco.Visible = true;
            btnEditar.Visible = false;
        }

        protected void habilitaCampos(bool status)
        {
            txtNome.Enabled = status;
            TxtTamanho.Enabled = status;
            txtPreco.Enabled = status;           
            txtMarca.Enabled = status;
            txtQtde.Enabled = status;
      
        }

        protected void limparCampos()
        {
           
            txtNome.Text = string.Empty;
            TxtTamanho.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtQtde.Text = string.Empty;
           
        }

        protected void gridProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}