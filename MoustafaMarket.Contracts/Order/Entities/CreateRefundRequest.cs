namespace MoustafaMarket.Contracts.Order.Entities;

public record CreateRefundRequest
(
    string PaymentId,
    string Reason
    );