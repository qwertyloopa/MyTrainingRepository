﻿namespace HW1._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char screenSymbol = 'v';
            char screenInput = Char.Parse(Console.ReadLine());
            switch(screenInput)
            {
                case 'w':
                    Console.WriteLine($"..{screenSymbol}..");     
                break;

                case 'a':
                    Console.WriteLine($"{screenSymbol}..");
                break;

                case 's':
                    Console.WriteLine(' ');
                    Console.WriteLine($"..{screenSymbol}..");
                break;

                case 'd':
                    Console.WriteLine($"..{screenSymbol}");
                break;
            }

            Console.ReadKey();
        }
    }
}