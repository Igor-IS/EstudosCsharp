using System;

namespace VirtualStore.PaymentMethods
{
    class PaymentInInstallments
    {
        internal Payment Payment { get; set; }
        internal int NumberOfInstallments { get; set; }
        internal double InstallmentsValue { get; private set; }
        internal const double Interest = 0.20;

        internal PaymentInInstallments() { }
        internal PaymentInInstallments(Payment payment, int installments)
        {
            Payment = payment;
            NumberOfInstallments = installments;
            GetInstallmentMethods();
        }

        private void GetInstallmentMethods()
        {
            GetInstallmentsValue();
            DisplayValue();
        }

        private void GetInstallmentsValue()
        {
            if (NumberOfInstallments > 10 || NumberOfInstallments >= 25 )
            {
                SetInstallmentWithInterest();
            }
            else
            {
                SetInteresFreeInstallment();
            }
        }

        private void SetInteresFreeInstallment()
        {
            SetInstallmentNumber();
            InstallmentsValue = Payment.TotalPayable / NumberOfInstallments;
        }

        private void SetInstallmentWithInterest()
        {
            SetInstallmentNumber();
            ApllyInteretToTheAmount();
            InstallmentsValue = Payment.TotalPayable / NumberOfInstallments;
        }

        private int SetInstallmentNumber()
        {
            if (NumberOfInstallments > 25)
            {
                NumberOfInstallments = 25;
            }
            else if (NumberOfInstallments <= 0)
            {
                NumberOfInstallments = 1;
            }
            return NumberOfInstallments;
        }

        private double GetInterest(double interest) => Payment.ShoppingListValue * interest;
        private void ApllyInteretToTheAmount() => Payment.TotalPayable += GetInterest(Interest);
        private void DisplayValue() => Console.WriteLine($"\nValor Total R${Payment.TotalPayable:F2}\nParcelado em {NumberOfInstallments}x R${InstallmentsValue:F2}");
    }
}
