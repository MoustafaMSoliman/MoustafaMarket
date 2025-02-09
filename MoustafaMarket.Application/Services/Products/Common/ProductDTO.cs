using MoustafaMarket.Domain.ProductAggregate.ValueObjects;

namespace MoustafaMarket.Application.Services.Products.Common;

public record ProductDTO
(
   ProductId Id,
   string Name,
   string Description,
   decimal Price,
   int Quantity,
   string CategoryId,
   string[]? Images,
   DateTime CreatedAt,
   DateTime UpdatedAt
);
