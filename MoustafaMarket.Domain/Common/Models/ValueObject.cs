﻿namespace MoustafaMarket.Domain.Common.Models;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public abstract IEnumerable<object> GetEqualityComponents();
    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
        {
            return false;
        }
        //var valueObject =  (ValueObject) obj; //it will throw InvalidCastException
        var valueObject = obj as ValueObject; // it will be null -safe casting-

        if (valueObject is null)
        {
            return false;
        }
        return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
    }

    public override int GetHashCode()
    {
        return GetEqualityComponents()
          .Select(x => x?.GetHashCode() ?? 0)
          .Aggregate((x, y) => x ^ y);
    }

    public bool Equals(ValueObject? other)
    {
        return Equals((object?)other);
    }

    public static bool operator ==(ValueObject left, ValueObject right) { return Equals(left, right); }
    public static bool operator !=(ValueObject left, ValueObject right) { return !Equals(left, right); }

}
