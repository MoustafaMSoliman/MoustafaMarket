namespace MoustafaMarket.Application.DTOs;

public record CategoryDTO(Guid Id, string Name, string Description, List<ProductDTO> ProductDTOs);