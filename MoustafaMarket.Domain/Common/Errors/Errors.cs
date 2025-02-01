using ErrorOr;

namespace MoustafaMarket.Domain.Common.Errors;

public static partial class Errors
{
    public static class UserErrors
    {
        public static Error DuplicateEmail => Error.Conflict(code:"UserErrors.DuplicateEmail", description:"This email already in use");
        public static Error NullOrWhiteSpaceEmail => Error.Conflict(code:"UserErrors.NullOrWhiteSpaceEmail", description:"Email can't contain white spaces or be null");
        public static Error InvalidEmail => Error.Conflict(code: "UserErrors.InvalidEmail", description: "Email is not in correct format");

        public static Error NullOrWhiteSpacePhoneNumber => Error.Conflict(code: "UserErrors.NullOrWhiteSpacePhoneNumber", description: "Phone NumberEmail can't contain white spaces or be null");
        public static Error InvalidPhoneNumber => Error.Conflict(code: "UserErrors.InvalidPhoneNumber", description: "Phone Number is not in correct format");
    }
}
