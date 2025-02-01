namespace MoustafaMarket.Contracts.Product;

public record CreateCategoryResponse
(
    string Id,
    string Name,
    string? Description,
    Category[]? Subcategories
);
public record Category
    (
      string Id,
      string Name,
      string? Description
    );
