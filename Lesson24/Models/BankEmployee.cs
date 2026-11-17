using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson24.Models
{
    internal class BankEmployee : User
    {
        public BankEmployee(
                string userID, string fullname, string email,
                string password, string phoneNumber
            ) : base(userID, fullname, email, password, phoneNumber)
        {
            
        }
    }
}
