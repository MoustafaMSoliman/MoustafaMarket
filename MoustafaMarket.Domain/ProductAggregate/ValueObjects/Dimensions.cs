using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.ProductAggregate.ValueObjects;

public class Dimensions : ValueObject
{
    public decimal Length { get; private set; }
    public decimal Width { get; private set; }
    public decimal Height { get; private set; }
#pragma warning disable CS8618
    private Dimensions() { }
#pragma warning restore CS8618
    private Dimensions(decimal length, decimal width, decimal height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    public static Dimensions Create(decimal length, decimal width, decimal height)
        =>new (length, width, height);
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Length;
        yield return Width;
        yield return Height;
    }

}
