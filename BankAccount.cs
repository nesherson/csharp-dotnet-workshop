using System;
using System.Collections.Generic;

namespace csharp_workshop {

    public class BankAccount {

        private static int accountNumberSeed = 100;
        private List<Transaction> allTransactions = new List<Transaction>();
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get {
            decimal balance = 0;
            foreach(var item in allTransactions) {
                balance += item.Amount;
            }
            return balance;
        } }
         public BankAccount(string name, decimal initialBalance) {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note) {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive value");
            }

            var deposit = new Transaction(amount, date, note);

            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note) {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive value");
            }

            if (Balance - amount < 0) {
                throw new InvalidOperationException("Not insufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}