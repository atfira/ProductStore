using MediatR;

namespace ProductStore.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<Guid>
    {
        public Guid ProductId { get; set; }
    }
}
