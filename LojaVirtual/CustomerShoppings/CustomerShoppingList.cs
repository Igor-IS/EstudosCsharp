using System;
using System.Collections.Generic;
using VirtualStore.Products;
using System.Text;

namespace VirtualStore.CustomerShoppings
{
    class CustomerShoppingList
    {
        internal double AmoutToPay { get; set; }
        internal List<Product> ShoppingList { get; set; }
        internal Product Produto { get; set; }
        internal int QuantityTheProduct { get; set; }
        internal CustomerShoppingList() { }

        internal CustomerShoppingList(Product product)
        {
            Produto = product;
        }

        internal void GetProduct()
        {

        }


        internal void RemoveProduct(string nomeProduto)
        {
            
        }


    }
}
