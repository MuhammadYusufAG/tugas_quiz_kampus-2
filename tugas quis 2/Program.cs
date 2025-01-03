using System;

namespace tugas_quis_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka, sisa, jumlahAngka,ulang;
            Console.Write("Masukkan Angka Berapapun : ");
            angka = Convert.ToInt32(Console.ReadLine());

            jumlahAngka = 0;
            for (ulang = 1; ulang < angka / 2; ulang++)
            {
                sisa = angka % ulang;
                if (sisa == 0)
                {
                    jumlahAngka = jumlahAngka + 1;
                }
                else
                {
                    jumlahAngka = jumlahAngka;
                }
            }
            if (jumlahAngka > 2)
            {
                Console.Write($"{angka} ini bilangan Prima.");
            }
            else
            {
                Console.Write($"{angka} ini bukan bilangan Prima.");
            }
            Console.ReadKey(); 
        }
    }
}
