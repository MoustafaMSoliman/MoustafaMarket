using ErrorOr;
using MediatR;
using MoustafaMarket.Application.Services.Products.Common;
using MoustafaMarket.Domain.Common.Errors;
using MoustafaMarket.Domain.Common.Persistence;
using MoustafaMarket.Domain.ProductAggregate;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;

namespace MoustafaMarket.Application.Services.Products.Command;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ErrorOr<ProductDTO>>
{
    private readonly IUnitOFWork _unitOfWork;

    public CreateProductCommandHandler(IUnitOFWork  unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<ErrorOr<ProductDTO>> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var existingProduct = (await _unitOfWork.Repository<Product>().GetAllAsync())
            .FirstOrDefault(p => p.Name == command.Name);
        if (existingProduct is not null)
        {
            return Errors.ProductErrors.NotFoundProduct;
        }
        var product = Product.Create
            (
              ProductId.CreateUnique(),
              command.Name,
              command.Description,
              command.Money,
              command.Dimensions,
              command.Images
            );

        await _unitOfWork.Repository<Product>().AddAsync( product );
        await _unitOfWork.SaveChangesAsync();
        return new ProductDTO(product.Id,product.Name,product.Description,product.Price.Amount,product.Quantity,product.Category.Id.Value.ToString(),product.Images,DateTime.Now,DateTime.Now);
    }
}
