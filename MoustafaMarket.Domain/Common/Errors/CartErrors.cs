using ErrorOr;

namespace MoustafaMarket.Domain.Common.Errors;

public static partial class Errors
{
    public static class CartErrors
    {
        public static Error AddItemWithZeroQuantity => Error.Conflict(
            code:"CartErrors.AddItemWithZeroQuantity",
            description:"Can't add item to cart with zero quantity");

        public static Error AddItemWithQuantityLessThanZero => Error.Conflict(
            code: "CartErrors.AddItemWithQuantityLessThanZero",
            description: "Can't add item to cart with quantity less than zero");

        public static Error AddExistingItem => Error.Conflict(
            code: "CartErrors.AddExistingItem",
            description: "Can't add item to cart with zero quantity");
        public static Error RemoveNotExistingItem => Error.Conflict(
            code: "CartErrors.RemoveNotExistingItem",
            description: "Can't remove item that doesn't exist");

    }

}
