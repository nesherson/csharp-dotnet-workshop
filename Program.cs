using System;

namespace csharp_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Amer", 1000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with balance: {account.Balance}$");
            account.MakeDeposit(200, DateTime.Now, "Another 200$");
            account.MakeWithdrawal(700, DateTime.Now, "Bought Xiaomi Killer");
            Console.WriteLine($"Account now has: {account.Balance}$");
            
            
        }
    }
}
