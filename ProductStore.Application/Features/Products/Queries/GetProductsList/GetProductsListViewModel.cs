namespace ProductStore.Application.Features.Products.Queries.GetProductsList
{
    public class GetProductsListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public CategoryDto? Category { get; set; }
    }
}
