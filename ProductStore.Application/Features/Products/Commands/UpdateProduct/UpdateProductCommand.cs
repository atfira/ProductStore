using MediatR;

namespace ProductStore.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public Guid CategoryId { get; set; }

    }
}