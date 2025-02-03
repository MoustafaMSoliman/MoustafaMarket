namespace MoustafaMarket.Contracts.Common.DTOs;

public record Address
(
    string Street,
    string City,
    string State,
    string ZipCode,
    string Country,
    bool IsPrimary
);