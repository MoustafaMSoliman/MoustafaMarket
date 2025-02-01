namespace MoustafaMarket.Contracts.Product;

public record CreateCategoryRequest
(
    string Name,
    string? Description,
    string? ParentId
);
