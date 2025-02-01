using MoustafaMarket.Contracts.Authentication;
using MoustafaMarket.Contracts.Cart;

namespace MoustafaMarket.Contracts.Order;

public record CreateOrderRequest
(
    CartItem[] CartItems,
    Address ShippingAddress,
    PaymentType PaymentType
);
public enum PaymentType
{
    CreditCard,
    DebitCard,
    PayPal,
    BankTransfer,
    ApplePay,
    GooglePay
}