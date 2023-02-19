using System;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 1;
            using (FileStream f = new FileStream("file.txt", FileMode.Create))
            {
                using (StreamWriter str = new StreamWriter(f))
                {
                    var number = new int[] { 2, 3, 6, 5, 4 };

                    foreach (var item in number)
                    {
                        result = item * item;
                        str.WriteLine(result);
                        Console.WriteLine(result);
                    }
                }
            }
            Console.Read();
        }
    }
}