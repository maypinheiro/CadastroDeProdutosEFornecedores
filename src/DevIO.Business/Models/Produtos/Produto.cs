using DevIO.Business.Core.Models;
using DevIO.Business.Models.Fornecedores;
using System;

namespace DevIO.Business.Models.Produtos
{
  public class Produto : Entity
  {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* Ef Relation */
        public Fornecedor Fornecedor { get; set; }
  }
}
