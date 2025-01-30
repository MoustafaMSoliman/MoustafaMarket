using ErrorOr;

namespace MoustafaMarket.Domain.Common.Errors;

public static partial class Errors
{
    public static class UserErrors
    {
        public static Error DuplicateEmail => Error.Conflict(code:"UserErrors.DuplicateEmail", description:"This email already in use");
    }
}
