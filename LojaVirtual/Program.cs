using VirtualStore.PaymentMethods;
using VirtualStore.CustomerShoppings;
using System;
using VirtualStore.Products;
using VirtualStore.Entities;

namespace VirtualStore
{
    class Program
    {

        static void Main(string[] args)
        {
            //PaymentOption(1000);
            Order newRequest = new Order(7, true);


            
        }

        static void TestGetProductData()
        {
            //var product = new Product("iPhone 11",1000 );
            //product = new Product("TV50",1000);
        }


        static void PaymentOption(double value) // teste classes Pagamento/Avista/Parcelado 
        {
            var purchasePrice = new Payment(value);
            
            purchasePrice.DisplayPaymentMethods();
            byte option = byte.Parse(Console.ReadLine());
            if (option <= 1)
            {
                var descount = new CashPayment(purchasePrice);
            }
            else if (option >= 2)
            {
                purchasePrice.GetNumberOfInstallments();
                int numberInstalments = int.Parse(Console.ReadLine());
                var dividirPagamento = new PaymentInInstallments(purchasePrice, numberInstalments);
            }  
        }   
    }
}
