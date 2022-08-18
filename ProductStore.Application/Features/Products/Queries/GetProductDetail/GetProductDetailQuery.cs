using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Application.Features.Products.Queries.GetProductDetail
{
    public class GetProductDetailQuery : IRequest<GetProductDetailViewModel>
    {
        public Guid ProductId { get; set; }
    }
}
