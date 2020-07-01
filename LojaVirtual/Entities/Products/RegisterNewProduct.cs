using System;
using System.Collections.Generic;
using System.Text;
using VirtualStore.Entities.Enums;

namespace VirtualStore.Entities.Products
{
    class RegisterNewProduct : Product
    {
        internal ProductType ProductType { get; private set; }

        internal RegisterNewProduct() { }

        internal RegisterNewProduct(int id, string name, string descrition, double value, ProductType type) 
            : base(id, name, descrition, value)
        {
            ProductType = type;
        }
    }
}
