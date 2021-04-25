
using Aspncore_GraphQL.Contracts;
using Aspncore_GraphQL.Entities.Context;
namespace Aspncore_GraphQL.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}