namespace MoustafaMarket.Contracts.Order.Entities;

public record OrderItemDTO
(
  string ProductId,
  string ProductName,
  int Quantity,
  decimal UnitPrice,
  decimal TotalPrice
);