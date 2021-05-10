namespace Interface
{
    public class SavingsAccount: IBankProcesses
    {
        private float balance;

        public SavingsAccount()
        {
            balance = 20000;
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