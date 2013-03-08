using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount oCheckingAccount = new CheckingAccount();
            SavingsAccount oSavingsAccount = new SavingsAccount();

            Console.WriteLine(oCheckingAccount.GetAccountinfo());
            Console.WriteLine(oSavingsAccount.GetAccountinfo());

            Console.ReadKey();
        }

        static void PrintAccountInfo(Account account)
        {
            //Console.WriteLine(account.GetAccountInfo());
        }
    }
}
