using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WithInterface;

namespace WithInterface
{
    class CheckingAccount : IAccount
    {
        public string GetAccountInfo()
        {
            return "This account information is from Checking Account";
        }
    }
}
