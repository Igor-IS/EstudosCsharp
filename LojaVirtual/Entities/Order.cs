using System;
using System.Collections.Generic;
using System.Text;
using VirtualStore.Entities.Enums;

namespace VirtualStore.Entities
{
    class Order
    {
        internal int Id { get; set; }
        internal DateTime Moment { get; set; }
        internal OrderStatus Status { get; set; }
    }
}
