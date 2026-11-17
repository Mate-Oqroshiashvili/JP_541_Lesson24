using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson24.Models
{
    internal class Bank : IGeneralInterface<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public static int BankCount { get; set; }

        public Bank(string name, decimal budget)
        {
            BankCount++;
            Id = BankCount;
            Name = name;
            Budget = budget;
        }

        public List<User> GetAll()
        {
            return Users;
        }

        public override string ToString()
        {
            return $"{Id}|{Name}|{Budget}";
        }
    }
}
