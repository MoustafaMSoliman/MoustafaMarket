namespace MoustafaMarket.Contracts.Cart;

public record AddToCartRequest
(
    CartItem CartItem
    );

public record CartItem
(
    string ProductId,
    int Quantity
);