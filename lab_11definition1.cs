using System;

class MaxNumber
{
    static void Main()
    {
        int n1, n2, n3, n4, n5, max;

        Console.Write("Enter number 1: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 3: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 4: ");
        n4 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 5: ");
        n5 = Convert.ToInt32(Console.ReadLine());

        max = n1;

        if (n2 > max)
            max = n2;

        if (n3 > max)
            max = n3;

        if (n4 > max)
            max = n4;

        if (n5 > max)
            max = n5;

        Console.WriteLine("Maximum number = " + max);
    }
}