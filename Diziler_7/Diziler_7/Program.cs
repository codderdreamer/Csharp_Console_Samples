using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[5];
            int[] notlar = new int[5];
            int[] siralinotlar = new int[5];
            int minindex = 0;
            int maxindex = 0;

            Console.WriteLine("Sınıf Not Değerlendirmesi");

            for(int i = 0; i<5; i++)
            {
                Console.Write((i + 1) + ". Öğrencinin ismini giriniz: ");
                isimler[i] = Console.ReadLine();
                Console.Write((i+1) + ". Notunu giriniz: ");
                notlar[i] = Convert.ToInt16(Console.ReadLine());
                siralinotlar[i] = notlar[i];
            }

            Array.Sort(siralinotlar);

            Console.WriteLine();
            for(int i=0;i<5;i++)
            {
                if(notlar[i] == siralinotlar[0])
                {
                    minindex = i;
                }

                if(notlar[i] == siralinotlar[4])
                {
                    maxindex = i;
                }

            }

            Console.WriteLine("En küçük not : " + siralinotlar[0] + " Alan kişi: " + isimler[minindex]);
            Console.WriteLine("En yüksek not: " + siralinotlar[4] + " Alan kişi: " + isimler[maxindex]);
            Console.WriteLine("Öğrenci sayısı: " + isimler.Length);

            Console.ReadLine();
        }
    }
}
