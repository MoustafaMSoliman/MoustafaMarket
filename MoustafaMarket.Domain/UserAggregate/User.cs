using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.UserAggregate.ValueObjects;

namespace MoustafaMarket.Domain.UserAggregate;

public class User : AggregateRoot<UserId>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
#pragma warning disable CS8618
    private User() { }
#pragma warning restore CS8618
    private User(UserId id, string fName, string lName, string email, string password)
     :base(id)
    { 
        FirstName = fName;
        LastName = lName;
        Email = email;
        Password = password;
    }
    public static User Create(string fName, string lName, string email, string password)
        =>new(UserId.CreateUnique(), fName, lName, email, password);
}
