using ErrorOr;
using MoustafaMarket.Domain.Common.Errors;
using MoustafaMarket.Domain.Common.Models;
using System.Text.RegularExpressions;

namespace MoustafaMarket.Domain.UserAggregate.ValueObjects;

public class PhoneNumber : ValueObject
{
    private static bool IsValidPhoneNumber(string number)
    {
        return Regex.IsMatch(number, @"^\+?[1-9]\d{1,14}$"); // E.164 format
    }
    public string Value { get; private set; }

#pragma warning disable CS8618
    private PhoneNumber() { }
#pragma warning restore CS8618
    private PhoneNumber(string value) { Value = value; }
    public static ErrorOr<PhoneNumber> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Errors.UserErrors.NullOrWhiteSpacePhoneNumber;

        if (!IsValidPhoneNumber(value))
            return Errors.UserErrors.InvalidPhoneNumber;

        return new PhoneNumber(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}
