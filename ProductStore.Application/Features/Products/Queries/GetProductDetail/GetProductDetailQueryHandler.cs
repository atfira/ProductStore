using AutoMapper;
using MediatR;
using ProductStore.Application.Contracts;

namespace ProductStore.Application.Features.Products.Queries.GetProductDetail
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, GetProductDetailViewModel>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductDetailQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<GetProductDetailViewModel> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var prodcut = await _productRepository.GetProductByIdAsync(request.ProductId, true);

            return _mapper.Map<GetProductDetailViewModel>(prodcut);
        }
    }
}
