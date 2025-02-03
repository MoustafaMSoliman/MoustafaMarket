namespace MoustafaMarket.Contracts.Product.Entities.Review;

public record ReviewDTO
(
    string Id,
    string ProductId,
    string UserId,
    int Rating,
    string Comment,
    DateTime ReviewedAt
);
