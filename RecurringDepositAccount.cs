using System;

namespace Interface
{
    public class RecurringDepositAccount: IBankProcesses
    {
        private float balance;

        public RecurringDepositAccount()
        {
            balance = 30000;
        }
        public void deposit(float money)
        {
            balance = money + balance;
        }

        public void withdraw(float money)
        {
           if( balance < money )
            {
                Console.WriteLine("\nINSUFFICIENT FUND\nPress Enter to continue");
                Console.ReadKey();
            }
            else
            {
                balance = balance - money;
            }
        }

        public float getBalance()
        {
            return balance;
        }
    }
}