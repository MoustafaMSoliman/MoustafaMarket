namespace MoustafaMarket.Contracts.Product;

public record CreateReviewResponse
(
    string Id,
    ProductInReview Product,
    int Rate,
    string Comment,
    DateTime CreatedAt,
    DateTime UpdatedAt
);
public record ProductInReview
(
    string Id,
    string Name
);
public record UserInReview
(
    string Id,
    string FullName
);

