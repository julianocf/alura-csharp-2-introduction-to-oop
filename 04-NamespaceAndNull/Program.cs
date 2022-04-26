using System;

namespace _04_NamespaceAndNull
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 04 - Namespace composição e null");

            CheckingAccount account = new CheckingAccount();
            account.holder = new Client();
            account.holder.name = "Gabriela Soares";
            account.holder.idDoc = "549.123.654-12";
            account.holder.profession = "Desenvolvedora C#";
            account.balance = 500;
            account.branch = 425;
            account.number = 123456;

            Console.WriteLine("Bem-vinda ao ByteBank, " + account.holder.name);
            Console.WriteLine(" Seu saldo atual é " + account.balance + " reais");

            Console.ReadLine();
        }
    }
}
