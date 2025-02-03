namespace MoustafaMarket.Contracts.Product.Entities.Category;

public record CreateCategoryRequest
(
    string Name,
    string? Description,
    string? ParentId
);
