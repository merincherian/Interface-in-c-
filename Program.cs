using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           IBankProcesses savings = new SavingsAccount();
           IBankProcesses current = new CurrentAccount();
           IBankProcesses recurring = new RecurringDepositAccount();

           while(true)
           {
               Console.WriteLine("\nMAIN MENU");
               Console.WriteLine("1. Savings account");
               Console.WriteLine("2. Current account");
               Console.WriteLine("3. Recurring Deposit account");
               Console.WriteLine("4. Exit");

               Console.Write("Options:- ");
               int option = Int32.Parse(Console.ReadLine());

               switch(option)
               {
                   case 1:
                   {
                       accountMenu(savings);
                   } 
                   break;

                   case 2:
                   {
                       accountMenu(current);
                   } 
                   break;

                   case 3:
                   {  
                       accountMenu(recurring);
                   } 
                   break;
                   
                   case 4:
                   {
                       System.Environment.Exit(0);
                   } 
                   break;
               }


           }
        }

        //Function to call corresponding  object to class/account
        static int accountMenu(IBankProcesses account)
        {
            while(true)
            {
               Console.WriteLine("\n ACCOUNT MENU");
               Console.WriteLine("1. View Balance");
               Console.WriteLine("2. Deposit money");
               Console.WriteLine("3. Withdraw money");
               Console.WriteLine("4. GO back to main menu");

              Console.Write("Options:- ");
               int option = Int32.Parse(Console.ReadLine());

               switch(option)
               {
                   case 1:
                   {
                       Console.WriteLine("\nBalance:- {0}\nPress Enter to continue", account.getBalance());
                       Console.ReadKey();
                   } 
                   break;

                   case 2:
                   {   Console.Write("Enter the amount to deposit:- ");
                       float money = float.Parse(Console.ReadLine());
                       account.deposit(money);
                   } 
                   break;

                   case 3:
                   {
                       Console.Write("Enter the amount to withdraw:- ");
                       float money = float.Parse(Console.ReadLine());
                       account.withdraw(money);
                   } 
                   break;
                   
                   case 4:
                   {
                       return 0;
                   } 
                
               }
 
            }
              
        }
    }


}
