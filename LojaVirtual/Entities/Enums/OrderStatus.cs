using System;

namespace VirtualStore.Entities.Enums
{
    internal enum OrderStatus
    {
        PaymentConfirmed,
        PedingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
