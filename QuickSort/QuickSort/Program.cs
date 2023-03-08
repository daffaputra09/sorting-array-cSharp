using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 7, 1, 4, 3, 6, 2, 5 };
            QuickSort(list);
        }
        public static void QuickSort(int[] number)
        {
            Console.WriteLine("===BEFORE===");
            foreach (var n in number)
            {
                Console.Write(n + ", ");
            }


            QuickSortAlgoritm(number, 0,number.Length -1);


            Console.WriteLine("\n===AFTER===");
            foreach (var n in number)
            {
                Console.Write(n + ", ");
            }
        }
        public static void QuickSortAlgoritm(int[] number, int start, int end)
        {
            int i = start;
            int j = end;
            int pivot = number[start];

            while(i <= j)
            {
                while (number[i] < pivot)
                {
                    i++;
                }
                while (number[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int t = number[i];
                    number[i] = number[j];
                    number[j] = t;
                    i++;
                    j--;
                }

                if(start < j)
                {
                    QuickSortAlgoritm(number, start, j);
                }
                if(start > i)
                {
                    QuickSortAlgoritm(number, i, end);
                }
            }
        }
    }
}