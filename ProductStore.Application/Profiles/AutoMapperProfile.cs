using AutoMapper;
using ProductStore.Application.Features.Products.Commands.CreateProduct;
using ProductStore.Application.Features.Products.Commands.DeleteProduct;
using ProductStore.Application.Features.Products.Commands.UpdateProduct;
using ProductStore.Application.Features.Products.Queries.GetProductDetail;
using ProductStore.Application.Features.Products.Queries.GetProductsList;
using ProductStore.Domain;

namespace ProductStore.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductsListViewModel>().ReverseMap();
            CreateMap<Product, GetProductDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();
            CreateMap<Product, DeleteProductCommand>().ReverseMap();
        }
    }
}
