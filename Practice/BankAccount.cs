namespace Practice
{
    public class BankAccount
    {
        public  string Name { get; private  set; }
        public decimal Balance { get;  private set; }

        public BankAccount(string name, decimal balance)
        {
            Name = name;
            if (balance < 0)
            {
                Console.WriteLine("Wrong Amount");
            }
            Balance = balance;
        }

        

        public void Deposit(decimal amount)
        {           
            if(amount <= 0)
            {
                Console.WriteLine("Wrong amount");
            }
            else
            {
                Balance += amount;

            }

        }

        public void Withdraw(decimal amount)
        {
            if(amount > Balance || amount < 0)
            {
                Console.WriteLine("Enter correct amount");
            }
            else
            {
                Balance -= amount;

            }
        }

        

    }

}
