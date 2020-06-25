using System;
using System.Collections.Generic;


namespace VirtualStore.Products
{
    abstract class Product
    {
        internal string ProductName { get; set; }
        internal double ProductValue { get; set; }
        internal string ProductDescrition { get; set; }
        internal List<string> ProductList { get; set; } = new List<string>();


        internal Product() { }


        internal Product(string name, string descrition, double value)
        {
            ProductName = name;
            ProductDescrition = descrition;
            ProductValue = value;
        }

        internal void GetProductData(string name, string descrition, double value)
        {
            var productData = new Dictionary<string, string>();
            productData.Add("Name", name);
            productData.Add("Descrition", descrition);
            productData.Add("Value", value.ToString());

        }

        internal void DisplayProductData()
        {

            foreach (var prod in ProductList)
            {
                Console.WriteLine($"{prod}");
            }

        }
    }
}
