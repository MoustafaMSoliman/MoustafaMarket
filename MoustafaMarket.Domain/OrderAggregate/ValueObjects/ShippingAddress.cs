using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.OrderAggregate.ValueObjects;

public class ShippingAddress : ValueObject
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string PostalCode { get; private set; }
    public string Country { get; private set; }
#pragma warning disable CS8618
    private ShippingAddress() { }
#pragma warning restore CS8618
    private ShippingAddress(string street, string city, string state, string postalCode, string country)
    {
        Street = street;
        City = city;
        State = state;
        PostalCode = postalCode;
        Country = country;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Street;
        yield return City;
        yield return State;
        yield return PostalCode;
        yield return Country;
    }
}
