﻿namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            int a = 17;
            int b = 4;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            
            int quotient = a / b;
            int remainder = a % b;

            //if (a == 17 && b == 4) ;


             Console.WriteLine($"17/4 is { a / b } remainder {a % b} ");




        }
    }
}
