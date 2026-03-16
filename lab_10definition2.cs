using System;

class LoanCheck
{
    static void Main()
    {
        int age, credit;
        double income;

        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter income: ");
        income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter credit score: ");
        credit = Convert.ToInt32(Console.ReadLine());

        if (age >= 21)
        {
            if (income >= 25000)
            {
                if (credit >= 650)
                {
                    Console.WriteLine("Loan Approved");
                }
                else
                {
                    Console.WriteLine("Low credit score");
                }
            }
            else
            {
                Console.WriteLine("Income too low");
            }
        }
        else
        {
            Console.WriteLine("Age not eligible");
        }
    }
}