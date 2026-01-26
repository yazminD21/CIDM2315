// Program class moved to homework1.cs
using System;

class Program
{
    static void Main()
    {
        double X = 2.5;
        double Y = 3.3;

        double Z = 4 * X * X + 3 * Y;

        Console.WriteLine($"When X = {X} and Y = {Y}, the value of Z is {Z:F2}");
    }
}

