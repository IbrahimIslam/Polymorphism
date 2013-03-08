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

            PrintAccountInfo(oCheckingAccount);
            PrintAccountInfo(oSavingsAccount);

            Console.ReadKey();
        }

        static void PrintAccountInfo(Account account)
        {
            Console.WriteLine(account.GetAccountInfo());
        }
    }
}
