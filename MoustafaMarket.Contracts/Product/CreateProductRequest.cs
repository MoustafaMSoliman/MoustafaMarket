using MoustafaMarket.Contracts.Common.DTOs;

namespace MoustafaMarket.Contracts.Product;

public record CreateProductRequest
(
    string Name,
    string Description,
    Money Money,
    Dimensions Dimensions,
    string[]? Images,
    int Quantity,
    string CategoryId
);


public record Dimensions
(
    decimal Length,
    decimal Width,
    decimal Height
);

