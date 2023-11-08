using System;

namespace H_W_28._10._23
{
    class BankTransaction
    {
        public readonly DateTime TransactionDate;
        public readonly decimal Amount;

        public BankTransaction(DateTime transactionDate, decimal amount)
        {
            TransactionDate = transactionDate;
            Amount = amount;
        }
    }
}
