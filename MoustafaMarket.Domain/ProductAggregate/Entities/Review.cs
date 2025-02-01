using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;
using MoustafaMarket.Domain.UserAggregate.ValueObjects;

namespace MoustafaMarket.Domain.ProductAggregate.Entities;

public class Review : Entity<ReviewId>
{
    public ProductId ProductId { get; private set; } // The product being reviewed
    public UserId UserId { get; private set; } // The user who submitted the review
    public int Rating { get; private set; } // Rating between 1 and 5 stars
    public string Comment { get; private set; } // Optional comment about the product
    public DateTime DatePosted { get; private set; } // When the review was posted

#pragma warning disable CS8618
    private Review() { }
#pragma warning restore CS8618

    private Review(ReviewId id, ProductId productId, UserId userId, int rating, string comment) 
        :base(id)
    {
        ProductId = productId;
        UserId = userId;
        Rating = rating;
        Comment = comment;
        DatePosted = DateTime.Now;
    }
    public static Review Create(ReviewId id, ProductId productId, UserId userId, int rating, string comment)
        => new(id, productId, userId, rating, comment);
}
