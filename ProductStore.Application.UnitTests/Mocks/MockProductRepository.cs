using Moq;
using ProductStore.Application.Contracts;
using ProductStore.Domain;

namespace ProductStore.Application.UnitTests.Mocks
{
    public static class MockProductRepository
    {
        public static Mock<IProductRepository> GetProductRepository()
        {
            var Products = new List<Product>
            {
                new Product
                {
                    Id = Guid.Parse("{A94C5659-8DE8-4F64-AC35-8BED9ED2641C}"),
                    Name = "Product 1 mock",
                    Desciption = "At the first signs of leaks, freezes, or excess humidity, ",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51xitGzq7pL.__AC_SX300_SY300_QL70_FMwebp_.jpg",
                    CategoryId = Guid.Parse("{EFBCE6FB-3A20-487A-8983-10DE14206AD7}")
                }
                ,new Product
                {
                    Id = Guid.Parse("{9F75E92C-CD39-466C-9FC5-0ACEFB43907E}"),
                    Name = "Product 2 mock",
                    Desciption = "Description 2 mock",
                    ImageUrl = "",
                    CategoryId = Guid.Parse("{EFBCE6FB-3A20-487A-8983-10DE14206AD7}")
                }
                ,new Product
                {
                    Id = Guid.Parse("{6340F038-D4E7-4346-839F-D4E4E78C7F58}"),
                    Name = "Product 3 mock",
                    Desciption = "Description 3 mock",
                    CategoryId = Guid.Parse("{EFBCE6FB-3A20-487A-8983-10DE14206AD7}")
                }
            };

            var mockRepo = new Mock<IProductRepository>();

            mockRepo.Setup(r => r.GetAllProductsAsync(true)).ReturnsAsync(Products);

            mockRepo.Setup(r => r.AddAsync(It.IsAny<Product>())).ReturnsAsync((Product Product) =>
            {
                Products.Add(Product);
                return Product;
            });

            return mockRepo;

        }
    }
}
