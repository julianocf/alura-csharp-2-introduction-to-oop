using System;

namespace _03_ClassBehavior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 03 - Comportamento de Classes");

            CheckingAccount firstAccount = new CheckingAccount();
            firstAccount.holder = "José";
            firstAccount.balance = 200;

            CheckingAccount secondAccount = new CheckingAccount();
            secondAccount.holder = "Gilberto";
            secondAccount.balance = 50;

            Console.WriteLine("O saldo inicial da conta do " + firstAccount.holder + " é " + firstAccount.balance + " reais de saldo.");
            Console.WriteLine("O saldo inicial da conta do " + secondAccount.holder + " é " + secondAccount.balance + " reais de saldo.");

            Console.WriteLine("Depositando 500 reais na conta do " + firstAccount.holder);
            firstAccount.Deposit(500);

            Console.WriteLine("Transferindo 350 reais da conta do " + firstAccount.holder + " para a conta do " + secondAccount.holder);
            firstAccount.Transferir(350, secondAccount);

            Console.WriteLine("Sacando 200 reais da conta do " + secondAccount.holder);
            secondAccount.Withdraw(200);

            Console.WriteLine("A conta do " + firstAccount.holder + " agora tem " + firstAccount.balance + " reais de saldo.");
            Console.WriteLine("A conta do " + secondAccount.holder + " agora tem " + secondAccount.balance + " reais de saldo.");

            Console.ReadLine();
        }
    }
}
