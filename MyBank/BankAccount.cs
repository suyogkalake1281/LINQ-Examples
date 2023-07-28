using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    internal class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance   {
            get
            {
            decimal balance = 0;
                foreach (var item in allTransaction)
                {
                    balance += item.Amount;


                }
                return balance;
            }
            }

        private static int accountNumberSeed = 123456789;

        private List<Transaction> allTransaction = new List<Transaction>();


        public BankAccount(string name,decimal intialBalance)
        {
            this.Owner = name;
            this.Balance = intialBalance;
            this.Number =accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount,DateTime date, string note) { }

        public void MakeWithdrawal(decimal amount, DateTime date, string note) { }

    }
}
