﻿using System;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new char[23];
            using (FileStream f = new FileStream("file.txt", FileMode.Create))
            {
                using (StreamWriter str = new StreamWriter(f))
                {
                    var number = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'v', 'x', 'y', 'z' };

                    for (int i = 0; i < number.Length; i++)
                    {
                        result[i] = number[number.Length - 1 - i];
                    }
                    for (int i = 0; i < result.Length; i++)
                    {
                        str.WriteLine(result[i]);
                        Console.WriteLine(result[i]);
                    }
                }
            }
            Console.Read();
        }
    }
}
