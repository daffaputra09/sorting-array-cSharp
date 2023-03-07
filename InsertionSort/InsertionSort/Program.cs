using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 7, 1, 4, 3, 6, 2, 5 };
            InsertionSort(list);
        }
        private static void InsertionSort(int[] number)
        {
            Console.WriteLine("===BEFORE===");
            foreach (var n in number)
            {
                Console.Write(n+ ", ");
            }

            for (int i = 1; i < number.Length;i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (number[j] < number[j - 1])
                    {
                        int t = number[j];
                        number[j] = number[j - 1];
                        number[j - 1] = t;
                    }
                }
            }


            Console.WriteLine("\n===AFTER===");
            foreach (var n in number)
            {
                Console.Write(n + ", ");
            }
        }
    }
}