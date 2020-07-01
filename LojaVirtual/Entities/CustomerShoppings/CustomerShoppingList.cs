using System;
using System.Linq;
using System.Collections.Generic;
using VirtualStore.Entities.Products;

namespace VirtualStore.Entities.CustomerShoppings
{
    class CustomerShoppingList
    {
        internal double AmoutToPay { get; private set; }
        internal List<Product> ShoppingList { get; set; }
        internal Product Produto { get; set; }
        internal int QuantityTheProduct { get; set; }

        internal CustomerShoppingList() { }

        internal CustomerShoppingList(Product product)
        {
            Produto = product;
        }

        internal void GetProduct(List<Product> products)
        {
            ShoppingList.AddRange(products);
        }


        internal void RemoveProduct(List<Product> nameProduct)
        {
            //var product = bd.Product.Where(_ => _.ProductName == nameProduct); implementar com BD
            //ShoppingList.Remove(nameProduct);
        }


    }
}
