using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Accounts
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount acct1 = new SavingsAccount(1000);

            BankAccount acct2 = new CheckingAccount(200);



            Console.WriteLine("Acct1 MID: {0:C}", acct1.MinimumInitialDeposit);

            Console.WriteLine("Acct2 MID: {0:C}", acct2.MinimumInitialDeposit);



            // does not compile:

            // BankAccount acct3 = new BankAccount(50, 0);



            Console.WriteLine("Acct1 balance: {0:C}", acct1.Balance);

            Console.WriteLine("Acct2 balance: {0:C}", acct2.Balance);



            // does not compile

            // acct2.Balance = 30000;



            acct1.Deposit(500);

            acct2.Deposit(50);



            acct1.Withdraw(250);

            acct2.Withdraw(25);



            BankAccount savings = new SavingsAccount(1000);

            BankAccount checking = new CheckingAccount(1000);

            savings.Withdraw(100); savings.Withdraw(100); savings.Withdraw(100);

            checking.Withdraw(100); checking.Withdraw(100); checking.Withdraw(100);



            checking.Withdraw(100); // succeeds

            try
            {

                savings.Withdraw(100); // throws exception

            }

            catch (InvalidOperationException)
            {

                Console.WriteLine("Maximum number of withdraws exceeded.");

            }



            checking.TransferTo(savings, 300);



            Console.WriteLine(checking);

            Console.WriteLine(savings);

            Console.ReadKey();

        }



    }
}
