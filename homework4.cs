namespace Homework4;
class Program
{
    static void Main(string[ ] args)
    	{
       // Call Q1_method()
       Q1_method();
       // Call Q2_method()
       Q2_method(5, "left");
}


// Q1_method
static void Q1_method()
{
    int a = 10;
    int b = 25;

    int largest = GetLargest(a, b);
    
    Console.WriteLine("The Largest number is: " + largest);
}

static int GetLargest(int x, int y)
    {
        if (x > y)
        return x; 
        else 
        return y;
    }




 //Q2_method
static void Q2_method(int N, string shape)
        {
            Console.WriteLine("N = " + N);
            Console.WriteLine("Shape = " + shape);

            if (shape.ToLower() == "left")
            {
                for (int i = 1; i <= N; i++)
                {
                    // print i stars
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (shape.ToLower() == "right")
            {
                for (int i = 1; i <= N; i++)
                {
                    // print spaces first
                    for (int s = 1; s <= N - i; s++)
                    {
                        Console.Write(" ");
                    }
                    // then stars
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid shape. Use 'left' or 'right'.");
            }
        }
    }


