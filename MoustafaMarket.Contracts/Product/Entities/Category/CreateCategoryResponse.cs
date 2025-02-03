namespace MoustafaMarket.Contracts.Product.Entities.Category;

public record CreateCategoryResponse
(
    string Id,
    string Name,
    string? Description,
    CategoryDTO[]? Subcategories
);
