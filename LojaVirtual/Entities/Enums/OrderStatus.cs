using System;

namespace VirtualStore.Entities.Enums
{
    internal enum OrderStatus : int
    {
        PaymentConfirmed = 0,
        PedingPayment = 1,
        Processing = 2,
        Shipped = 3,
        Delivered = 4
    }
}
