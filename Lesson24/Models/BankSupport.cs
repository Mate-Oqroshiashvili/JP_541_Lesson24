using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson24.Models
{
    internal class BankSupport : User
    {
        public BankSupport(
            string userID, string fullname, string email,
            string password, string phoneNumber)
            : base(userID, fullname, email, password, phoneNumber)
        {

        }
    }
}
