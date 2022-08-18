using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductStore.Application.Features.Products.Commands.CreateProduct;
using ProductStore.Application.Features.Products.Commands.DeleteProduct;
using ProductStore.Application.Features.Products.Commands.UpdateProduct;
using ProductStore.Application.Features.Products.Queries.GetProductDetail;
using ProductStore.Application.Features.Products.Queries.GetProductsList;

namespace ProductStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllProducts")]
        public async Task<ActionResult<List<GetProductsListViewModel>>> GetAllProducts()
        {
            var data = await _mediator.Send(new GetProductsListQuery());
            return Ok(data);
        }

        [HttpGet("{id}", Name = "GetProductById")]
        public async Task<ActionResult<GetProductDetailViewModel>> GetProductById(Guid id)
        {
            var getEventDetailQuery = new GetProductDetailQuery() { ProductId = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddProduct")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateProductCommand createProductCommand)
        {
            var id = await _mediator.Send(createProductCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateProduct")]
        public async Task<ActionResult> Update([FromBody] UpdateProductCommand updateProductCommand)
        {
            var id = await _mediator.Send(updateProductCommand);
            return Ok(id);
        }

        [HttpDelete("{id}", Name = "DeleteProduct")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteProductCommand = new DeleteProductCommand() { ProductId = id };
            var productId = await _mediator.Send(deleteProductCommand);
            return Ok(productId);
        }
    }
}
