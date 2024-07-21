using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pymentService = PaymentService.GetInstance();

            var card1 = new Card(5000, "156389535135623");
            var card2 = new Card(3000, "156389535135623");

            pymentService.Deposit(card1, 15);
            pymentService.Deposit(card2, 15);

            pymentService.Withdraw(card1, 100);
            pymentService.Withdraw(card2, 20);

            pymentService.CreateTransaction(card1, card2, 50);

            Console.WriteLine("Card1 balance: " + card1.GetBalance());
            Console.WriteLine("Card2 balance: " + card2.GetBalance());
        }
    }
}