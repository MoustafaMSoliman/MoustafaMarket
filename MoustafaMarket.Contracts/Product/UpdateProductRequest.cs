namespace MoustafaMarket.Contracts.Product;

public record UpdateProductRequest
(
    string Name,
    string Description,
    Money Money,
    Dimensions Dimensions,
    string[]? Images,
    int Quantity,
    string CategoryId
);
