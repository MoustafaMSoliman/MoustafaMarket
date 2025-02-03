namespace MoustafaMarket.Contracts.Order.Entities;

public record CreateRefundResponse
(
    bool Success,
    string TransactionId,
    string Status,
    string Message
    );
