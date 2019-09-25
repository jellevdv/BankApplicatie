using BankApplicatie.Domein;
using System;

namespace BankApplicatie {
    class Program {
        static void Main(string[] args) {

            BankAccount ba = new BankAccount("123-4567889-99");
            BankAccount ba2 = new BankAccount("000-4567889-99",1000);
            //   ba.SetBalance(100);
            //string interpolatie==> dollarteken+ evt verwijzingen nr wat je wil opvragen
            //    Console.WriteLine($"Balance is {ba.GetBalance()}");
            Console.WriteLine($"Account {ba.AccountNumber} - Balance is {ba.Balance}");
            Console.WriteLine($"Account {ba2.AccountNumber} - Balance is {ba2.Balance}");
            ba.Deposit(100.50M);//M voor deciMal
            ba.Deposit(50.50M);
            Console.WriteLine($"Account {ba.AccountNumber} - Balance is {ba.Balance}");
            ba.Withdraw(51);
            Console.WriteLine($"Account {ba.AccountNumber} - Balance is {ba.Balance}");
            //ba.Withdraw(500);
            //Console.WriteLine($"Account {ba.AccountNumber} - Balance is {ba.Balance}");


        }
    }
}
