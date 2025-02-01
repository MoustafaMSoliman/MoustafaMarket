using ErrorOr;

namespace MoustafaMarket.Domain.Common.Errors;
public static partial class Errors
{
    public static class InventoryErrors
    {
        public static Error AddStockWithInvalidQuantity => Error.Conflict(
             code: "InventoryErrors.AddStockWithInvalidQuantity",
             description: "Invalid quantity to add stock by it"
            );
        public static Error RemoveStockWithInvalidQuantity => Error.Conflict(
             code: "InventoryErrors.RemoveStockWithInvalidQuantity",
             description: "Invalid quantity to remove stock by it"
            );
        public static Error RemoveNotExistStock => Error.Conflict(
             code: "InventoryErrors.RemoveNotExistStock",
             description: "This stock is not exist"
            );
    }
}

