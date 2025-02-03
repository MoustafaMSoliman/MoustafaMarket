namespace MoustafaMarket.Contracts.Order.Entities;

public record CreatePaymentResponse
(
    bool Success,
    string TransactionId,
    string Status,
    string Message
    );
