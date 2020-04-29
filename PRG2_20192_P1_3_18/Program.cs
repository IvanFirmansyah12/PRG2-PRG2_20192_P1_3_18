using System;

namespace PRG2_20192_P1_3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka;

            Console.WriteLine(" Program Syair Anak Ayam ");
            Console.Write(" Masukan Nilai N = ");
            angka = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" ANAK AYAM TURUN {0} \n", angka);
            for (int i = angka; i >= 1; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine(" Anak Ayam Turun {0}, Mati satu tinggal induknya ", i);
                }
                else
                {
                    Console.WriteLine(" Anak Ayam Turun {0}, Mati satu tinggal {1} ", i, i - 1);
                }
            }
        }
    }
}
