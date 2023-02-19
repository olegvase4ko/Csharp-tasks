using System;
using System.IO;


namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            using(FileStream f = new FileStream("file.txt",FileMode.Create))
            {
                using (StreamWriter str = new StreamWriter(f))
                {
                    var number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                    foreach(var item in number)
                    {
                        if(item % 2 == 0)
                        {
                            Console.WriteLine(item);
                            result += item;
                        }
                    }
                    str.WriteLine(result);
                }
            }
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
