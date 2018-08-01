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
    public partial class FormFornecedor : Form
    {
        private FornecedorController controller = new FornecedorController();

        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
          var fornecedor =  this.controller.Insert(
            new Fornecedor()
            {
                Id = Guid.NewGuid(),
                Nome = txtNome.Text,
                CNPJ = txtCNPJ.Text
            }
            );

            txtID.Text = fornecedor.Id.ToString();
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
            ClearControls();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = dgvFornecedores.CurrentRow.Cells[0].
            Value.ToString();
            txtNome.Text = dgvFornecedores.CurrentRow.Cells[1].
            Value.ToString();
            txtCNPJ.Text = dgvFornecedores.CurrentRow.Cells[2].
            Value.ToString();
        }


        private void ClearControls()
        {
            dgvFornecedores.ClearSelection();
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNome.Focus();
        }


    }
}
