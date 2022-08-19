using AutoMapper;
using Moq;
using ProductStore.Application.Contracts;
using ProductStore.Application.Features.Products.Commands.CreateProduct;
using ProductStore.Application.Profiles;
using ProductStore.Application.UnitTests.Mocks;
using Shouldly;
using System.Reflection.Metadata;
using Xunit;

namespace ProductStore.Application.UnitTests.Products.Commands
{
    public class CreateProductCommandHandlerTests
    {

        private readonly IMapper _mapper;
        private readonly CreateProductCommand _productCommand;
        private readonly Mock<IProductRepository> _mockRepo;

        public CreateProductCommandHandlerTests()
        {
            _mockRepo = MockProductRepository.GetProductRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<AutoMapperProfile>();
            });

            _mapper = mapperConfig.CreateMapper();

            _productCommand = new CreateProductCommand
            {
                Name = "New Product",
                Desciption = "New Description",
                ImageUrl = "new Image Path",
                CategoryId = Guid.Parse("{EFBCE6FB-3A20-487A-8983-10DE14206AD7}")
            };
        }

        [Fact]
        public async Task CreateProductTests()
        {
            var handler = new CreateProductCommandHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(_productCommand, CancellationToken.None);

            var products = await _mockRepo.Object.GetAllProductsAsync(true);

            result.ShouldBeOfType<Guid>();

            products.Count.ShouldBe(4);

        }

    }
}
