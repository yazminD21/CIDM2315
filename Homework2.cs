namespace Homework2;
class Program
{
    static void Main(string[ ] args)
    {
        // Code for Q1
        Console.Write("Please input a letter grade: ");
        string grade = (Console.ReadLine() ?? string.Empty).ToUpper();
        int gpaPoints;

        switch (grade)
        {
            case "A": gpaPoints = 4; break;
            case "B": gpaPoints = 3; break;
            case "C": gpaPoints = 2; break;
            case "D": gpaPoints = 1; break;
            case "F": gpaPoints = 0; break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return;
        }

        Console.WriteLine($"GPA point: {gpaPoints}\n");

        // Code for Q2
        int num1 = ReadInt("Please input the first num: ");
        int num2 = ReadInt("Please input the second num: ");
        int num3 = ReadInt("Please input the third num: ");

        int smallest = Math.Min(num1, Math.Min(num2, num3));
        Console.WriteLine("The smallest number is: " + smallest + "\n");

    }
}

   