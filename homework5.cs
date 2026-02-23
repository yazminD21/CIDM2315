using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Q1 Output -----");
            Q1_method();

            Console.WriteLine("\n----- Q2 Output -----");
            Q2_method();

            Console.WriteLine("\n----- Q3 Output -----");
            createAccount();
        }

        // Q1: Return the largest of 2 integers
        static int max1(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        static void Q1_method()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int largest = max1(a, b);
            Console.WriteLine("The largest number is: " + largest);
        }

        
        // Q2: Use Q1 three times to find the largest of 4 numbers
        static void Q2_method()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter d: ");
            int d = int.Parse(Console.ReadLine());

            int maxAB = max1(a, b);
            int maxBC = max1(b, c);
            int maxCD = max1(c, d);

            int finalMax = max1(max1(maxAB, maxBC), maxCD);

            Console.WriteLine("The largest number is: " + finalMax);
        }

        // Q3: Account creation
        static bool checkAge(int birth_year)
        {
            int current_year = 2024;
            int age = current_year - birth_year;

            return age >= 18;
        }

        static void createAccount()
        {
            Console.Write("Enter Your Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Your Password: ");
            string password1 = Console.ReadLine();

            Console.Write("Enter Your Password Again: ");
            string password2 = Console.ReadLine();

            Console.Write("Enter Your Birthyear: ");
            int birthyear = int.Parse(Console.ReadLine());

            bool isAdult = checkAge(birthyear);

            if (isAdult)
            {
                if (password1 == password2)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }
    }
}