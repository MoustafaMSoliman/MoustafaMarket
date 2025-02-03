using MoustafaMarket.Contracts.Common.Enums;

namespace MoustafaMarket.Contracts.Common.DTOs;

public record Money
(
    decimal Amount,
    Currency Currency
);