using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson24.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserID { get; private set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password 
        {
            get
            {
                return _password;
            }
            set 
            {
                _password = value;
            }
        }
        public string PhoneNumber { get; set; }
        public List<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
        public List<UserTransaction> UserTransactions { get; set;} = new List<UserTransaction>();
        public static int UserCount { get; set; }

        public User(string userID, string fullname, string email, 
                    string password, string phoneNumber)
        {
            UserCount++;
            Id = UserCount;
            UserID = userID;
            Fullname = fullname;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{Id}|{UserID}|{Fullname}|{Email}|{Password}|{PhoneNumber}";
        }
    }
}
