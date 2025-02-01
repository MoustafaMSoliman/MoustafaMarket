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
public record Money
(
    decimal Amount,
    Currency Currency
);
public enum Currency
{
    USD,
    EUR,
    GBP,
    JPY,
    AED
}
public record Dimensions
(
    decimal Length,
    decimal Width,
    decimal Height
);

