namespace MoustafaMarket.Contracts.Authentication;

public record UpdateProfile
(
    string FirstName,
    string LastName,
    string PhoneNumber,
    Address Address
 );
