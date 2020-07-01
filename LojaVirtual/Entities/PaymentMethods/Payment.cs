    using System;

namespace VirtualStore.Entities.PaymentMethods
{
    class Payment : PaymentConfirmation
    {
        internal double ShoppingListValue { get; private set; }
        internal double TotalPayable = 0;

        internal Payment() { }
        
        internal Payment(double shoppingListValue)
        {
            ShoppingListValue = shoppingListValue;
            Totalizer();
        }

        private void Totalizer()
        {
            TotalPayable += ShoppingListValue;
            DisplayValue();
        }

        internal void DisplayPaymentMethods()
        {
            Console.WriteLine($"\nPayment options\n    [1] Money or debit\n    [2] In installments\nOption of installments: 10x interest-free or 25x with interest");
            Console.Write("Payment option: ");
        }
        internal void GetNumberOfInstallments() => Console.Write("Number of installments: ");
        private void DisplayValue() => Console.WriteLine($"Total value R${TotalPayable:F2}");
    }
}
