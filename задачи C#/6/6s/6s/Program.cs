using System;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 1.0;
            using (FileStream f = new FileStream("file.txt", FileMode.Create))
            {
                using (StreamWriter str = new StreamWriter(f))
                {
                    var number = new int[] { 30, 45, 60, 90, 180, 270, 360 };

                    foreach (var item in number)
                    {
                        result = Math.Cos(item);
                        str.WriteLine(result);
                        Console.WriteLine(result);
                    }
                }
            }
            Console.Read();
        }
    }
}