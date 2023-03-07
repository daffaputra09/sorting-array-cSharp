using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 7, 1, 4, 3, 6, 2, 5 };
            Console.WriteLine("===BEFORE===");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + ", ");
            }
            BubbleSort(list);
            Console.WriteLine("\n===AFTER===");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + ", ");
            }
        }
        private static void BubbleSort(int[] number)
        {
            int length = number.Length;
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < length - 1; i++)
                {
                    if (number[i] > number[i + 1])
                    {
                        int j = number[i];
                        number[i] = number[i + 1];
                        number[i + 1] = j;
                        sorted = false;
                    }
                }
               
            }
        }
    }
}