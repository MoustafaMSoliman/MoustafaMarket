using ErrorOr;
using MoustafaMarket.Domain.Common.Errors;
using MoustafaMarket.Domain.Common.Models;
using System.Text.RegularExpressions;

namespace MoustafaMarket.Domain.UserAggregate.ValueObjects;

public class Email : ValueObject
{
    private static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
    public string Value { get; private set; }
#pragma warning disable CS8618
    private Email() { }
#pragma warning restore CS8618
    private Email(string value)
    {
        Value = value;
    }
    public static ErrorOr<Email> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Errors.UserErrors.NullOrWhiteSpaceEmail;

        if (!IsValidEmail(value))
            return Errors.UserErrors.InvalidEmail;
        return new Email(value);    
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value.ToLower();
    }

}
