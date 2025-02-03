using MoustafaMarket.Contracts.Common.DTOs;

namespace MoustafaMarket.Contracts.Order.Entities;

public record CreatePaymentRequest
(
  string OrderId,
  string PaymentMethod,
  Money Money
);


