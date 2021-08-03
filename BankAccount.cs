using System;
using System.Collections.Generic;

namespace csharp_workshop {

    public class BankAccount {

        private static int accountNumberSeed = 100;
        private List<Transaction> allTransactions = new List<Transaction>();
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
         public BankAccount(string name, decimal initialBalance) {
            Owner = name;
            Balance = initialBalance;
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note) {}
        public void MakeWithdrawal(decimal amount, DateTime date, string note) {}
    }
}