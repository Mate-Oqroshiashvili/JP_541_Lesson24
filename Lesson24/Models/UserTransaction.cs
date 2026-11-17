using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson24.Models
{
    internal class UserTransaction
    {
        public int Id { get; set; }
        public string TransactionName { get; set; }
        public decimal Amount { get; set; }
        public string TransactionMessage { get; set; }
        public static int TransactionCount { get; set; }
        public UserTransaction(string transactionName, decimal amount,
            string transactionMessage)
        {
            TransactionCount++;
            Id = TransactionCount;
            TransactionName = transactionName;
            Amount = amount;
            TransactionMessage = transactionMessage;
        }

        public override string ToString()
        {
            return $"{Id}|{TransactionName}|{Amount}|{TransactionMessage}";
        }
    }
}
