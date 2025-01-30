namespace MoustafaMarket.Application.DTOs;

public record ProductDTO (Guid Id, string Name, string Description, decimal Price, string? Image, int Quantity, Guid CategoryId);
