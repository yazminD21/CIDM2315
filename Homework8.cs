namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please use following code to create Customer objects and customer list
            Customer cus1 = new Customer(customerName:"Alice", customerAge:39, customerCity:"Amarillo", customerCredit:198.5);
            Customer cus2 = new Customer(customerName:"Bob", customerAge:40, customerCity:"Amarillo", customerCredit:225);
            Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:198.5);
            Customer cus4 = new Customer(customerName:"David", customerAge:35, customerCity:"Amarillo", customerCredit:198.5);
            Customer cus5 = new Customer(customerName:"Jack", customerAge:30, customerCity:"Canyon", customerCredit:198.5);
            Customer cus6 = new Customer(customerName:"Tom", customerAge:38, customerCity:"Canyon", customerCredit:198.5);
            Customer cus7 = new Customer(customerName:"Sam", customerAge:45, customerCity:"Canyon", customerCredit:198.5);
            Customer cus8 = new Customer(customerName:"Sue", customerAge:25, customerCity:"Canyon", customerCredit:202.8);

            Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

            // call Q1 method
            TotalCredits(customer_list);
            // call Q2 method
            AmarilloAverageAge(customer_list);
            // call Q3 method
            CanyonAge(customer_list);
        }

// Q1. Create a method to calculate and print the total credit of all customers in the customer_list.
        public static void TotalCredits(Customer[] customer_list)
        {
            double total = 0;

            foreach (Customer c in customer_list)
            {
                total += c.customerCredit;
            }

            Console.WriteLine("Q1: The total credits: " + total);
        }

        // Q2 Create a method to calculate and print the average age of customers living in Amarillo.
        public static void AmarilloAverageAge(Customer[] customer_list)
        {
            int count = 0;
            int sumAges = 0;

            foreach (Customer c in customer_list)
            {
                if (c.customerCity == "Amarillo")
                {
                    sumAges += c.customerAge;
                    count++;
                }

}

            double avg = (double)sumAges / count;
            Console.WriteLine("Q2: The average age of customers in Amarillo: " + avg);
        }

        // Q3 Create a method to print the names of customers who live in Canyon and are older than 30.
        public static void CanyonAge(Customer[] customer_list)
        {
            Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");

            foreach (Customer c in customer_list)
            {
                if (c.customerCity == "Canyon" && c.customerAge > 30)
                {
                    Console.Write(c.customerName + ", ");
                }
            }

            Console.WriteLine();
        }

        // Q4 Create a class called Customer
        

public class Customer
{
    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}
        

    }
}

