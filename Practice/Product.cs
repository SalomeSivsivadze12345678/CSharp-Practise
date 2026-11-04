namespace Practice
{
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public decimal TotalValue => Price * Quantity;


        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            if(price <= 0)
            {
                Console.WriteLine("enter correct number");
            }
            else
            {
                Price = price;

            }

            if (quantity < 0)
            {
                Console.WriteLine("enter correct number");
            }
            else
            {
                Quantity = quantity;

            }
           
        }

        public void IncreaseQuantity(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("enter correct number");
            }
            else
            {
                Quantity += amount;
            }

        }


        public void DecreaseQuantity(int amount)
        {
            if (Quantity < amount || amount < 0)
            {
                Console.WriteLine("enter correct number");
            }
            else
            {
                Quantity -= amount;
            }
        }
    }
}

