using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormProduto : Form
    {
        private ProdutoController controller;

        public FormProduto(ProdutoController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var produto = new Produto()
            {
                Id = (txtID.Text == string.Empty ? Guid.NewGuid() : new Guid(txtID.Text)),
                Descricao = txtDescricao.Text,
                PrecoDeCusto = Convert.ToDouble(txtPrecoCusto.Text),
                PrecoDeVenda = Convert.ToDouble(txtPrecoVenda.Text),
                Estoque = Convert.ToDouble(txtEstoque.Text)
            };

            produto = (txtID.Text == string.Empty ? this.controller.Insert(produto) : this.controller.Update(produto));
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = this.controller.GetAll();
            ClearControls();
        }

        
        private void ClearControls()
        {
            dgvProdutos.ClearSelection();
            txtID.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPrecoCusto.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            txtDescricao.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show(
                "Selecione o PRODUTO a ser removido no GRID");
            }
            else
            {
                this.controller.Remove(
                new Produto()
                {
                    Id = new Guid(txtID.Text)
                }
                );
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = this.controller.GetAll();
                ClearControls();
            }
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPrecoCusto.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
            txtPrecoVenda.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
