using ErrorOr;

namespace MoustafaMarket.Domain.Common.Errors;

public static partial class Errors 
{
    public static class ProductErrors
    {
        public static Error NotFoundProduct => Error.Conflict(code:"ProductErrors.NotFoundProduct", description:"This product is not found");
    }

}
