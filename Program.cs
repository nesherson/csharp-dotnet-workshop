using System;

namespace csharp_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Amer", 1000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with balance: {account.Balance}$");
        }
    }
}
