using System;

namespace _06_ConstructorsAndStaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 06 - Construtores e Membros Estáticos");

            Console.WriteLine("Total de contas no ByteBank: " + CheckingAccount.TotalCreatedAccounts);

            CheckingAccount norbertosAccount = new CheckingAccount(425, 12345);
            
            Console.WriteLine("Total de contas no ByteBank: " + CheckingAccount.TotalCreatedAccounts);

            CheckingAccount gabrielasAccount = new CheckingAccount(425, 12321);
            
            Console.WriteLine("Total de contas no ByteBank: " + CheckingAccount.TotalCreatedAccounts);

            CheckingAccount josesAccount = new CheckingAccount(425, 984123);
            
            Console.WriteLine("Total de contas no ByteBank: " + CheckingAccount.TotalCreatedAccounts);

            Console.ReadLine();
        }
    }
}
