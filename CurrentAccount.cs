using System;

namespace Interface
{
    public class CurrentAccount: IBankProcesses
    {
        private float balance;

        public CurrentAccount()
        {
            balance = 25000;
        }
        public void deposit(float money)
        {
            balance = money + balance;
        }

        public void withdraw(float money)
        {
            balance = balance - money;
        }

        public float getBalance()
        {
            return balance;
        }
    }
}