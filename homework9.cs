namespace Homework9;

using System;
using System.Collections.Generic;

class Student
{
    private int studentID;
    private string studentName;

    // Static list to store all students
    public static List<Student> studentList = new List<Student>();

    // Constructor
    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    // PrintInfo method
    public void PrintInfo()
    {
        Console.WriteLine($"ID: {studentID}, Name: {studentName}");
    }

    // Getter for name (needed for dictionary lookup)
    public string GetName()
    {
        return studentName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // -------------------------------
        // 2. Create 4 students
        // -------------------------------
        Student s1 = new Student(222, "Bob");
        Student s2 = new Student(333, "Carly");
        Student s3 = new Student(444, "David");
        Student s4 = new Student(111, "Alice");

        // -------------------------------
        // 3. Create gradebook dictionary
        // -------------------------------
        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Carly", 2.5},
            {"David", 1.8}
        };

        // -------------------------------
        // 4. Check if Tom exists
        // -------------------------------
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        // -------------------------------
        // 5. Calculate average GPA
        // -------------------------------
        double total = 0;
        foreach (var g in gradebook.Values)
        {
            total += g;
        }
        double avg = total / gradebook.Count;

        Console.WriteLine($"Average GPA: {avg:F2}");

        // -------------------------------
        // 6. Print students with GPA > avg
        // -------------------------------
        Console.WriteLine("\nStudents with GPA above average:");

        foreach (var stu in Student.studentList)
        {
            string name = stu.GetName();

            if (gradebook.ContainsKey(name) && gradebook[name] > avg)
            {
                stu.PrintInfo();
                Console.WriteLine($"GPA: {gradebook[name]}");
            }
        }
    }
}