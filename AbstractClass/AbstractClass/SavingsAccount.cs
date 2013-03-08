using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WithInterface
{
    class SavingsAccount : Account
    {
        public override string GetAccountInfo()
        {
            return "This account information is from Savings Account";
        }
    }
}
