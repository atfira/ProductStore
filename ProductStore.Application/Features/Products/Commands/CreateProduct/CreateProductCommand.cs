using MediatR;

namespace ProductStore.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Desciption { get; set; }
        public Guid CategoryId { get; set; }

    }
}
