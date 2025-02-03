namespace MoustafaMarket.Contracts.Product;

public record ProductDTO
(
  string Id,
  string Name,
  string Description,
  decimal Price,
  int Quantity,
  string CategoryId,
  string[]? Images,
  DateTime CreatedAt,
  DateTime UpdatedAt
);
