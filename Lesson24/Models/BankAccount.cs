using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson24.Models
{
    internal class BankAccount
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public User User { get; set; }
        public static int BankAccountCount { get; set; } = 0;

        public BankAccount(decimal balance, User user)
        {
            BankAccountCount++;
            Id = BankAccountCount;
            Balance = balance;
            User = user;
        }

        public override string ToString()
        {
            return $"{Id}|{Balance}|{User.ToString()}";
        }
    }
}
