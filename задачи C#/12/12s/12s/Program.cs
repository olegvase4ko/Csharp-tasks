using System;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream f = new FileStream("file.txt", FileMode.Create))
            {
                using (StreamWriter str = new StreamWriter(f))
                {
                    var Arr = new char[] { 'a', 'b', 'c', 'd', 'f', 'e', 's', 'w', 'q', 'x', 'y', 'z', '1', '2' };
                    int count = Arr.Length, oddNum = 0, evenNum = 0;
                    var flag = true;
                    for (int i = 1; i < count; i += 2)
                    {
                        if (flag)
                        {
                            oddNum++;
                            flag = false;
                        }
                        else
                        {
                            evenNum++;
                            flag = true;
                        }

                    }
                    var oddArr = new char[oddNum];
                    var evenArr = new char[evenNum];
                    flag = true;
                    for (int i = 1, j = 0, k = 0; i < count; i += 2)
                    {
                        if (flag)
                        {
                            oddArr[j] = Arr[i];
                            j++;
                            flag = false;
                        }
                        else
                        {
                            evenArr[k] = Arr[i];
                            k++;
                            flag = true;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("1 группа \t 2 группа");
                    if (oddArr.Length > evenArr.Length)
                    {
                        count = oddArr.Length;
                    }
                    else
                    {
                        count = evenArr.Length;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        if (i < oddArr.Length)
                        {
                            Console.Write("{0,9}", oddArr[i]);
                            str.Write(oddArr[i]);
                        }
                        else
                        {
                            Console.Write("{0,14}", ' ');
                            str.Write(" ");
                        }
                        if (i < evenArr.Length)
                        {
                            Console.Write("{0,14}", evenArr[i]);
                            str.Write(evenArr[i]);
                        }
                        else
                        {
                            Console.Write("{0,14}", ' ');
                            str.Write(" ");
                        }
                        Console.WriteLine();
                        str.WriteLine();
                    }
                }
            }
            Console.Read();
        }
    }
}
