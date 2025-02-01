namespace MoustafaMarket.Contracts.Authentication;

public record RegisterRequest
(
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string ConfirmPassword,
    string PhoneNumber,
    Address Address
);
public record Address
(
    string Street,
    string City,
    string State,
    string ZipCode,
    string Country,
    bool IsPrimary
);
