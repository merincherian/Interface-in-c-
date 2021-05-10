namespace Interface
{
    public interface IBankProcesses
    {
        
        void deposit(float money);
        
        float getBalance();

        void withdraw(float money);
    }
}