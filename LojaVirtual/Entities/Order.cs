using System;
using VirtualStore.Entities.Enums;

namespace VirtualStore.Entities
{
    class Order
    {
        internal bool PaymentConfirmed = false;
        internal int Id { get; set; }
        internal DateTime Moment { get; set; }
        internal OrderStatus Status { get; set; }

        internal Order() { }
        internal Order( int id, bool verification)
        {
            Moment = DateTime.Now;
            Id = id;
            PaymentConfirmed = verification;
            GetOrderStatus(verification);
        }

        internal void GetOrderStatus(bool verification)
        {
            if (verification == false)
            {
                Status = OrderStatus.PedingPayment;
                DisplayOrderStatus(Status);
            }
            else
            {
                Status = OrderStatus.PaymentConfirmed;
                DisplayOrderStatus(Status);
            }
        }

        private void DisplayOrderStatus(OrderStatus status) => Console.WriteLine($"\nPurchaser Order number: {Id}   Date: {Moment} \nOrder Status: {status}");
    }
}
