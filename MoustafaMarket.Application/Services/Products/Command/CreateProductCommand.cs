using ErrorOr;
using MediatR;
using MoustafaMarket.Application.Services.Products.Common;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;

namespace MoustafaMarket.Application.Services.Products.Command;

public record CreateProductCommand
(
    string Name,
    string Description,
    Money Money,
    Dimensions Dimensions,
    string[]? Images,
    int Quantity,
    string CategoryId

) :IRequest<ErrorOr<ProductDTO>>;
