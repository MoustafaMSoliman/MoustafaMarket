namespace MoustafaMarket.Contracts.Cart;

public record UpdateToCartRequest
(
    string ProductId,
    int Quantity
);
