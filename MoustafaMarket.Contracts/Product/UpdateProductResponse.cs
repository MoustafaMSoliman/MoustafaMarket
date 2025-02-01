namespace MoustafaMarket.Contracts.Product;

public record UpdateProductResponse
(
  string Id,
  string Name,
  string Description,
  decimal Price,
  int Quantity,
  Category Category,
  string[]? Images,
  DateTime CreatedAt,
  DateTime UpdatedAt
);

