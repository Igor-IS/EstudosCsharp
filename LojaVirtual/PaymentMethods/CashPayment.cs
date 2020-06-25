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
            GetFullValueDiscount();
            DisplayValue();
        }

        private double GetDiscountAmount(double descount) =>  Payment.ShoppingListValue * descount;

        private void GetFullValueDiscount() => Payment.TotalPayable -= GetDiscountAmount(Descount);

        private void DisplayValue() => Console.WriteLine($"\nValor Total a vista R${Payment.TotalPayable:F2}");
    }
}
