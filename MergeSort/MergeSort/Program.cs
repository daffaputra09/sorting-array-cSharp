using System;


namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 7, 1, 4, 3, 6, 2, 5 };
            MergeSort(list);
        }


        public static void MergeSort(int[] number)
        {
            Console.WriteLine("===BEFORE===");
            foreach (var n in number)
            {
                Console.Write(n + ", ");
            }

            number = PisahArray(number);
            Console.WriteLine("\n===AFTER===");
            foreach (var n in number)
            {
                Console.Write(n + ", ");
            }
        }

 
        public static int[] PisahArray(int[] number)
        {
    
            if (number.Length <= 1)
            {
       
                return number;
            }
            int tengah = number.Length / 2;
            int[] kiri = new int[tengah];
            int[] kanan;

       
            if (number.Length % 2 == 0)
            {
                kanan = new int[tengah];
            }
            else
            {
                kanan = new int[tengah + 1];
            }

   
            for (int i = 0; i < kiri.Length; i++)
            {
                kiri[i] = number[i];
            }

 
            for (int i = 0; i < kanan.Length; i++)
            {
                kanan[i] = number[tengah + i];
            }


            kiri = PisahArray(kiri);
            kanan = PisahArray(kanan);

            int[] hasil = new int[number.Length];

            hasil = GabungArray(kiri, kanan);

            return hasil;
        }

        public static int[] GabungArray(int[] kiri, int[] kanan)
        {
            int[] hasilGabung = new int[kiri.Length + kanan.Length];

            int indexKiri = 0, indexKanan = 0, indexHasilGabung = 0;

            while (indexKiri < kiri.Length || indexKanan < kanan.Length)
            {
                if (indexKiri < kiri.Length && indexKanan < kanan.Length)
                {
                    if (kiri[indexKiri] < kanan[indexKanan])
                    {
                        hasilGabung[indexHasilGabung] = kiri[indexKiri];
                        indexHasilGabung++;
                        indexKiri++;
                    }
                    else
                    {
                        hasilGabung[indexHasilGabung] = kanan[indexKanan];
                        indexHasilGabung++;
                        indexKanan++;
                    }

                }
                else if (indexKiri < kiri.Length)
                {

                    hasilGabung[indexHasilGabung] = kiri[indexKiri];
                    indexHasilGabung++;
                    indexKiri++;
                }
                else if (indexKanan < kanan.Length)
                {
                    hasilGabung[indexHasilGabung] = kanan[indexKanan];
                    indexHasilGabung++;
                    indexKanan++;
                }
            }


            return hasilGabung;
        }
    }
}