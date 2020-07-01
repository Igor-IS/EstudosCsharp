using VirtualStore.Entities.PaymentMethods;
using VirtualStore.Entities.CustomerShoppings;
using System;
using VirtualStore.Entities.Products;
using VirtualStore.Entities.Orders;
using VirtualStore.Entities.Enums;

namespace VirtualStore
{
    class Program
    {

        static void Main(string[] args)
        {
            //PaymentOption(1000);
            TestGetProductData();
        }

        static void TestGetProductData() // criar um banco de dados para armazenar os cadastros!
        {
            var newRegister = new ProductStock();

            var xBurger = new RegisterNewProduct(1, "X-Burger", "Delicious burger", 18.50, ProductType.Food);
            var drinkBeer = new RegisterNewProduct(2, "Duff Beer", "Pure malt beer", 9.72, ProductType.Drink);
            var xEgg = new RegisterNewProduct(3, "X-Egg", "Delicious Eggs with cheese", 15.50, ProductType.Food);
            newRegister.AddNewProduct(xBurger);
            newRegister.AddNewProduct(drinkBeer);
            newRegister.AddNewProduct(xEgg);

            newRegister.DisplayStock();
        }


        static void PaymentOption(double value) // teste classes Pagamento/Avista/Parcelado 
        {
            var purchasePrice = new Payment(value);
            var confirmation = new PaymentConfirmation();


            purchasePrice.DisplayPaymentMethods();
            byte option = byte.Parse(Console.ReadLine());
            if (option <= 1)
            {
                var descount = new CashPayment(purchasePrice);
                confirmation.GetConfirmationOfClient();
                var newRequest = new Order(7,confirmation.Confirmation);
            }
            else if (option >= 2)
            {
                purchasePrice.GetNumberOfInstallments();
                int numberOfInstallments = int.Parse(Console.ReadLine());
                var intallmentMethods = new PaymentInInstallments(purchasePrice, numberOfInstallments);
                confirmation.GetConfirmationOfClient();
                var newRequest = new Order(7, confirmation.Confirmation);
            }  
        }   
    }
}
