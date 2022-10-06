using DevIO.Business.Models.Fornecedores;
using DevIO.infra.Data.Context;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DevIO.infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId);
        }
    }
}
