using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WithInterface
{
    class SavingsAccount : IAccount
    {
        public string GetAccountInfo()
        {
            return "This account information is from Savings Account";
        }
    }
}
