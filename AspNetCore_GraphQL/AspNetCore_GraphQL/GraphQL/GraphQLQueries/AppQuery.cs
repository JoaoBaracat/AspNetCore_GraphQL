
using Aspncore_GraphQL.Contracts;
using Aspncore_GraphQL.GraphQL.GraphQLTypes;
using GraphQL.Types;
namespace Aspncore_GraphQL.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(ICategoriaRepository repository)
        {
            Field<ListGraphType<CategoriaType>>(
               "categorias",
               resolve: context => repository.GetAll()
           );
        }
    }
}