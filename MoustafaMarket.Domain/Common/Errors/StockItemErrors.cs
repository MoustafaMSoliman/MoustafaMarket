using ErrorOr;

namespace MoustafaMarket.Domain.Common.Errors;

public static partial class Errors
{
    public static class StockItemErrors
    {
        public static Error IncreaseStockWithInvalidQuantity => Error.Conflict(
             code:"StockItemErrors.IncreaseStockWithInvalidQuantity",
             description:"Invalid quantity to increase by it"
            );
        public static Error DecreaseStockWithInvalidQuantity => Error.Conflict(
             code: "StockItemErrors.DecreaseStockWithInvalidQuantity",
             description: "Invalid quantity to decrease by it"
            );
    }

}
