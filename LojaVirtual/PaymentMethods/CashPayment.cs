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

<<<<<<< HEAD
        private double GetDiscountAmount(double descount) =>  Payment.ShoppingListValue * descount;
=======
        private double GetDiscountAmount(double valorDesconto) =>  Payment.ShoppingListValue * valorDesconto;
>>>>>>> 8ee72d9840ae808773ce43ffc0d5ef8d03a32383

        private void GetFullValueDiscount() => Payment.TotalPayable -= GetDiscountAmount(Descount);

        private void DisplayValue() => Console.WriteLine($"\nValor Total a vista R${Payment.TotalPayable:F2}");
    }
}
