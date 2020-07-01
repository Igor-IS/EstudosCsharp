using System;
using System.Collections.Generic;
using VirtualStore.Entities.Enums;

namespace VirtualStore.Entities.Products
{
    abstract class Product
    {

        internal int Id { get; set; }
        internal string ProductName { get; set; }
        internal double ProductValue { get; set; }
        internal string ProductDescrition { get; set; }


        internal Product() { }


        private protected Product(int id, string name, string descrition, double value)
        {
            Id = id;
            ProductName = name;
            ProductDescrition = descrition;
            ProductValue = value;
        }
    }
}
