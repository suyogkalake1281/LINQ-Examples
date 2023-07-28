using MyBank;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var account = new BankAccount("Suyog", 25000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance" );

    }
}