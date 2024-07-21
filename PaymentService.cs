using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    public class PaymentService
    {
        private static readonly PaymentService instance = new PaymentService();

        private PaymentService() { }

        public static PaymentService GetInstance()
        {
            return instance;
        }
        public void Deposit(Card card, decimal amount)
        {
            card.SetBalance(card.GetBalance() + amount);
        }
        public void Withdraw(Card card, decimal amount)
        {
            card.SetBalance(card.GetBalance() - amount);
        }
        public void CreateTransaction(Card fromCard, Card toCard, decimal amount)
        {
            fromCard.SetBalance(fromCard.GetBalance() - amount);
            toCard.SetBalance(toCard.GetBalance() + amount);
        }
    }
}
