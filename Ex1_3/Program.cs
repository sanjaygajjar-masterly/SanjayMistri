﻿using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;

            }
            Console.WriteLine("Factorial of Number is : "  + factorial);
        }

    }
}