namespace _04_NamespaceAndNull
{
    public class CheckingAccount
    {
        public Client holder;
        public int branch;
        public int number;
        public double balance;

        public void Deposit(double value)
        {
            this.balance += value;
        }

        public bool Withdraw(double value)
        {
            if (this.balance < value)
            {
                return false;
            }

            this.balance -= value;
            return true;
        }
        public bool Transferir(double value, CheckingAccount destinationAccount)
        {
            if (this.balance < value)
            {
                return false;
            }

            this.balance -= value;
            destinationAccount.Deposit(value);
            return true;
        }

    }
}