using System;
using System.Collections.Generic;
using System.Text;
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
        internal Order( int id, bool payment)
        {
           // Status = Status;
            Moment = DateTime.Now;
            Id = id;
            PaymentConfirmed = payment;
            GetOrderStatus(payment);
        }

        internal void GetOrderStatus(bool confirmed)
        {
            
            if (confirmed == false)
            {
                
                Status = OrderStatus.PedingPayment;
                DisplayOrderStatus(Status);
            }
            else
            {

                Status = OrderStatus.Processing;
                DisplayOrderStatus(Status);
            }

        }

        internal void DisplayOrderStatus(OrderStatus status) => Console.WriteLine($"\nPurchaser Order number: {Id}   Date: {Moment} \nOrder Status: {status}");
    }
}
