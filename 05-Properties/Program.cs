using System;

namespace _05_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 05 - Propriedades");

            CheckingAccount account = new CheckingAccount();
            account.Holder = new Client();
            account.Holder.Name = "Gabriela Soares";
            account.Holder.IdDoc = "549.123.654-12";
            account.Holder.Profession = "Desenvolvedora C#";
            account.Balance = 500;
            account.Branch = 425;
            account.Number = 123456;

            Console.WriteLine("Bem-vinda ao ByteBank, " + account.Holder.Name);
            Console.WriteLine(" Seu saldo atual é " + account.Balance + " reais");

            Console.ReadLine();
        }
    }
}
