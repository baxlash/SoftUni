﻿using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Decimal: ");
        long decimalNumber = int.Parse(Console.ReadLine());

        long remainder;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("Binary:  {0}", result);
    }
}