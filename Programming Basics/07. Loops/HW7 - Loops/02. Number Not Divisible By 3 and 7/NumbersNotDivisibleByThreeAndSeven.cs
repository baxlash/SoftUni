﻿using System;

class NumbersNotDivisibleByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Enter a number to check: ");
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}
