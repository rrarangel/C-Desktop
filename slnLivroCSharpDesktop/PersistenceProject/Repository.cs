using ModelProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceProject
{
    public class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();
        private IList<Produto> produtos = new List<Produto>();
        private IList<NotaEntrada> notasEntrada = new List<NotaEntrada>();

        public Fornecedor InsertFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
            return fornecedor;
        }

        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Remove(fornecedor);
        }

        public IList<Fornecedor> GetAllFornecedores()
        {
            return this.fornecedores;
        }

        public Fornecedor UpdateFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores[this.fornecedores.
            IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }
        
    }
}
