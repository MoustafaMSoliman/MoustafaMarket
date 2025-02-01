using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.UserAggregate.Entities;
using MoustafaMarket.Domain.UserAggregate.ValueObjects;

namespace MoustafaMarket.Domain.UserAggregate;

public class User : AggregateRoot<UserId>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Email Email { get; set; } = null!;
    public PhoneNumber PhoneNumber { get; set; }
    public string Password { get; set; } = null!;

    private List<PaymentMethod> _paymentMethods = new List<PaymentMethod>();
    public IReadOnlyList<PaymentMethod> PaymentMethods => _paymentMethods.AsReadOnly(); 

    private List<Address> _addresses = new List<Address>();
    public IReadOnlyList<Address> Addresss => _addresses.AsReadOnly();

    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }

#pragma warning disable CS8618
    private User() { }
#pragma warning restore CS8618
    private User(UserId id, string fName, string lName, Email email,string password ,PhoneNumber phoneNumber)
     :base(id)
    { 
        FirstName = fName;
        LastName = lName;
        Email = email;
        PhoneNumber = phoneNumber;
        Password = password;
    }
    public static User Create(string fName, string lName, Email email, string password  ,PhoneNumber phoneNumber)
        =>new(UserId.CreateUnique(), fName, lName, email, password, phoneNumber);

    public void AddPaymentMethod(PaymentMethod paymentMethod)
    {
        _paymentMethods.Add(paymentMethod);
    }

    public void AddAddress(Address address) 
    {
        _addresses.Add(address);
    }
}
