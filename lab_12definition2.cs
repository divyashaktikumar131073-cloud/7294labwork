using System;

class MarksAverage
{
    static void Main()
    {
        int[] marks = new int[5];
        int sum = 0;
        double avg;

        // Input marks
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter marks of student " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate sum
        for (int i = 0; i < 5; i++)
        {
            sum = sum + marks[i];
        }

        // Average
        avg = sum / 5.0;

        Console.WriteLine("Total Marks = " + sum);
        Console.WriteLine("Average = " + avg);
    }
}