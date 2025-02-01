using ErrorOr;

namespace MoustafaMarket.Domain.Common.Errors;

public static partial class Errors
{
    public static class CartItemErrors
    {
        public static Error IncreaseZeroQuantity => Error.Conflict(code:"IncreaseZeroQuantity",
            description:"Can't increase zero item");
        public static Error IncreaseByMinus => Error.Conflict(code:"IncreaseByMinus",
            description:"Can't increase by minus");
        public static Error DecreaseQuantityFromZero => Error.Conflict(code:"DescreaseFromZeroCartItem",
            description:"Can't decrease from that item, it's quantity is zero");

        public static Error DecreaseQuantityBelowToZero => Error.Conflict(code: "DecreaseQuantityBelowToZero",
            description:"Can't decrease this quantity ,the result is less than zero ");
    }
}

