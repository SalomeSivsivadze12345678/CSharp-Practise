namespace Practice
{ 

    public class Employee
    {
        public string Name { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            if (salary <= 0)
            {
                Console.WriteLine("enter correct number");
            }
            else
            {
                Salary = salary;
            }
        }

        public void IncreaseSalary(decimal amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("enter correct number");
            }
            else
            {
                Salary += amount;
            }
        }
        public decimal GetAnnualSalary()
        {
            return Salary * 12;
        }
    }
}

