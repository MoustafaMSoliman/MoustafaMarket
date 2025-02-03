using MoustafaMarket.Contracts.Common.DTOs;

namespace MoustafaMarket.Contracts.Order.Entities;

public record PaymentDTO
(
    string Id,
    string OrderId,
    Money Money,
    PaymentMethodDTO PaymentMethod,
    string Status,
    DateTime PaymentDate

);
