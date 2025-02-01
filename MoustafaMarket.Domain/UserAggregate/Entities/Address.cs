using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.UserAggregate.ValueObjects;

namespace MoustafaMarket.Domain.UserAggregate.Entities;

public class Address : Entity<AddressId>
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string ZipCode { get; private set; }
    public string Country { get; private set; }
    public bool IsPrimary { get; private set; }

#pragma warning disable CS8618
    private Address() { }
#pragma warning restore CS8618
    private Address(AddressId id, string street, string city, string state, string zipCode, string country)
        :base(id)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
    }
    public static Address Create(AddressId id, string street, string city, string state, string zipCode, string country)
        => new(id, street, city, state, zipCode, country);

}
