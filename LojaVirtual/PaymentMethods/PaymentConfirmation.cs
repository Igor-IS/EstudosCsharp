using System;


namespace VirtualStore.PaymentMethods
{
    class PaymentConfirmation
    {
        internal bool Confirmation { get; set; }

        internal PaymentConfirmation() { }
        internal PaymentConfirmation(bool confirmation)
        {
            Confirmation = confirmation;
        }

        internal void GetConfirmationOfClient()
        {
            DisplayMessage();
            int option = int.Parse(Console.ReadLine());
            SetConfirmationOfClient(option);
        }

        internal bool SetConfirmationOfClient(int option)
        {
            if (option == 1)
            {
                Confirmation = true;
                return Confirmation;
            }
            else
            {
                Confirmation = false;
                return Confirmation;
            }
        }

        private void DisplayMessage()
        {
            Console.WriteLine("\nVerification of payment\nfor confirmation of payment select option [1] or for cancel your shopping select option [2]");
            Console.Write("Option selected: ");
        }
    }
}
