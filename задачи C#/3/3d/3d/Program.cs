﻿using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0.0;
            var number = new double[] { 1, 0.2, 3, 0.4, 5, 6, 0.7, 8 };

            foreach (var item in number)
            {
                result = item * 1000;
                Console.WriteLine(result);
            }
            Console.Read();
        }
    }
}
