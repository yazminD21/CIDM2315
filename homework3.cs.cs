namespace Homework3;
class Program
{
    static void Main(string[ ] args)
    {
        // Code for Q1
        Console.Write("Enter integer N: ");
        string? input = Console.ReadLine();
        if (!long.TryParse(input, out long n))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        bool prime = IsPrime(n);
        Console.WriteLine($"{n} is {(prime ? "prime" : "non-prime")}");

        // Code for Q2
        Console.Write("Enter integer N: ");
        string? inputQ2 = Console.ReadLine();
        if (!int.TryParse(inputQ2, out int n2))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        for (int i = 0; i < n2; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }}

        // Code for Bonus question
    

    
}
