using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            int max = 0;
            int index = 0;
            int[] siralisayilar = new int[10];

            Console.WriteLine("********* Sayıları Büyükten Küçüğe Doğru Sıralama *********");
            Console.WriteLine();
            Console.WriteLine("10 tane sayi giriniz!");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + ". sayı: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Sıralanışı: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (sayilar[j] > max)
                    {
                        max = sayilar[j];
                        index = j;
                    }
                }

                sayilar[index] = 0;

                siralisayilar[i] = max;
                Console.WriteLine(siralisayilar[i]);
                max = 0;
            }

            Console.ReadLine();
        }
    }
}
