using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Accounts
{
    class SavingsAccount: BankAccount
    {
        private uint _withdrawalCount = 0;
        private const uint _maxWithdrawalCount = 3;
               
        public SavingsAccount(int Balance) : base(Balance, 200) {}

        public override void  Withdraw(int Ammount)
        {
            if (_WithdrawalIsAllowed())
            {
                _withdrawalCount++;
                base.Withdraw(Ammount);
            }
            
        }

        private bool _WithdrawalIsAllowed()
        {
            if (_withdrawalCount >= _maxWithdrawalCount)
            {
                throw new InvalidOperationException(String.Format("Maximum Number of Withdrawals: ({0}) Exceeded", _maxWithdrawalCount));
            }
            else{
                return true;
            }
        }

        public override string ToString()
        {
            string str;

            str = String.Format("Savings account: {0:C2}", Balance);

            return str;
        }
                
    }
}
