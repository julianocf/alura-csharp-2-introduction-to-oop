using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Byte Bank");
            
            CheckingAccount firstAccount = new CheckingAccount();
            firstAccount.holder = "José";
            firstAccount.balance = 200;
            
            CheckingAccount secondAccount = new CheckingAccount();
            secondAccount.holder = "Gilberto";
            secondAccount.balance = 50;
            
            firstAccount.balance += 100;

            Console.WriteLine("A conta do " + firstAccount.holder + " tem " + firstAccount.balance + " reais de saldo.");
            Console.WriteLine("A conta do " + secondAccount.holder + " tem " + secondAccount.balance + " reais de saldo.");

            Console.ReadLine();
        }
    }
}
