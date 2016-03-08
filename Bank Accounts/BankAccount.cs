using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Accounts
{
    abstract class BankAccount
    {
        public int Balance { get; protected set; }

        public readonly int MinimumInitialDeposit;

        
        protected BankAccount(int Balance, int MinDeposit)
        {
            this.Balance = Balance;
            MinimumInitialDeposit = MinDeposit;
        }

        public BankAccount(int Balance) : this(Balance, 0)
        {
                      
        }

        public void Deposit(int Deposit)
        {
            Balance += Deposit;
        }
        
        public virtual void Withdraw(int Ammount)
        {
            if (Ammount > Balance)
            {
                throw new InvalidOperationException(String.Format("There is no sufficient funds to withdraw ${0}", Ammount));
            }
                       
            Balance -= Ammount;
        }

        public void TransferTo(BankAccount ToAccount, int Ammount)
        {
            Withdraw(Ammount);
            ToAccount.Deposit(Ammount);
            
        }

    }
}
