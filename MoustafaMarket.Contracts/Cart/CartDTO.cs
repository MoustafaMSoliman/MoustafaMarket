using MoustafaMarket.Contracts.Cart.Entities;

namespace MoustafaMarket.Contracts.Cart;

public record CartDTO
(
    string Id,
    string UserId,
    CartItemDTO[] CatItems,
    decimal TotalPrice
);