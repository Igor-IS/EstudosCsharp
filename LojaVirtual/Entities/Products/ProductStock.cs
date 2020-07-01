using System;
using System.Collections.Generic;
using System.Text;
using VirtualStore.Entities.Enums;

namespace VirtualStore.Entities.Products
{
    class ProductStock
    {
        List<RegisterNewProduct> Stock { get; set; } = new List<RegisterNewProduct>();
        

        internal ProductStock() { }

        internal ProductStock( List<RegisterNewProduct> list)
        {
            Stock = list;
        }

        internal void AddNewProduct(RegisterNewProduct product)
        {
            Stock.Add(product);
        }

        internal void RemoveProduct(RegisterNewProduct product)
        {

        }

        internal void DisplayStock()
        {
            double totalValue = 0;
            foreach (var prod in Stock)
            {
                Console.WriteLine($"Product Data: ID {prod.Id} - Type {prod.ProductType} - {prod.ProductName} - Descrition: {prod.ProductDescrition} - Value ${prod.ProductValue:F2}");
                totalValue += prod.ProductValue;
            }
            Console.WriteLine($"Total value ${totalValue:F2}");
        }
    }
}
