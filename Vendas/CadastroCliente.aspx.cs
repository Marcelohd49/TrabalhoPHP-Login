using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Vendas
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                btnSalvarNoBanco.Visible = true;
                btnCancelar.Visible = false;
                btnInserir.Visible = false;
                habilitaCampos(true);

                txtCodigo.Text = "-1";
                Cache["OP"] = "Gravar";
                camadas.dal.Cliente dalCliente = new camadas.dal.Cliente();
                gridCliente.DataSource = dalCliente.Select();
                gridCliente.DataBind();
            }
        }
 
        protected void btnRemover_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtCodigo.Text) > 0)
            {
                camadas.dal.Cliente bllCliente = new camadas.dal.Cliente();
                camadas.model.Cliente cliente = new camadas.model.Cliente();

                cliente.id = Convert.ToInt32(txtCodigo.Text);
                bllCliente.Delete(cliente);

                btnSalvarNoBanco.Visible = false;
                btnInserir.Visible = true;
                btnRemover.Visible = false;
                btnCancelar.Visible = false;
                btnEditar.Visible = false;

                btnSalvarNoBanco.Visible = true;
                habilitaCampos(true);
                limparCampos();
                gridCliente.DataSource = bllCliente.Select();
                gridCliente.DataBind();

            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Cache["OP"] = "Limpar";

            btnSalvarNoBanco.Visible = false;
            btnInserir.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = false;
            btnRemover.Visible = false;
            habilitaCampos(true);
            limparCampos();
            btnSalvarNoBanco.Visible = true;

        }

        protected void gridCliente_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            camadas.dal.Cliente daoCliente = new camadas.dal.Cliente();
            gridCliente.DataSource = daoCliente.Select();
            gridCliente.PageIndex = e.NewPageIndex;
            gridCliente.DataBind();
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
                habilitaCampos(false);
                

                Cache["OP"] = "Editar";


                GridViewRow linha = gridCliente.Rows[Convert.ToInt32(e.CommandArgument)];
                txtCodigo.Text = linha.Cells[0].Text;
                txtNome.Text = linha.Cells[1].Text;
                TxtRg.Text = linha.Cells[2].Text;
                txtCidade.Text = linha.Cells[3].Text;
                txtEndereco.Text = linha.Cells[4].Text;
                txtBairro.Text = linha.Cells[5].Text;
                txtTelefone.Text = linha.Cells[6].Text;
                txtDataNasc.Text = linha.Cells[7].Text;
            }
        }

        protected void btnSalvarNoBanco_Click(object sender, EventArgs e)
        {

            camadas.model.Cliente cliente = new camadas.model.Cliente();
            camadas.dal.Cliente dalCliente = new camadas.dal.Cliente();

            cliente.id = Convert.ToInt32(txtCodigo.Text.Trim());
            cliente.nome = txtNome.Text.Trim();
            cliente.rg = TxtRg.Text.Trim();
            cliente.cidade = txtCidade.Text.Trim();
            cliente.endereco = txtEndereco.Text.Trim();
            cliente.bairro = txtBairro.Text.Trim();
            cliente.telefone = txtTelefone.Text.Trim();
            cliente.data = txtDataNasc.Text.Trim();

            if (Cache["OP"].ToString() == "Gravar")
            {
                dalCliente.Insert(cliente);
                MessageBox.Show("Cliente " + cliente.nome + " foi gravado no banco");
            }
            else
            {
                if (Cache["OP"].ToString() == "Editar")
                {
                    dalCliente.Update(cliente);
                    MessageBox.Show("Cliente " + cliente.nome + " foi alterado no banco");
                }
            }

            gridCliente.DataSource = dalCliente.Select();
            gridCliente.DataBind();

            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            TxtRg.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtDataNasc.Text = string.Empty;

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "-1";
            btnSalvarNoBanco.Visible = true;
            btnCancelar.Visible = true;
            btnInserir.Visible = false;

            habilitaCampos(true);
            Cache["OP"] = "Gravar";
        }

        protected void habilitaCampos(bool status)
        {
            txtNome.Enabled = status;
            TxtRg.Enabled = status;
            txtCidade.Enabled = status;
            txtEndereco.Enabled = status;
            txtTelefone.Enabled = status;
            txtBairro.Enabled = status;
            txtDataNasc.Enabled = status;

        }

        protected void limparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            TxtRg.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            btnSalvarNoBanco.Visible = true;
            Cache["OP"] = "Editar";
            
        }
    }
}