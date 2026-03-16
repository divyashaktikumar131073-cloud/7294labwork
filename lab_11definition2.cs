using System;

class MinNumber
{
    static void Main()
    {
        int n1, n2, n3, n4, n5, min;

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

        min = n1;

        if (n2 < min)
            min = n2;

        if (n3 < min)
            min = n3;

        if (n4 < min)
            min = n4;

        if (n5 < min)
            min = n5;

        Console.WriteLine("Minimum number = " + min);
    }
}