using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 7, 1, 4, 3, 6, 2, 5 };
            SelectionSort(list);
        }
        private static void SelectionSort(int[] number)
        {
            Console.WriteLine("===BEFORE===");
            foreach (var n in number)
            {
                Console.Write(n + ", ");
            }

            for(int i = 0; i < number.Length;i++)
            {
                int ArrayPos = i;
                for(int j = i; j < number.Length;j++)
                {
                    if (number[ArrayPos] > number[j])
                    {
                        ArrayPos = j;
                    }
                }
                int t = number[i];
                number[i] = number[ArrayPos];
                number[ArrayPos] = t;
            }


            Console.WriteLine("\n===AFTER===");
            foreach (var n in number)
            {
                Console.Write(n + ", ");
            }
        }
    }
}