﻿using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[] { 1, 2, 3, 4, 9, 15, 20, 25, 7, 8, 155, 5, 21, 38, 0, 2 };
            Array.Sort(number);
            foreach (var item in number)
            {
                if(item % 2 == 0)
                {
                Console.WriteLine(item);
                }
            }
            Console.Read();
        }
    }
}