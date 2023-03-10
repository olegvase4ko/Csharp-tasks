using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 4, 23, 4, 124, 35, 34, 534, 63423, 42, 122, 3, 12, 312, 32, 34345, 65, 65, 765, 67, 4, 453, 48, 0 };
            int count = Arr.Length, oddNum = 0, evenNum = 0;
            for (int i = 0; i < count; i++)
            {
                if (Arr[i] % 2 == 0)
                    oddNum++;
                else
                    evenNum++;
            }
            int[] oddArr = new int[oddNum];
            int[] evenArr = new int[evenNum];
            for (int i = 0, j = 0, k = 0; i < count; i++)
            {
                if (Arr[i] % 2 == 0)
                {
                    oddArr[j] = Arr[i];
                    j++;
                }
                else
                {
                    evenArr[k] = Arr[i];
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Четные \t Нечетные");
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
                    Console.Write("{0,9}", oddArr[i]);
                else
                    Console.Write("{0,14}", ' ');
                if (i < evenArr.Length)
                    Console.Write("{0,14}", evenArr[i]);
                else
                    Console.Write("{0,14}", ' ');
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
