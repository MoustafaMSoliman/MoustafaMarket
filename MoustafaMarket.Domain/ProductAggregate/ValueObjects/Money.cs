using MoustafaMarket.Domain.Common.Enums;
using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.ProductAggregate.ValueObjects;

public class Money : ValueObject
{
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }

#pragma warning disable CS8618
    private Money() { }
#pragma warning restore CS8618
    private Money(decimal amount, Currency currency)
    {
        Amount = amount;
        Currency = currency;
    }
    public static Money Create(decimal amount, Currency currency)
        =>new(amount, currency);
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }

    public Money Add(Money other)
    {
        return new Money(Amount + other.Amount, Currency);
    }

    public Money Subtract(Money other)
    {
        return new Money(Amount - other.Amount, Currency);
    }

    public Money Multiply(decimal multiplier)
    {
        return new Money(Amount * multiplier, Currency);
    }

}
