/*
 2. Вводиться число. Масив заповнити випадковими числами. Знайти кількість входжень у масив введеного числа.
Скористатися Count() з System.Linq
 */


using System;
using System.Linq;

namespace _02_random_array
{
    class Program
    {
        static void FillRand(int[] arr, int left = 0, int rigth = 100)
        {
            Random rand = new Random();
            if (left > rigth)
            {
                int tmp = left;
                left = rigth;
                rigth = tmp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(left, rigth);
            }
        }

        static void Print(int[] arr, string message = "")
        {
            Console.WriteLine(message);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}\t");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter digit for find in array:\t");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int [10];
            FillRand(arr);
            Print(arr, "\nRandom array:");
            Console.WriteLine($"Count of digit {count} in array Arr is:\t" + arr.Count(x => x == count));
            Console.WriteLine("\n");

        }
    }
}
