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
    public partial class FormNotaEntrada : Form
    {
        private NotaEntradaController controller;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;

        private NotaEntrada notaAtual;

        public FormNotaEntrada(
                                NotaEntradaController controller,
                                FornecedorController fornecedorController,
                                ProdutoController produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;
            InicializaComboBoxs();
        }


        private void InicializaComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();

            foreach (Fornecedor fornecedor in
            this.fornecedorController.GetAll())
            {
                cbxFornecedor.Items.Add(fornecedor);
            }

            foreach (Produto produto in
            this.produtoController.GetAll())
            {
                cbxProduto.Items.Add(produto);
            }
        }

        private void btnNovoNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }



        private void ClearControlsNota()
        {
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            txtIDNotaEntrada.Text = string.Empty;
            cbxFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            cbxFornecedor.Focus();
        }

        private void btnGravarNota_Click(object sender, EventArgs e)
        {
            var notaEntrada = new NotaEntrada()
            {
                Id = (txtIDNotaEntrada.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIDNotaEntrada.Text)),
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpEntrada.Value,
                FornecedorNota = (Fornecedor)cbxFornecedor.SelectedItem,
                Numero = txtNumero.Text
            };

            notaEntrada = (txtIDNotaEntrada.Text == string.Empty ? this.controller.Insert(notaEntrada) : 
                this.controller.Update(notaEntrada));
                dgvNotasEntrada.DataSource = null;
                dgvNotasEntrada.DataSource = this.controller.GetAll();
                ClearControlsNota();
        }

        private void btnCancelarNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void btnRemoverNota_Click(object sender, EventArgs e)
        {
            if (txtIDNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show(
                "Selecione a NOTA a ser removida no GRID");
            }
            else
            {
                this.controller.Remove(
                new NotaEntrada()
                {
                    Id = new Guid(txtIDNotaEntrada.Text)
                }
                );

                dgvNotasEntrada.DataSource = null;
                dgvNotasEntrada.DataSource = this.controller.GetAll();
                ClearControlsNota();
            }
        }
        
        private void UpdateProdutosGrid()
        {
            dgvProdutos.DataSource = null;
            if (this.notaAtual.Produtos.Count > 0)
            {
                dgvProdutos.DataSource = this.notaAtual.
                Produtos;
            }
        }

        private void dgvNotasEntrada_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.notaAtual = this.controller.GetNotaEntradaById((Guid)dgvNotasEntrada.CurrentRow.Cells[0].Value);
                txtIDNotaEntrada.Text = notaAtual.Id.ToString();
                txtNumero.Text = notaAtual.Numero;
                cbxFornecedor.SelectedItem = notaAtual.FornecedorNota;
                dtpEmissao.Value = notaAtual.DataEmissao;
                dtpEntrada.Value = notaAtual.DataEntrada;
                UpdateProdutosGrid();
            }
            catch (Exception exception)
            {
                this.notaAtual = new NotaEntrada();
            }
        }
    }
}
