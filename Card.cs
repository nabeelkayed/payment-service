using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    public class Card
    {
        private decimal balance;
        private readonly string cardNumber;
        public Card(decimal balance, string cardNumber)
        {
            this.balance = balance;
            this.cardNumber = cardNumber;
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public void SetBalance(decimal amount)
        {
            balance = amount;
        }
        public string GetCardNumber()
        {
            return cardNumber;
        }
    }
}
