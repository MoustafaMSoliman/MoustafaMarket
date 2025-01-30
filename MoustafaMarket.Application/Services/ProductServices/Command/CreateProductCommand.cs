namespace MoustafaMarket.Application.Services.ProductServices.Command;

public record CreateProductCommand
(
  string Name,
  string Description,
  decimal Price,
  int Quantity,
  Guid CategoryId
);
