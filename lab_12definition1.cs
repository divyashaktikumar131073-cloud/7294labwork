using System;

class PositiveNegative
{
    static void Main()
    {
        int[] num = new int[8];
        int positive = 0;
        int negative = 0;

        // Input
        for (int i = 0; i < 8; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Check numbers
        for (int i = 0; i < 8; i++)
        {
            if (num[i] >= 0)
            {
                positive++;
            }
            else
            {
                negative++;
            }
        }

        Console.WriteLine("Positive numbers = " + positive);
        Console.WriteLine("Negative numbers = " + negative);
    }
}