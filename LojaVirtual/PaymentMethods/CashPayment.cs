using System;

namespace VirtualStore.PaymentMethods
{
    class CashPayment 
    {
        internal Payment Payment { get; set; }
        internal const double Descount = 0.10;

        internal CashPayment() { }
        internal CashPayment(Payment payment)
        {
            Payment = payment;
            GetDiscount();
        }

        private void GetDiscount()
        {
            ApplyDiscount();
            DisplayValue();
        }


        private double SetDiscountAmount(double discount) =>  Payment.ShoppingListValue * discount;


        private void ApplyDiscount() => Payment.TotalPayable -= SetDiscountAmount(Descount);

        private void DisplayValue() => Console.WriteLine($"\nTotal value in money or debit R${Payment.TotalPayable:F2}");
    }
}
