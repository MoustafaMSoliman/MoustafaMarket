using MoustafaMarket.Domain.Common;
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.UserAggregate.ValueObjects;

namespace MoustafaMarket.Domain.UserAggregate.Entities;

public class PaymentMethod : Entity<PaymentMethodId>
{
    public UserId UserId { get; private set; }
    public PaymentType PaymentType { get; private set; }
    public string CardNumber { get; private set; }
    public string CardHolderName { get; private set; }
    public DateTime ExpiryDate { get; private set; }
#pragma warning disable CS8618
    private PaymentMethod() { }
#pragma warning restore CS8618
    private PaymentMethod(PaymentMethodId id, UserId userId, PaymentType paymentType,
        string cardNumber, string cardHolderName, DateTime expiryDate)
      :base(id)
    {
        UserId = userId;
        PaymentType = paymentType;
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
        ExpiryDate = expiryDate;
    }

    public static PaymentMethod Create(PaymentMethodId id, UserId userId, PaymentType paymentType,
        string cardNumber, string cardHolderName, DateTime expiryDate)
        => new(id,userId,paymentType,cardNumber,cardHolderName, expiryDate);
}
