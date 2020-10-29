using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int [10];
            int max = 0;

            Console.WriteLine("********* En Büyük Sayıyı Bulma *********");
            Console.WriteLine();
            Console.WriteLine("10 tane sayi giriniz!");
            for(int i = 0; i<10; i++)
            {
                Console.Write(i+1 + ". sayı: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                if(sayilar[i] > max)
                {
                    max = sayilar[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("En büyük sayı: " + max);
           
            Console.ReadLine();
        }
    }
}
