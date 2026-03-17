using System;

class Student
{
    int rollNo;
    string name;
    double marks;

    // Default constructor
    public Student()
    {
        rollNo = 0;
        name = "No Name";
        marks = 0;
    }

    // Parameterized constructor
    public Student(int r, string n, double m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    // Method to calculate grade
    public string Grade()
    {
        if (marks >= 80)
            return "A";
        else if (marks >= 60)
            return "B";
        else if (marks >= 40)
            return "C";
        else
            return "Fail";
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Roll No = " + rollNo);
        Console.WriteLine("Name = " + name);
        Console.WriteLine("Marks = " + marks);
        Console.WriteLine("Grade = " + Grade());
    }
}

class Program
{
    static void Main()
    {
        // Default constructor
        Student s1 = new Student();
        Console.WriteLine("Student 1");
        s1.Display();

        // Parameterized constructor
        Student s2 = new Student(101, "Rahul", 75);
        Console.WriteLine("\nStudent 2");
        s2.Display();
    }
}