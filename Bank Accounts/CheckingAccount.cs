using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Accounts
{
    class CheckingAccount: BankAccount
    {
                
        public CheckingAccount(int Balance) : base(Balance, 10){}
        public override string ToString()
        {
            string str;

            str = String.Format("Checking account: {0:C2}", Balance);

            return str;
        }
    }

}
