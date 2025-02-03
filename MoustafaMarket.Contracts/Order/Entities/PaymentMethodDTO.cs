using MoustafaMarket.Contracts.Common.Enums;

namespace MoustafaMarket.Contracts.Order.Entities;

public record PaymentMethodDTO
(
    string CardNumber,
    string CardHolderName,
    PaymentType PaymentType,
    DateTime ExpiryDate
    );
