using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.CustomerAggregate.ValueObjects;

namespace MoustafaMarket.Domain.CustomerAggregate;

public class Customer :AggregateRoot<CustomerId>
{
    public string Address { get; set; }
}
