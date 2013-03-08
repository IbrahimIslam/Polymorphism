using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WithInterface
{
    class SavingsAccount : Account
    {
        public string GetAccountinfo()
        {
            return "This is Account Information from Savings Account";
        }
    }
}
