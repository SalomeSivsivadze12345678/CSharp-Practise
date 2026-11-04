namespace Practice
{
    public class ShoppingCart
    {
        public string CustomerName { get; private set; }
        public decimal TotalPrice { get; private set; }



        public ShoppingCart(string customerName)
        {
            CustomerName = customerName;
        }

        public void AddItem(decimal price)
        {

            if (price <= 0)
            {
                Console.WriteLine("enter correct price");
            }
            else
            {
                TotalPrice += price;

            }

        }

        public void RemoveItem(decimal price)
        {
            if (price <= 0 || price > TotalPrice)
            {
                Console.WriteLine("enter correct price");
            }
            else
            {
                TotalPrice -= price;

            }

        }
    }
}

