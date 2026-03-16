using System;

class Program
{
    static void Main()
    {
        double bill, discount = 0, finalBill;
        int category;

        Console.Write("Enter bill amount: ");
        bill = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1 Senior");
        Console.WriteLine("2 Regular");
        Console.WriteLine("3 Industrial");

        category = Convert.ToInt32(Console.ReadLine());

        if (category == 1)
            discount = bill * 0.20;
        else if (category == 2)
            discount = bill * 0.10;
        else if (category == 3)
            discount = bill * 0.30;

        finalBill = bill - discount;

        Console.WriteLine("Final Bill = " + finalBill);
    }
}