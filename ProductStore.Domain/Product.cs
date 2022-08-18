namespace ProductStore.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Desciption { get; set; }
        public Category? Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
