using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 7, 1, 4, 3, 6, 2, 5 };
            MergeSort(list);
        }
        private static void MergeSort(int[] number)
        {
            Console.WriteLine("===BEFORE===");
            foreach (var n in number)
            {
                Console.Write(n + ", ");
            }




            Console.WriteLine("\n===AFTER===");
            foreach (var n in number)
            {
                Console.Write(n + ", ");
            }
        }
    }
}