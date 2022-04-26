using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto ByteBank - Instânciando a minha primeira classe.");
            
            CheckingAccount account = new CheckingAccount();

            account.holder = "Gabriela";
            account.branch = 123;
            account.number = 948573;
            account.balance = 100;

            Console.WriteLine(account.holder);
            Console.WriteLine("Agência: " + account.branch);
            Console.WriteLine("Conta: " + account.number);
            Console.WriteLine("Saldo atual: " + account.balance);

            Console.ReadLine();

        }
    }
}
