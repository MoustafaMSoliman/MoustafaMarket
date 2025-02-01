using MoustafaMarket.Domain.Common.Enums;
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.OrderAggregate.ValueObjects;

namespace MoustafaMarket.Domain.OrderAggregate.Entities;

public class ShippingDetails : Entity<ShippingDetailsId>
{
    public ShippingAddress Address { get; private set; }  // Where the order is being shipped
    public string TrackingNumber { get; private set; }   // The tracking number (if available)
    public string Carrier { get; private set; }          // Shipping carrier (e.g., FedEx, DHL)
    public ShippingMethod ShippingMethod { get; private set; } // Standard, Express, etc.
    public DateTime EstimatedDeliveryDate { get; private set; } // Expected arrival date
    public DateTime? ShippedDate { get; private set; }   // When the order was shipped
    public ShippingStatus Status { get; private set; }   // Pending, Shipped, Delivered, etc.


#pragma warning disable CS8618
    private ShippingDetails() { }
#pragma warning restore CS8618
    private ShippingDetails(ShippingDetailsId id, ShippingAddress shippingAddress,
        ShippingMethod shippingMethod)
        :base(id)
    {
        ShippingMethod = shippingMethod;
        Address = shippingAddress;
        Status = ShippingStatus.Pending;
    }
    private DateTime CalculateEstimatedDelivery()
    {
        return ShippingMethod switch
        {
            ShippingMethod.Standard => DateTime.UtcNow.AddDays(5),
            ShippingMethod.Express => DateTime.UtcNow.AddDays(2),
            ShippingMethod.Overnight => DateTime.UtcNow.AddDays(1),
            _ => DateTime.UtcNow.AddDays(7) // Default
        };
    }
    public void MarkAsShipped(string trackingNumber, string carrier)
    {
        TrackingNumber = trackingNumber;
        Carrier = carrier;
        Status= ShippingStatus.Shipped;
        ShippedDate = DateTime.Now;
        EstimatedDeliveryDate = this.CalculateEstimatedDelivery();
    }
    public void MarkAsDelivered()
    {
        Status = ShippingStatus.Delivered;
    }

}
