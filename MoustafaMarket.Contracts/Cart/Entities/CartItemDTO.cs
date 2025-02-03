namespace MoustafaMarket.Contracts.Cart.Entities;

public record CartItemDTO
(
    string ProductId,
    string ProductName,
    int Quantity,
    decimal UnitPrice

);
