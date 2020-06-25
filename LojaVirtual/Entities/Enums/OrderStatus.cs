using System;

namespace VirtualStore.Entities.Enums
{
    internal enum OrderStatus : int
    {
        PedingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
