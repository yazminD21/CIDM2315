namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        // Q1 & Q2

        // Create two customers
        Customer c1 = new Customer(110, "Alice", 28);
        Customer c2 = new Customer(111, "Bob", 30);

        // Print initial info
        c1.PrintCusInfo();
        c2.PrintCusInfo();

        // Update IDs
        c1.ChangeID(220);
        c2.ChangeID(221);

        // Print updated info
        c1.PrintCusInfo();
        c2.PrintCusInfo();

        // Compare ages
        c1.CompareAge(c2);
    }
}

class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else if (this.cus_age < objCustomer.cus_age)

{
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else
        {
            Console.WriteLine("They are the same age.");
        }
    }
}

