using System;

namespace VirtualStore.PaymentMethods
{
    class Payment
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
            Console.WriteLine($"\nFormas de Pagamento\n    [1] A Vista\n    [2] Parcelamento\nOpções de parcelamento: 10x sem juros ou 25x com juros");
            Console.Write("Opção de pagamento: ");
        }
        internal void GetNumberOfInstallments() => Console.Write("Quantidade de parcelas: ");
        private void DisplayValue() => Console.WriteLine($"Valor total R${TotalPayable:F2}");
    }
}
