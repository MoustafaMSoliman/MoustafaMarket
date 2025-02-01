using ErrorOr;

namespace MoustafaMarket.Domain.Common.Errors;
public static partial class Errors
{
  public static class StockLevelErrors
  {
        public static Error IncreaseStockLevelWithInvalidQuantity => Error.Conflict(
            code:"StockLevelErrors.IncreaseStockLevelWithInvalidQuantity",
            description:"Can't increase stock level with zero or minus quantity"
            );
        public static Error DecreaseStockLevelWithInvalidQuantity => Error.Conflict(
            code: "StockLevelErrors.DecreaseStockLevelWithInvalidQuantity",
            description: "Can't decrease stock level with zero or minus quantity"
            );
    }
  
}
