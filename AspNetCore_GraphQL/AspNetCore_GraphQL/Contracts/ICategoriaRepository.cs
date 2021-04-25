
using Aspncore_GraphQL.Entities;
using System.Collections.Generic;
namespace Aspncore_GraphQL.Contracts
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
    }
}