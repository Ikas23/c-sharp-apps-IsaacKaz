using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.bank_app
{
    internal class Account
    {
        public double balance;
        public Owner Owner;
        public int overdraft;
        public int MAX_OVERDRAFT = 90_000;


        public Account(Owner owner,double balance, int overdraft)
        {
            this.balance = balance;
            this.Owner = owner;
            this.overdraft = overdraft;
        }
        public double GetBalance() { return balance; }
        public Owner GetOwner() { return Owner; }
        public int GetOverDraft() { return overdraft; }

        public void SetOverdraft(int sum)
        {
            if (sum > MAX_OVERDRAFT)
            {
                Console.WriteLine("Not possible!");
            }
            else
            {
                this.overdraft = sum; 
            }
        }

        public void Withdraw(double sum)
        {
            double check = this.balance - sum;
            if (check < -overdraft) 
            {
                Console.WriteLine("Not possible, Bye");
            }
            else
            {
                this.balance -= sum;
            }
        }
        public void Deposit(double sum)
        {
            this.balance += sum;
        }
    }
}
