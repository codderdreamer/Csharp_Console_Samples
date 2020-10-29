using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isim = new string[5];
            int[] not = new int[5];
            int toplam = 0;
            int ortalama;

            Console.WriteLine("5 öğrencinin ismini ve notunu giriniz.");
            
            for(int i = 0; i<5; i++)
            {
                Console.Write("İsim: ");
                isim[i] = Console.ReadLine();
                Console.Write("notu: ");
                not[i] = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + not[i];
            }
            ortalama = toplam / 5;
            Console.WriteLine();
            Console.WriteLine("Ortalama: " + ortalama);
            Console.ReadLine();


        }
    }
}
