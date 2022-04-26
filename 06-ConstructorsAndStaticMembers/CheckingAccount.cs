namespace _06_ConstructorsAndStaticMembers
{
    public class CheckingAccount
    {
        private Client _holder;
        private int _branch;
        private int _number;
        private double _balance = 0;
        
        public static int TotalCreatedAccounts { get; private set; }

        public Client Holder { get; set; }
        public int Branch { get; set; }
        public int Number { get; set; }
        public double Balance 
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _balance = value;
            }
        }

        public CheckingAccount(int branch, int number)
        {
            Branch = branch;
            Number = number;

            TotalCreatedAccounts++;
        }

        public void Deposit(double value)
        {
            _balance += value;
        }

        public bool Withdraw(double value)
        {
            if (_balance < value)
            {
                return false;
            }

            _balance -= value;
            return true;
        }
        public bool Transferir(double value, CheckingAccount destinationAccount)
        {
            if (_balance < value)
            {
                return false;
            }

            _balance -= value;
            destinationAccount.Deposit(value);
            return true;
        }

    }
}