using ProductStore.Application.Features.Products.Queries.GetProductsList;

namespace ProductStore.Application.Features.Products.Queries.GetProductDetail
{
    public class GetProductDetailViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Desciption { get; set; }
        public CategoryDto? Category { get; set; }
    }
}
