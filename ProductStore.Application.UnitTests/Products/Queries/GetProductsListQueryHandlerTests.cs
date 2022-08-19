using AutoMapper;
using Moq;
using ProductStore.Application.Contracts;
using ProductStore.Application.Features.Products.Queries.GetProductsList;
using ProductStore.Application.Profiles;
using ProductStore.Application.UnitTests.Mocks;
using Shouldly;
using Xunit;

namespace ProductStore.Application.UnitTests.Products.Queries
{
    public class GetProductsListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IProductRepository> _mockRepo;

        public GetProductsListQueryHandlerTests()
        {
            _mockRepo = MockProductRepository.GetProductRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<AutoMapperProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetProductsListTest()
        {
            var handler = new GetProductsListQueryHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(new GetProductsListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<GetProductsListViewModel>>();

            result.Count.ShouldBe(3);
        }
    }
}
