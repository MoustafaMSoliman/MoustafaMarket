using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoustafaMarket.Application.Services.Products.Command;
using MoustafaMarket.Application.Services.Products.Common;
using MoustafaMarket.Contracts.Product;

namespace MoustafaMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ProductController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost("RegisterNewProduct")]
        public async Task<IActionResult> RegisterNewProduct(CreateProductRequest createProductRequest)
        {
            await Task.CompletedTask;
            var command = _mapper.Map<CreateProductCommand>(createProductRequest);
            ErrorOr<ProductDTO> productDTO = await _mediator.Send(command);
            return productDTO.Match(
                productDTO=>Ok(_mapper.Map<RegisterProductResponse>(productDTO)),
                errors=>Problem(errors)
                );
        }
    }
}
