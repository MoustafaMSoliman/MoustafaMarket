using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.OrderAggregate.ValueObjects;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;
using MoustafaMarket.Domain.UserAggregate.Entities;

namespace MoustafaMarket.Domain.OrderAggregate.Entities;

public class Payment :Entity<PaymentId>
{
    public Money Amount { get; private set; }
    public PaymentMethod Method { get; private set; }
    public DateTime Date { get; private set; }
#pragma warning disable CS8618
    private Payment() { }
#pragma warning restore CS8618
    private Payment(PaymentId id,Money amount, PaymentMethod method)
        :base(id)
    {
        Amount = amount;
        Method = method;
        Date = DateTime.UtcNow;
    }


}
