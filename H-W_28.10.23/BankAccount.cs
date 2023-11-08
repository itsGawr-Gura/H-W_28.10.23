using System;
using System.Collections.Generic;
using System.IO;

namespace H_W_28._10._23
{
    enum AccountType
    {
        Checking,
        Savings
    }
    class BankAccount : IDisposable
    {
        private static int accountNumberCounter = 1000;
        private readonly int accountNumber;
        private decimal balance;
        private AccountType accountType;
        private Queue<BankTransaction> transactionQueue;
        public int AccountNumber
        {
            get { return accountNumber; }
        }
        public decimal Balance
        {
            get { return balance; }
        }

        public AccountType AccountType
        {
            get { return accountType; }
        }
        public BankAccount(decimal initialBalance, AccountType type)
        {
            accountNumber = GetNextAccountNumber();
            balance = initialBalance;
            accountType = type;
            transactionQueue = new Queue<BankTransaction>();
        }
        private static int GetNextAccountNumber()
        {
            return ++accountNumberCounter;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
            transactionQueue.Enqueue(new BankTransaction(DateTime.Now, amount));
        }
        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                transactionQueue.Enqueue(new BankTransaction(DateTime.Now, -amount));
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
                return false;
            }
        }
        public void Transfer(BankAccount destinationAccount, decimal amount)
        {
            if (Withdraw(amount))
            {
                destinationAccount.Deposit(amount);
            }
        }
        public void Dispose()
        {
            using (StreamWriter writer = new StreamWriter("transactions.txt", true))
            {
                while (transactionQueue.Count > 0)
                {
                    BankTransaction transaction = transactionQueue.Dequeue();
                    writer.WriteLine($"{accountNumber},{transaction.TransactionDate},{transaction.Amount}");
                }
            }
            GC.SuppressFinalize(this);
        }
    }
}
