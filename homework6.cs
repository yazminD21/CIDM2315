namespace Homework6;
class Program
{
    static void Main(string[] args)
{
    Professor p1 = new Professor("Alice", "Java", 9000);
    Professor p2 = new Professor("Bob", "Math", 8000);

    Student s1 = new Student("Lisa", "Java", 90);
    Student s2 = new Student("Tom", "Math", 80);

    Console.WriteLine($"Professor {p1.GetName()} teaches {p1.GetClassTeach()} and the salary is: {p1.GetSalary()}");
    Console.WriteLine($"Professor {p2.GetName()} teaches {p2.GetClassTeach()} and the salary is: {p2.GetSalary()}");

    Console.WriteLine($"Student {s1.GetName()} enrolls {s1.GetClassEnrolled()}, and the grade is: {s1.GetGrade()}");
    Console.WriteLine($"Student {s2.GetName()} enrolls {s2.GetClassEnrolled()}, and the grade is: {s2.GetGrade()}");

    double salaryDiff = p2.GetSalary() - p1.GetSalary();
    Console.WriteLine($"The salary difference between Alice and Bob is: {salaryDiff}");

    double totalGrade = s1.GetGrade() + s2.GetGrade();
    Console.WriteLine($"Total grade of Lisa and Tom is: {totalGrade}");
}

 }


class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string name, string classTeach, double salary)
    {
        this.profName = name;
        this.classTeach = classTeach;
        this.salary = salary;
    }

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
     public string GetName()
    {
        return profName;
    }

    public string GetClassTeach()
    {
        return classTeach;
    }
}







class Student
{
    private string studentName;
    private string classEnrolled;
    private double studentGrade;

    public Student(string name, string classEnrolled, double grade)
    {
        this.studentName = name;
        this.classEnrolled = classEnrolled;
        this.studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }

    public string GetName()
    {
        return studentName;
    }

    public string GetClassEnrolled()
    {
        return classEnrolled;
    }
}


