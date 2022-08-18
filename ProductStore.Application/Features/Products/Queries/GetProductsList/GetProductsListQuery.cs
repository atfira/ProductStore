using MediatR;

namespace ProductStore.Application.Features.Products.Queries.GetProductsList
{
    public class GetProductsListQuery : IRequest<List<GetProductsListViewModel>>
    {
    }
}
