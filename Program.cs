using System;

namespace csharp_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Amer", 1000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with balance: {account.Balance}$");
            account.MakeDeposit(200, DateTime.Now, "Added 200$");
            account.MakeWithdrawal(150, DateTime.Now, "Bought Gamepad");
            account.MakeWithdrawal(100, DateTime.Now, "Bought Sunglasses");


            Console.WriteLine(account.GetAccountHistory());
            
            
        }
    }
}
